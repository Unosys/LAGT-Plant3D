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
	public class OpenProject_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcOpenProject_DB = new List<Command>
		{
			new OpenProject_DB()
		};
	}

	public class OpenProject_DB : Command
	{
		public override void Launch()
		{
            string sProjectName = LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\NetworkPath\\Project.xml";

            PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			CmdOpt_Engine.SendCmd("OPENPROJECT");
			CmdOpt_Engine.EnterText(sProjectName);
			System.Threading.Thread.Sleep(12000);
            PandIDAutoCADPIDMigration2009DLG PandIDAutoCADPIDMigration2009DLG = new PandIDAutoCADPIDMigration2009DLG();
			if (PandIDAutoCADPIDMigration2009DLG.Exists)
			{
                PandIDAutoCADPIDMigration2009DLG.SetActive();
                PandIDAutoCADPIDMigration2009DLG.CancelPB.Click();
				MigrationCancelTaskDLG MigrationCancelTaskDLG = new MigrationCancelTaskDLG();
				if (MigrationCancelTaskDLG.WaitExists(5 * 1000))
				{
					MigrationCancelTaskDLG.SetActive();
					MigrationCancelTaskDLG.Dismiss();
					System.Threading.Thread.Sleep(10000);
				}
			
			
			}	else
				{	CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
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
