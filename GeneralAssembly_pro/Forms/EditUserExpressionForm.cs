//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.QueryView;

namespace GeneralAssembly.Forms
{
    public partial class EditUserExpressionForm : Form
    {
        private UserConditionVisualItem _selectedPredefinedCondition;
        private IQueryView _queryView;

        public EditUserExpressionForm()
        {
            InitializeComponent();

            foreach (DbType name in Enum.GetValues(typeof(DbType)))
                CheckComboBoxDbTypes.Items.Add(name);
        }

        public void LoadUserConditions(IQueryView queryView)
        {
            ListBoxConditions.Items.Clear();

            _selectedPredefinedCondition = null;

            if (_queryView == null)
            {
                _queryView = queryView;
                TextBoxCondition.Query = queryView.Query;
            }

            if (_queryView == null) return;

            foreach (var expression in _queryView.UserPredefinedConditions)
            {
                ListBoxConditions.Items.Add(new UserConditionVisualItem(expression));
            }
        }

        private void RemoveSelectedUserExpression()
        {
            var itemForRemove = ListBoxConditions.SelectedItems.OfType<UserConditionVisualItem>().ToList();

            foreach (var item in itemForRemove)
                _queryView.UserPredefinedConditions.Remove(item.PredefinedCondition);

            LoadUserConditions(null);

            ResetForm();
        }

        private void ResetForm()
        {
            _selectedPredefinedCondition = null;
            TextBoxCaption.Text = string.Empty;
            TextBoxCondition.Text = string.Empty;
            CheckBoxIsNeedEdit.Checked = false;
            CheckComboBoxDbTypes.ClearCheckedItems();
        }

