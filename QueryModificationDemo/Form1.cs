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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace QueryModificationDemo
{
	public partial class Form1 : Form
	{
		private SQLQualifiedName _joinFieldName;
		private SQLQualifiedName _companyNameFieldName;
		private SQLQualifiedName _orderDateFieldName;

		private DataSource _customers;
		private DataSource _orders;
		private QueryColumnListItem _companyName;
		private QueryColumnListItem _orderDate;

	    private const string CustomersName = "Northwind.dbo.Customers";
	    private const string OrdersName = "Northwind.dbo.Orders";
	    private const string CustomersAlias = "c";
	    private const string OrdersAlias = "o";
	    private const string CustomersCompanyName = "CompanyName";
	    private const string CusomerId = "CustomerId";
	    private const string OrderDate = "OrderDate";

        public Form1()
		{
			InitializeComponent();
		}

	    protected override void OnLoad(EventArgs e)
	    {
			// load metadata from XML file located in resource (for demonstration purposes)
	        queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = true;
            queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml");
            queryBuilder1.InitializeDatabaseSchemaTree();

	        queryBuilder1.SQLUpdated += SqlUpdated;

            //prepare parsed names
            _joinFieldName = queryBuilder1.SQLContext.ParseQualifiedName(CusomerId);
            _companyNameFieldName = queryBuilder1.SQLContext.ParseQualifiedName(CustomersCompanyName);
            _orderDateFieldName = queryBuilder1.SQLContext.ParseQualifiedName(OrderDate);

            base.OnLoad(e);
		}

        private bool IsTablePresentInQuery(UnionSubQuery unionSubQuery, DataSource table)
		{
			// collect the list of datasources used in FROM
			var dataSources = unionSubQuery.GetChildrenRecursive<DataSource>(false);

			// check given table in list of all datasources
			return dataSources.IndexOf(table) != -1;
		}

		private bool IsQueryColumnListItemPresentInQuery(UnionSubQuery unionSubQuery, QueryColumnListItem item)
		{
			return unionSubQuery.QueryColumnList.IndexOf(item) != -1 && !String.IsNullOrEmpty(item.ExpressionString);
		}

		private void ClearConditionCells(UnionSubQuery unionSubQuery, QueryColumnListItem item)
		{
            for (int i = 0; i < unionSubQuery.QueryColumnList.GetMaxConditionCount(); i++)
            {
                item.ConditionStrings[i] = "";
            }
        }

	    private DataSource AddTable(UnionSubQuery unionSubQuery, string name, string alias)
	    {
	        using (var parsedName = queryBuilder1.SQLContext.ParseQualifiedName(name))
	        using (var parsedAlias = queryBuilder1.SQLContext.ParseIdentifier(alias))
	        {
	            return queryBuilder1.QueryView.Query.AddObject(unionSubQuery, parsedName, parsedAlias);
	        }
	    }

		private DataSource FindTableInQueryByName(UnionSubQuery unionSubQuery, string name)
		{
		    List<DataSourceObject> foundDatasources;
		    using (var qualifiedName = queryBuilder1.SQLContext.ParseQualifiedName(name))
		    {
		        foundDatasources = new List<DataSourceObject>();
		        unionSubQuery.FromClause.FindTablesByDbName(qualifiedName, foundDatasources);
		    }

		    // if found more than one tables with given name in the query, use the first one
			return foundDatasources.Count > 0 ? foundDatasources[0] : null;
		}

		private void AddWhereCondition(QueryColumnList columnList, QueryColumnListItem whereListItem, string condition)
		{
			bool whereFound = false;

			// GetMaxConditionCount: returns the number of non-empty criteria columns in the grid.
			for (int i = 0; i < columnList.GetMaxConditionCount(); i++)
			{
				// CollectCriteriaItemsWithWhereCondition:
				// This function returns the list of conditions that were found in
				// the i-th criteria column, applied to specific clause (WHERE or HAVING).
				// Thus, this function collects all conditions joined with AND
				// within one OR group (one grid column).
				List<QueryColumnListItem> foundColumnItems = new List<QueryColumnListItem>();
				CollectCriteriaItemsWithWhereCondition(columnList, i, foundColumnItems);

				// if found some conditions in i-th column, append condition to i-th column
				if (foundColumnItems.Count > 0)
				{
					whereListItem.ConditionStrings[i] = condition;
					whereFound = true;
				}
			}

			// if there are no cells with "where" conditions, add condition to new column
			if (!whereFound)
			{
				whereListItem.ConditionStrings[columnList.GetMaxConditionCount()] = condition;
			}
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
            queryBuilder1.BeginUpdate();

			try
			{
				// get the active SELECT

			    var usq = queryBuilder1.ActiveUnionSubQuery;

				#region actualize stored references (if query is modified in GUI)
				#region actualize datasource references
				// if user removed previously added datasources then clear their references
				if (_customers != null && !IsTablePresentInQuery(usq, _customers))
				{
					// user removed this table in GUI
					_customers = null;
				}

				if (_orders != null && !IsTablePresentInQuery(usq, _orders))
				{
					// user removed this table in GUI
					_orders = null;
				}
                #endregion

                // clear CompanyName conditions
                if (_companyName != null)
				{
					// if user removed entire row OR cleared expression cell in GUI, clear the stored reference
					if (!IsQueryColumnListItemPresentInQuery(usq, _companyName))
						_companyName = null;
				}

			    // clear all condition cells for CompanyName row
			    if (_companyName != null)
			    {
			        ClearConditionCells(usq, _companyName);
			    }

                // clear OrderDate conditions
                if (_orderDate != null)
				{
					// if user removed entire row OR cleared expression cell in GUI, clear the stored reference
					if (!IsQueryColumnListItemPresentInQuery(usq, _orderDate))
						_orderDate = null;
				}

				// clear all condition cells for OrderDate row
				if (_orderDate != null)
				{
					ClearConditionCells(usq, _orderDate);
				}
				#endregion

				#region process Customers table
				if (cbCustomers.Checked)
				{
					// if we have no previously added Customers table, try to find one already added by the user
					if (_customers == null)
					{
						_customers = FindTableInQueryByName(usq, CustomersName);
					}

					// there is no Customers table in query, add it
					if (_customers == null)
					{
					    _customers = AddTable(usq, CustomersName, CustomersAlias);
					}

					#region process CompanyName condition
					if (cbCompanyName.Enabled && cbCompanyName.Checked && !String.IsNullOrEmpty(tbCompanyName.Text))
					{
						// if we have no previously added grid row for this condition, add it
						if (_companyName == null || _companyName.IsDisposing)
						{
							_companyName = usq.QueryColumnList.AddField(_customers, _companyNameFieldName.QualifiedName);
							// do not append it to the select list, use this row for conditions only
							_companyName.Selected = false;
						}

						// write condition from edit box to all needed grid cells
						AddWhereCondition(usq.QueryColumnList, _companyName, tbCompanyName.Text);
					}
					else
					{
						// remove previously added grid row
						if (_companyName != null)
						{
							_companyName.Dispose();
						}

						_companyName = null;
					}
					#endregion
				}
				else
				{
					// remove previously added datasource
					if (_customers != null)
					{
						_customers.Dispose();
					}

					_customers = null;
				}
				#endregion

				#region process Orders table
				if (cbOrders.Checked)
				{
					// if we have no previosly added Orders table, try to find one already added by the user
					if (_orders == null)
					{
						_orders = FindTableInQueryByName(usq, OrdersName);
					}

					// there are no Orders table in query, add one
					if (_orders == null)
					{
					    _orders = AddTable(usq, OrdersName, OrdersAlias);
					}

					#region link between Orders and Customers
					// we added Orders table,
					// check if we have Customers table too,
					// and if there are no joins between them, create such join
					string joinFieldNameStr = _joinFieldName.QualifiedName;
					if (_customers != null &&
					    usq.FromClause.FindLink(_orders, joinFieldNameStr, _customers, joinFieldNameStr) == null &&
					    usq.FromClause.FindLink(_customers, joinFieldNameStr, _orders, joinFieldNameStr) == null)
					{
                        queryBuilder1.QueryView.Query.AddLink(_customers, _joinFieldName, _orders, _joinFieldName);
					}
					#endregion

					#region process OrderDate condition
					if (cbOrderDate.Enabled && cbOrderDate.Checked && !String.IsNullOrEmpty(tbOrderDate.Text))
					{
						// if we have no previously added grid row for this condition, add it
						if (_orderDate == null)
						{
							_orderDate = usq.QueryColumnList.AddField(_orders, _orderDateFieldName.QualifiedName);
							// do not append it to the select list, use this row for conditions only
							_orderDate.Selected = false;
						}

						// write condition from edit box to all needed grid cells
						AddWhereCondition(usq.QueryColumnList, _orderDate, tbOrderDate.Text);
					}
					else
					{
						// remove prviously added grid row
						if (_orderDate != null)
						{
							_orderDate.Dispose();
						}

						_orderDate = null;
					}
					#endregion
				}
				else
				{
					if (_orders != null)
					{
						_orders.Dispose();
						_orders = null;
					}
				}
				#endregion
			}
			finally
			{
                queryBuilder1.EndUpdate();
			}
		}

		private void CollectCriteriaItemsWithWhereCondition(QueryColumnList criteriaList, int columnIndex, IList<QueryColumnListItem> result)
		{
		    result.Clear();

		    foreach (var item in criteriaList)
		    {
		        if (item.ConditionType == ConditionType.Where &&
		            item.ConditionCount > columnIndex &&
		            item.GetASTCondition(columnIndex) != null)
		        {
		            result.Add(item);
		        }
		    }
		}

		private void btnQueryCustomers_Click(object sender, EventArgs e)
		{
			queryBuilder1.SQL = "select * from Northwind.dbo.Customers c";
		}

		private void btnQueryOrders_Click(object sender, EventArgs e)
		{
            queryBuilder1.SQL = "select * from Northwind.dbo.Orders o";
		}

		private void btnQueryCustomersOrders_Click(object sender, EventArgs e)
		{
            queryBuilder1.SQL = "select * from Northwind.dbo.Customers c, Northwind.dbo.Orders o";
		}

		private void cbCompanyName_CheckedChanged(object sender, EventArgs e)
		{
			tbCompanyName.Enabled = cbCompanyName.Checked;
		}

		private void cbCustomers_CheckedChanged(object sender, EventArgs e)
		{
			cbCompanyName.Enabled = cbCustomers.Checked;
			tbCompanyName.Enabled = (cbCompanyName.Checked && cbCustomers.Checked);
		}

		private void cbOrderDate_CheckedChanged(object sender, EventArgs e)
		{
			tbOrderDate.Enabled = cbOrderDate.Checked;
		}

		private void cbOrders_CheckedChanged(object sender, EventArgs e)
		{
			cbOrderDate.Enabled = cbOrders.Checked;
			tbOrderDate.Enabled = cbOrderDate.Checked && cbOrders.Checked;
		}

		private void tbSQL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				// Update the query builder with manually edited query text:
                queryBuilder1.SQL = tbSQL.Text;

				// Hide error banner if any
				ShowErrorBanner(tbSQL, "");
			}
			catch (SQLParsingException ex)
			{
				// Set caret to error position
				tbSQL.SelectionStart = ex.ErrorPos.pos;

				// Show banner with error text
				ShowErrorBanner(tbSQL, ex.Message);
			}
		}

        private void SqlUpdated(object sender, EventArgs e)
		{
			// query text in the Query Builder has been updated
		    
			// Hide error banner if any
			ShowErrorBanner(tbSQL, "");
			
		    tbSQL.Text = queryBuilder1.FormattedSQL;
		}

		public void ShowErrorBanner(Control control, string text)
		{
			// Destory banner if already showing
			{
				Control[] banners = control.Controls.Find("ErrorBanner", true);

				if (banners.Length > 0)
				{
					foreach (Control banner in banners)
						banner.Dispose();
				}
			}

			// Show new banner if text is not empty
			if (!String.IsNullOrEmpty(text))
			{
				Label label = new Label
				{
					Name = "ErrorBanner",
					Text = text,
					BorderStyle = BorderStyle.FixedSingle,
					BackColor = Color.LightPink,
					AutoSize = true,
					Visible = true
				};

				control.Controls.Add(label);
				control.Controls.SetChildIndex(label, 0);
				label.Location = new Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2);
				control.Focus();
			}
		}

      
	}
}
