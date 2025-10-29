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
    public partial class iso_refdim_preview_pp : PropertiesPallete
    {
        //private List<string> steps;

        public iso_refdim_preview_pp() // add the constructor name as filename for each dialog
        {
            //also for:
            //pp_iso_refdim_ew
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "iso_refdim_preview_pp",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-F025B2BC-D25F-45DB-8EF7-EED2297BAB6A",
                    "GUID-735DA645-72A0-4F27-99A5-CB0FFD391535"
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
            Drawing.Current.TypeE("_-OSNAP");
            Drawing.Current.TypeE("_MID");
            Drawing.Current.TypeE("_PLANTPIPEADD");
            Drawing.Current.TypeE("10,10");
            Drawing.Current.TypeE("10,30");
            //Drawing.Current.TypeE("20,20");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("PLANTISOADDREFDIM");

            //Drawing.Current.TypeE("100,400");
            //Drawing.Current.TypeE("_near");
            //Drawing.Current.TypeE("13,16,34");

            Drawing.Current.MoveMouse(10, 20);
            Drawing.Current.Click(MouseButton.Left, 10, 20);
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.Click(MouseButton.Left, 30, 20);
            Drawing.Current.TypeE("");


 
            //Drawing.Current.TypeE("");
            //Desktop.Current.MoveMouse(243, 293);
            //Desktop.Current.Click(MouseButton.Left, 243, 293);
            //System.Threading.Thread.Sleep(1000);
            //Desktop.Current.Click(MouseButton.Left, 443, 393);
            //Drawing.Current.TypeE("");//success message
            System.Threading.Thread.Sleep(2000);
            base.Size(498, 501);
            PropertiesPallete PropertiesPallete = new PropertiesPallete();
            RECT Props = PropertiesPallete.ListBoxLB.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, (Props.xPos + Props.xSize) - 5, Props.yPos + 5);
            System.Threading.Thread.Sleep(2000);
            Desktop.Current.Click(MouseButton.Left, (Props.xPos + Props.xSize) - 5, Props.yPos + 20);
            PropertiesPallete.TypeKeys("<Tab 5>");
            RECT Tag = PropertiesPallete.LineNumbTag.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, (Tag.xPos + Tag.xSize) - 3, Tag.yPos + 3);
            System.Threading.Thread.Sleep(2000);
            DialogBox ComboBox = new DialogBox("[MainWin]$1000|#1");            
            if (ComboBox.WaitExists(5000))
               {
                RECT Combo = ComboBox.GetRect(true);
                Desktop.Current.Click(MouseButton.Left, (Combo.xPos + Combo.xSize) - 3, Combo.yPos + 3);
               };
            AssignTagDLG AssignTagDLG = new AssignTagDLG();
            AssignTagDLG.SetActive();
            AssignTagDLG.TypeKeys("102");
            AssignTagDLG.AssignPB.Click();
            System.Threading.Thread.Sleep(5000);
            PropertiesPallete.SetActive();
            //PropertiesPallete.TypeKeys("<Tab 4><Up>");
            //System.Threading.Thread.Sleep(1000);
            //PropertiesPallete.TypeKeys("<Tab 1><Down>");
            //PropertiesPallete.TypeKeys("<Tab 3>");
            //PropertiesPallete.TypeKeys("OUTSIDE WALL<Home><Shift-End>");
            //PropertiesPallete.TypeKeys("<Home><Shift-End>");
            System.Threading.Thread.Sleep(2000);
            //PropertiesPallete.LineNumbTag.DoubleClick(MouseButton.Left, 3, 3);
            //PropertiesPallete.TypeKeys("<Up>");
            //AssignTagDLG AssignTagDLG = new AssignTagDLG();
            //AssignTagDLG.Number.SetText("102");
            //AssignTagDLG.AssignPB.Click();
            PropertiesPallete.ObjectType.DoubleClick(MouseButton.Left, 3,3);
            PropertiesPallete.TypeKeys("<Up><Enter>");
            System.Threading.Thread.Sleep(1000);
            PropertiesPallete.Direction.DoubleClick(MouseButton.Left, 3, 3);
            PropertiesPallete.TypeKeys("<Down><Enter>");
            System.Threading.Thread.Sleep(1000);
            //PropertiesPallete.Message.DoubleClick(MouseButton.Left, 3, 3);
            //PropertiesPallete.TypeKeys("OUTSIDE WALL<Home><Shift-End>");
            PropertiesPallete.Message.Click(MouseButton.Left, 3, 3);
            PropertiesPallete.TypeKeys("OUTSIDE WALL");
            PropertiesPallete.Direction.Click(MouseButton.Left, 3, 3); ;
            System.Threading.Thread.Sleep(1000);
            PropertiesPallete.Message.Click(MouseButton.Left, 3, 3); ;
            //PropertiesPallete.TypeKeys("<Home><Shift-End>");
            System.Threading.Thread.Sleep(2000);
            //PropertiesPallete.TypeKeys("OUTSIDE WALL");
            //PropertiesPallete.TypeKeys("<Home><SHIFT-End>");
        }

        public override void Capture(string SaveLocation)
        {
            PropertiesPallete PropertiesPallete = new PropertiesPallete();
            PropertiesPallete.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

            System.Threading.Thread.Sleep(2000);
            //PropertiesPallete.SetActive();
            PropertiesPallete.LineNumbTag.DoubleClick(MouseButton.Left, 3, 3);
            System.Threading.Thread.Sleep(1000);
            RECT Tag = PropertiesPallete.LineNumbTag.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, (Tag.xPos + Tag.xSize) - 3, Tag.yPos + 3);
            System.Threading.Thread.Sleep(2000);
            DialogBox ComboBox = new DialogBox("[MainWin]$1000|#1");
            if (ComboBox.WaitExists(5000))
            {
                RECT Combo = ComboBox.GetRect(true);
                Desktop.Current.Click(MouseButton.Left, (Combo.xPos + Combo.xSize) - 3, Combo.yPos + 3);
            };
            AssignTagDLG AssignTagDLG = new AssignTagDLG();
            AssignTagDLG.SetActive();
            AssignTagDLG.TypeKeys("115");
            AssignTagDLG.AssignPB.Click();
            System.Threading.Thread.Sleep(5000);
            //PropertiesPallete.Message.DoubleClick(MouseButton.Left, 3, 3);
            //PropertiesPallete.TypeKeys("<Home><Shift-End><Delete>WALL");
            PropertiesPallete.Message.Click(MouseButton.Left, 3, 3);
            PropertiesPallete.TypeKeys("WALL");
            System.Threading.Thread.Sleep(2000);
            PropertiesPallete.Enclose.DoubleClick(MouseButton.Left, 3, 3);
            PropertiesPallete.TypeKeys("<Up><Enter>");
            System.Threading.Thread.Sleep(1000);
            PropertiesPallete.Linetype.DoubleClick(MouseButton.Left, 3, 3);
            PropertiesPallete.TypeKeys("<Up><Enter>");
            System.Threading.Thread.Sleep(1000);
            PropertiesPallete.ObjectType.DoubleClick(MouseButton.Left, 3, 3);
            PropertiesPallete.TypeKeys("<Down 3><Enter>");
            System.Threading.Thread.Sleep(1000);
            PropertiesPallete.LocatingDimension.DoubleClick(MouseButton.Left, 3, 3);
            PropertiesPallete.TypeKeys("<Up><Enter>");
            System.Threading.Thread.Sleep(1000);
            PropertiesPallete.Direction.Click(MouseButton.Left, 3, 3);
            PropertiesPallete.TypeKeys("<Down>");

            //PropertiesPallete.Message.DoubleClick(MouseButton.Left, 3, 3);
            //PropertiesPallete.TypeKeys("WALL");
            System.Threading.Thread.Sleep(2000);
            PropertiesPallete.Size(402, 490);
            System.Threading.Thread.Sleep(2000);
            //PropertiesPallete PropertiesPallete = new PropertiesPallete();
            PropertiesPallete.CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension);
        }

        public override void Dismiss()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            PropertiesPallete PropertiesPallete = new PropertiesPallete();
            RECT Props = PropertiesPallete.ListBoxLB.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, (Props.xPos + Props.xSize) - 5, Props.yPos + 20);
            System.Threading.Thread.Sleep(2000);
            Desktop.Current.Click(MouseButton.Left, (Props.xPos + Props.xSize) - 5, Props.yPos + 5);
            //System.Threading.Thread.Sleep(5000);
            base.Size(276, 513);
            Drawing.Current.TypeE("_ERASE");
            Drawing.Current.TypeE("_All");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("0");
            PropertiesPallete.Dismiss();
            Plant3DFunctions.DeleteAllDrawings();
        }
    }
}
