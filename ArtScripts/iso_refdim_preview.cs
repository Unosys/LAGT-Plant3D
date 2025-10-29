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
    public partial class iso_refdim_preview : Plant3DMainWin
    {
        private List<string> steps;

        public iso_refdim_preview() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "iso_refdim_preview",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-1EFD735E-67A8-4828-B226-4A1B83896C0A"
				//Add the GUID here
				},
                FYRelease.FY16,
                true
            );
            this.steps = new List<string> {
                "1. Move the mouse over ISO Reference dimension to display tooltip",
                "2. Use SnagIt to Capture tooltip using 'PrtScn' button according to the source image",
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
            Drawing.Current.TypeE("PLANTISOADDREFDIM");
            //Drawing.Current.TypeE("100,400");
            Drawing.Current.MoveMouse(10, 20);
            Drawing.Current.Click(MouseButton.Left, 10, 20);
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.Click(MouseButton.Left, 30, 20);

            Drawing.Current.TypeE("");//success message
            Drawing.Current.TypeE("_PROPERTIESCLOSE");
            System.Threading.Thread.Sleep(2000);
            Desktop.Current.MoveMouse(210, 310);
            System.Threading.Thread.Sleep(5000);
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

            Drawing.Current.TypeE("_PROPERTIESCLOSE");
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
