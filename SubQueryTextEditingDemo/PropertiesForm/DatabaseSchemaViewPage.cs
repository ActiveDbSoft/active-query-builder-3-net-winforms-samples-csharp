//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2018 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.DatabaseSchemaView;
using ActiveQueryBuilder.View.WinForms;

namespace ActiveUnionSubQueryChangedBlock.PropertiesForm
{
	[ToolboxItem(false)]
	internal partial class DatabaseSchemaViewPage : UserControl
	{
		private readonly QueryBuilder _queryBuilder;
		private bool _modified = false;


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
			cmbSortObjectsBy.SelectedIndex = (int) queryBuilder.DatabaseSchemaViewOptions.SortingType;

			cmbDefaultExpandLevel.Text = queryBuilder.DatabaseSchemaViewOptions.DefaultExpandLevel.ToString(CultureInfo.InvariantCulture);
			
			cbGroupByServers.CheckedChanged += Changed;
			cbGroupByDatabases.CheckedChanged += Changed;
			cbGroupBySchemas.CheckedChanged += Changed;
			cbGroupByTypes.CheckedChanged += Changed;
			cbShowFields.CheckedChanged += Changed;
			cmbSortObjectsBy.SelectedIndexChanged += Changed;
			cmbDefaultExpandLevel.SelectedIndexChanged += Changed;
		}

		protected override void Dispose(bool disposing)
		{
			cbGroupByServers.CheckedChanged -= Changed;
			cbGroupByDatabases.CheckedChanged -= Changed;
			cbGroupBySchemas.CheckedChanged -= Changed;
			cbGroupByTypes.CheckedChanged -= Changed;
			cbShowFields.CheckedChanged -= Changed;
			cmbSortObjectsBy.SelectedIndexChanged -= Changed;
			cmbDefaultExpandLevel.SelectedIndexChanged -= Changed;

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
					_queryBuilder.DatabaseSchemaViewOptions.SortingType = (ObjectsSortingType)cmbSortObjectsBy.SelectedIndex;

					int defaultExpandLevel;
					if (int.TryParse(cmbDefaultExpandLevel.Text, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out defaultExpandLevel))
						_queryBuilder.DatabaseSchemaViewOptions.DefaultExpandLevel = defaultExpandLevel;
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
	}
}
