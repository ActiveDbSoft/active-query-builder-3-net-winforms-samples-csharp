//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//


using System.Collections.Generic;
using System.Text;
using ActiveQueryBuilder.Core;

namespace QueryStructureDemo
{
    partial class Form1
    {
        private void DumpLinkInfo(StringBuilder stringBuilder, Link link)
        {
            // write full sql fragment of link expression
            stringBuilder.AppendLine(link.LinkExpression.GetSQL(link.SQLContext.SQLGenerationOptionsForServer));

            // write information about left side of link
            stringBuilder.AppendLine("  left datasource: " + link.LeftDataSource.GetResultSQL());
            stringBuilder.AppendLine(link.LeftType == LinkSideType.Inner ? "  left type: Inner" : "  left type: Outer");

            // write information about right side of link
            stringBuilder.AppendLine("  right datasource: " + link.RightDataSource.GetResultSQL());
            stringBuilder.AppendLine(link.RightType == LinkSideType.Inner ? "  right type: Inner" : "  right type: Outer");
        }

        private void DumpLinksInfo(StringBuilder stringBuilder, IList<Link> links)
        {
            foreach (var link in links)
            {
                // append separator
                if (stringBuilder.Length > 0)
                {
                    stringBuilder.AppendLine();
                }

                DumpLinkInfo(stringBuilder, link);
            }
        }

        public void DumpLinksInfoFromUnionSubQuery(StringBuilder stringBuilder, UnionSubQuery unionSubQuery)
        {
            var links = unionSubQuery.GetChildrenRecursive<Link>(false);
            DumpLinksInfo(stringBuilder, links);
        }
    }
}
