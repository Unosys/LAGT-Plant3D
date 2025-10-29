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
    public partial class dlg_attachexternalreferencerelated_ref : SelectVaultLocationDLG
    {
        private List<string> steps;
        public dlg_attachexternalreferencerelated_ref() // add the constructor name as filename for each dialog
        {


            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_attachexternalreferencerelated_ref",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-8A7A4D2A-4246-4EE8-BBEB-AE9A93884786",

				//Add the GUID here
				},
                FYRelease.FY16
            );
            this.steps = new List<string> {
                "1. Right-click the table header to display the menu",
                "2. Select Choose Columns... from the menu",
                "3. From Choose Column dialog select Path ",
                "4. Doubleclick to add the Path column",
                "5. Close the Choose Columns dialog ",
                "6. Adjust the Path column as per source screenshot",
                "7. Click OK once ready to capture the dialog",
            };
        }

        public override void Invoke()
        {
            Plant3DFunctions.CreateNewVaultProject();
            Plant3DMainWin Plant3DMainWin = new Plant3DMainWin();
            Plant3DMainWin.SetActive();
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_PROJECTMANAGER");

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

            Plant3DMainWin.SetActive();
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            wTreeView.Click(MouseButton.Right, 1, 1); //set active
            wTreeView.TypeKeys("<Esc><home>");
            wTreeView.Click(MouseButton.Right, 5, rTree.ySize - 20);
            System.Threading.Thread.Sleep(1000);
            wTreeView.TypeKeys("<down 3><right><down 3>");
            wTreeView.TypeKeys("<enter>");
            System.Threading.Thread.Sleep(2000);
            GetCheckOutDLG GetCheckOutDLG = new GetCheckOutDLG();
            GetCheckOutDLG.HeaderCTL.Click(MouseButton.Left, 5, 5);
            GetCheckOutDLG.OKPB.Click();
            System.Threading.Thread.Sleep(5000);

            Plant3DMainWin.SetActive();
            Drawing.Current.TypeE("_PLANTVAULTATTACHRELATED");
            base.Size(677, 558);
            base.ComboBoxCB.SetText("SUBBA_EXT");
            RECT table = base.TableTBL.GetRect(true);
            Desktop.Current.DoubleClick(MouseButton.Left, table.xPos + 10,  table.yPos + table.ySize - 50 );
            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);

        }

        public override void Capture(string SaveLocation)
        {

            SelectVaultLocationDLG SelectVaultLocationDLG = new SelectVaultLocationDLG();
            Thread.Sleep(1000);
            SelectVaultLocationDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

        }

        public override void Dismiss()
        {
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
