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
    public partial class ill_ortho_template : ProjectSetupTitleBlockandDisplayDLG
	{
		
		
		public ill_ortho_template() // add the constructor name as filename for each dialog
		 // The same  dbscript is used for these dialogs - 
		 //ill_g_pipe_fittings_valve_lever
		 //ill_g_pipe_fittings_valve
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
				true,
                "ill_ortho_template",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-71E84F76-48B4-44BB-947C-43487030F9EF"
                 //Add the GUID here
				},
				FYRelease.FY16
			);
		}
		public override void Invoke()
		{
			base.Invoke();
			
		}

        public override void Capture(string SaveLocation)
        {

            RECT captureArea = base.Pane8PANE.GetRect(true);
            captureArea.yPos = captureArea.yPos + 30;
            captureArea.ySize = captureArea.ySize - 85;
            //captureArea.xPos = captureArea.xPos + 100;
            //captureArea.xSize = captureArea.xSize - 70;
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, captureArea);
           
        }
        
        public override void Dismiss()
		{
			base.Dismiss();
		}
	}
}
