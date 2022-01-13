//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.ComponentModel;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace MetadataEditorDemo.Common.LoadingWizardPages
{
    [ToolboxItem(false)]
    internal partial class MetadataOptsWizardPage : UserControl
    {
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public MetadataOptsWizardPage()
        {
            InitializeComponent();

            Load += MetadataOptsWizardPage_Load;
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _subscriptions.Dispose();
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void MetadataOptsWizardPage_Load(object sender, System.EventArgs e)
        {
            Load -= MetadataOptsWizardPage_Load;

            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.DatabaseConnectionOptions.Subscribe(x => label1.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.DatabaseTestConnectionPrompt.Subscribe(x => lWelcome.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.MetadataFiltrationClickLoadOrCancel.Subscribe(x => lblNextToContinue.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.ButtonTestConnection.Subscribe(x => bConnectionTest.Text = x));
        }
    }
}
