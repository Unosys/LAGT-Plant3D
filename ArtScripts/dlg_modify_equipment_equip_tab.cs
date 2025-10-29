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
    public partial class dlg_modify_equipment_equip_tab : P3DModifyEquipmentDLG
    {


        public dlg_modify_equipment_equip_tab() // add the constructor name as filename for each dialog

        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_modify_equipment_equip_tab",//Name define by persons who edit scripts , excel?
                new List<string> {
				//Add the GUID here
                "GUID-F883B9A8-8065-4179-A611-2813A97F333F"
				},
                FYRelease.FY15
            );
        }



        public override void Invoke()
        {
            base.Invoke();

            /* Before Extensions
            base.TypeKeys("<Tab 3><Down>");
            */

            base.CylinderLBI.Click();
            base.AddTrimPB.Click();
            base.TypeKeys("<Down 3><Enter><Tab>");

            

        }

        public override void Capture(string SaveLocation)
        {
            Current<P3DModifyEquipmentDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

        public override void Dismiss()
        {
            base.Dismiss();
        }
    }
}
