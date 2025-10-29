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
	public class PLANTVAULTLOGOUT_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTVAULTLOGOUT_DB = new List<Command>
		{
			new PLANTVAULTLOGOUT_DB()
		};
	}

	public class PLANTVAULTLOGOUT_DB : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTVAULTLOGIN");
			VaultLogInDLG VaultLogInDLG = Window.Current<VaultLogInDLG>();
			VaultLogInDLG.SetActive();
			VaultLogInDLG.UserNameTextBox.Text = "Administrator";
			VaultLogInDLG.OK.Click();
			CmdOpt_Engine.SendCmd("PLANTVAULTLOGOUT");
			System.Threading.Thread.Sleep(0);
			VaultLogOutDLG VaultLogOutDLG = new VaultLogOutDLG();
			if (VaultLogOutDLG.Exists)
			{
				VaultLogOutDLG.SetActive();
			}
			//VaultLogOutDLG VaultLogOutDLG = new VaultLogOutDLG();
			if (!VaultLogOutDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
				//VaultLogOutDLG VaultLogOutDLG = Window.Current<VaultLogOutDLG>();
				VaultLogOutDLG.ClosePB.Click();
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
