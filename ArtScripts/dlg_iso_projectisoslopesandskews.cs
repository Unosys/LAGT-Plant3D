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
    public partial class dlg_iso_projectisoslopesandskews : IsometricDWGSettingsSlopesandSkewsDLG
	{


        public dlg_iso_projectisoslopesandskews() // add the constructor name as filename for each dialog

        {
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_iso_projectisoslopesandskews",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-CDDB5C9A-EE03-47C0-9F4A-144B738D9D1E",

                
				//Add the GUID here
				},
				FYRelease.FY16
			);
		}
		public override void Invoke()
		{
			base.Invoke();
            base.TypeKeys("<Tab 14>");
			
		}

        public override void Capture(string SaveLocation)
        {
            RECT Sloped = base.Pane5PANE.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, Sloped);

        }

		public override void Dismiss()
		{
			base.Dismiss();
		}
		
	}
}
