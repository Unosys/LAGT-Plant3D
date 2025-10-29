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
	public class ProjectManager_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcProjectManager_DB = new List<Command>
		{
			new ProjectManager_DB()
		};
	}

	public class ProjectManager_DB : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PROJECTMANAGER");
            PandIDPROJECTMANAGERDLG PROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
			if (PROJECTMANAGERDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				Drawing.Current.TypeKeys("<ESC>");
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
