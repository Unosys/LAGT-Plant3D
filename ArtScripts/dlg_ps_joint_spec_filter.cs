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
    public partial class dlg_ps_joint_spec_filter : SetupConnectionComponentDLG
    {

        public dlg_ps_joint_spec_filter() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_ps_joint_spec_filter",//Name define by persons who edit scripts , excel?
                new List<string> {
                "GUID-7DAB2858-10F8-44D4-82FF-498307BA2C89"
				//Add the GUID here
				},
                FYRelease.FY16
            );
        }

        public override void Invoke()
        {
            ProjectSetupPlant3DConnectionsDLG ProjectSetupPlant3DConnectionsDLG = new ProjectSetupPlant3DConnectionsDLG();
            ProjectSetupPlant3DConnectionsDLG.Invoke();
            ProjectSetupPlant3DConnectionsDLG.TypeKeys("<Tab 2><Down 4>");
            ProjectSetupPlant3DConnectionsDLG.Modify2PB.Click();
            ModifyJointDLG ModifyJointDLG = new ModifyJointDLG();
            ModifyJointDLG.LFL1LBI.Click();
            ModifyJointDLG.BoltSet.DoubleClick();
            ModifyJointDLG.TypeKeys("<Down 5><Space>");
            ModifyJointDLG.SpecFilterPB.Click();
            SetupConnectionComponentDLG SetupConnectionComponentDLG = new SetupConnectionComponentDLG();
            //SetupConnectionComponentDLG.Row25WIN.Click();
            SetupConnectionComponentDLG.TypeKeys("<Tab 2><PageDown 2><Up 9><End>");

        }

        public override void Capture(string SaveLocation)
        {
            SetupConnectionComponentDLG SetupConnectionComponentDLG = new SetupConnectionComponentDLG();
            SetupConnectionComponentDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

        }

        public override void Dismiss()
        {
            base.Dismiss();

        }
    }
}
