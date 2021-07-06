//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using GeneralAssembly;

namespace ExpressionEditorDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Icon = ResourceHelpers.GetResourceIcon("App");

            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendLine("Select Person.Address.AddressLine1,");
            sqlBuilder.AppendLine("Person.StateProvince.IsOnlyStateProvinceFlag");
            sqlBuilder.AppendLine("From Person.Address as CC");
            sqlBuilder.AppendLine("  Inner Join Person.StateProvince On Person.Address.StateProvinceID =");
            sqlBuilder.AppendLine("    Person.StateProvince.StateProvinceID");
            sqlBuilder.AppendLine("  Inner Join Sales.SalesTaxRate On Person.StateProvince.StateProvinceID =");
            sqlBuilder.AppendLine("    Sales.SalesTaxRate.StateProvinceID");

            var sqlContext = new SQLContext { SyntaxProvider = new MSSQLSyntaxProvider() };
            sqlContext.MetadataContainer.LoadingOptions.OfflineMode = true;
            sqlContext.MetadataContainer.ImportFromXML("AdventureWorks2014.xml");
            var query = new SQLQuery(sqlContext) { SQL = sqlBuilder.ToString() };

            expressionEditorControl1.Query = query;
            expressionEditorControl1.ActiveUnionSubQuery = query.QueryRoot.FirstSelect();
            expressionEditorControl1.Expression = "Person.Address.AddressLine1";
        }
    }
}
