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
    class dlg_open_vault_project_piper : OpenProjectFromVaultDLG
    {
        public dlg_open_vault_project_piper() // add the constructor name as filename for each dialog
		{
			this.Information =  new TestCaseInformation(
				"Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
				false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_open_vault_project_piper",//Name define by persons who edit scripts , excel?
				new List<string> {
				"GUID-8E384665-E1B5-47B4-9C56-B1D45ACBA41F"
				},
				FYRelease.FY15
			);
		}
		public override void Invoke()
		{
            OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
            OpenProjectFromVaultDLG.Invoke();
            //OpenProjectFromVaultDLG.Project1LVI.Click();
            //resize headers - N/A
            //RECT OPFV = OpenProjectFromVaultDLG.ProjectNameWIN.GetRect(true);
            //OpenProjectFromVaultDLG.ProjectNameWIN.DragMouse(MouseButton.Left, OPFV.xSize, OPFV.ySize / 2, 300, OPFV.ySize / 2);
            
            Thread.Sleep(2000);
            CaptureActive("GUID-8E384665-E1B5-47B4-9C56-B1D45ACBA41F.3.bmp");
		}
		public override void Dismiss()
		{
            base.Dismiss();

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