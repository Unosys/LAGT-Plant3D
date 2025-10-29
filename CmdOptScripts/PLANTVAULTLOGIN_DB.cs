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
	public class PLANTVAULTLOGIN_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTVAULTLOGIN_DB = new List<Command>
		{
			new PLANTVAULTLOGIN_DB()
		};
	}

	public class PLANTVAULTLOGIN_DB : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTVAULTLOGIN");
			System.Threading.Thread.Sleep(0);
			VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
			if (VaultLogInDLG.Exists)
			{
				VaultLogInDLG.SetActive();
			}
			//VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
			if (!VaultLogInDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
				//VaultLogInDLG VaultLogInDLG = Window.Current<VaultLogInDLG>();
				VaultLogInDLG.UserNameTextBox.Text = "Administrator";
				VaultLogInDLG.OK.Click();
				Drawing.Current.TypeKeys("<Esc>");
				Drawing.Current.TypeKeys("<Esc>");
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
