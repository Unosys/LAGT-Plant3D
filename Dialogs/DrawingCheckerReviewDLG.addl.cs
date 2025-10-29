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
    public partial class DrawingCheckerReviewDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$DwgCheckerReview";
		}

		public override void Invoke()
		{
            DrawingCheckerDLG DrawingCheckerDLG = new DrawingCheckerDLG();
            DrawingCheckerDLG.Invoke();
            System.Threading.Thread.Sleep(1000);
            DrawingCheckerDLG.TypeKeys("<Enter>");
		}

		public override void Dismiss()
		{
            DrawingCheckerReviewDLG DrawingCheckerReviewDLG = new DrawingCheckerReviewDLG();
            DrawingCheckerReviewDLG.BtnCancel.Click();
            // Plant3DFunctions.DeleteDrawing("PID");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
            RECT wWind = WTreeView.GetRect();
            //WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 60);
            //Desktop.Current.TypeKeys("<Down 4><Enter>");
            //RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
            //if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
            //{
            //    RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
            //    System.Threading.Thread.Sleep(1000);
            //}
            PandIDFunctions.DeleteDrawing();
            RemoveDrawingFromProjectDLG RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();
            if (RemoveDrawingFromProjectDLG.WaitExists(2000))
            {
                RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(100);
		}
    }
}
