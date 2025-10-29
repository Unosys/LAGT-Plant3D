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
    public partial class iso_refdim_add : Plant3DMainWin
    {
        private List<string> steps;

        public iso_refdim_add() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "iso_refdim_add",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-F56D5DE3-8A0B-428E-A510-0D97925C1C0F"
				//Add the GUID here
				},
                FYRelease.FY16,
                true
            );
            this.steps = new List<string> {
                "1.select one pipe",
                "2. click + icon on the pipe",
                "3. hold on SHIFT button and right click",
                "4. Click Perpendicular",
                "5. Move mouse on another pipe",
                "6. Use SnagIt to Capture tooltip using 'PrtScn' button according to the source image",
            };
        }

        public override void Invoke()
        {
            Plant3DFunctions.CreateDrawing("P3D");
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("TOOLTIPS");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("_-OSNAP");
            Drawing.Current.TypeE("_MID");
            Drawing.Current.TypeE("_PLANTPIPEADD");
            Drawing.Current.TypeE("10,10");
            Drawing.Current.TypeE("10,30");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_PLANTPIPEADD");
            Drawing.Current.TypeE("20,10");
            Drawing.Current.TypeE("20,30");
            Drawing.Current.TypeE("");
            
        }

        public override void Capture(string SaveLocation)
        {
            //Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            //RECT drawing = AppWnd.GetRect(true);
            //this.CaptureDelimitedArea(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension,
            //drawing.xPos,
            //drawing.yPos + 200,
            //drawing.xSize - 60,
            //drawing.ySize - 100);

            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            Thread.Sleep(2000);
            CaptureBitmaps.SaveSangIt(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

        }

        public override void Dismiss()
        {

            //Drawing.Current.TypeE("_PROPERTIESCLOSE");
            Desktop.Current.TypeKeys("<Esc 2>");
            Drawing.Current.TypeE("_ERASE");
            Drawing.Current.TypeE("_All");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("TOOLTIPS");
            Drawing.Current.TypeE("0");
            Plant3DFunctions.DeleteAllDrawings();
        }
    }
}
