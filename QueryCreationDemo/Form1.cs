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
using System.Linq;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using GeneralAssembly.Forms.QueryInformationForms;

namespace QueryCreationDemo
{

	public partial class Form1 : Form
	{

		private readonly SQLQuery _query;
		public Form1()
		{
		    SQLContext sqlContext = new SQLContext {LoadingOptions = {OfflineMode = true}};

		    _query = new SQLQuery(sqlContext);
			_query.SQLUpdated += Query_SQLUpdated;
			InitializeComponent();

			comboBoxSyntax.SelectedItem = "MS SQL Server";
		}

		private void Query_SQLUpdated(object sender, EventArgs e)
		{
			// at this stage you can get simple unformatted query text...
			//SqlBox.Text = _query.SQL;

			// ... or format the query text with SQL formatter
			SQLFormattingOptions formattingOptions = new SQLFormattingOptions { KeywordFormat = KeywordFormat.UpperCase };
			string sql = FormattedSQLBuilder.GetSQL(_query.QueryRoot, formattingOptions);

			// put the result SQL query text to the text box
			SqlBox.Text = sql;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FillMetadataContainer();
			comboBoxExamples.SelectedIndex = 0;
		}

		private void buttonQueryStatistics_Click(object sender, EventArgs e)
		{
			QueryStatistics();
		}

		// HOWTO: Fill metadata container with custom objects
		public void FillMetadataContainer()
		{
			MetadataNamespace database = _query.SQLContext.MetadataContainer.AddDatabase("MyDB");
			database.Default = true;
			// hides the default database prefix from object names
			MetadataNamespace schema = database.AddSchema("MySchema");
			schema.Default = true;
			// hides the default schema prefix from object names
			// create table
			MetadataObject tableOrders = schema.AddTable("Orders");
			tableOrders.AddField("OrderID");
			tableOrders.AddField("OrderDate");
			tableOrders.AddField("City");
			tableOrders.AddField("CustomerID");
			tableOrders.AddField("ResellerID");

			// create another table
			MetadataObject tableCustomers = schema.AddTable("Customers");
			tableCustomers.AddField("CustomerID");
			tableCustomers.AddField("CustomerName");
			tableCustomers.AddField("CustomerAddress");

			MetadataField fieldCustValue = tableCustomers.AddField("CustomerValue");
			fieldCustValue.FieldType = System.Data.DbType.Double;

			MetadataField fieldCustBirthDate = tableCustomers.AddField("CustomerBirthDay");
			fieldCustBirthDate.FieldType = System.Data.DbType.DateTime;

			MetadataField fieldCustCity = tableCustomers.AddField("City");
			fieldCustCity.FieldType = System.Data.DbType.String;
			fieldCustCity.Size = 50;

			// add a relation between these two tables
			MetadataForeignKey relation = tableCustomers.AddForeignKey("FK_CustomerID");
			relation.Fields.Add("CustomerID");
			relation.ReferencedObjectName = tableOrders.GetQualifiedName();
			relation.ReferencedFields.Add("CustomerID");

			// create another table
			MetadataObject salesOrderHeader = schema.AddTable("SalesOrderHeader");
			salesOrderHeader.AddField("SalesOrderID");
			salesOrderHeader.AddField("OrderDate");

			// create another table
			MetadataObject salesOrderDetail = schema.AddTable("SalesOrderDetail");
			salesOrderDetail.AddField("SalesOrderID");
			salesOrderDetail.AddField("UnitPrice");


			//create a view
			MetadataObject viewResellers = schema.AddView("Resellers");
			viewResellers.AddField("ResellerID");
			viewResellers.AddField("ResellerName");
		}

		// HOWTO: Get query statistics
		public void QueryStatistics()
		{
		    try
		    {
		        _query.SQL = SqlBox.Text;
		    }
		    catch (Exception e)
		    {
		        MessageBox.Show(e.Message, "Parsing error");
		        return;
		    }

		    QueryStatistics qs = _query.QueryStatistics;

		    var stats = "Used Objects (" + qs.UsedDatabaseObjects.Count + "):\r\n";

		    foreach (StatisticsDatabaseObject statisticsDatabaseObject in qs.UsedDatabaseObjects)
		        stats += "\r\n" + statisticsDatabaseObject.ObjectName.QualifiedName;

		    stats += "\r\n\r\n" + "Used Columns (" + qs.UsedDatabaseObjectFields.Count + "):\r\n";

		    foreach (StatisticsField statisticsField in qs.UsedDatabaseObjectFields)
		        stats += "\r\n" + statisticsField.FullName.QualifiedName;

		    stats += "\r\n\r\n" + "Output Expressions (" + qs.OutputColumns.Count + "):\r\n";

		    foreach (StatisticsOutputColumn statisticsOutputColumn in qs.OutputColumns)
		        stats += "\r\n" + statisticsOutputColumn.Expression;

		    var f = new QueryStatisticsForm { textBox = { Text = stats } };

		    f.ShowDialog(this);
        }

