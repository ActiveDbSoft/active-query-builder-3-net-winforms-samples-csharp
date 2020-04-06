//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ActiveQueryBuilder.View.QueryView;

namespace FullFeaturedDemo
{
    public partial class EditUserExpressionForm : Form, IDisposable
    {
        private UserExpressionVisualItem _editingUserExpression;
        private IList<PredefinedCondition> _predefinedConditions;

        public EditUserExpressionForm()
        {
            InitializeComponent();

            foreach (DbType name in Enum.GetValues(typeof(DbType)))
                CheckComboBoxDbTypes.Items.Add(name);

            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            ButtonAddExpression.Enabled = !string.IsNullOrEmpty(TextBoxCaption.Text) &&
                                          !string.IsNullOrEmpty(TextBoxExpression.Text);

            ButtonEditExpression.Enabled = ListBoxExpressions.SelectedItems.Count == 1;
            ButtonRemoveExpression.Enabled = ListBoxExpressions.SelectedItems.Count != 0;
        }

        public void LoadUserExpressions(IList<PredefinedCondition> predefinedConditions)
        {
            ListBoxExpressions.Items.Clear();
            _editingUserExpression = null;

            if (!Equals(_predefinedConditions, predefinedConditions))
                _predefinedConditions = predefinedConditions;

            if (_predefinedConditions == null) return;

            foreach (var expression in predefinedConditions)
                ListBoxExpressions.Items.Add(new UserExpressionVisualItem(expression));
        }

        private void ButtonEditExpression_Click(object sender, EventArgs e)
        {
            if (ListBoxExpressions.SelectedItems.Count != 1) return;

            _editingUserExpression = ListBoxExpressions.SelectedItem as UserExpressionVisualItem;

            if (_editingUserExpression == null) return;

            TextBoxCaption.Text = _editingUserExpression.Caption;
            TextBoxExpression.Text = _editingUserExpression.Expression;
            CheckBoxIsNeedEdit.Checked = _editingUserExpression.IsNeedEdit;

            foreach (var item in _editingUserExpression.ShowOnlyForDbTypes.Select(type => CheckComboBoxDbTypes.Items
                .OfType<DbType>().First(x =>
                    x == type)))
            {
                CheckComboBoxDbTypes.SetItemChecked(CheckComboBoxDbTypes.Items.OfType<DbType>().ToList().IndexOf(item),
                    true);
            }
        }

        private void ButtonRemoveExpression_Click(object sender, EventArgs e)
        {
            RemoveSelectedUserExpression();
        }

        private void ButtonClearForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ButtonAddExpression_Click(object sender, EventArgs e)
        {
            SaveForm();
        }

        private void RemoveSelectedUserExpression()
        {
            var itemForRemove = ListBoxExpressions.SelectedItems.OfType<UserExpressionVisualItem>().ToList();

            foreach (var item in itemForRemove)
            {
                _predefinedConditions.Remove(item.ConditionExpression);
            }

            LoadUserExpressions(null);
        }

        private void ResetForm()
        {
            _editingUserExpression = null;
            TextBoxCaption.Text = string.Empty;
            TextBoxExpression.Text = string.Empty;
            CheckBoxIsNeedEdit.Checked = false;
            CheckComboBoxDbTypes.ClearCheckedItems();
        }

        private void SaveForm()
        {
            try
            {
                var listTypes = CheckComboBoxDbTypes.CheckedItems.OfType<DbType>().ToList();

                var userExpression = new PredefinedCondition(
                    TextBoxCaption.Text,
                    listTypes,
                    TextBoxExpression.Text, CheckBoxIsNeedEdit.Checked
                );

                if (_editingUserExpression != null)
                    _predefinedConditions.Remove(_editingUserExpression.ConditionExpression);

                _predefinedConditions.Add(userExpression);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                LoadUserExpressions(_predefinedConditions);
                ResetForm();
            }
        }
    }

    internal class UserExpressionVisualItem
    {
        public List<DbType> ShowOnlyForDbTypes { get; set; }

        public string Caption { get; set; }
        public string Expression { get; set; }
        public bool IsNeedEdit { get; set; }

        public PredefinedCondition ConditionExpression { get; private set; }

        public UserExpressionVisualItem(PredefinedCondition conditionExpression)
        {
            ConditionExpression = conditionExpression;
            ShowOnlyForDbTypes = new List<DbType>();

            Caption = conditionExpression.Caption;
            Expression = conditionExpression.Expression;
            IsNeedEdit = conditionExpression.IsNeedEdit;

            ShowOnlyForDbTypes.AddRange(conditionExpression.ShowOnlyFor);
        }

        public override string ToString()
        {
            var types = ShowOnlyForDbTypes.Count == 0 ? "For all types" : "For types: ";
            foreach (var dbType in ShowOnlyForDbTypes)
            {
                if (ShowOnlyForDbTypes.IndexOf(dbType) != 0)
                    types += ", ";

                types += dbType;
            }

            return $"{Caption}, [{Expression}], Is need edit: {IsNeedEdit}, {types}";
        }
    }
}
