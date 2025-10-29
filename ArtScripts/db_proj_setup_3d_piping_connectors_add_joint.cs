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
    public partial class db_proj_setup_3d_piping_connectors_add_joint : AddJointDLG
	{

        public db_proj_setup_3d_piping_connectors_add_joint() // add the constructor name as filename for each dialog

        //-------legacy---------
        // The same  dbscript is used for these dialogs - 
        //db_proj_setup_3d_piping_connections_setup_connection_component
        //db_proj_setup_3d_piping_connectors_complex_joint_setup
        //db_proj_setup_3d_piping_connectors_add_joint
        //db_proj_setup_3d_piping_select_class
        //db_proj_setup_3d_piping_connectors
        //dlg_set_matching_values
        {
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "db_proj_setup_3d_piping_connectors_add_joint",//Name define by persons who edit scripts , excel?
				new List<string> {
                    "GUID-685B41B3-2006-48A7-94CB-2598448CF722"
				//Add the GUID here
				},
				FYRelease.FY16
			);
		}

		public override void Invoke()
		{
            AddEndcodeDLG AddEndcodeDLG = new AddEndcodeDLG();
            AddEndcodeDLG.Invoke();
            AddEndcodeDLG.SetActive();
            AddEndcodeDLG.TxtboxEndcode.SetText("TC");
            AddEndcodeDLG.TxtboxDesc.SetText("Triclover Joint");
            AddEndcodeDLG.BtnOK.Click();
            ManageEndcodesDLG ManageEndcodesDLG = new ManageEndcodesDLG();
            ManageEndcodesDLG.BtnOK.Click();
            base.Invoke();
            base.SetActive();
            base.TypeKeys("TC");

            /*Before Extensions
            
            base.TypeKeys("<Tab 2>");
            base.TypeKeys("Triclover Joint");
            base.TypeKeys("<Tab 3><Down 25><Space><Tab 2><Down 25><Space><Tab><Down 4><Space><Down 3><Space>");
            */
            base.TypeKeys("<Tab>");
            base.TypeKeys("Triclover Joint");
            base.TypeKeys("<Tab 3><Down 20><Space><Tab><Down 20><Space><Tab 3><Down 4><Space><Down 3><Space>");
            base.AddPropertyPB.Click();
            System.Threading.Thread.Sleep(2000);
            SelectClassProperty SelectClassProperty = new SelectClassProperty();
            SelectClassProperty.SetActive();
            SelectClassProperty.TypeKeys("<Tab 2><Down 13>");
            SelectClassProperty.OKPB.Click();
            base.SetActive();



		}

        public override void Capture(string SaveLocation)
        {
            AddJointDLG AddJointDLG = new AddJointDLG();
            AddJointDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

        }

		public override void Dismiss()
		{
			base.Dismiss();
            ManageEndcodesDLG ManageEndcodesDLG = new ManageEndcodesDLG();
            ManageEndcodesDLG.Invoke();
            ManageEndcodesDLG.SetActive();
            ManageEndcodesDLG.TypeKeys("<Down 24>");
            ManageEndcodesDLG.M_btnDelete.Click();
            DialogBox Message = new DialogBox("[DialogBox]#1");            
            if (Message.WaitExists(5000))
               {
                Message.TypeKeys("<Enter>");
               }
            ManageEndcodesDLG.BtnOK.Click();
            //ManageEndcodesDLG.Dismiss();





		}
	}
}
