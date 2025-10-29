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
    public partial class Select3DClassDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$Select3DPipingClassDlg";
		}

		public override void Invoke()
		{
			Drawing.Current.SetSysVar("SDI", 0);
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			PROJECTMANAGERDLG.Undock();
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            TreeView wTreeView1 = PROJECTMANAGERDLG.TreeViewTV;
            //ExpandTreeP3D(wTreeView1,1,1,2) //ExpandTreeP3D(wTreeView1,1,1,2) = new //ExpandTreeP3D(wTreeView1,1,1,2)();
            //ExpandTreeP3D(wTreeView1,1,1,2);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2");
            NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.M_tb_filename.SetText("P3D.dwg");
			NewDWGDLG.BtnOK.Click();
			FileExistsDLG FileExistsDLG = new FileExistsDLG();
			if (FileExistsDLG.Exists)
			{
				FileExistsDLG.TypeKeys("<Enter>");
			}
			System.Threading.Thread.Sleep(2000);
			PROJECTMANAGERDLG.SetActive();
            PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039, 2, "Default Project"));
            //ExpandTreeP3D(wTreeView1,1,1,1) //ExpandTreeP3D(wTreeView1,1,1,1) = new //ExpandTreeP3D(wTreeView1,1,1,1)();
            //ExpandTreeP3D(wTreeView1,1,1,1);
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2");
            NewDWGDLG.M_tb_filename.SetText("PID.dwg");
			NewDWGDLG.BtnOK.Click();
			if (FileExistsDLG.Exists)
			{
				FileExistsDLG.TypeKeys("<Enter>");
			}
			System.Threading.Thread.Sleep(2000);
			ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
			ProjectSetupPlant3DDWG.Invoke();
            //ShowManualSteps(Select3DClassDLG);    // manual steps commented
            //ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
            ProjectSetupPlant3DDWG.Invoke();
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.M_treeView.Expand(AcMainWin.cBabel(21047, 1, "Plant 3D DWG Settings") + "/" + AcMainWin.cBabel(21051, 1, "Plant 3D Class Definitions"));
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21047, 1, "Plant 3D DWG Settings") + "/" + AcMainWin.cBabel(21051, 1, "Plant 3D Class Definitions"));
            ProjectSetupProjectDetailsDLG.M_treeView.Expand(AcMainWin.cBabel(21047, 1, "Plant 3D DWG Settings") + "/" + AcMainWin.cBabel(21051, 1, "Plant 3D Class Definitions") + "/" + AcMainWin.cBabel(23073, 16, "Piping and Equipment"));
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21047, 1, "Plant 3D DWG Settings") + "/" + AcMainWin.cBabel(21051, 1, "Plant 3D Class Definitions") + "/" + AcMainWin.cBabel(23073, 16, "Piping and Equipment"));
            ProjectSetupProjectDetailsDLG.M_treeView.Expand(AcMainWin.cBabel(21047, 1, "Plant 3D DWG Settings") + "/" + AcMainWin.cBabel(21051, 1, "Plant 3D Class Definitions") + "/" + AcMainWin.cBabel(23073, 16, "Piping and Equipment") + "/" + AcMainWin.cBabel(21051, 3, "Equipment"));
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21047, 1, "Plant 3D DWG Settings") + "/" + AcMainWin.cBabel(21051, 1, "Plant 3D Class Definitions") + "/" + AcMainWin.cBabel(23073, 16, "Piping and Equipment") + "/" + AcMainWin.cBabel(21051, 3, "Equipment"));
            ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<Down>");
        }

		public override void Dismiss()
		{
			Select3DClassDLG Select3DClassDLG = new Select3DClassDLG();
			Select3DClassDLG.SetActive();
			Select3DClassDLG.Btn_Cancel.Click();
		}
    }
}
