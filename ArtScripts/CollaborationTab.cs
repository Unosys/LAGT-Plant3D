using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using OptionSet;
using LAGT.CommonFiles;
using LAGT.CommonFiles.Constants;
using LAGT.CommonFiles.Entities;
using LAGT.CommonFiles.Extensions.CaptureBitmaps;
using LAGT.CommonFiles.Extensions.Rectangle;
using Autodesk.GUIHarness.AutoCAD;
namespace Autodesk.GUIHarness.Plant3D.ArtScripts
{
    public partial class CollaborationTab : Plant3DMainWin
    {
        private List<string> steps;
     
        public CollaborationTab() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "CollaborationTab",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-D3BCCB67-2C66-4F9C-83D6-4E4597AD7954"
				//Add the GUID here
				},
                FYRelease.FY16,
                false
            );
            this.steps = new List<string> {
                "1. Wait for the balloon notification to show on Status Bar",
                "2. Use SnagIt to Capture screen using 'PrtScn' button according to the source image",
            };
        }

        public override void Invoke()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.Size(1560, 970);
            Drawing.Current.TypeE("MENUBAR");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("_RIBBON");
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_TOOLPALETTESCLOSE");
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("TOOLTIPS");
            Drawing.Current.TypeE("1");
            Thread.Sleep(2000);
            //Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.SetActive();
            RibbonDialogClassP3D RibbonDialogClassP3D = new RibbonDialogClassP3D();
            RibbonDialogClassP3D.CollaborationPB.Click(MouseButton.Left, 5, 5);

        }

        public override void Capture(string SaveLocation)
        {
            CollaborationRibbon CollaborationRibbon = new CollaborationRibbon();
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            RECT captureArea = AppWnd.Ribbon.GetRect(true);
            //RECT ProjectPanel = CollaborationRibbon.ProjectPanel.GetRect(true);
            //RECT FilePanel = CollaborationRibbon.FilePanel.GetRect(true);
            //RECT button = IsosRibbon.ExportPanel.PCFExportPB.GetRect(true);
            captureArea.xSize = captureArea.xSize / 2 - 100;
            captureArea.yPos = captureArea.yPos + 20;
            captureArea.ySize = captureArea.ySize - 20;
            //captureArea.xSize = ProjectPanel.xSize + FilePanel.xSize;
            //captureArea.yPos = captureArea.yPos + 30;
            //captureArea.ySize = captureArea.ySize - 85;
            //captureArea.xPos = captureArea.xPos + 100;
            //captureArea.xSize = captureArea.xSize - 112;
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, captureArea);

            
            //Current<AddEndcodeDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
            //LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            //Thread.Sleep(2000);
            //CaptureBitmaps.SaveSangIt(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        
        }

        public override void Dismiss()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.Size(653, 635);
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("TOOLTIPS");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("_RIBBONCLOSE");
            Drawing.Current.TypeE("MENUBAR");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            Drawing.Current.TypeE("_TOOLPALETTES");

            
        }
    }
}
