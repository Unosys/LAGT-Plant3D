using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.Dialogs.General;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using OptionSet;
using LAGT.CommonFiles;
using LAGT.CommonFiles.Constants;
using LAGT.CommonFiles.Entities;
using LAGT.CommonFiles.Extensions.CaptureBitmaps;
using LAGT.CommonFiles.Extensions.Rectangle;
using Autodesk.GUIHarness.AutoCAD;
using Microsoft.Win32;
namespace Autodesk.GUIHarness.Plant3D.ArtScripts
{
    public partial class dlg_vault_check_in : CheckInDLG
    {

        public dlg_vault_check_in() // add the constructor name as filename for each dialog
        {
            //also for:
            //menu_vault_project_root

            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_vault_check_in",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-48612D51-0ED2-4825-9335-051FD468E6E1",
                    "GUID-088E85F8-9EBA-4003-918D-46FB0E9B96A6"
				//Add the GUID here
				},
                FYRelease.FY16
            );
        }

        public override void Invoke()
        {
            Plant3DFunctions.CreateNewVaultProject();
            Plant3DMainWin Plant3DMainWin = new Plant3DMainWin();
            Plant3DMainWin.SetActive();
            //Plant3DMainWin.Click(MouseButton.Left,10, 10);
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            Plant3DFunctions.CopyDrawing("1-A1-1001.dwg", "PID");
            Plant3DFunctions.CopyDrawing("1-A1-1002.dwg", "PID");
            Plant3DFunctions.CopyDrawing("COMBINED-MODELS.dwg", "P3D");
            Plant3DFunctions.CopyDrawing("PPG-PIPING-01.dwg", "P3D");
            Plant3DFunctions.CopyDrawing("STR-BUILDING.dwg", "P3D");
            Plant3DFunctions.CopyDrawing("STR-RACK-01.dwg", "P3D");

            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            wTreeView.Click(MouseButton.Right, 1, 1); //set active
            wTreeView.TypeKeys("<Esc><home>");
            RECT rTree = wTreeView.GetRect();
            wTreeView.Click(MouseButton.Right, 5, rTree.ySize - 20);
            System.Threading.Thread.Sleep(1000);
            wTreeView.TypeKeys("<down 3><right>");
            //wTreeView.TypeKeys("<enter>");
            System.Threading.Thread.Sleep(5000);



            //ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            //Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //wTreeView.Click(MouseButton.Right, 1, 1); //set active
            //wTreeView.TypeKeys("<Esc><home>");
            //RECT rTree = wTreeView.GetRect();
            //wTreeView.Click(MouseButton.Right, 5, rTree.ySize - 20);
            //System.Threading.Thread.Sleep(1000);
            //wTreeView.TypeKeys("<down 3><right><down 2>");
            //wTreeView.TypeKeys("<enter>");
            //System.Threading.Thread.Sleep(2000);
            //base.DeleteWorkingCopiesCK.Check();

        }

        public override void Capture(string SaveLocation)
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            RECT TV = PROJECTMANAGERDLG.VaultDropDownMNU.GetRect(true);
            Thread.Sleep(2000);
            this.CaptureDelimitedArea(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension,
            TV.xPos,
            TV.yPos,
            TV.xSize,
            TV.ySize);

            Desktop.Current.TypeKeys("<ESC 2>");
            Thread.Sleep(1000);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            wTreeView.Click(MouseButton.Right, 1, 1); //set active
            wTreeView.TypeKeys("<Esc><home>");
            RECT rTree = wTreeView.GetRect();
            wTreeView.Click(MouseButton.Right, 5, rTree.ySize - 20);
            System.Threading.Thread.Sleep(1000);
            wTreeView.TypeKeys("<down 3><right><down 2>");
            wTreeView.TypeKeys("<enter>");
            System.Threading.Thread.Sleep(2000);
            CheckInDLG CheckInDLG = new CheckInDLG();
            //CheckInDLG.DeleteWorkingCopiesCK.Check();
            Thread.Sleep(1000);
            CheckInDLG.CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension);
        }

        public  void Dismiss()
        {
            base.Dismiss();
            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "DefaultProject", "") as string;

            string sProjectName = sProjectPath + "Project.xml";
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
        }
    }
}
