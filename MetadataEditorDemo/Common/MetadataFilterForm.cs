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

namespace MetadataEditorDemo.Common
{
    internal partial class MetadataFilterForm : Form
    {
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();
        private readonly MetadataFilter _filter = new MetadataFilter();
        private readonly MetadataFilter _originalFilter;

        public MetadataFilterControl FilterControl => filterControl;

        public MetadataFilterForm()
        {
            InitializeComponent();

            _subscriptions.Add(ActiveQueryBuilder.View.Helpers.Localizer.Subscribe(LocalizerOnLanguageChanged));
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

        private void LocalizerOnLanguageChanged(string newLang)
        {
            Text = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAdvancedMetadataFilter", LocalizableConstantsInternal.strAdvancedMetadataFilter);
            pnlInfo.InfoText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strMetadataFilterControlDescription",
                LocalizableConstantsInternal.strMetadataFilterControlDescription);
        }

        public MetadataFilterForm(MetadataFilter filter)
            : this()
        {
            _originalFilter = filter;
            _filter.Assign(_originalFilter);

            filterControl.MetadataFilter = _filter;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            _originalFilter.Assign(_filter);
        }
    }
}
