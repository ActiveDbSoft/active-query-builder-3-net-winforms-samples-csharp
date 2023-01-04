//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace FullFeaturedMdiDemo.PropertiesForm
{
    public partial class SqlGenerationPage : UserControl
    {
        private readonly SQLGenerationOptions _generationOptions;
        private readonly SQLFormattingOptions _formattingOptions;

        public SqlGenerationPage()
        {
            InitializeComponent();
        }

        public SqlGenerationPage(SQLGenerationOptions generationOptions, SQLFormattingOptions formattingOptions)
            : this()
        {
            _generationOptions = generationOptions;
            _formattingOptions = formattingOptions;

            foreach (var value in Enum.GetValues(_generationOptions.ObjectPrefixSkipping.GetType()))
            {
                cbObjectPrefixSkipping.Items.Add(value);
            }

            cbObjectPrefixSkipping.SelectedItem = _generationOptions.ObjectPrefixSkipping;
            cbQuoteAllIdentifiers.Checked = _generationOptions.QuoteIdentifiers == IdentQuotation.All;
        }

        private void cbQuoteAllIdentifiers_CheckedChanged(object sender, EventArgs e)
        {
            _generationOptions.QuoteIdentifiers =
                cbQuoteAllIdentifiers.Checked ? IdentQuotation.All : IdentQuotation.IfNeed;
            _formattingOptions.QuoteIdentifiers =
                cbQuoteAllIdentifiers.Checked ? IdentQuotation.All : IdentQuotation.IfNeed;
        }

        private void cbObjectPrefixSkipping_SelectedIndexChanged(object sender, EventArgs e)
        {
            _formattingOptions.ObjectPrefixSkipping = (ObjectPrefixSkipping) cbObjectPrefixSkipping.SelectedItem;
            _generationOptions.ObjectPrefixSkipping = (ObjectPrefixSkipping) cbObjectPrefixSkipping.SelectedItem;
        }
    }
}
