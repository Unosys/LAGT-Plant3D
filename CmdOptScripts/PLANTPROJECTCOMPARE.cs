using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using LAGT.CommonFiles.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness.Plant3D.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
	public class PLANTPROJECTCOMPARECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPROJECTCOMPARE = new List<Command>
		{
			new PLANTPROJECTCOMPARE()
		};
	}

	public class PLANTPROJECTCOMPARE : Command
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("SDI", 0);
			CmdOpt_Engine.SendCmd("PLANTPROJECTCOMPARE");
			System.Threading.Thread.Sleep(15000);
			ProjectCompareDLG ProjectCompareDLG = new ProjectCompareDLG();
			if (!ProjectCompareDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
				//ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = Window.Current<ProjectSetupProjectDetailsDLG>();
				ProjectCompareDLG.Close2PB.Click();

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
