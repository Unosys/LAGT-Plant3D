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
    public partial class dlg_ps_iso_advanced_defaults_ref : IsometricDWGSettingsAdvancedDefaultsDLG
    {

        public dlg_ps_iso_advanced_defaults_ref() // add the constructor name as filename for each dialog
        //also for:
        //lex_project_setup_format
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_ps_iso_advanced_defaults_ref",//Name define by persons who edit scripts , excel?
                new List<string> {
				"GUID-79552FBC-AFDE-461E-8424-E737F784FC8E",
                "GUID-E8B73BBB-48ED-4834-91F9-386E8A472E79",
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
            RECT Settings = base.Pane5PANE.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, Settings);

            RECT Measure = base.MeasurementsGB.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension, Measure);
        }

        public override void Dismiss()
        {
            base.Dismiss();
        }

    }
}
