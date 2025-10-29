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
    public partial class dlg_report_query_configuration : QueryConfigurationDLG
	{


        public dlg_report_query_configuration() // add the constructor name as filename for each dialog
		 // The same  dbscript is used for these dialogs - 
		 //dlg_report_query_configuration.png
		 //dlg_plant_reporter.png
		 //dlg_report_settings.png
		 //dlg_report_query_result.png
         // dlg_report_variables
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_report_query_configuration",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-4D6C3AD9-343F-4731-BDB5-F287448C2440"
                //Add the GUID here
				},
				FYRelease.FY16
			);
		}
		public override void Invoke()
		{
			base.Invoke();
            base.Restore();
            Current<QueryConfigurationDLG>().Size(816, 598);
		}

        public override void Capture(string SaveLocation)
        {
            QueryConfigurationDLG QueryConfigurationDLG = new QueryConfigurationDLG();
            QueryConfigurationDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

		public override void Dismiss()
		{
			base.Dismiss();
		}
	}
}
