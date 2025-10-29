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
    public partial class dlg_vault_project_setup : VaultProjectSetupProjectDLG
	{


        public dlg_vault_project_setup() // add the constructor name as filename for each dialog
            //also for dlg_vault_project_setup_testname
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_vault_project_setup",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-212450E5-EDC6-433B-A236-28E82D522809",
				"GUID-2009A088-FC62-4D6A-B49A-7095C284EA63"
				//Add the GUID here
				},
				FYRelease.FY16
			);
		}
        public override void Invoke()
        {
            base.Invoke();
            //    base.M_vaultLocationTB.SetText("$/RSF");
            //    base.M_comboServer.SetText("10.11.3.170");
            //    base.Size(660, 710);


            //}
        }
          public override void Capture(string SaveLocation)
         {
           VaultProjectSetupProjectDLG VaultProjectSetupProjectDLG = new VaultProjectSetupProjectDLG();
          VaultProjectSetupProjectDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

        //    Thread.Sleep(2000);

        //    VaultProjectSetupProjectDLG.M_vaultLocationTB.SetText("$/Project-Plant");
        //    VaultProjectSetupProjectDLG.M_tbDbName.SetText("10.11.3.170_Project-Plant");
        //    VaultProjectSetupProjectDLG.M_comboAuthent.Select(1);
        //    VaultProjectSetupProjectDLG.M_tbUsrName.SetText("cca");
        //    VaultProjectSetupProjectDLG.M_tbPwd.SetText("12345678");

            RECT captureArea = VaultProjectSetupProjectDLG.CancelPB.GetRect(true);
            captureArea.yPos = captureArea.yPos;
            captureArea.ySize = captureArea.ySize + 220;
            //captureArea.xPos = captureArea.xPos + 100;
            //captureArea.xSize = captureArea.xSize - 360;
            CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension, captureArea);

        }

		public override void Dismiss()
		{
            base.Size(660, 896);
            base.Dismiss();
            Drawing.Current.TypeE("_PLANTVAULTLOGOUT");
            VaultLogOutDLG VaultLogOutDLG = new VaultLogOutDLG();
            VaultLogOutDLG.ClosePB.Click();

            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "DefaultProject", "") as string;

            string sProjectName = sProjectPath + "Project.xml";
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
		}
		
	}
}
