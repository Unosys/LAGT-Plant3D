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
    public partial class DrawingAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(21027, 1, "Drawing Already Exists");
		}

		public override void Invoke()
		{
			Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.CreateDrawing("P3D", "no", "New", null);
			Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
			PROJECTMANAGERDLG.SetActive();
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("0");
			PROJECTMANAGERDLG.Invoke();
            RECT rPaletteWnd = PROJECTMANAGERDLG.GetRect(true);
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2");
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.M_tb_filename.SetText("New");
			NewDWGDLG.BtnOK.Click();
            //FileExistsDLG FileExistsDLG = new FileExistsDLG();
            //if (FileExistsDLG.Exists)
            //{
            //    FileExistsDLG.TypeKeys("<Enter>");
            //}
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
            DrawingAlreadyExistsDLG.SetActive();
		}

		public override void Dismiss()
		{
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
			DrawingAlreadyExistsDLG.OK.Click();
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.BtnCancel.Click();
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
