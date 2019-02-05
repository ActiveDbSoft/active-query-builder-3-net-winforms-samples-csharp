﻿//*******************************************************************//
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace ActiveUnionSubQueryChangedBlock.PropertiesForm
{
	[ToolboxItem(false)]
	internal partial class OfflineModePage : UserControl
	{
		private QueryBuilder _queryBuilder = null;
	    private SQLContext _sqlContextCopy;
		private BaseSyntaxProvider _syntaxProvider = null;
        private bool _modified = false;


		public bool Modified { get { return _modified; } set { _modified = value; } }


		public OfflineModePage(QueryBuilder queryBuilder, BaseSyntaxProvider syntaxProvider)
		{
			_queryBuilder = queryBuilder;
			_syntaxProvider = syntaxProvider;

		    _sqlContextCopy = new SQLContext();
            _sqlContextCopy.Assign(queryBuilder.SQLContext);

			InitializeComponent();

			cbOfflineMode.Checked = queryBuilder.MetadataLoadingOptions.OfflineMode;

			UpdateMode();

			cbOfflineMode.CheckedChanged += checkOfflineMode_CheckedChanged;
			bEditMetadata.Click += buttonEditMetadata_Click;
			bSaveToXML.Click += buttonSaveToXML_Click;
			bLoadFromXML.Click += buttonLoadFromXML_Click;
			bLoadMetadata.Click += buttonLoadMetadata_Click;
		}

		protected override void Dispose(bool disposing)
		{
		    _sqlContextCopy.Dispose();

			cbOfflineMode.CheckedChanged -= checkOfflineMode_CheckedChanged;
			bEditMetadata.Click -= buttonEditMetadata_Click;
			bSaveToXML.Click -= buttonSaveToXML_Click;
			bLoadFromXML.Click -= buttonLoadFromXML_Click;
			bLoadMetadata.Click -= buttonLoadMetadata_Click;

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
				_queryBuilder.MetadataLoadingOptions.OfflineMode = cbOfflineMode.Checked;

				if (_queryBuilder.MetadataLoadingOptions.OfflineMode)
				{
					if (_queryBuilder.MetadataProvider != null)
					{
						_queryBuilder.MetadataProvider.Disconnect();
					}

					_queryBuilder.MetadataContainer.Assign(_sqlContextCopy.MetadataContainer);
				}
				else
				{
					_queryBuilder.MetadataContainer.Items.Clear();
				}
			}
		}

		private void checkOfflineMode_CheckedChanged(object sender, EventArgs e)
		{
			Modified = true;
			UpdateMode();
		}

		private void buttonLoadMetadata_Click(object sender, EventArgs e)
		{
		    _sqlContextCopy.MetadataContainer.BeginUpdate();

			try
			{
				using (MetadataContainerLoadForm f = new MetadataContainerLoadForm(_sqlContextCopy.MetadataContainer))
				{
					if (f.ShowDialog() == DialogResult.OK)
					{
						Modified = true;
						cbOfflineMode.Checked = true;
					}
				}
			}
			finally
			{
			    _sqlContextCopy.MetadataContainer.EndUpdate();
			}
		}

		private void UpdateMode()
		{
			lMetadataObjectCount.Font = new Font(lMetadataObjectCount.Font, (cbOfflineMode.Checked) ? FontStyle.Bold : FontStyle.Regular);
			bLoadFromXML.Enabled = cbOfflineMode.Checked;
			bSaveToXML.Enabled = cbOfflineMode.Checked;
			bEditMetadata.Enabled = cbOfflineMode.Checked;

			UpdateMetadataStats();
		}

		private void UpdateMetadataStats()
		{
			List<MetadataObject> metadataObjects = _sqlContextCopy.MetadataContainer.Items.GetItemsRecursive<MetadataObject>(MetadataType.Objects);
            int t = 0, v = 0, p = 0, s = 0;

            for (int i = 0; i < metadataObjects.Count; i++)
            {
                MetadataObject mo = metadataObjects[i];

                if (mo.Type == MetadataType.Table)
                {
                    t++;
                }
                else if (mo.Type == MetadataType.View)
                {
                    v++;
                }
                else if (mo.Type == MetadataType.Procedure)
                {
                    p++;
                }
                else if (mo.Type == MetadataType.Synonym)
                {
                    s++;
                }
            }

            string tmp = "Loaded Metadata: {0} tables, {1} views, {2} procedures, {3} synonyms.";
            lMetadataObjectCount.Text = String.Format(tmp, t, v, p, s);
		}

		private void buttonLoadFromXML_Click(object sender, EventArgs e)
		{
			if (OpenDialog.ShowDialog() == DialogResult.OK)
			{
			    _sqlContextCopy.MetadataContainer.ImportFromXML(OpenDialog.FileName);
				Modified = true;
				UpdateMetadataStats();
			}
		}

		private void buttonSaveToXML_Click(object sender, EventArgs e)
		{
			if (SaveDialog.ShowDialog() == DialogResult.OK)
			{
			    _sqlContextCopy.MetadataContainer.ExportToXML(SaveDialog.FileName);
			}
		}

		private void buttonEditMetadata_Click(object sender, EventArgs e)
		{
			if (QueryBuilder.EditMetadataContainer(_sqlContextCopy, _sqlContextCopy.LoadingOptions))
			{
				Modified = true;
			}
		}
	}
}