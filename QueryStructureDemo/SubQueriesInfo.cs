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
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace QueryStructureDemo
{
	partial class Form1
	{
		private void DumpSubQueryInfo(StringBuilder stringBuilder, int index, SubQuery subQuery)
		{
			string sql = subQuery.GetResultSQL();

			stringBuilder.AppendLine(index + ": " + sql);
		}

		public void DumpSubQueriesInfo(StringBuilder stringBuilder, QueryBuilder queryBuilder)
		{
			for (int i = 0; i < queryBuilder.ActiveUnionSubQuery.QueryRoot.SubQueryCount; i++)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.AppendLine();
				}

				DumpSubQueryInfo(stringBuilder, i, queryBuilder.ActiveUnionSubQuery.QueryRoot.SubQueries[i]);
                DumpSubQueryStatistics(stringBuilder, queryBuilder.ActiveUnionSubQuery.QueryRoot.SubQueries[i]);
			}
		}

		private void DumpSubQueryStatistics(StringBuilder stringBuilder, SubQuery subQuery)
		{
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Subquery statistic:");
			DumpQueryStatisticsInfo(stringBuilder, subQuery.QueryStatistics);
		}
	}
}
