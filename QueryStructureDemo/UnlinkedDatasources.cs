//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Collections;
using System.Collections.Generic;
using System.Text;
using ActiveQueryBuilder.Core;

namespace QueryStructureDemo
{
    partial class Form1
    {
        private void GetUnlinkedDatsourcesRecursive(DataSource firstDataSource, IList<DataSource> dataSources, IList<Link> links)
        {
            // Remove reached datasource from list of available datasources.
            dataSources.Remove(firstDataSource);

            foreach (var link in links)
            {
                // If left end of the link is connected to firstDataSource,
                // then link.RightDatasource is reachable.
                // If it's still in dataSources list (not yet processed), process it recursivelly.
                if (link.LeftDataSource == firstDataSource && dataSources.IndexOf(link.RightDataSource) != -1)
                {
                    GetUnlinkedDatsourcesRecursive(link.RightDataSource, dataSources, links);
                }
                // If right end of the link is connected to firstDataSource,
                // then link.LeftDatasource is reachable.
                // If it's still in dataSources list (not yet processed), process it recursivelly.
                else if (link.RightDataSource == firstDataSource && dataSources.IndexOf(link.LeftDataSource) != -1)
                {
                    GetUnlinkedDatsourcesRecursive(link.LeftDataSource, dataSources, links);
                }
            }
        }

        public string GetUnlinkedDataSourcesFromUnionSubQuery(UnionSubQuery unionSubQuery)
        {
            var dataSources = unionSubQuery.GetChildrenRecursive<DataSource>(false);

            // Process trivial cases
            if (dataSources.Count == 0)
            {
                return "There are no datasources in current UnionSubQuery!";
            }

            if (dataSources.Count == 1)
            {
                return "There are only one datasource in current UnionSubQuery!";
            }

            var links = unionSubQuery.GetChildrenRecursive<Link>(false);

            // The first DataSource is the initial point of reachability algorithm
            DataSource firstDataSource =  dataSources[0];

            // Remove all linked DataSources from dataSources list
            GetUnlinkedDatsourcesRecursive(firstDataSource, dataSources, links);

            // Now dataSources list contains only DataSources unreachable from the firstDataSource

            if (dataSources.Count == 0)
            {
                return "All DataSources in the query are connected!";
            }
                
            // Some DataSources are not reachable - show them in a message box
            var sb = new StringBuilder();

            for (int i = 0; i < dataSources.Count; i++)
            {
                var dataSource = dataSources[i];
                sb.AppendLine((i + 1) + ": " + dataSource.GetResultSQL());
            }

            return "The following DataSources are not reachable from the first DataSource:\r\n" + sb;
        }
    }
}
