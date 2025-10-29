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
    public partial class balloon_iso_complete : CreateQuickIsoDLG
    {
        private List<string> steps;
     
        public balloon_iso_complete() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "balloon_iso_complete",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-0F534FFA-C4D8-45E6-8354-3757EF08B0F1"
				//Add the GUID here
				},
                FYRelease.FY16,
                true
            );
            this.steps = new List<string> {
                "1. Wait for the balloon notification to show on Status Bar",
                "2. Use SnagIt to Capture screen using 'PrtScn' button according to the source image",
            };
        }

        public override void Invoke()
        {
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("TRAYNOTIFY");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("TRAYICONS");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("TRAYTIMEOUT");
            Drawing.Current.TypeE("10");
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.Size(1180, 860);
            base.Invoke();
            base.Button_Create.Click();


        }

        public override void Capture(string SaveLocation)
        {
            //Current<AddEndcodeDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            Thread.Sleep(2000);
            CaptureBitmaps.SaveSangIt(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        
        }

        public override void Dismiss()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            Drawing.Current.TypeE("_ERASE");
            Drawing.Current.TypeE("_All");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("TRAYNOTIFY");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("TRAYICONS");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("TRAYTIMEOUT");
            Drawing.Current.TypeE("0");
            AppWnd.Size(630, 630);
            Plant3DFunctions.DeleteAllDrawings();
        }
    }
}
