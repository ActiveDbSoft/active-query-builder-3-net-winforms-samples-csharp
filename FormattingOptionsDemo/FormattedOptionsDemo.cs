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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.Serialization;

namespace FormattingOptionsDemo
{
    public partial class FormattedOptionsDemo : Form
    {
        private string _tmpName = "";
        private bool _afterSave = false;
        private readonly Dictionary<string, int> _namesToOptionsId = new Dictionary<string, int>();
        private readonly Dictionary<int, string> _savedOptions = new Dictionary<int, string>();
        private readonly XmlSerializer _xmlSerializer = new XmlSerializer(){SerializeDefaultValues = true};

        public FormattedOptionsDemo()
        {
            InitializeComponent();

            var fOptions  = new SQLFormattingOptions();
            fOptions.MainQueryFormat.NewLineAfterPartKeywords = true;
            formattingOptions1.SqlFormattingOptions = fOptions;

            formattingOptions1.OptionsUpdated += FormattingOptions1_OptionsUpdated;
        }

        private void FormattingOptions1_OptionsUpdated(object sender, EventArgs e)
        {
            var currentOptionsName = cmBxCurrentScheme.Text;

            if (currentOptionsName.Contains("(Modified)")) return;

            var newValue = currentOptionsName + " (Modified)";

            cmBxCurrentScheme.Items.Add(newValue);
            cmBxCurrentScheme.Text = newValue;
            _tmpName = newValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlContext1.MetadataContainer.ImportFromXML("Northwind.xml");

            _namesToOptionsId.Add("Default", 0);
            _savedOptions.Add(0, _xmlSerializer.Serialize(formattingOptions1.SqlFormattingOptions));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var xml = _xmlSerializer.Serialize(formattingOptions1.SqlFormattingOptions);
            var currentScheme = cmBxCurrentScheme.Text;
            var index = currentScheme.IndexOf("(Modified)", StringComparison.InvariantCultureIgnoreCase);
            if (index != -1)
                currentScheme = currentScheme.Substring(0, index - 1);

            using (var dialog = new SaveOptionsDialog())
            {
                dialog.ShowDialog();

                if (_namesToOptionsId.ContainsKey(dialog.OptionsName))
                {
                    MessageBox.Show("Options with such name already exists");
                    return;
                }

                if (dialog.Result)
                {
                    _savedOptions.Add(_namesToOptionsId.Count, xml);
                    currentScheme = dialog.OptionsName;
                    _namesToOptionsId.Add(currentScheme, _namesToOptionsId.Count);
                    cmBxCurrentScheme.Items.Add(currentScheme);
                    _afterSave = true;
                }
            }

            cmBxCurrentScheme.Items.Remove(_tmpName);
            cmBxCurrentScheme.Text = currentScheme;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var currentOptionsName = cmBxCurrentScheme.Text;

            if (currentOptionsName == "Default") return;

            int optionsId;
            if (!_namesToOptionsId.TryGetValue(currentOptionsName, out optionsId))
            {
                cmBxCurrentScheme.Items.Remove(currentOptionsName);
                cmBxCurrentScheme.SelectedItem = cmBxCurrentScheme.Items[0];
                return;
            }

            _savedOptions.Remove(optionsId);
            _namesToOptionsId.Remove(currentOptionsName);
            cmBxCurrentScheme.Items.Remove(currentOptionsName);
            cmBxCurrentScheme.SelectedItem = cmBxCurrentScheme.Items[0];
        }

        private void cmBxCurrentScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cmBxCurrentScheme.SelectedIndex;
            var optionsName = (string)cmBxCurrentScheme.Items[selectedIndex];

            int optionsID;
            if (!_namesToOptionsId.TryGetValue(optionsName, out optionsID) || _afterSave)
            {
                _afterSave = false;
                return;
            }

            var desOptions = new SQLFormattingOptions();
            _xmlSerializer.Deserialize(_savedOptions[optionsID], desOptions);

            formattingOptions1.OptionsUpdated -= FormattingOptions1_OptionsUpdated;
            formattingOptions1.SqlFormattingOptions = desOptions;
            formattingOptions1.OptionsUpdated += FormattingOptions1_OptionsUpdated;
            formattingOptions1.UpdateOptions();
        }
    }
}
