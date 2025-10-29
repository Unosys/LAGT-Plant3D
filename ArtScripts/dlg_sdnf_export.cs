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

    public partial class dlg_sdnf_export : AdvanceSteelXMLExportDLG
	{


        public dlg_sdnf_export() // add the constructor name as filename for each dialog
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
				true,
                "dlg_sdnf_export",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-662DF787-ACB3-4689-9B05-E93E63B033F9"
                //Add the GUID here
				},
				FYRelease.FY16
			);
		}
		public override void Invoke()
		{
			base.Invoke();
            Thread.Sleep(2000);
            base.SetActive();
            base.OutputFileTF.SetText("pipe_rack.smlx");

		}

        public override void Capture(string SaveLocation)
        {
            Current<AdvanceSteelXMLExportDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

		public override void Dismiss()
		{
			base.Dismiss();
		}
	}
}
