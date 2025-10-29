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
    public partial class ill_Vault_Ribbon : Plant3DMainWin
    {
        private List<string> steps;

        public ill_Vault_Ribbon() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "ill_Vault_Ribbon",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-055C09A5-FC64-4428-8D68-174E6472E1AA"
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
            RibbonDialogClassP3D.VaultPB.Click(MouseButton.Left, 5, 5);

        }

        public override void Capture(string SaveLocation)
        {
            CollaborationRibbon CollaborationRibbon = new CollaborationRibbon();
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            RECT captureArea = AppWnd.Ribbon.GetRect(true);            
            captureArea.xSize = captureArea.xSize / 2;
            captureArea.yPos = captureArea.yPos + 20;
            captureArea.ySize = captureArea.ySize - 20;            
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, captureArea);            
           
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
