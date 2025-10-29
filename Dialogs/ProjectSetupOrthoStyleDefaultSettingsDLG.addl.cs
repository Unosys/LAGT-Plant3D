// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2017 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectSetupOrthoStyleDefaultSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        //partial void OnInitialize()
        // {
        // }
        partial void OnInitialize()
        {
            Tag = "[Pane]$EditProjectSettingsDlg";
        }

        public override void Invoke()
        {
            //ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            //ProjectSetupProjectDetailsDLG.Invoke();
            //ProjectSetupProjectDetailsDLG.OrthoDWGSettingsTVI.Click();
            //System.Threading.Thread.Sleep(1000);
            //ProjectSetupProjectDetailsDLG.OrthoDWGSettingsTVI.TypeKeys("<Add>");
            //System.Threading.Thread.Sleep(5000);
            //ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(23066, 1, "Ortho DWG Settings") + "/" + AcMainWin.cBabel(23035, 9, "Ortho Style Default Settings"));
            //System.Threading.Thread.Sleep(1000);

            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.Invoke();
            ProjectSetupProjectDetailsDLG.OrthoDWGSettingsTVI.TypeKeys("<Add><Down>");
            ProjectSetupOrthoStyleDefaultSettingsDLG ProjectSetupOrthoStyleDefaultSettingsDLG = new ProjectSetupOrthoStyleDefaultSettingsDLG();
            ProjectSetupOrthoStyleDefaultSettingsDLG.SetActive();
        }

        public override void Dismiss()
        {
            Current<ProjectSetupOrthoStyleDefaultSettingsDLG>().ClosePB.Click();
            Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.SetToDefault();
        }
    }
}
