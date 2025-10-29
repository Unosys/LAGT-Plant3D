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
    public partial class dlg_iso_projecttitleblockanddisplay : IsometricDWGSettingsTitleBlockandDisplayDLG
	{


        public dlg_iso_projecttitleblockanddisplay() // add the constructor name as filename for each dialog
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_iso_projecttitleblockanddisplay",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-A9FE8FAE-C036-46EF-BD4E-34B1723FDC22"
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
            RECT Block = base.Pane5PANE.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, Block);

        }

		public override void Dismiss()
		{
			base.Dismiss();
		}
		
	}
}
