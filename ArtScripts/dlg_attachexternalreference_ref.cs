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
    public partial class dlg_attachexternalreference_ref : AttachXRefFromVaultDLG
    {

        public dlg_attachexternalreference_ref() // add the constructor name as filename for each dialog
        {


            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_attachexternalreference_ref",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-7252B789-D47E-4ECF-920A-4CA982469733",

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
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_PROJECTMANAGER");

            Plant3DFunctions.CopyDrawing("COMBINED-MODELS.dwg", "P3D");
            Plant3DFunctions.CopyDrawing("PPG-PIPING-01.dwg", "P3D");
            Plant3DFunctions.CopyDrawing("STR-BUILDING.dwg", "P3D");
            Plant3DFunctions.CopyDrawing("STR-RACK-01.dwg"); //different func to open the first drawing

            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
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
            CheckInDLG.OK.Click();
            System.Threading.Thread.Sleep(1000);
            DialogBox Message = new DialogBox("[Pane]#1");
            while (Message.Exists)
            {
                System.Threading.Thread.Sleep(100);
            }
            System.Threading.Thread.Sleep(2000);

            //Plant3DMainWin.SetActive();
            //Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            //Drawing.Current.TypeE("_PROJECTMANAGER");
            //wTreeView.Click(MouseButton.Right, 1, 1); //set active
            //wTreeView.TypeKeys("<Esc><home>");
            //wTreeView.TypeKeys("<Add><Down 2><Add><Down>");
            //wTreeView.Click(MouseButton.Right, 5, rTree.ySize - 20);
            //System.Threading.Thread.Sleep(1000);
            //wTreeView.TypeKeys("<down>");
            //wTreeView.TypeKeys("<enter>");
            //System.Threading.Thread.Sleep(5000);

            Plant3DMainWin.SetActive();
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            wTreeView.Click(MouseButton.Right, 1, 1); //set active
            wTreeView.TypeKeys("<Esc><home>");
            //RECT rTree = wTreeView.GetRect();
            wTreeView.Click(MouseButton.Right, 5, rTree.ySize - 20);
            System.Threading.Thread.Sleep(1000);
            wTreeView.TypeKeys("<down 3><right><down 3>");
            wTreeView.TypeKeys("<enter>");
            System.Threading.Thread.Sleep(2000);
            GetCheckOutDLG GetCheckOutDLG = new GetCheckOutDLG();
            GetCheckOutDLG.HeaderCTL.Click(MouseButton.Left, 5, 5);
            GetCheckOutDLG.OKPB.Click();
            System.Threading.Thread.Sleep(5000);

            //DialogBox Message1 = new DialogBox("[Pane]#1");
            //while (Message1.Exists)
            //{
            //    System.Threading.Thread.Sleep(50);
            //}
            //System.Threading.Thread.Sleep(2000);

            Plant3DMainWin.SetActive();
            Drawing.Current.TypeE("_PLANTVAULTATTACH");

        }

        public override void Capture(string SaveLocation)
        {

            AttachXRefFromVaultDLG AttachXRefFromVaultDLG = new AttachXRefFromVaultDLG();
            AttachXRefFromVaultDLG.Size(736, 419);
            Thread.Sleep(1000);
            AttachXRefFromVaultDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

        }

        public override void Dismiss()
        {
            base.Size(769, 569);
            base.Dismiss();

            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "DefaultProject", "") as string;

            string sProjectName = sProjectPath + "Project.xml";
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
            CloseProjectDrawingsDLG CloseProjectDrawingsDLG = new CloseProjectDrawingsDLG();
            CloseProjectDrawingsDLG.OKPB.Click();
        }
    }
}
