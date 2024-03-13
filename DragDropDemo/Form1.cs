//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2024 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;

namespace DragDropDemo
{
    public partial class Form1 : Form
    {
        private Rectangle _dragBoxFromMouseDown = Rectangle.Empty;
        private int _errorPosition = -1;
        private string _lastValidSql;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Fill query builder with demo data
            queryBuilder1.SyntaxProvider = new MSSQLSyntaxProvider();
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true;
            queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml");
            queryBuilder1.InitializeDatabaseSchemaTree(); 

            base.OnLoad(e);
        }

        private void queryBuilder1_SQLUpdated(object sender, EventArgs e)
        {
            // Handle the event raised by SQL Builder object that the text of SQL query is changed

            // Hide error banner if any
            errorBox1.Show(null, queryBuilder1.SyntaxProvider);

            // update the text box
            _lastValidSql = textBox1.Text = queryBuilder1.FormattedSQL;
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // Update the query builder with manually edited query text:
                queryBuilder1.SQL = textBox1.Text;

                // Hide error banner if any
                errorBox1.Show(null, queryBuilder1.SyntaxProvider);
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                _errorPosition = textBox1.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Prepare drag'n'drop:
            if (listBox1.SelectedIndex != -1)
            {
                Rectangle r = listBox1.GetItemRectangle(listBox1.SelectedIndex);

                Size dragSize = SystemInformation.DragSize;

                _dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                _dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Do drag:

            if (listBox1.SelectedIndex != -1)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    if (_dragBoxFromMouseDown != Rectangle.Empty && !_dragBoxFromMouseDown.Contains(e.X, e.Y))
                    {
                        string objectName = (string) listBox1.SelectedItem;
                        MetadataObject metadataObject = queryBuilder1.MetadataContainer.FindItem<MetadataObject>(objectName);
                        
                            if (metadataObject != null)
                        {
                            MetadataDragObject dragObject = new MetadataDragObject();
                            dragObject.MetadataDragged.Add(metadataObject);
                            
                            listBox1.DoDragDrop(dragObject, DragDropEffects.Copy);
                        }
                    }
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // Double click will add the object in automatic position:
            if (listBox1.SelectedIndex != -1)
            {
                String objectName = (String) listBox1.SelectedItem;
                queryBuilder1.AddObjectToActiveUnionSubQuery(objectName);
            }
        }

        private void ErrorBox1_RevertValidText(object sender, EventArgs e)
        {
            textBox1.Text = _lastValidSql;
            textBox1.Focus();
        }

        private void ErrorBox1_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                textBox1.SelectionStart = _errorPosition;
                textBox1.SelectionLength = 0;
                textBox1.ScrollToCaret();
            }

            textBox1.Focus();
        }
    }
}
