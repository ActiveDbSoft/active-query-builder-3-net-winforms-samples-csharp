//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.DatabaseSchemaView;
using ActiveQueryBuilder.View.WinForms;

namespace GeneralAssembly.QueryBuilderProperties
{
    [ToolboxItem(false)]
    internal partial class DatabaseSchemaViewPage : UserControl
    {
        private readonly QueryBuilder _queryBuilder;
        private bool _modified = false;
        private MetadataType _expandMetadataType;

        public bool Modified { get { return _modified; } set { _modified = value; } }


        public DatabaseSchemaViewPage(QueryBuilder queryBuilder)
        {
            _queryBuilder = queryBuilder;

            InitializeComponent();

            cbGroupByServers.Checked = queryBuilder.MetadataStructure.Options.GroupByServers;
            cbGroupByDatabases.Checked = queryBuilder.MetadataStructure.Options.GroupByDatabases;
            cbGroupBySchemas.Checked = queryBuilder.MetadataStructure.Options.GroupBySchemas;
            cbGroupByTypes.Checked = queryBuilder.MetadataStructure.Options.GroupByTypes;
            cbShowFields.Checked = queryBuilder.MetadataStructure.Options.ShowFields;

            cmbSortObjectsBy.Items.Add("Sort by Name");
            cmbSortObjectsBy.Items.Add("Sort by Type, Name");
            cmbSortObjectsBy.Items.Add("No sorting");
            cmbSortObjectsBy.SelectedIndex = (int)queryBuilder.DatabaseSchemaViewOptions.SortingType;

            cbGroupByServers.CheckedChanged += Changed;
            cbGroupByDatabases.CheckedChanged += Changed;
            cbGroupBySchemas.CheckedChanged += Changed;
            cbGroupByTypes.CheckedChanged += Changed;
            cbShowFields.CheckedChanged += Changed;
            cmbSortObjectsBy.SelectedIndexChanged += Changed;
            cbDefaultExpandType.ItemChecked += CbDefaultExpandTypeOnItemChecked;

            _expandMetadataType = queryBuilder.DatabaseSchemaView.Options.DefaultExpandMetadataType;
            FillComboBox(typeof(MetadataType));
            SetExpandType(queryBuilder.DatabaseSchemaView.Options.DefaultExpandMetadataType);
        }

        private void CbDefaultExpandTypeOnItemChecked(object sender, EventArgs eventArgs)
        {
            _expandMetadataType = GetExpandType();
            cbDefaultExpandType.Text = _expandMetadataType.ToString();
            Changed(this, EventArgs.Empty);
        }

        protected override void Dispose(bool disposing)
        {
            cbGroupByServers.CheckedChanged -= Changed;
            cbGroupByDatabases.CheckedChanged -= Changed;
            cbGroupBySchemas.CheckedChanged -= Changed;
            cbGroupByTypes.CheckedChanged -= Changed;
            cbShowFields.CheckedChanged -= Changed;
            cmbSortObjectsBy.SelectedIndexChanged -= Changed;
            cbDefaultExpandType.ItemChecked -= CbDefaultExpandTypeOnItemChecked;

            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        public void ApplyChanges()
        {
            if (Modified)
            {
                MetadataStructureOptions metadataStructureOptions = _queryBuilder.MetadataStructure.Options;
                metadataStructureOptions.BeginUpdate();

                try
                {
                    metadataStructureOptions.GroupByServers = cbGroupByServers.Checked;
                    metadataStructureOptions.GroupByDatabases = cbGroupByDatabases.Checked;
                    metadataStructureOptions.GroupBySchemas = cbGroupBySchemas.Checked;
                    metadataStructureOptions.GroupByTypes = cbGroupByTypes.Checked;
                    metadataStructureOptions.ShowFields = cbShowFields.Checked;
                }
                finally
                {
                    metadataStructureOptions.EndUpdate();
                }

                DatabaseSchemaViewOptions databaseSchemaViewOptions = _queryBuilder.DatabaseSchemaViewOptions;
                databaseSchemaViewOptions.BeginUpdate();

                try
                {
                    databaseSchemaViewOptions.SortingType = (ObjectsSortingType)cmbSortObjectsBy.SelectedIndex;
                    databaseSchemaViewOptions.DefaultExpandMetadataType = GetExpandType();
                }
                finally
                {
                    databaseSchemaViewOptions.EndUpdate();
                }
            }
        }

        private void Changed(object sender, EventArgs e)
        {
            Modified = true;
        }

        private void FillComboBox(Type enumType)
        {
            var flags = GetFlagsFromType(enumType);
            foreach (var flag in flags)
            {
                cbDefaultExpandType.Items.Add(flag);
            }
        }

        private List<Enum> GetFlagsFromType(Type enumType)
        {
            var values = Enum.GetValues(enumType);
            var result = new List<Enum>();
            foreach (var value in values)
            {
                // filter unity items
                if (IsDegreeOf2((int)value))
                    result.Add((Enum)value);
            }

            return result;
        }

        private bool IsDegreeOf2(int n)
        {
            return n != 0 && (n & (n - 1)) == 0;
        }

        private MetadataType GetExpandType()
        {
            var intValue = (int)_expandMetadataType;

            for (int i = 0; i < cbDefaultExpandType.Items.Count; i++)
            {
                if (cbDefaultExpandType.IsItemChecked(i))
                    intValue |= (int)cbDefaultExpandType.Items[i];
                else
                    intValue &= ~(int)cbDefaultExpandType.Items[i];
            }

            return (MetadataType)intValue;
        }

        private void SetExpandType(object value)
        {
            cbDefaultExpandType.ClearCheckedItems();
            var decomposed = DecomposeEnum(value);
            for (int i = 0; i < cbDefaultExpandType.Items.Count; i++)
            {
                if (decomposed.Contains((int)cbDefaultExpandType.Items[i]))
                    cbDefaultExpandType.SetItemChecked(i, true);
            }
        }

        private List<int> DecomposeEnum(object value)
        {
            // decomposite enum by degrees of 2
            var binary = Convert.ToString((int)value, 2).Reverse().ToList();
            var result = new List<int>();
            for (int i = 0; i < binary.Count; i++)
            {
                if (binary[i] == '1')
                    result.Add((int)Math.Pow(2, i));
            }

            return result;
        }
    }
}
