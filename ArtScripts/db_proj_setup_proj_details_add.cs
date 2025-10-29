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
    public partial class db_proj_setup_proj_details_add : AddCategoryDLG
    {


        public db_proj_setup_proj_details_add() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "db_proj_setup_proj_details_add",
                // used also for:
                //"dlg_proj_setup_gen_set_proj_detail_custom_props",
                //"db_proj_setup_proj_details_add", //Name define by persons who edit scripts , excel?
                new List<string> {
                "GUID-D505F46A-9D1B-43F2-9D33-B9B425038E5C"
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
            Current<AddCategoryDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

        public override void Dismiss()
        {

            base.Dismiss();

        }

    }
}
