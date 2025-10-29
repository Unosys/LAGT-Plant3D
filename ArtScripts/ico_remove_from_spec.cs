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
    public partial class ico_remove_from_spec : SpecEditorDLG
	{
		
		
		public ico_remove_from_spec() // add the constructor name as filename for each dialog

		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
				true,
                "ico_remove_from_spec",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-3E73C807-82A0-462C-858B-BB8EE9ACC00B"
                //Add the GUID here
				},
				FYRelease.FY15
			);
		}
		public override void Invoke()
		{
			base.Invoke();
            Thread.Sleep(2000);
            base.OpenSpec(LAGT.CommonFiles.Product.Variables.TestFilesDir + "CS150 Flanged.pspx");
            Thread.Sleep(5000);
            base.SpecSheetListView.Select(2);
            

            base.Item1.Click();
		}

        public override void Capture(string SaveLocation)
        {
            SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
            RECT Button = SpecEditorDLG.PushButton14PB.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, Button);

        }

		public override void Dismiss()
		{
			base.Dismiss();
		}
	}
}
