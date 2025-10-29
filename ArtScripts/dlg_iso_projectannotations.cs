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
    public partial class dlg_iso_projectannotations : IsometricDWGSettingsAnnotationsDLG
	{


        public dlg_iso_projectannotations() // add the constructor name as filename for each dialog
		    //also for:
            //lex_project_setup_text
            //dlg_ps_iso_advanced_defaults_nf
            //project_setup_iso_config_scr.png
        {
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_iso_projectannotations",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-2644752F-42CD-4A6F-9A02-FAF45C185091",
                "GUID-6E190085-6501-4175-9D23-E070A9C8E56F",
                "GUID-F0E4FD2E-B415-4232-A760-4D4551AFD6E7",
                "GUID-A28F5023-F241-446C-98C7-978AD8966B4E",
				//Add the GUID here
				},
				FYRelease.FY15
			);
		}
		public override void Invoke()
		{
			base.Invoke();
			
		}
        public override void Capture(string SaveLocation)
        {
            RECT Annotations = base.Pane5PANE.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, Annotations);

            RECT Text = base.TextGB.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension, Text);

            base.SetActive();
            base.PopupListPL.Click();
            base.TypeKeys("<Enter>");
            //Thread.Sleep(2000);
            RECT captureArea = base.GetRect(true);
            //captureArea.yPos = captureArea.yPos;
            captureArea.ySize = captureArea.ySize - 290;
            //captureArea.xPos = captureArea.xPos + 100;
            captureArea.xSize = captureArea.xSize - 360;
            CaptureBitmap(SaveLocation + this.Information.Items[2].ToString() + ArtEngineConstants.BitmapExtension, captureArea);

            base.SetActive();
            base.IsometricDWGSettingsTVI.Click();
            ProjectSetupIsometricDWGSettingsDLG ProjectSetupIsometricDWGSettingsDLG = new ProjectSetupIsometricDWGSettingsDLG();
            RECT captureArea2 = ProjectSetupIsometricDWGSettingsDLG.GetRect(true);
            ProjectSetupIsometricDWGSettingsDLG.CaptureDelimitedArea(SaveLocation + this.Information.Items[3].ToString() + ArtEngineConstants.BitmapExtension,
            captureArea2.xPos,
            captureArea2.yPos,
            captureArea2.xSize - 700,
            captureArea2.ySize - 370);
        }
        
        public override void Dismiss()
		{
			base.Dismiss();
		}
		
	}
}
