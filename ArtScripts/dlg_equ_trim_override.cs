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
    public partial class dlg_equ_trim_override : P3DCreateEquipmentDLG
    {


        public dlg_equ_trim_override() // add the constructor name as filename for each dialog
        //also for:
        //dlg_equ_trim_buttons
        //equ_menu_trim
        //ill_equ_trim_ladder

        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_equ_trim_override",//Name define by persons who edit scripts , excel?
                new List<string> {
				"GUID-CE87F0F4-1459-4724-80CD-ABD4379CB0E7",
                "GUID-11F44659-2148-4013-AFB0-3BC88478C2E7",
                "GUID-15F786BE-AE5D-4D5D-AB93-A7520B43210E",
                "GUID-AE5871F8-1F47-428A-80EC-711C9D00ECA5",
				//Add the GUID here
				},
                FYRelease.FY16
            );
        }
        public override void Invoke()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.Size(1430, 960);
            Autodesk.GUIHarness.AutoCAD.classes.ArtFunctions.PreSettingProductColor(Drawing.Current, 0);
            Plant3DFunctions.CreateDrawing("P3D");
            Drawing.Current.TypeE("_GRID");
            Drawing.Current.TypeE("_OFF");
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_Erase");
            Drawing.Current.TypeE("_All");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            P3DCreateEquipmentDLG.SetActive();
            //base.Invoke();
            base.TorisphericHead1LBI.Click();
            RECT Button = base.DataGridView2TBL.GetRect(true);
            Desktop.Current.DoubleClick(MouseButton.Left, (Button.xPos + Button.xSize) - 10, Button.yPos + 10);


        }
        public override void Capture(string SaveLocation)
        {
            
            RECT Dim = base.Pane6PANE.GetRect(true);
            this.CaptureDelimitedArea(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension,
            Dim.xPos,
            Dim.yPos - 10,
            Dim.xSize + 440,
            Dim.ySize - 240);

            base.TorisphericHead1LBI.Click();
            base.AddTrimPB.MoveMouse(20,20);
            Thread.Sleep(1000);
            RECT Buttons = base.Pane4PANE.GetRect(true);
            Buttons.yPos = Buttons.yPos + 360;
            Buttons.ySize = Buttons.ySize - 360;
            //Buttons.xPos = Buttons.xPos + 100;
            Buttons.xSize = Buttons.xSize - 45;
            CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension, Buttons);

            base.TorisphericHead2LBI.Click();
            base.AddTrimPB.Click();
            Thread.Sleep(2000);
            RECT Menu = base.DropDownMNU.GetRect(true);
            CaptureBitmap(SaveLocation + this.Information.Items[2].ToString() + ArtEngineConstants.BitmapExtension, Menu);

            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            P3DCreateEquipmentDLG.SetActive();
            P3DCreateEquipmentDLG.Size(787, 707);
            P3DCreateEquipmentDLG.AddTrimPB.Click();
            P3DCreateEquipmentDLG.PlatformMI.Click();
            RECT Platform = P3DCreateEquipmentDLG.DataGridView2TBL.GetRect(true);
            Platform.yPos = Platform.yPos + 242;
            Platform.ySize = Platform.ySize - 242;
            //Buttons.xPos = Buttons.xPos + 100;
            //Platform.xSize = Platform.xSize - 45;
            CaptureBitmap(SaveLocation + this.Information.Items[3].ToString() + ArtEngineConstants.BitmapExtension, Platform);



        }

        public override void Dismiss()
        {
            base.Size(787, 596);
            base.RemovePB.Click();
            base.Dismiss();
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.Size(653, 635);
            DrawingWindowColorsDLG DrawingColorDLG = new DrawingWindowColorsDLG();
            DrawingColorDLG.Invoke();
            DrawingColorDLG.ColorPL.Select(7);//Color
            DrawingColorDLG.ValidChangesAndDimsiss();//Apply & Close
            Drawing.Current.TypeE("_GRID");
            Drawing.Current.TypeE("_ON");
            //Autodesk.GUIHarness.AutoCAD.classes.ArtFunctions.PreSettingProductColor(Drawing.Current, 1);
        }

    }
}