		private void comboBoxSyntax_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch ((string)comboBoxSyntax.SelectedItem) {
				case "Advantage":
					_query.SQLContext.SyntaxProvider = new AdvantageSyntaxProvider();
					break; 

				case "ANSI SQL-2003":
					_query.SQLContext.SyntaxProvider = new SQL2003SyntaxProvider();
					break; 

				case "ANSI SQL-89":
					_query.SQLContext.SyntaxProvider = new SQL89SyntaxProvider();
					break; 

				case "ANSI SQL-92":
					_query.SQLContext.SyntaxProvider = new SQL92SyntaxProvider();
					break; 

				case "Firebird":
					_query.SQLContext.SyntaxProvider = new FirebirdSyntaxProvider();
					break; 

				case "IBM DB2":
					_query.SQLContext.SyntaxProvider = new DB2SyntaxProvider();
					break; 

				case "IBM Informix":
					_query.SQLContext.SyntaxProvider = new InformixSyntaxProvider();
					break; 

				case "MS Access":
					_query.SQLContext.SyntaxProvider = new MSAccessSyntaxProvider();
					break; 

				case "MS SQL Server":
					_query.SQLContext.SyntaxProvider = new MSSQLSyntaxProvider();
					break; 

				case "MySQL":
					_query.SQLContext.SyntaxProvider = new MySQLSyntaxProvider();
					break; 

				case "Oracle":
					_query.SQLContext.SyntaxProvider = new OracleSyntaxProvider();
					break; 

				case "PostgreSQL":
					_query.SQLContext.SyntaxProvider = new PostgreSQLSyntaxProvider();
					break; 

				case "SQLite":
					_query.SQLContext.SyntaxProvider = new SQLiteSyntaxProvider();
					break; 

				case "Sybase":
					_query.SQLContext.SyntaxProvider = new SybaseSyntaxProvider();
					break; 

				case "Teradata":
					_query.SQLContext.SyntaxProvider = new TeradataSyntaxProvider();
					break; 

				case "VistaDB":
					_query.SQLContext.SyntaxProvider = new VistaDBSyntaxProvider();
					break; 

				default:
					_query.SQLContext.SyntaxProvider = new SQL92SyntaxProvider();
					break; 

			}
		}

