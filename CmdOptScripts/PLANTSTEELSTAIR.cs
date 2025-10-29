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
	public class PLANTSTEELSTAIRCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELSTAIR = new List<Command>
		{
			new PLANTSTEELSTAIR(),
			new PLANTSTEELSTAIR_Settings(),
			new PLANTSTEELSTAIR_SettingsDB()
		};
	}

	public class PLANTSTEELSTAIR : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELSTAIR");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(1000,1000);
			CmdOpt_Engine.EnterPoint(1200,1000);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELSTAIR_Settings : PLANTSTEELSTAIR
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTSTEELSTAIR");
			CmdOpt_Engine.SendOption("Settings",1,1);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
			AppWnd.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
			string sText=Drawing.Current.GetCmdLine();
			if (sText.EndsWith("[ * ]:"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "The setting option should prompt for Length and other parameters", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTSTEELSTAIR_SettingsDB : PLANTSTEELSTAIR
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("cmddia", 1);
			CmdOpt_Engine.SendCmd("_PLANTSTEELSTAIR");
			CmdOpt_Engine.SendOption("Settings",1,1);
			System.Threading.Thread.Sleep(2000);
			StairSettingsDLG StairSettingsDLG = new StairSettingsDLG();
			if (StairSettingsDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				StairSettingsDLG.Cancel.Click();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
			Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
			AppWnd.TypeKeys("<ESC>");
			Drawing.Current.SetSysVar("cmddia", 0);
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
