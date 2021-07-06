//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.ComponentModel;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace MetadataEditorDemo.Common.LoadingWizardPages
{
	[ToolboxItem(false)]
	internal partial class SyntaxWizardPage : UserControl
	{
		public SyntaxWizardPage()
		{
			InitializeComponent();

            Load += SyntaxWizardPage_Load;
		}

        private void SyntaxWizardPage_Load(object sender, System.EventArgs e)
        {
            
            label1.Text = Helpers.Localizer.GetString("strSelectSyntaxProvider", LocalizableConstantsInternal.strSelectSyntaxProvider);
            lWelcome.Text = Helpers.Localizer.GetString("strStepSpecifyDatabaseServer", LocalizableConstantsInternal.strStepSpecifyDatabaseServer);

            lSyntax.Text = Helpers.Localizer.GetString("strSyntaxProvider", LocalizableConstantsInternal.strSyntaxProvider);

            lblNextToContinue.Text = Helpers.Localizer.GetString("strMetadataFiltrationClickLoadOrCancel",
                LocalizableConstantsInternal.strMetadataFiltrationClickLoadOrCancel);
        }

        private void comboSelectSyntax_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (comboSelectSyntax.SelectedItem is GenericSyntaxProvider)
				lblWarning.Text = "Usage of Generic Syntax Provider is not recommended. Metadata may be not fully loaded.";
			else
				lblWarning.Text = "";
		}
	}
}
