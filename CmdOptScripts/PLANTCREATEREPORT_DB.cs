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
	public class PLANTCREATEREPORT_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTCREATEREPORT_DB = new List<Command>
		{
			new PLANTCREATEREPORT_DB()
		};
	}

	public class PLANTCREATEREPORT_DB : Command
	{
		public override void Launch()
		{
			////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTCREATEREPORT");
			PlantCreateReportDLG PlantCreateReportDLG = new PlantCreateReportDLG();
			if (PlantCreateReportDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				PlantCreateReportDLG.SetActive();
				PlantCreateReportDLG.Dismiss();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
