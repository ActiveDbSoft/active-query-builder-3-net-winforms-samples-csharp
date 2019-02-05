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
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace QueryStructureDemo
{
	public partial class Form1 : Form
	{
		private const string CSampleSelect =
			"Select 1 as cid, Upper('2'), 3, 4 + 1, 5 + 2 IntExpression ";

		private const string CSampleSelectFromWhere =
			"Select c.CustomerId as cid, c.CompanyName, Upper(c.CompanyName), o.OrderId " +
			"From Customers c Inner Join Orders o On c.CustomerID = o.CustomerID Where o.OrderId > 0 and c.CustomerId < 10";

		private const string CSampleSelectFromJoin =
			"Select c.CustomerId as cid, Upper(c.CompanyName), o.OrderId, " +
			" p.ProductName + 1, 2+2 IntExpression From Customers c Inner Join " +
			"Orders o On c.CustomerID = o.CustomerID Inner Join " +
			"[Order Details] od On o.OrderID = od.OrderID Inner Join " +
			"Products p On p.ProductID = od.ProductID ";

		private const string CSampleSelectFromJoinSubqueries =
			"Select c.CustomerId as cid, Upper(c.CompanyName), o.OrderId, " +
			"p.ProductName + 1, 2+2 IntExpression From Customers c Inner Join " +
			"Orders o On c.CustomerID = o.CustomerID Inner Join " +
			"[Order Details] od On o.OrderID = od.OrderID Inner Join " +
			"(select pr.ProductId, pr.ProductName from Products pr) p On p.ProductID = od.ProductID ";

		private const string CSampleUnions =
			"Select c.CustomerId as cid, Upper(c.CompanyName), o.OrderId, " +
			"p.ProductName + 1, 2+2 IntExpression From Customers c Inner Join " +
			"Orders o On c.CustomerID = o.CustomerID Inner Join " +
			"[Order Details] od On o.OrderID = od.OrderID Inner Join " +
			"(select pr.ProductId, pr.ProductName from Products pr) p " +
			"On p.ProductID = od.ProductID union all " +
			"(select 1,2,3,4,5 union all select 6,7,8,9,0) union all " +
			"select (select Null as \"Null\") as EmptyValue, " +
			"SecondColumn = 2, Lower('ThirdColumn') as ThirdColumn, 0 as \"Quoted Alias\", 2+2*2 ";

		public Form1()
		{
			InitializeComponent();

			// set required syntax provider
			queryBuilder.SyntaxProvider = new MSSQLSyntaxProvider();
		}

		protected override void OnLoad(EventArgs e)
		{
			// Load sample database metadata from XML file
			try
			{
				queryBuilder.MetadataLoadingOptions.OfflineMode = true;
				queryBuilder.MetadataContainer.ImportFromXML("Northwind.xml");
				queryBuilder.InitializeDatabaseSchemaTree(); 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// load sample query
			queryBuilder.SQL = CSampleSelectFromWhere;

			base.OnLoad(e);
		}

        private void queryBuilder_SQLUpdated(object sender, EventArgs e)
		{
			// Hide error banner if any
			ShowErrorBanner(tbSQL, "");
			
			// QueryBuilder generates new SQL query text. Show it to user.
			tbSQL.Text = queryBuilder.FormattedSQL;

			// update info for entire query
			UpdateQueryInfo();
		}

		private void btnSampleSelect_Click(object sender, EventArgs e)
		{
			queryBuilder.SQL = CSampleSelect;
		}

		private void btnSampleSelectFromWhere_Click(object sender, EventArgs e)
		{
			queryBuilder.SQL = CSampleSelectFromWhere;
		}

		private void btnSampleSelectFromJoin_Click(object sender, EventArgs e)
		{
			queryBuilder.SQL = CSampleSelectFromJoin;
		}

		private void btnSampleSelectFromJoinSubqueries_Click(object sender, EventArgs e)
		{
			queryBuilder.SQL = CSampleSelectFromJoinSubqueries;
		}

		private void btnSampleUnions_Click(object sender, EventArgs e)
		{
			queryBuilder.SQL = CSampleUnions;
		}

		private void btnShowUnlinkedDatasourcesButton_Click(object sender, EventArgs e)
		{
		    // get active UnionSubQuery
			var unionSubQuery = queryBuilder.ActiveUnionSubQuery.ParentUnionSubQuery;

			// analize links and datasources
			var unlinkedDatasourcesInfo = GetUnlinkedDataSourcesFromUnionSubQuery(unionSubQuery);

			MessageBox.Show(unlinkedDatasourcesInfo);
		}

        private void queryBuilder_ActiveUnionSubQueryChanged(object sender, EventArgs e)
		{
            if(queryBuilder.ActiveUnionSubQuery == null) return;
			// update Query Structure information
			UpdateSubQueryStructureInfo();

			// update DataSources information
			UpdateDataSourcesInfo();

			// update Links information
			UpdateLinksInfo();

			// and update Selected expressions information
			UpdateSelectedExpressionsInfo();
		}

		private void UpdateDataSourcesInfo()
		{
			UnionSubQuery unionSubQuery = queryBuilder.ActiveUnionSubQuery;
			StringBuilder stringBuilder = new StringBuilder();

			DumpDataSourcesInfoFromUnionSubQuery(stringBuilder, unionSubQuery);

			tbDataSources.Text = stringBuilder.ToString();
		}

		private void UpdateLinksInfo()
		{
			UnionSubQuery unionSubQuery = queryBuilder.ActiveUnionSubQuery;
			StringBuilder stringBuilder = new StringBuilder();

			DumpLinksInfoFromUnionSubQuery(stringBuilder, unionSubQuery);

			tbLinks.Text = stringBuilder.ToString();
		}

		private void UpdateQueryInfo()
		{
			// update Query Structure information
			UpdateQueryStatisticsInfo();

			// and update SubQueries list
			UpdateQuerySubQueriesInfo();

			// and update information for current SubQuery/UnionSubQuery
			UpdateSubQueryInfo();
		}

		private void UpdateQueryStatisticsInfo()
		{
			QueryStatistics statistics = queryBuilder.QueryStatistics;
			StringBuilder stringBuilder = new StringBuilder();

			DumpQueryStatisticsInfo(stringBuilder, statistics);

			tbStatistics.Text = stringBuilder.ToString();
		}

		private void UpdateQuerySubQueriesInfo()
		{
			StringBuilder stringBuilder = new StringBuilder();

			DumpSubQueriesInfo(stringBuilder, queryBuilder);

			tbSubQueries.Text = stringBuilder.ToString();
		}

		private void UpdateSubQueryStructureInfo()
		{
			SubQuery subQuery = queryBuilder.ActiveUnionSubQuery.ParentSubQuery;
			StringBuilder stringBuilder = new StringBuilder();

			DumpQueryStructureInfo(stringBuilder, subQuery);

			tbSubQueryStructure.Text = stringBuilder.ToString();
		}

		private void UpdateWhereInfo()
		{
			UnionSubQuery unionSubQuery = queryBuilder.ActiveUnionSubQuery;
			StringBuilder stringBuilder = new StringBuilder();

			SQLSubQuerySelectExpression unionSubQueryAst = unionSubQuery.ResultQueryAST;

			try
			{
				if (unionSubQueryAst.Where != null)
				{
					DumpWhereInfo(stringBuilder, unionSubQueryAst.Where);
				}
			}
			finally
			{
				unionSubQueryAst.Dispose();
			}

			tbWhere.Text = stringBuilder.ToString();
		}

		private void UpdateSelectedExpressionsInfo()
		{
			UnionSubQuery unionSubQuery = queryBuilder.ActiveUnionSubQuery;
			StringBuilder stringBuilder = new StringBuilder();

			DumpSelectedExpressionsInfoFromUnionSubQuery(stringBuilder, unionSubQuery);

			tbSelectedExpressions.Text = stringBuilder.ToString();
		}

		private void UpdateSubQueryInfo()
		{
			// update Query Structure information
			UpdateSubQueryStructureInfo();

			// update DataSources information
			UpdateDataSourcesInfo();

			// update Links information
			UpdateLinksInfo();

			// update Selected Expressions information
			UpdateSelectedExpressionsInfo();

			// and update WHERE clause information
			UpdateWhereInfo();
		}

		private void tbSQL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				// Update the query builder with manually edited query text:
				queryBuilder.SQL = tbSQL.Text;

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

		public void ShowErrorBanner(Control control, String text)
		{
			// Destory banner if already showing
			{
				bool existBanner = false;
				Control[] banners = control.Controls.Find("ErrorBanner", true);

				if (banners.Length > 0)
				{
				    foreach (Control banner in banners)
				    {
                        if(Equals(text, banner.Text)) 
						{
							existBanner = true;
							continue;
						}
				        banner.Dispose();
				    }
				}

                if(existBanner) return;
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
					AutoSize =  true,
					Visible = true
				};

				control.Controls.Add(label);
				label.Location = new Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2);
				label.BringToFront();
                
				control.Focus();
			}
		}
	}
}
