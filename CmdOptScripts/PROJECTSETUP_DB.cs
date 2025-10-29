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
	public class PROJECTSETUP_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPROJECTSETUP_DB = new List<Command>
		{
			new PROJECTSETUP_DB()
		};
	}

	public class PROJECTSETUP_DB : Command
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("SDI", 0);
			CmdOpt_Engine.SendCmd("PROJECTSETUP");
			System.Threading.Thread.Sleep(15000);
            PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
			if (!PandIDProjectSetupProjectDetailsDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
                //ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = Window.Current<ProjectSetupProjectDetailsDLG>();
                PandIDProjectSetupProjectDetailsDLG.CancelPB.Click();
				
			}
		}

		public override void Dismiss()
		{
            System.Threading.Thread.Sleep(3000);
            Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}
}
