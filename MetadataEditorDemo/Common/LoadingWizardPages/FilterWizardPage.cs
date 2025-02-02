//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace MetadataEditorDemo.Common.LoadingWizardPages
{
    [ToolboxItem(false)]
    internal partial class FilterWizardPage : UserControl
    {
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public bool LoadFileds
        {
            get { return cbLoadFields.Checked; }
            set { cbLoadFields.Checked = value; }
        }

        public MetadataFilter MetadataFilter { get; set; }
        
        public bool ShowServer { get; set; }
        public bool ShowDatabase { get; set; }
        public bool ShowSchema { get; set; }
        public bool ShowPackage { get; set; }

        public List<string> DatabaseList { get; set; }
        public List<string> SchemaList { get; set; }

        public FilterWizardPage()
        {
            InitializeComponent();

            Load += FilterWizardPage_Load;
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

        private void FilterWizardPage_Load(object sender, System.EventArgs e)
        {
            Load -= FilterWizardPage_Load;

            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.MetadataFiltration.Subscribe(x => label1.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.MetadataFiltrationPrompt.Subscribe(x => lbInfo.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.LoadFieldsDescription.Subscribe(x => lbLoadFieldsDescr.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.AdvancedFiltrationDescrption.Subscribe(x => lbAdvancedFilter.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.AdvancedFiltration.Subscribe(x => btnAdvanced.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.LoadFields.Subscribe(x => cbLoadFields.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.MetadataFiltrationClickLoadOrCancel.Subscribe(x => lblLoadToStart.Text = x));
        }

        private void bntAdvanced_Click(object sender, System.EventArgs e)
        {
            using (var form = new MetadataFilterForm(MetadataFilter))
            {
                form.FilterControl.ShowServer = ShowServer;
                form.FilterControl.ShowDatabase = ShowDatabase;
                form.FilterControl.ShowSchema = ShowSchema;
                form.FilterControl.ShowPackage = ShowPackage;

                form.FilterControl.DatabaseList = DatabaseList;
                form.FilterControl.SchemaList = SchemaList;

                //form.Parent = this;
                form.ShowDialog();
            }
        }
    }
}
