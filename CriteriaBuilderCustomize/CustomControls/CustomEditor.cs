//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Drawing;
using System.Net.Http.Headers;
using System.Windows.Forms;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.CriteriaBuilder.CustomEditors;

namespace CriteriaBuilderCustomize.CustomControls
{
    public partial class CustomEditor : UserControl, ICriteriaBuilderCustomEditor
    {
        public event EventHandler CommitChanges;
        public new event CKeyEventHandler KeyDown;

        public new CRectangle Bounds
        {
            get { return new CRectangle(base.Bounds.X, base.Bounds.Y, base.Bounds.Width, base.Bounds.Height); }
            set
            {
                base.Bounds = new Rectangle((int) value.X, (int) value.Top + (int) (value.Height - Height) / 2,
                    base.Bounds.Width,
                    base.Bounds.Height);
            }
        }

        public bool IsVisible => Visible;

        public string Value
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public CustomEditor()
        {
            InitializeComponent();
            Load += CustomEditor_Load;
        }

        private void CustomEditor_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        protected virtual void OnCommitChanges()
        {
            CommitChanges?.Invoke(this, EventArgs.Empty);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            OnCommitChanges();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(new CKeyEventArgs((CKeys)e.KeyData));
        }

        protected virtual void OnKeyDown(CKeyEventArgs e)
        {
            KeyDown?.Invoke(this, e);
        }
    }
}
