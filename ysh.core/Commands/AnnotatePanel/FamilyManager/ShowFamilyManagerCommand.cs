﻿using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace ysh.core
{
    /// <summary>
    /// 
    /// </summary>
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class ShowFamilyManagerCommand : IExternalCommand
    {
        #region public method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandData"></param>
        /// <param name="message"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //将停靠窗口挂在Command
            var dpid = new DockablePaneId(PaneIdentifiers.GetManagerPaneIdentifier());
            var dp = commandData.Application.GetDockablePane(dpid);
            dp.Show();

           
            return Result.Succeeded;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            return typeof(ShowFamilyManagerCommand).Namespace + "." + nameof(ShowFamilyManagerCommand);
        }
        #endregion

    }
}
