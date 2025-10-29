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
	public class DWFOutputSettings_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcDWFOutputSettings_DB = new List<Command>
		{
			new DWFOutputSettings_DB()
		};
	}

	public class DWFOutputSettings_DB : Command
	{
		public override void Launch()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			CmdOpt_Engine.SendCmd("DWFOUTPUTSETTINGS");
			PIDDWFOutputSettingsDLG PIDDWFOutputSettingsDLG = new PIDDWFOutputSettingsDLG();
			if (PIDDWFOutputSettingsDLG.CancelBtn.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				PIDDWFOutputSettingsDLG.Dismiss();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
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
