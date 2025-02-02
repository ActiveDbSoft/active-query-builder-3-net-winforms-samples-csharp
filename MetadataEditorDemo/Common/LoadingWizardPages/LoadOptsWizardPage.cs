//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
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
    internal partial class LoadOptsWizardPage : UserControl
    {
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public LoadOptsWizardPage()
        {
            InitializeComponent();

            Load += LoadOptsWizardPage_Load;
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

        private void LoadOptsWizardPage_Load(object sender, System.EventArgs e)
        {
            Load -= LoadOptsWizardPage_Load;

            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.LoadingWizardPageDatabaseWelcom.Subscribe(x => lWelcome.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.MetadataFiltrationClickLoadOrCancel.Subscribe(x => lblNextToContinue.Text = x));
        }
    }
}
