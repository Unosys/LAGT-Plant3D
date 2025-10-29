using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.Dialogs.General;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using OptionSet;
using LAGT.CommonFiles;
using LAGT.CommonFiles.Constants;
using LAGT.CommonFiles.Entities;
using LAGT.CommonFiles.Extensions.CaptureBitmaps;
using LAGT.CommonFiles.Extensions.Rectangle;
using Autodesk.GUIHarness.AutoCAD;
using Microsoft.Win32;


namespace Autodesk.GUIHarness.Plant3D.ArtScripts
{
    public partial class db_proj_setup_proj_details : Plant3DMainWin
    {
        private List<string> steps;

        public db_proj_setup_proj_details() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "db_proj_setup_proj_details",
                // used also for:
                //"dlg_proj_setup_gen_set_proj_detail_custom_props",
                //"db_proj_setup_proj_details_add", //Name define by persons who edit scripts , excel?
                new List<string> {
                "GUID-6EE92209-81FF-4223-BE93-2B7E6D976609"
				//Add the GUID here
				},
                FYRelease.FY16,
                true
            );
            this.steps = new List<string> {
                "1. In Project Manager Select the 'SampleProject'",
                "2. Wait to load 'SampleProject' in Project Manager and then click on 'OK'",
            };
        }
        public override void Invoke()
        {
            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            Thread.Sleep(2000);
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.Invoke();
        }

        public override void Capture(string SaveLocation)
        {
            //LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);

            Current<ProjectSetupProjectDetailsDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

        public override void Dismiss()
        {

            Current<ProjectSetupProjectDetailsDLG>().Dismiss();
            Plant3DFunctions.SetToDefault();

        }
    }
}
