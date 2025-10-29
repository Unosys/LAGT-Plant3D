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
	public class ValidateConfig_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcValidateConfig_DB = new List<Command>
		{
			new ValidateConfig_DB()
		};
	}

	public class ValidateConfig_DB : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("VALIDATECONFIG");
            System.Threading.Thread.Sleep(5000);
            PandIDValidateConfigDLG PandIDValidateConfigDLG = new PandIDValidateConfigDLG();
			if (PandIDValidateConfigDLG.BtnCancel.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
                PandIDValidateConfigDLG.Dismiss();
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