        private bool SaveForm()
        {
            try
            {
                var result =
                    _queryView.Query.SQLContext.ParseLogicalExpression(TextBoxCondition.Text, false, false,
                        out var token);
                if (result == null && token != null)
                {
                    throw new SQLParsingException(
                        string.Format(
                            Helpers.Localizer.GetString(nameof(LocalizableConstantsUI.strInvalidCondition),
                                LocalizableConstantsUI.strInvalidCondition), TextBoxCondition.Text),
                        token);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Invalid SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TextBoxCondition.Focus();
                return false;
            }

            var listTypes = CheckComboBoxDbTypes.CheckedItems.OfType<DbType>().ToList();

            var userExpression = new PredefinedCondition(
                TextBoxCaption.Text,
                listTypes,
                TextBoxCondition.Text, CheckBoxIsNeedEdit.Checked
            );

            var index = -1;
            if (_selectedPredefinedCondition != null)
            {
                index = _queryView.UserPredefinedConditions.IndexOf(_selectedPredefinedCondition.PredefinedCondition);
                _queryView.UserPredefinedConditions.Remove(_selectedPredefinedCondition.PredefinedCondition);
            }

            if (_queryView.UserPredefinedConditions.Any(x =>
                string.Compare(x.Caption, TextBoxCaption.Text, StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                MessageBox.Show($"Condition with caption \"{TextBoxCaption.Text}\" already exist", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                TextBoxCaption.Focus();

                return false;
            }

            try
            {
                if (index != -1)
                    _queryView.UserPredefinedConditions.Insert(index, userExpression);
                else
                    _queryView.UserPredefinedConditions.Add(userExpression);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            LoadUserConditions(null);

            ResetForm();

            if (index >= 0)
                ListBoxConditions.SelectedIndex = index;
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ResetForm();
            ListBoxConditions.SelectedItem = null;
            TextBoxCaption.Focus();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            _selectedPredefinedCondition = ListBoxConditions.SelectedItem as UserConditionVisualItem;

            if (_selectedPredefinedCondition == null) return;

            var name = _selectedPredefinedCondition.Caption;

            var newName = "";

            if (ListBoxConditions.Items.OfType<UserConditionVisualItem>().All(x =>
                string.Compare(x.Caption, $"{name} Copy", StringComparison.InvariantCultureIgnoreCase) != 0))
            {
                newName = $"{name} Copy";
            }
            else
            {
                for (var i = 1; i < 1000; i++)
                {
                    if (ListBoxConditions.Items.OfType<UserConditionVisualItem>().Any(x => string.Compare(x.Caption, $"{name} Copy ({i})", StringComparison.InvariantCultureIgnoreCase) == 0)) continue;

                    newName = $"{name} Copy ({i})";
                    break;
                }
            }

            var newCopy = _selectedPredefinedCondition.Copy(newName);
            var index = ListBoxConditions.Items.IndexOf(_selectedPredefinedCondition);

            _queryView.UserPredefinedConditions.Insert(index + 1, newCopy.PredefinedCondition);

            LoadUserConditions(null);
            ListBoxConditions.SelectedIndex = index + 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RemoveSelectedUserExpression();
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            var selectedItem = ListBoxConditions.SelectedItem as UserConditionVisualItem;

            if (selectedItem == null) return;

            var index = ListBoxConditions.SelectedIndex;

            if (index - 1 < 0) return;

            Helpers.IListMove(_queryView.UserPredefinedConditions, index, index - 1);

            LoadUserConditions(null);

            ListBoxConditions.SelectedIndex = index - 1;
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            var selectedItem = ListBoxConditions.SelectedItem as UserConditionVisualItem;

            if (selectedItem == null) return;

            var index = ListBoxConditions.SelectedIndex;

            if (index + 1 >= ListBoxConditions.Items.Count) return;

            Helpers.IListMove(_queryView.UserPredefinedConditions, index, index + 1);

            LoadUserConditions(null);

            ListBoxConditions.SelectedIndex = index + 1;
        }

        private void TextBoxCaption_TextChanged(object sender, EventArgs e)
        {
            CheckChangingItem();
        }

        private void TextBoxExpression_TextChanged(object sender, EventArgs e)
        {
            CheckChangingItem();
        }

        private void CheckBoxIsNeedEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckChangingItem();
        }

        private void CheckChangingItem()
        {
            if (_selectedPredefinedCondition == null)
            {
                buttonSave.Enabled =
                    !string.IsNullOrEmpty(TextBoxCaption.Text) && !string.IsNullOrEmpty(TextBoxCondition.Text);

                return;
            }

            var dbTypes = CheckComboBoxDbTypes.CheckedItems.OfType<DbType>().ToList();

            var changed = string.Compare(TextBoxCaption.Text, _selectedPredefinedCondition.Caption,
                              StringComparison.InvariantCulture) != 0 ||
                          string.Compare(TextBoxCondition.Text, _selectedPredefinedCondition.Condition,
                              StringComparison.InvariantCulture) != 0 ||
                          CheckBoxIsNeedEdit.Checked != _selectedPredefinedCondition.IsNeedEdit ||
                          !((_selectedPredefinedCondition.ShowOnlyForDbTypes.Count == dbTypes.Count) && !_selectedPredefinedCondition.ShowOnlyForDbTypes.Except(dbTypes).Any());

            buttonSave.Enabled = changed;
        }

        private void ListBoxExpressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void CheckComboBoxDbTypes_ItemChecked(object sender, EventArgs e)
        {
            CheckChangingItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_EnabledChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = buttonSave.Enabled ? SystemColors.Info : SystemColors.Control;
            labelInformSave.Visible = buttonSave.Enabled;
            buttonRevert.Enabled = buttonSave.Enabled;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (buttonSave.Enabled)
            {
                DialogResult result =
                    MessageBox.Show(@"Save changes to the current condition?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes && !SaveForm())
                {
                    e.Cancel = true;
                }
            }
            base.OnClosing(e);
        }
        private void buttonRevert_Click(object sender, EventArgs e)
        {
            ResetForm();
            UpdateForm();
        }

        private void UpdateForm()
        {
            var enable = ListBoxConditions.SelectedItem is UserConditionVisualItem;

            buttonCopy.Enabled = enable;
            buttonDelete.Enabled = enable;
            buttonMoveUp.Enabled = enable;
            buttonMoveDown.Enabled = enable;

            for (var i = 0; i < CheckComboBoxDbTypes.Items.Count; i++)
                CheckComboBoxDbTypes.SetItemChecked(i, false);

            if (!enable) return;

            _selectedPredefinedCondition = (UserConditionVisualItem)ListBoxConditions.SelectedItem;

            if (_selectedPredefinedCondition == null) return;

            TextBoxCaption.Text = _selectedPredefinedCondition.Caption;
            TextBoxCondition.Text = _selectedPredefinedCondition.Condition;
            CheckBoxIsNeedEdit.Checked = _selectedPredefinedCondition.IsNeedEdit;

            foreach (var item in _selectedPredefinedCondition.ShowOnlyForDbTypes.Select(type => CheckComboBoxDbTypes.Items
                .OfType<DbType>().First(x =>
                    x == type)))
            {
                CheckComboBoxDbTypes.SetItemChecked(CheckComboBoxDbTypes.Items.OfType<DbType>().ToList().IndexOf(item),
                    true);
            }

            buttonSave.Enabled = false;
        }
    }

    internal class UserConditionVisualItem
    {
        public List<DbType> ShowOnlyForDbTypes { get; }

        public string Caption { get; }
        public string Condition { get; }
        public bool IsNeedEdit { get; }

        public PredefinedCondition PredefinedCondition { get; }

        public UserConditionVisualItem(PredefinedCondition predefinedCondition)
        {
            PredefinedCondition = predefinedCondition;
            ShowOnlyForDbTypes = new List<DbType>();

            Caption = predefinedCondition.Caption;
            Condition = predefinedCondition.Expression;
            IsNeedEdit = predefinedCondition.IsNeedEdit;

            ShowOnlyForDbTypes.AddRange(predefinedCondition.ShowOnlyFor);
        }

        public override string ToString()
        {
            return $"{Caption}";
        }

        public UserConditionVisualItem Copy(string newName)
        {
            return new UserConditionVisualItem(new PredefinedCondition(newName, PredefinedCondition.ShowOnlyFor,
                PredefinedCondition.Expression, PredefinedCondition.IsNeedEdit));
        }
    }
}
