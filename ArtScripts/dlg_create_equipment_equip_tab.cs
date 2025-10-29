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
    public partial class dlg_create_equipment_equip_tab : P3DCreateEquipmentDLG
	{


        public dlg_create_equipment_equip_tab() // add the constructor name as filename for each dialog
		 // The same  dbscript is used for these dialogs:
         //dlg_modify_equipment_equip_tab

         //-----------legacy--------------   
            //dlg_footing_settings
		 //dlg_pip_publish_options
		 //dlg_create_quick_iso
		 //dlg_modify_endcode
		 //dlg_validation_settings_PID
		 //dlg_member_settings
		 //dlg_pip_publish_options
		 //dlg_footing_settings
		 //dlg_create_production_iso
		 //dlg_spec_update_check
		 //dlg_validation_settings
		 //dlg_extend_to_plane
		 //dlg_add_endcode
		 //dlg_member_settings
		 //dlg_manage_endcode
		 //dlg_trim_to_plane
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_create_equipment_equip_tab",//Name define by persons who edit scripts , excel?
				new List<string> {
				//Add the GUID here
                "GUID-9554348F-F140-4F2B-ABF2-C368E3DADB28"
				},
				FYRelease.FY15
			);
		}



		public override void Invoke()
		{
			base.Invoke();
            base.VesselVerticalVesselPB.Click();
            base.TypeKeys("<Down 12><Right><Down 2><Enter>");
            base.TypeKeys("<TAB 5>");
            Thread.Sleep(1000);

		}

        public override void Capture(string SaveLocation)
        {
            Current<P3DCreateEquipmentDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

		public override void Dismiss()
		{
            base.VesselVerticalVesselPB.Click();
            base.TypeKeys("<Up 2><Right><Down><Enter>");
			base.Dismiss();
		}
	}
}
