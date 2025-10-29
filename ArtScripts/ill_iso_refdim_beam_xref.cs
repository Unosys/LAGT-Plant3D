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
    public partial class ill_iso_refdim_beam_xref : QuickProperties
    {
        //private List<string> steps;

        public ill_iso_refdim_beam_xref() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "ill_iso_refdim_beam_xref",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-B9BC7088-125B-49A7-A989-00DBEB43D098"
				//Add the GUID here
				},
                FYRelease.FY16,
                true
            );
            //this.steps = new List<string> {
            //    "1. Wait for the balloon notification to show on Status Bar",
            //    "2. Use SnagIt to Capture screen using 'PrtScn' button according to the source image",
            //};
        }

        public override void Invoke()
        {
            Plant3DFunctions.CreateDrawing("P3D");
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("_-ATTACH");
            Drawing.Current.TypeE(LAGT.CommonFiles.Product.Variables.TestFilesDir+"STR-RACK-01.dwg");
            Drawing.Current.TypeE("_A");
            Drawing.Current.TypeE("0,0,0");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_ZOOM");
            Drawing.Current.TypeE("_E");
            Drawing.Current.TypeE("_SELECT");
            Drawing.Current.TypeE("_last");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_QUICKPROPERTIES");
        }

        public override void Capture(string SaveLocation)
        {

            QuickProperties QuickProperties = new QuickProperties();
            Thread.Sleep(2000);
            QuickProperties.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

        }

        public override void Dismiss()
        {
            //Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            Drawing.Current.TypeE("_ERASE");
            Drawing.Current.TypeE("_All");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("0");
            Plant3DFunctions.DeleteAllDrawings();
        }
    }
}
