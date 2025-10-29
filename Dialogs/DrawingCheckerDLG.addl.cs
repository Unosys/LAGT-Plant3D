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
    public partial class DrawingCheckerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23066,2,"Drawing Checker");
		}

		public override void Invoke()
		{
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.Invoke();
            Drawing.Current.TypeE("_toolpalettesclose");
            Drawing.Current.SetSysVar("SDI", 0);
            Drawing.Current.TypeE("_PROJECTMANAGER");
            //Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
           // Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "0,1");
            PROJECTMANAGERDLG.PIDDrawingsTVI.Select();
            PROJECTMANAGERDLG.PIDDrawingsTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Down 3><Enter>");
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "DrawingChecker.dwg");
            SelectDrawingsToCopyToProDLG.Open.Click();
            System.Threading.Thread.Sleep(2000);
            Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
            if (Plant3DProjectSomeFilesDLG.Exists)
            {
                Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            }
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            if (ProjectDataMergedDLG.Exists)
            {
                ProjectDataMergedDLG.BtnOk.Click();
            }
            //PROJECTMANAGERDLG.SetActive();

            //PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039, 2, "Default Project"));
            //wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");
            Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
            RECT wWind = WTreeView.GetRect();
            WTreeView.Click(MouseButton.Right, 5, 45);
            Desktop.Current.TypeKeys("<Down 1><Enter>");
            System.Threading.Thread.Sleep(3000);
            if (!this.Exists)
            {
                Drawing.Current.TypeE("_PLANTDwGCHECKER");
            }
		}

		public override void Dismiss()
		{
            this.Close();
            //Plant3DFunctions.DeleteDrawing("PID");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
            RECT wWind = WTreeView.GetRect();
            //WTreeView.Click(MouseButton.Right, 5, 45);
            //Desktop.Current.TypeKeys("<Down 3><Enter>");
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
