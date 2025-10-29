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
    public partial class dlg_create_new_style : CreateIsoStyleDLG
    {


        public dlg_create_new_style() // add the constructor name as filename for each dialog
        //used also for:
        //dlg_iso_create_style_leaders
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_create_new_style",//Name define by persons who edit scripts , excel?
                new List<string> {
                "GUID-2379B095-A9FB-4756-881E-0B2BC2091BFD",
                "GUID-015F8E4B-C6A7-49DB-9EE0-44A57A491709"
				//Add the GUID here
				},
                FYRelease.FY15
            );
        }
        public override void Invoke()
        {
            base.Invoke();
            base.TypeKeys("ansi-d");
            base.NewStyleName2RB.Click();
            base.CreatePB.Click();
            CreateIsometricStyleDLG CreateIsometricStyleDLG = new CreateIsometricStyleDLG();
            CreateIsometricStyleDLG.Btn_NextOption.Click(MouseButton.Left, 20,20);
            CreateIsometricStyleDLG.TypeKeys("<Enter 7>");

        }

        public override void Capture(string SaveLocation)
        {
            CreateIsometricStyleDLG CreateIsometricStyleDLG = new CreateIsometricStyleDLG();
            CreateIsometricStyleDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

            CreateIsometricStyleDLG.Btn_Next.Click(MouseButton.Left, 20, 20);
            CreateIsometricStyleDLG.Btn_NextOption.Click(MouseButton.Left, 20, 20);
            CreateIsometricStyleDLG.TypeKeys("<Enter 3>");
            CreateIsometricStyleDLG.CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension);
        }

        public override void Dismiss()
        {
            CreateIsometricStyleDLG CreateIsometricStyleDLG = new CreateIsometricStyleDLG();
            CreateIsometricStyleDLG.Btn_Cancel.Click();
            IsometricDWGSettingsIsoStyleSetupDLG IsometricDWGSettingsIsoStyleSetupDLG = new IsometricDWGSettingsIsoStyleSetupDLG();
            IsometricDWGSettingsIsoStyleSetupDLG.SetActive();
            IsometricDWGSettingsIsoStyleSetupDLG.Dismiss();
        }

    }
}
