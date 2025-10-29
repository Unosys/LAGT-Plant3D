// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2015 by Autodesk, Inc.
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
    public partial class PandIDPipeLineGroupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
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
			ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions"));
			ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right>");
			ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 5, "Pipe Line Group"));
			System.Threading.Thread.Sleep(3000);
			this.SetActive();
		}

		public override void Dismiss()
		{
			//this.CancelPB.Click();

			ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
			ProjectSetupProjectDetailsDLG.Dismiss();

		}
    }
}
