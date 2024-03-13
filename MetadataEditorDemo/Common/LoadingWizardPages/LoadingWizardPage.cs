//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2024 Active Database Software              //
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
    internal partial class LoadingWizardPage : UserControl
    {
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public LoadingWizardPage()
        {
            InitializeComponent();

            Load += LoadingWizardPage_Load;
        }

        public void ShowSuccess()
        {
            pbSuccess.Visible = true;
            lbSuccess.Visible = true;
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

        private void LoadingWizardPage_Load(object sender, System.EventArgs e)
        {
            Load -= LoadingWizardPage_Load;

            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.LoadingWizardPagePrompt.Subscribe(x => label2.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.LoadingMetadataProgress.Subscribe(x => label1.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.Loading.Subscribe(x => lblLoaded.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.LoadingSuccess.Subscribe(x => lbSuccess.Text = x));
        }
    }
}
