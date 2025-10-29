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
    public partial class SpecViewerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "#1";
		}
        public void UnDock()
        {
            //RECT rTPRect1 = AppWnd.GetRect ()
		    //Desktop.DoubleClick (1, rTPRect1.xPos + 150, rTPRect1.yPos + 80)
            RECT rTPRect1 = this.GetRect();
            this.DoubleClick(MouseButton.Left, rTPRect1.xPos + 150, rTPRect1.yPos + 80);
        }
		public override void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			//CreateDrawing("P3D") CreateDrawing("P3D") = new CreateDrawing("P3D")();
			//FunctionsP3D FunctionsP3D = new FunctionsP3D();
            Plant3DFunctions.CreateDrawing("P3D",null,null,null);
			Drawing.Current.SetSysVar("cmddia", 1);
			Drawing.Current.TypeE("_ProjectManagerclose");
			Drawing.Current.TypeE("_PLANTSPECVIEWER");
            if (this.DialogBox(AfxControlBar90u1 +"/#1").Exists)
			{
				UnDock();
			}
			System.Threading.Thread.Sleep(10000);
		}

		public override void Dismiss()
		{
			SpecViewerDLG SpecViewerDLG = new SpecViewerDLG();
			SpecViewerDLG.SetActive();
			SpecViewerDLG.Click(MouseButton.Left,20,30);
			SpecViewerDLG.TypeKeys("<Alt-Space><Down 3><Enter>");
			Drawing.Current.SetSysVar("cmddia", 0);
			Drawing.Current.TypeE("_ProjectManager");
			//FunctionsP3D FunctionsP3D = new FunctionsP3D();
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
