//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2024 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//


using ActiveQueryBuilder.Core;

namespace GeneralAssembly
{
    public interface ISupportOptions
    {
        object BehaviorOptions { get; set; }
        object DesignPaneOptions { get; set; }
        object VisualOptions { get; set; }
        object AddObjectDialogOptions { get; set; }
        object DataSourceOptions { get; set; }
        MetadataLoadingOptions MetadataLoadingOptions { get; set; }
        object MetadataStructureOptions { get; set; }
        object QueryColumnListOptions { get; set; }
        object QueryNavBarOptions { get; set; }
        object UserInterfaceOptions { get; set; }
        object SqlGenerationOptions { get; set; }
        object SqlFormattingOptions { get; set; }
    }
}
