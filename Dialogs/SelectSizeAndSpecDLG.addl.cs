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
    public partial class SelectSizeAndSpecDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$SelectSizePipeSpecDlg";
		}

		public override void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			//CreateDrawing() CreateDrawing() = new CreateDrawing()();
			Plant3DFunctions.CreateDrawing();
            Plant3DFunctions.CreateDrawing("P3D");
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
			//window wTreeView = PROJECTMANAGERDLG.M_treeView;
			//ExpandTreeP3D(wTreeView,1,1,1,1) //ExpandTreeP3D(wTreeView,1,1,1,1) = new //ExpandTreeP3D(wTreeView,1,1,1,1)();
			//ExpandTreeP3D(wTreeView,1,1,1,1);
			WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
			if (WarningAutoCADDLG.Exists)
			{
				WarningAutoCADDLG.No.Click();
			}
			Drawing.Current.TypeE("_SLINE");
			Drawing.Current.TypeE("20,20");
			Drawing.Current.TypeE("20,10");
			if (!Drawing.Current.ReadyForNextCommand())
			{
				Drawing.Current.TypeE("");
			}
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
			TreeView wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			//ExpandTreeP3D(wTreeView,1,1,2,1) //ExpandTreeP3D(wTreeView,1,1,2,1) = new //ExpandTreeP3D(wTreeView,1,1,2,1)();
			//ExpandTreeP3D(wTreeView,1,1,2,1);
			if (WarningAutoCADDLG.Exists)
			{
				WarningAutoCADDLG.Yes.Click();
			}
			Drawing.Current.TypeE("_ProjectManagerClose");
			Drawing.Current.TypeE("_plantpidlinelist");
			PIDLineListDLG PIDLineListDLG = new PIDLineListDLG();
            //PIDLineListDLG.Undock(); //manually check this...
			PIDLineListDLG.SetActive();
            //wTreeView = PIDLineListDLG.AfxControlBar90u1.AfxWnd90u1.PIDLineList.LineListESW.M_treeLines;
			//ExpandTreeP3D(wTreeView,1,1,1) //ExpandTreeP3D(wTreeView,1,1,1) = new //ExpandTreeP3D(wTreeView,1,1,1)();
			//ExpandTreeP3D(wTreeView,1,1,1);
		}

		public override void Dismiss()
		{
			SelectSizeAndSpecDLG SelectSizeAndSpecDLG = new SelectSizeAndSpecDLG();
			SelectSizeAndSpecDLG.Cancel.Click();
			PIDLineListDLG PIDLineListDLG = new PIDLineListDLG();
			PIDLineListDLG.Dismiss();
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			Plant3DFunctions.DeleteDrawing("PID");
		}
    }
}
