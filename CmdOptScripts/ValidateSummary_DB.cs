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
	public class ValidateSummary_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcValidateSummary_DB = new List<Command>
		{
			new ValidateSummary_DB()
		};
	}

	public class ValidateSummary_DB : Command
	{
		public override void Launch()
		{
			//CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            Plant3DFunctions.CreateDrawing("PID");
			CmdOpt_Engine.SendCmd("_Sline");
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
			if (PandIDAlertAddDwgDLG.Exists)
			{
                PandIDAlertAddDwgDLG.Yes.Click();
				CmdOpt_Engine.SendCmd("_Sline");
			}
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			if (!Drawing.Current.ReadyForNextCommand())
			{
				CmdOpt_Engine.EnterCR();
			}
			if (!Drawing.Current.ReadyForNextCommand())
			{
				CmdOpt_Engine.EnterCR();
			}
			CmdOpt_Engine.SendCmd("VALIDATE");
			System.Threading.Thread.Sleep(5000);
            PandIDWarningAutoCADDLG WarningAutoCADDLG = new PandIDWarningAutoCADDLG();
			if (WarningAutoCADDLG.WaitExists(2 * 1000))
			{
				WarningAutoCADDLG.SetActive();
				WarningAutoCADDLG.No.Click();
			}
			CmdOpt_Engine.SendCmd("VALIDATESUMMARY");
			System.Threading.Thread.Sleep(5000);
			//WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
			if (WarningAutoCADDLG.WaitExists(2 * 1000))
			{
				WarningAutoCADDLG.SetActive();
				WarningAutoCADDLG.No.Click();
			}
            PandIDValidationSummaryDLG ValidationSummaryDLG = new PandIDValidationSummaryDLG();
			if (ValidationSummaryDLG.WaitExists(50000))
			{
				ValidationSummaryDLG.Dismiss();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
				
			}
		}

		public override void Dismiss()
		{
            CmdOpt_Engine.SendCmd("_VALIDATESUMMARYCLOSE");
            Plant3DFunctions.DeleteAllDrawings();

		}

		public override void Verify()
		{
		}
	}
}
