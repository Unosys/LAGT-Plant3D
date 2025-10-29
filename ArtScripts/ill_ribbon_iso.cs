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
	public partial class ill_ribbon_iso : Plant3DMainWin
	{
        private List<string> steps;

        public ill_ribbon_iso() // add the constructor name as filename for each dialog
            //also for:
            //dlg_vault_ribbon
            //ico_vault_checkout_ribbon
            //ill_advance_steel
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "ill_ribbon_iso",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-D03D3CE8-960C-4242-82E3-62C4F72B41D0",
                "GUID-7959413E-1A02-4BDD-ADB4-143DA0466275",
                "GUID-D59CC379-2617-48D0-8978-93F0D3F2B9FE",
                "GUID-98AADF75-9520-4030-92C0-E508323073A9",

				//Add the GUID here
				},
				FYRelease.FY16
			);
            this.steps = new List<string> {
                "1. Use SnagIt to Capture screen using 'PrtScn' button according to the source image",
            };
		}
        
		public override void Invoke()
		{
			//base.Invoke();
            //base.Size(800,800);
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
            RibbonDialogClassP3D.IsosPB.Click(MouseButton.Left, 5, 5);
            //AppWnd.Click(MouseButton.Left, 200, 200);
            //AppWnd.TypeKeys("<Alt><i><Alt>");
		}

        public override void Capture(string SaveLocation)
        {
            //RibbonDialogClassP3D RibbonDialogClassP3D = new RibbonDialogClassP3D();
            IsosRibbon IsosRibbon = new IsosRibbon();
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            RECT captureArea = AppWnd.Ribbon.GetRect(true);
            RECT button = IsosRibbon.ExportPanel.PCFExportPB.GetRect(true);
            captureArea.xSize = button.xPos + button.xSize;
            //captureArea.yPos = captureArea.yPos + 30;
            //captureArea.ySize = captureArea.ySize - 85;
            //captureArea.xPos = captureArea.xPos + 100;
            //captureArea.xSize = captureArea.xSize - 112;
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, captureArea);

            RibbonDialogClassP3D RibbonDialogClassP3D = new RibbonDialogClassP3D();
            RibbonDialogClassP3D.VaultPB.Click(MouseButton.Left, 5, 5);
            VaultRibbon VaultRibbon = new VaultRibbon();
            RECT button1 = VaultRibbon.AdminPanel.AutodeskVaultPB.GetRect(true);
            captureArea.xSize = button1.xPos + button1.xSize;
            //captureArea.yPos = captureArea.yPos + 30;
            //captureArea.ySize = captureArea.ySize - 85;
            //captureArea.xPos = captureArea.xPos + 100;
            //captureArea.xSize = captureArea.xSize - 112;
            CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension, captureArea);

            RECT button2 = VaultRibbon.FilePanel.CheckOutPB.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[2].ToString() + ArtEngineConstants.BitmapExtension, button2);

            //AppWnd.SetActive();
            //AppWnd.Click(MouseButton.Left, 200, 200);
            AppWnd.Size(1180, 860);
            AppWnd.SetActive();
            //RibbonDialogClassP3D RibbonDialogClassP3D = new RibbonDialogClassP3D();
            RibbonDialogClassP3D.StructurePB.Click(MouseButton.Left, 5,5);

            //AppWnd.TypeKeys("<Alt><s><Alt>");
            //AppWnd.TypeKeys("<Esc>");

            StructureRibbon RibbonStruct = new StructureRibbon();
            RECT Steel = RibbonStruct.ExportPanel.AdvanceSteelXMLExportPB.GetRect(true);
            //Thread.Sleep(2000);
            //AppWnd.MoveMouse(Steel.xPos + 2, Steel.yPos + Steel.ySize - 2);
            Desktop.Current.MoveMouse(Steel.xPos + 4, Steel.yPos + Steel.ySize - 4);
            Thread.Sleep(10000);

            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            Thread.Sleep(2000);
            CaptureBitmaps.SaveSangIt(SaveLocation + this.Information.Items[3].ToString() + ArtEngineConstants.BitmapExtension);
            //////Steel.yPos = captureArea.yPos + 30;
            ////Steel.ySize = Steel.ySize * 2;
            //////Steel.xPos = captureArea.xPos + 100;
            ////Steel.xSize = Steel.xSize * 3;
            ////CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension, Steel);

            ///not working on VM machine///
            //this.CaptureDelimitedArea(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension,
            //Steel.xPos,
            //Steel.yPos,
            //Steel.xSize * 3,
            //Steel.ySize * 3);
                
            
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
            

			//base.Dismiss();
		}
		
	}
}
