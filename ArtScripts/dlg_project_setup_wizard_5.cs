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
    public partial class dlg_project_setup_wizard_5 : ProjectSetupWizardSpecifyDatabaseSettingsDLG
	{


        public dlg_project_setup_wizard_5() // add the constructor name as filename for each dialog
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_project_setup_wizard_5",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-01F03BB9-8854-4636-8567-783E9D9ECD7E"
				},
				FYRelease.FY16
			);
		}
		public override void Invoke()
		{
			base.Invoke();
            base.M_radioSQLServer.Select();
            base.TypeKeys("<Tab>");
            base.TypeKeys(".\\SQLEXPRESS");
            base.M_tbDbName.SetText("servername_projectname");
            base.DropDownButtonPB.Click();
            base.TypeKeys("<Down><Enter>");
            base.M_tbPwd.MoveMouse();
            base.M_tbUsrName.SetText("cca");
            base.M_tbPwd.SetText("password");
            base.TypeKeys("<Tab 9>");
            //Thread.Sleep(1000);

			
		}

        public override void Capture(string SaveLocation)
        {
            Current<ProjectSetupWizardSpecifyDatabaseSettingsDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

		public override void Dismiss()
		{
			base.Dismiss();
		}
		
	}
}
