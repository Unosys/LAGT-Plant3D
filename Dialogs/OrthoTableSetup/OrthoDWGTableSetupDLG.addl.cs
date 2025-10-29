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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class OrthoDWGTableSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            //Tag = "[Pane]|IsoTBTableSetupDlg";
            Tag = "[Window]$Window_BOMSetup";
        }

        public override void Invoke()
        {
            Drawing.Current.SetSysVar("SDI", 0);
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.Invoke();
            ProjManUndocked.SetActive();
            //PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            Window wTreeView1 = ProjManUndocked.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView1, 3, "0,2");
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.SetText(Path.Combine(LAGT.CommonFiles.Product.Variables.TestFilesDir, "TableSetup.dwg"));
            SelectDrawingsToCopyToProDLG.Open.Click();
            System.Threading.Thread.Sleep(5000);
            Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
            if (Plant3DProjectSomeFilesDLG.Exists)
            {
                Plant3DProjectSomeFilesDLG.SetActive();
                Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            }
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            if (ProjectDataMergedDLG.Exists)
            {
                ProjectDataMergedDLG.SetActive();
                ProjectDataMergedDLG.BtnOk.Click();
            }
            ProjManUndocked.SetActive();
            ////Window wTreeView = PROJECTMANAGERDLG.M_treeView;
            //Plant3DFunctions.ExpandTreeP3D(wTreeView1,1,"0,2,1");
            ////window wDlg = PROJECTMANAGERDLG.PROJECTMANAGER.PROJECTMANAGER;
            //RECT rPaletteWnd = PROJECTMANAGERDLG.GetRect(true);
            //PROJECTMANAGERDLG.SetActive();
            //PROJECTMANAGERDLG.DoubleClick(MouseButton.Left, rPaletteWnd.xSize-10,rPaletteWnd.ySize/2);
            //PROJECTMANAGERDLG.SetActive();
            ////PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            ////window wTreeView2 = PROJECTMANAGERDLG.M_treeView;
            wTreeView1 = ProjManUndocked.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView1, 1, "0,2");
            NewDWGDLG NewDWGDLG = new NewDWGDLG();
            NewDWGDLG.M_tb_filename.SetText("Draw1.dwg");
            NewDWGDLG.BtnOK.Click();
            System.Threading.Thread.Sleep(2000);
            FileExistsDLG FileExistsDLG = new FileExistsDLG();
            if (FileExistsDLG.Exists)
            {
                FileExistsDLG.TypeKeys("<Enter>");
            }
            Plant3DFunctions.CreateOrthoDrawingColurStyle(null);
            Drawing.Current.TypeE("_PLANTORTHOCREATE");
            SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
            SelectReferenceModelsDLG.SetActive();
            SelectReferenceModelsDLG.TypeKeys("<End>");
            SelectReferenceModelsDLG.TypeKeys("<Space>");
            SelectReferenceModelsDLG.M_btnOK.Click();
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_PLANTORTHODWGTABLESETUP");
            this.Size(1015, 604);
        }

        public override void Dismiss()
        {
            OrthoDWGTableSetupDLG OrthoDWGTableSetupDLG = new OrthoDWGTableSetupDLG();
            OrthoDWGTableSetupDLG.CancelPB.Click();
            System.Threading.Thread.Sleep(3000);
            Drawing.Current.TypeE("_CLOSE");
            System.Threading.Thread.Sleep(2000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }

            System.Threading.Thread.Sleep(2000);
            Desktop Desktop = new Desktop();
            //         Desktop.TypeKeys("<Tab><Enter>");
            Drawing.Current.TypeE("_CLOSE");
            //Desktop.TypeKeys("<Tab><Enter>");
            System.Threading.Thread.Sleep(2000);

            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_CLOSE");

            System.Threading.Thread.Sleep(2000);

            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            //if (WarningAutoCADDLG.Exists)
            //{
            //    WarningAutoCADDLG.No.Click();
            //}
            Plant3DFunctions.DeleteOrthoDrawing();
            Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.DeleteAllDrawings();
        }
    }
}
