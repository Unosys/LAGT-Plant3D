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
    public partial class IsometricDWGSettingsIsoStyleSetupMDLG : Pane
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

		public  void Invoke()
		{
			Drawing.Current.SetSysVar("SDI", 0);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
			PROJECTMANAGERDLG.Invoke();
			PROJECTMANAGERDLG.TreeViewTV.Click(MouseButton.Right, 70, 8);
			PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<Up><Enter>");
			ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            System.Threading.Thread.Sleep(6000);
			ProjectSetupProjectDetailsDLG.SetActive();
			ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21028,1,"Project Details"));
			ProjectSetupProjectDetailsDLG.M_treeView.Expand(AcMainWin.cBabel(23035,5,"Isometric DWG Settings"));
			ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(23035,5,"Isometric DWG Settings"));
			ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(23035,5,"Isometric DWG Settings")+"/"+AcMainWin.cBabel(23035,6,"Iso Style Setup"));
			System.Threading.Thread.Sleep(1000);
			this.MoveMouse(1,1);
			this.SetActive();
		}

		public  void Dismiss()
		{
            this.CancelPB.Click();
		}
    }
}
