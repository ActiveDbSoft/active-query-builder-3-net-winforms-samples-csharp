//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace MetadataEditorDemo.Common.LoadingWizardPages
{
    internal partial class ConnectionTypeWizardPage : UserControl
    {
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public ConnectionTypeWizardPage()
        {
            InitializeComponent();
            SubscribeLocalization();
        }

        private void SubscribeLocalization()
        {
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.SelectConnectionTypeDescr.Subscribe(x => lWelcome.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.SelectConnectionType.Subscribe(x => labelConnection.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.SelectSyntaxProvider.Subscribe(x => labelSyntax.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.MetadataFiltrationClickLoadOrCancel.Subscribe(x => lblNextToContinue.Text = x));
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

        public bool SyntaxVisible
        {
            set
            {
                cbSyntax.Visible = value;
                labelSyntax.Visible = value;

                if (value)
                {
                    panelSyntaxOpts.Top = labelSyntax.Top + 24;
                }
                else
                {
                    panelSyntaxOpts.Top = labelSyntax.Top;
                }
            }
        }
    }
}

