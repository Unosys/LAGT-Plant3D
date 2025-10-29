using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs; 
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using Autodesk.GUIHarness.Plant3D.TestSuites.GlobalCmdOpt;
using ProductTestSuite.CommonFiles; 
using LAGT.CommonFiles.Classes;
using Autodesk.GUIHarness.Plant3D.Dialogs;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
	public class PLANTPROJECTTOVAULT_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPROJECTTOVAULT_DB = new List<Command>
		{
			new PLANTPROJECTTOVAULT_DB()
		};
	}

	public class PLANTPROJECTTOVAULT_DB : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTVAULTLOGIN");
			VaultLogInDLG VaultLogInDLG = Window.Current<VaultLogInDLG>();
			VaultLogInDLG.SetActive();
			VaultLogInDLG.UserNameTextBox.Text = "Administrator";
			VaultLogInDLG.OK.Click();
			ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = new ProjectSetupWizardFinishDLG();
			ProjectSetupWizardFinishDLG.Invoke();
			//ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = Window.Current<ProjectSetupWizardFinishDLG>();
			ProjectSetupWizardFinishDLG.M_buttonFinish.Click();
			System.Threading.Thread.Sleep(10000);
			//Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc") Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc") = Window.Current<Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc")>();
			Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc");
			CmdOpt_Engine.SendCmd("PLANTPROJECTTOVAULT");
			PlaceProjectInVaultDLG PlaceProjectInVaultDLG = Window.Current<PlaceProjectInVaultDLG>();
			PlaceProjectInVaultDLG.SetActive();
			if (!PlaceProjectInVaultDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
				PlaceProjectInVaultDLG.No.Click();
				Drawing.Current.TypeKeys("<Esc>");
				Drawing.Current.TypeKeys("<Esc>");
				//SetToDefault() SetToDefault() = Window.Current<SetToDefault()>();
				//SetToDefault();
			}
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}
}
