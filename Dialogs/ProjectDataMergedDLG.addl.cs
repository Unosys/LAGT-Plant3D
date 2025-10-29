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
    public partial class ProjectDataMergedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$DwgOffLineEditsNotification";
		}

		public override void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.SetActive();
			//window wTreeView = PROJECTMANAGERDLG.M_treeView;
			//ExpandTreeP3D(wTreeView,3,1,2) //ExpandTreeP3D(wTreeView,3,1,2) = new //ExpandTreeP3D(wTreeView,3,1,2)();
			//ExpandTreeP3D(wTreeView,3,1,2);
			SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
			SelectDrawingsToCopyToProDLG.SetActive();
			SelectDrawingsToCopyToProDLG.FileName.SetText(Path.Combine(Harness.ToolsDir, "Test Files","PandID","SampleDrawing.dwg"));
			SelectDrawingsToCopyToProDLG.Open.Click();
			this.SetActive();
			Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
			if (Plant3DProjectSomeFilesDLG.Exists)
			{
				Plant3DProjectSomeFilesDLG.SetActive();
				Plant3DProjectSomeFilesDLG.M_btnOk.Click();
			}
		}

		public override void Dismiss()
		{
			ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
			ProjectDataMergedDLG.SetActive();
			ProjectDataMergedDLG.BtnOk.Click();
//   Plant3DFunctions.DeleteDrawing("P3D") Plant3DFunctions.DeleteDrawing("P3D") = new Plant3DFunctions.DeleteDrawing("P3D")();
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
