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
    public partial class db_proj_setup_themes : ProjectSetupIsoThemesDLG
    {

        public db_proj_setup_themes() // add the constructor name as filename for each dialog
        //also for:
        //lex_project_setup_scale
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "db_proj_setup_themes",//Name define by persons who edit scripts , excel?
                new List<string> {
				"GUID-79D6F749-3D46-4C5C-941B-2616745FD5F1",
                "GUID-BE3665EE-BEC8-4A3B-9AD2-C51E41D088E2",
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

            RECT Themes = base.ThemesGB.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension, Themes);
        }

        public override void Dismiss()
        {
            base.Dismiss();
        }

    }
}
