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
using Microsoft.Win32;

namespace Autodesk.GUIHarness.Plant3D.ArtScripts
{
    public partial class dlg_vault_dns : HiddenMessageSettingsPDLG
	{


        public dlg_vault_dns() // add the constructor name as filename for each dialog
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_vault_dns",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-4E337733-1D27-4489-8157-913C6FA9510D"
				},
				FYRelease.FY15
			);
		}
		public override void Invoke()
		{
            //base.Invoke();
            //create vault project
            //add drawing
            DeleteWorkspaceFilesVDLG DeleteWorkspaceFilesVDLG = new DeleteWorkspaceFilesVDLG();
            DeleteWorkspaceFilesVDLG.Invoke();
            DeleteWorkspaceFilesVDLG.CheckboxCK.Check();
            DeleteWorkspaceFilesVDLG.DeleteFilesPB.Click();
            Thread.Sleep(2000);
            //options-system-hidden messages
            HiddenMessageSettingsPDLG HiddenMessageSettingsDLG = new HiddenMessageSettingsPDLG();
            HiddenMessageSettingsDLG.Invoke();
            HiddenMessageSettingsDLG.PushButton2PB.Click();//expand
            HiddenMessageSettingsDLG.CheckBox3CK.Check();
            HiddenMessageSettingsDLG.DeleteWorkspaceFilesST.Click();
            Thread.Sleep(2000);
            CaptureActive("GUID-4E337733-1D27-4489-8157-913C6FA9510D.1.bmp");
		}
		public override void Dismiss()
		{
            HiddenMessageSettingsPDLG HiddenMessageSettingsDLG = new HiddenMessageSettingsPDLG();
            HiddenMessageSettingsDLG.OKPB.Click();// .Dismiss();
            Thread.Sleep(1000);
            P3DOptionsDLG P3DOptionsDLG = new P3DOptionsDLG();
            P3DOptionsDLG.OKPB.Click();
            Plant3DFunctions.DeleteAllDrawings();
            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "DefaultProject", "") as string;

            string sProjectName = sProjectPath + "Project.xml";
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
		}
		public void CaptureActive(string SaveLocation)
		{
			Thread.Sleep(2000);
			//this.CaptureBitmap(SaveLocation + this.GUIDitems[0].ToString() + ArtConstants.BitmapExtension);
		}
	}
}
