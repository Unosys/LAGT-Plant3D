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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class RenameOrthoViewDLG : Pane
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "$frmRenameOrthoView";
        }

        public void Invoke()
        {
            Plant3DFunctions.OpenSampleProject();
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            Plant3DFunctions.ExpandTreeOrtho(PROJECTMANAGERDLG.TreeViewTV, 5, "0,1,1,1");
            System.Threading.Thread.Sleep(8000);
            //ProjManUndocked projectmanagerDLG = new ProjManUndocked();
            //projectmanagerDLG.Invoke();
            //projectmanagerDLG.SetTab(2);
            //System.Threading.Thread.Sleep(1000);
            //Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.OrthoTreeViewTV, 3, "0,1");
            //System.Threading.Thread.Sleep(1000);
            //Window WTreeView = projectmanagerDLG.TreeViewTV;
            //RECT wWind = WTreeView.GetRect();
            //SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            //SelectDrawingsToCopyToProDLG.SetActive();
            //SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "OrthoViewPort.dwg");
            //SelectDrawingsToCopyToProDLG.Open.Click();
            //System.Threading.Thread.Sleep(3000);
            //ProjectDataMerged ProjectDataMerged = new ProjectDataMerged();
            //if (ProjectDataMerged.Exists)
            //{
            //    ProjectDataMerged.OKPB.Click();
            //    System.Threading.Thread.Sleep(3000);
            //}
            //AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
            //if (AutoCADPlant3DMigrationDLG.Exists)
            //{
            //    AutoCADPlant3DMigrationDLG.BackupTheDrawingBeforeCK.Uncheck();
            //    Desktop.Current.TypeKeys("<enter>"); //close migration
            //}

            //System.Threading.Thread.Sleep(3000);
            //Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
            //if (Plant3DProjectSomeFilesDLG.Exists)
            //{
            //    Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            //}
            //System.Threading.Thread.Sleep(3000);         
            //Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.OrthoTreeViewTV, 5, "0,1,1,1");
            //System.Threading.Thread.Sleep(5000);

        }

        public void Dismiss()
        {
            this.CancelPB.Click();
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(2000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.SetToDefault();
            //this.CancelPB.Click();
            //System.Threading.Thread.Sleep(2000);
            //Drawing.Current.TypeE("_Close");
            //SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            //if (SaveChangesMSG.Exists)
            //{
            //    SaveChangesMSG.NoPB.Click();

            //}
            //Drawing.Current.TypeE("_Close");
            //System.Threading.Thread.Sleep(2000);
            //if (SaveChangesMSG.Exists)
            //{
            //    SaveChangesMSG.NoPB.Click();

            //}
            //Plant3DFunctions.DeleteOrthoDrawing();

        }
    }
}
