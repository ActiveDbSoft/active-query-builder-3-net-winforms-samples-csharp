//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.PropertiesEditors;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.PropertiesEditors;
using GeneralAssembly;
using Helpers = ActiveQueryBuilder.Core.Helpers;

namespace FullFeaturedMdiDemo
{
    public partial class EditXMLConnectionForm : Form
    {
        private readonly ConnectionInfo _connection;

        public EditXMLConnectionForm()
        {
            InitializeComponent();
        }

        public EditXMLConnectionForm(ConnectionInfo connection)
            : this()
        {
            _connection = connection;

            FillSyntaxTypes();

            tbConnectionName.Text = _connection.Name;
            tbXmlPath.Text = _connection.XMLPath;
            cbSyntax.SelectedItem = _connection.ConnectionDescriptor.SyntaxProvider.Description;

            RecreateSyntaxFrame();
        }

        private void FillSyntaxTypes()
        {
            foreach (Type syntax in Helpers.SyntaxProviderList)
            {
                var instance = Activator.CreateInstance(syntax) as BaseSyntaxProvider;
                cbSyntax.Items.Add(instance.Description);
            }
        }

        private void tbXmlPath_TextChanged(object sender, EventArgs e)
        {
            _connection.XMLPath = tbXmlPath.Text;
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                tbXmlPath.Text = openDialog.FileName;
            }            
        }

        private void cbSyntax_SelectedIndexChanged(object sender, EventArgs e)
        {
            var syntaxType = GetSelectedSyntaxType();
            if (_connection.ConnectionDescriptor.SyntaxProvider.GetType() == syntaxType)
            {
                return;
            }

            _connection.ConnectionDescriptor.SyntaxProvider = CreateSyntaxProvider(syntaxType);
            _connection.SyntaxProviderName = syntaxType.ToString();
            RecreateSyntaxFrame();
        }

        private Type GetSelectedSyntaxType()
        {
            return Helpers.SyntaxProviderList[cbSyntax.SelectedIndex];
        }

        private BaseSyntaxProvider CreateSyntaxProvider(Type type)
        {
            return Activator.CreateInstance(type) as BaseSyntaxProvider;
        }

        private void RecreateSyntaxFrame()
        {
            RemoveSyntaxFrame();
            var syntxProps = _connection.ConnectionDescriptor.SyntaxProperties;
            if (syntxProps == null)
            {
                pbSyntax.Height = 0;
                return;
            }

            ClearProperties(syntxProps);
            var container = PropertiesFactory.GetPropertiesContainer(syntxProps);
            (pbSyntax as IPropertiesControl).SetProperties(container);
            
            pbSyntax.Height = pbSyntax.Controls[0].Bottom + 5;
            Height = pnlTop.Height + pbSyntax.Height + pnlFilePath.Height + 90;
        }

        private void ClearProperties(ObjectProperties properties)
        {
            properties.GroupProperties.Clear();
            properties.PropertiesEditors.Clear();
        }

        private void RemoveSyntaxFrame()
        {
            pbSyntax.Controls.Clear();
        }
    }
}
