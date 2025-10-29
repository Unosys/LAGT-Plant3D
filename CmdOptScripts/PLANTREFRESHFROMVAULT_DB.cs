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
	public class PLANTREFRESHFROMVAULT_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTREFRESHFROMVAULT_DB = new List<Command>
		{
			new PLANTREFRESHFROMVAULT_DB()
		};
	}

	public class PLANTREFRESHFROMVAULT_DB : Command
	{
		public override void Launch()
		{
			CheckInDLG CheckInDLG = new CheckInDLG();
			CheckInDLG.Invoke();
			//CheckInDLG CheckInDLG = Window.Current<CheckInDLG>();
			CheckInDLG.SetActive();
			CheckInDLG.OK.Click();
			System.Threading.Thread.Sleep(2000);
			ProjectDataMergedVaultDLG ProjectDataMergedVaultDLG = Window.Current<ProjectDataMergedVaultDLG>();
			ProjectDataMergedVaultDLG.SetActive();
			ProjectDataMergedVaultDLG.BtnOk.Click();
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			CmdOpt_Engine.SendCmd("PLANTREFRESHFROMVAULT");
			RefreshLocalProjectDLG RefreshLocalProjectDLG = Window.Current<RefreshLocalProjectDLG>();
			RefreshLocalProjectDLG.SetActive();
			if (!RefreshLocalProjectDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
				RefreshLocalProjectDLG.TypeKeys("<Enter>");
				ProjectRefreshedFromVaultDLG ProjectRefreshedFromVaultDLG = Window.Current<ProjectRefreshedFromVaultDLG>();
				ProjectRefreshedFromVaultDLG.TypeKeys("<Enter>");
				Drawing.Current.TypeKeys("<Esc>");
				Drawing.Current.TypeKeys("<Esc>");
				//CheckOutDrawing() CheckOutDrawing() = Window.Current<CheckOutDrawing()>();
				//CheckOutDrawing();
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
