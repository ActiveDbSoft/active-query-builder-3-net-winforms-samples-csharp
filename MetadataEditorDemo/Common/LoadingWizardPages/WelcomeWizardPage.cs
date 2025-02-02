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
    internal partial class WelcomeWizardPage : UserControl
    {
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public WelcomeWizardPage()
        {
            InitializeComponent();

            Load += WelcomeWizardPage_Load;
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

        private void WelcomeWizardPage_Load(object sender, System.EventArgs e)
        {
            Load -= WelcomeWizardPage_Load;

            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.WelcomeWizardPrompt.Subscribe(x => lWelcome.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.WelcomeAQBMetadataWizard.Subscribe(x => label1.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.SavePreviousPropmpt.Subscribe(x => label2.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.ClearMetadataConteinerBeforeLoading.Subscribe(x => cbClearBeforeLoading.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.MetadataFiltrationClickLoadOrCancel.Subscribe(x => lblNextToContinue.Text = x));
        }
    }
}
