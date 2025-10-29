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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectSetupEndConnectionDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$EditProjectSettingsDlg";
		}

		public  void Invoke()
		{
			ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
			ProjectSetupProjectDetailsDLG.Invoke();
			ProjectSetupEndConnectionDLG ProjectSetupEndConnectionDLG = new ProjectSetupEndConnectionDLG();
            //ProjectSetupEndConnectionDLG.M_treeView.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings"));
            //ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21009, 1, "End Connections"));
            System.Threading.Thread.Sleep(3000);
		}

		public  void Dismiss()
		{
			ProjectSetupEndConnectionDLG ProjectSetupEndConnectionDLG = new ProjectSetupEndConnectionDLG();
			ProjectSetupEndConnectionDLG.M_btnOk.Click();
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Dismiss();
		}
    }
}
