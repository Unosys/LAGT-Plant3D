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
	public class PLANTSIZEDISPLAYMODECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSIZEDISPLAYMODE = new List<Command>
		{
			new PLANTSIZEDISPLAYMODE(),
			new PLANTSIZEDISPLAYMODE_Project(),
			new PLANTSIZEDISPLAYMODE_Mixed()
		};
	}

	public class PLANTSIZEDISPLAYMODE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSIZEDISPLAYMODE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(1);
            //AdResultLog.Current.Print(sCmdOpt); 
            //if (!sCmdOpt.Contains("?"))
            if (!sCmdOpt.WcMatch("*?*"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Piping component sizes are not displayed.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTSIZEDISPLAYMODE_Project : PLANTSIZEDISPLAYMODE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTSIZEDISPLAYMODE");
			CmdOpt_Engine.SendOption("Project",1,2);
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(1);
            AdResultLog.Current.Print(sCmdOpt); 
            if (!sCmdOpt.Contains("?"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "Piping component sizes are not mixed displayed.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTSIZEDISPLAYMODE_Mixed : PLANTSIZEDISPLAYMODE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTSIZEDISPLAYMODE");
			CmdOpt_Engine.SendOption("Mixed",2,2);
		}

		public override void Dismiss()
		{
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(1);
            //AdResultLog.Current.Print(sCmdOpt); 
            if (!sCmdOpt.Contains("?"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "Piping component sizes are not project displayed. "+sCmdOpt, "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			Plant3DFunctions.DeleteDrawing();
		}
	}
}
