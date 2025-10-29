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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class AutoCADPIDMigrationDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]|$frmDrawingMigration1|#1";
		}

		public void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			//CreateDrawing() CreateDrawing() = new CreateDrawing()();
			//Plant3DFunctions.CreateDrawing();
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
			//window wTreeView = PROJECTMANAGERDLG.M_treeView;
			//ExpandTreePID(wTreeView,3,1,1) //ExpandTreePID(wTreeView,3,1,1) = new //ExpandTreePID(wTreeView,3,1,1)();
			//ExpandTreePID(wTreeView,3,1,1);
			SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
			SelectDrawingsToCopyToProDLG.FileName.SetText(Path.Combine(Harness.ToolsDir, "Test Files","PandID","PIDEditBlock.dwg"));
			SelectDrawingsToCopyToProDLG.Open.Click();
		}

		public void Dismiss()
		{
			AutoCADPIDMigrationDLG AutoCADPIDMigrationDLG = new AutoCADPIDMigrationDLG();
			AutoCADPIDMigrationDLG.SetActive();
			AutoCADPIDMigrationDLG.BtnCancel.Click();
			MigrationCancelTaskDLG MigrationCancelTaskDLG = new MigrationCancelTaskDLG();
			MigrationCancelTaskDLG.SetActive();
			MigrationCancelTaskDLG.Dismiss();
			System.Threading.Thread.Sleep(10000);
		}
    }
}
