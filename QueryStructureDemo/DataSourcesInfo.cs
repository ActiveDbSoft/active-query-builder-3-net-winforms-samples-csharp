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
using System.Text;
using ActiveQueryBuilder.Core;

namespace QueryStructureDemo
{
	partial class Form1
	{
		private void DumpDataSourceInfo(StringBuilder stringBuilder, DataSource dataSource)
		{
			// write full sql fragment
			stringBuilder.AppendLine(dataSource.GetResultSQL());

			// write alias
			stringBuilder.AppendLine("  alias: " + dataSource.Alias);

			// write referenced MetadataObject (if any)
			if (dataSource.MetadataObject != null)
			{
				stringBuilder.AppendLine("  ref: " + dataSource.MetadataObject.Name);
			}

			// write subquery (if datasource is actually a derived table)
		    var dataSourceQuery = dataSource as DataSourceQuery;
		    if (dataSourceQuery != null)
			{
				stringBuilder.AppendLine("  subquery sql: " + dataSourceQuery.GetResultSQL());
			}

			// write fields
			var fields = new StringBuilder();

			foreach (var field in dataSource.Metadata.Fields)
			{
			    if (fields.Length > 0)
			    {
			        fields.Append(", ");
			    }

			    fields.Append(field.Name);
			}

			stringBuilder.AppendLine("  fields (" + dataSource.Metadata.Count + "): " + fields);
		}

		private void DumpDataSourcesInfo(StringBuilder stringBuilder, IEnumerable<DataSource> dataSources)
		{
			foreach (var dataSource in dataSources)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.AppendLine();
				}

				DumpDataSourceInfo(stringBuilder, dataSource);
			}
		}

		public void DumpDataSourcesInfoFromUnionSubQuery(StringBuilder stringBuilder, UnionSubQuery unionSubQuery)
		{
		    var datasources = unionSubQuery.GetChildrenRecursive<DataSource>(false);
			DumpDataSourcesInfo(stringBuilder, datasources);
		}
	}
}
