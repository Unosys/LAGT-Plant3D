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
    public partial class RenameDWGDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(21070, 13, "Rename DWG");
		}

		public override void Invoke()
		{
			Plant3DFunctions.DeleteAllDrawings();
			Plant3DFunctions.CreateDrawing("P3D","no",null, null);
			Plant3DFunctions.CreateDrawing("P3D","no",null, null);
			Drawing.Current.TypeE("SDI 0");
			Drawing.Current.TypeE("_Close");
			WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
			if (WarningAutoCADDLG.Exists)
			{
				WarningAutoCADDLG.No.Click();
			}
			Drawing.Current.TypeE("_PROJECTMANAGER");
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.SetActive();
			//window wTreeView = PROJECTMANAGERDLG.M_treeView;
            //switch gsProductName;
            //case "AutoCAD P and ID";
			//ExpandTreeP3D(wTreeView,5,1,1,1) //ExpandTreeP3D(wTreeView,5,1,1,1) = new //ExpandTreeP3D(wTreeView,5,1,1,1)();
			//ExpandTreeP3D(wTreeView,5,1,1,1);
            //case "AutoCAD Plant 3D";
			//ExpandTreeP3D(wTreeView,5,1,2,1) //ExpandTreeP3D(wTreeView,5,1,2,1) = new //ExpandTreeP3D(wTreeView,5,1,2,1)();
			//ExpandTreeP3D(wTreeView,5,1,2,1);
		}

		public override void Dismiss()
		{
			RenameDWGDLG RenameDWGDLG = new RenameDWGDLG();
			RenameDWGDLG.SetActive();
			RenameDWGDLG.CancelPB.Click();
			Plant3DFunctions.DeleteAllDrawings();
		}
    }
}
