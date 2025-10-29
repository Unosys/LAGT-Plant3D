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
    public partial class dlg_iso_createisostyle : CreateIsoStyleDLG
    {


        public dlg_iso_createisostyle() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_iso_createisostyle",//Name define by persons who edit scripts , excel?
                new List<string> {
                "GUID-48B6601A-F923-4F8D-A210-CE8553AD3F17"
				//Add the GUID here
				},
                FYRelease.FY15
            );
        }
        public override void Invoke()
        {
            base.Invoke();
            base.TypeKeys("newisostyle-d");
            base.NewStyleName2RB.Click();
            Thread.Sleep(1000);

        }
        public override void Capture(string SaveLocation)
        {
            Current<CreateIsoStyleDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

        public override void Dismiss()
        {
            base.Dismiss();
        }

    }
}
