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
    public partial class Attach_Icon : Plant3DMainWin
    {
        private List<string> steps;

        public Attach_Icon() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "Attach_Icon",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-FACAD706-C5AF-4E07-BE93-490C083F18F8"
				//Add the GUID here
				},
                FYRelease.FY16,
                true
            );
            this.steps = new List<string> {
                "1. capture 'Attach' icon in ribbon (Last icon in Ribbon)",
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
            Thread.Sleep(1000);
            AppWnd.Size(653, 635);
        }

        public override void Capture(string SaveLocation)
        {
            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            Thread.Sleep(2000);
            CaptureBitmaps.SaveSangIt(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        
        }

        public override void Dismiss()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.SetActive();
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