		private void comboBoxExamples_SelectedIndexChanged(object sender, EventArgs e)
		{
			_query.Clear();

			// HOWTO: Create a query programmatically
			switch (comboBoxExamples.SelectedIndex) {
				case 0:
					LoadQuerySimple();
					break; 
				case 1:
					LoadQueryWithLeftJoin();
					break; 
				case 2:
					LoadQueryWithAggregateAndGroup();
					break; 
				case 3:
					LoadQueryWithDerivedTableAndCte();
					break; 
				case 4:
					LoadQueryWithUnions();
					break; 
				case 5:
					LoadQueryWithSubQueryExpression();
					break; 

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void LoadQuerySimple()
		{
			UnionSubQuery unionSubQuery = _query.QueryRoot.FirstSelect();

			// add three objects to the query
			DataSource ds1 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Customers", "c");
			DataSource ds2 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Orders", "o");
			DataSource ds3 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Resellers", "r");

			// create a relation between 'Resellers' and 'Orders'
			_query.AddLink(ds3, "ResellerID", ds2, "ResellerID");

			// create WHERE condition
			QueryColumnListItem ci2 = unionSubQuery.QueryColumnList.AddExpression("CustomerID");
			// do not add this item to the select list
			ci2.Selected = false;
			ci2.ConditionStrings[0] = "> 0";

			// create an output column
			QueryColumnListItem ci3 = unionSubQuery.QueryColumnList.AddField(ds1, "CustomerName");
			// add this item to the select list
			ci3.Selected = true;
		}

		private void LoadQueryWithLeftJoin()
		{
			UnionSubQuery unionSubQuery = _query.QueryRoot.FirstSelect();

			// add data source objects into the query
			DataSource ds1 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Orders");
			DataSource ds2 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Resellers");

			// create a relation between 'Resellers' and 'Orders'
			Link link = _query.AddLink(ds2, "ResellerID", ds1, "ResellerID");

			if (link == null) {
				return;
			}

			// set link type to left outer join
			link.LeftType = LinkSideType.Outer;

			// alter join expression
			link.LinkExpressionString = link.LinkExpressionString + " and Orders.ResellerID IS NOT NULL";
		}

		private void LoadQueryWithAggregateAndGroup()
		{
			UnionSubQuery unionSubQuery = _query.QueryRoot.FirstSelect();

			// add an object to the query
			DataSource ds1 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Customers");

			// create two output columns
			QueryColumnListItem ci1 = unionSubQuery.QueryColumnList.AddField(ds1, "CustomerID");
			ci1.Selected = true;
			QueryColumnListItem ci2 = unionSubQuery.QueryColumnList.AddField(ds1, "CustomerValue");
			ci2.Selected = true;

			// add WHERE condition
			ci2.ConditionStrings[0] = "> 100";

			// specify order by 
			ci2.SortType = ItemSortType.Desc;
			ci2.SortOrder = 0;

			// group by
			ci2.Grouping = true;

			// define aggregate function for the first column
			ci1.AggregateString = "Count";

			// add a HAVING clause
			ci1.ConditionStrings[0] = "> 10";
			ci1.ConditionType = ConditionType.Having;
		}

		private void LoadQueryWithDerivedTableAndCte()
		{
			UnionSubQuery unionSubQuery = _query.QueryRoot.FirstSelect();

			// Derived Table
			SQLFromQuery fq = new SQLFromQuery(_query.SQLContext) {
				Alias = new SQLAliasObjectAlias(_query.SQLContext) { Alias = _query.QueryRoot.CreateUniqueSubQueryName() },
				SubQuery = new SQLSubSelectStatement(_query.SQLContext)
			};

			SQLSubQuerySelectExpression sqse = new SQLSubQuerySelectExpression(_query.SQLContext);
			fq.SubQuery.Add(sqse);
			sqse.SelectItems = new SQLSelectItems(_query.SQLContext);
			sqse.From = new SQLFromClause(_query.SQLContext);

			DataSourceQuery dataSourceQuery = (DataSourceQuery)_query.AddObject(unionSubQuery, fq, typeof(DataSourceQuery));
			UnionSubQuery usc = dataSourceQuery.SubQuery.FirstSelect();
			DataSource dsDerivedTable = _query.AddObject(usc, "MyDB.MySchema.SalesOrderHeader");

			QueryColumnListItem ciDerivedTable1 = usc.QueryColumnList.AddField(dsDerivedTable, "OrderDate");
			ciDerivedTable1.Selected = true;

			QueryColumnListItem ciDerivedTable2 = usc.QueryColumnList.AddField(dsDerivedTable, "SalesOrderID");
			ciDerivedTable2.ConditionStrings[0] = "> 25";

			// CTE
			SQLQualifiedName qn = new SQLQualifiedName(_query.SQLContext);
			if (!unionSubQuery.QueryRoot.SQLContext.SyntaxProvider.IsSupportCTE()) {
				return;
			}

			DataSource dataSourceCte = null;
			try {
				AstTokenIdentifier withClauseItemName = _query.QueryRoot.CreateUniqueCTEName("CTE");

				qn.Add(withClauseItemName);

				SubQuery parentSubQuery = unionSubQuery.ParentSubQuery ?? unionSubQuery.QueryRoot as SubQuery;

				if (parentSubQuery.IsMainQuery) {
					_query.QueryRoot.AddNewCTE(null, withClauseItemName);
				} else {
					if (parentSubQuery.IsSubQueryCTE()) {
						int index = parentSubQuery.GetSubQueryCTEIndex();
						parentSubQuery.InsertNewCTE(index, null, withClauseItemName);
					} else {
						parentSubQuery.AddNewCTE(null, withClauseItemName);
					}
				}

				if (_query.IsUniqueAlias(unionSubQuery, withClauseItemName)) {
					dataSourceCte = _query.AddObject(unionSubQuery, qn, null);
				} else {
					string withClauseItemNameStr = withClauseItemName.GetSQL(new SQLGenerationOptions());
					using (AstTokenIdentifier alias = _query.CreateUniqueAlias(unionSubQuery, withClauseItemNameStr)) {
						dataSourceCte = _query.AddObject(unionSubQuery, qn, alias);
					}
				}
			} finally {
				qn.Dispose();
			}

			SubQuery cte = _query.QueryRoot.GetSubQueryCTEList().FirstOrDefault();

			if (cte == null) {
				return;
			}


			UnionSubQuery unionSubQueryCte = cte.FirstSelect();
			DataSource ds1 = _query.AddObject(unionSubQueryCte, "MyDB.MySchema.Customers");

			// create output column
			QueryColumnListItem ci1 = unionSubQueryCte.QueryColumnList.AddField(ds1, "CustomerName");
			ci1.Selected = true;

			// create output column
			QueryColumnListItem ci2 = unionSubQuery.QueryColumnList.AddField(dataSourceCte, "CustomerName");
			ci2.Selected = true;
		}

		private void LoadQueryWithUnions()
		{
			UnionSubQuery unionSubQuery = _query.QueryRoot.FirstSelect();

			DataSource ds1 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Customers");

			// create output column 
			QueryColumnListItem ci1 = unionSubQuery.QueryColumnList.AddField(ds1, "City");
			ci1.Selected = true;

			UnionSubQuery union1 = unionSubQuery.ParentGroup.Add();

			DataSource ds2 = _query.AddObject(union1, "MyDB.MySchema.Orders");

			// create output column with grouping
			QueryColumnListItem ci2 = union1.QueryColumnList.AddField(ds2, "City");
			ci2.Selected = true;
			ci2.Grouping = true;

			// Copy UnionSubQuery

			// add an empty UnionSubQuery
			UnionSubQuery usq = unionSubQuery.ParentGroup.Add();

			// copy the content of existing union sub-query to a new one
			SQLSubQuerySelectExpression usqAst = unionSubQuery.ResultQueryAST;
			usqAst.RestoreColumnPrefixRecursive(true);

			List<SQLWithClauseItem> lCte = new List<SQLWithClauseItem>();
			List<SQLFromSource> lFromObj = new List<SQLFromSource>();
			unionSubQuery.GatherPrepareAndFixupContext(lCte, lFromObj, false);
			usqAst.PrepareAndFixupRecursive(lCte, lFromObj);

			usq.LoadFromAST(usqAst);

			QueryColumnListItem ci3 = usq.QueryColumnList.AddField(ds1, "CustomerAddress");
			ci3.Selected = true;
		}

		private void LoadQueryWithSubQueryExpression()
		{
			UnionSubQuery unionSubQuery = _query.QueryRoot.FirstSelect();

			// add data source to the query
			DataSource ds1 = _query.AddObject(unionSubQuery, "MyDB.MySchema.SalesOrderHeader", "Ord");

			// add SQL expression column
			QueryColumnListItem ci0 = unionSubQuery.QueryColumnList.AddExpression("GetDate()");
			ci0.Selected = true;
			ci0.AliasString = "CurrentDate";

			// add database field columns
			QueryColumnListItem ci1 = unionSubQuery.QueryColumnList.AddField(ds1, "SalesOrderID");
			ci1.Selected = true;
			QueryColumnListItem ci2 = unionSubQuery.QueryColumnList.AddField(ds1, "OrderDate");
			ci2.Selected = true;

			// add sub-query in expression 
			QueryColumnListItem ci3 = unionSubQuery.QueryColumnList.AddExpression("(SELECT *)");
			ci3.AliasString = "MaxUnitPrice";
			ci3.Selected = true;

			IList<SubSelectStatementProxy> subQueriesAst = ci3.CollectSubqueryProxiesByRootNode(ci3.Expression);
			UnionSubQuery unionSubQueryExpression = subQueriesAst[0].SubQuery.FirstSelect();

			DataSource dsExpression = _query.AddObject(unionSubQueryExpression, "MyDB.MySchema.SalesOrderDetail", "OrdDet");

			QueryColumnListItem ciExpression1 = unionSubQueryExpression.QueryColumnList.AddField(ds1, "SalesOrderID");
			ciExpression1.ConditionStrings[0] = "= OrdDet.SalesOrderID";

			QueryColumnListItem ciExpression = unionSubQueryExpression.QueryColumnList.AddField(dsExpression, "UnitPrice");
			ciExpression.AggregateString = "Max";
			ciExpression.Selected = true;
		}
	}
}
