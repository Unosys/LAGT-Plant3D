// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectSetupPIDPainterSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2017";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$EditProjectSettingsDlg";
        }

        public override void Invoke()
        {
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            Drawing.Current.SetSysVar("SDI", 0);
            Drawing.Current.TypeE("_ProjectSetup");
            System.Threading.Thread.Sleep(10000);
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings"));
            ProjectSetupProjectDetailsDLG.M_treeView.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings"));
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(23031, 13, "P&ID Painter Settings"));
            ProjectSetupProjectDetailsDLG.PIDPainterSettingsTVI.Click();
            this.SetActive();
        }

        public override void Dismiss()
        {
            ProjectSetupPIDPainterSettingsDLG ProjectSetupPIDPainterSettingsDLG = new ProjectSetupPIDPainterSettingsDLG();
            ProjectSetupPIDPainterSettingsDLG.ClosePB.Click();
            PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            PROJECTMANAGERDLG.Dismiss();
        }
    }
}
