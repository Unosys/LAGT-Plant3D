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
	public class Validate_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcValidate_DB = new List<Command>
		{
			new Validate_DB()
		};
	}

	public class Validate_DB : Command
	{
        public override void Launch()
        {
            PandIDFunctions.CreateDrawing("PID"); ;
            CmdOpt_Engine.SendCmd("_Sline");
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(50, 50);
            CmdOpt_Engine.EnterPoint(100, 50);
            if (!Drawing.Current.ReadyForNextCommand())
            {
                CmdOpt_Engine.EnterCR();
            }
            CmdOpt_Engine.SendCmd("VALIDATE");
            System.Threading.Thread.Sleep(5000);
            PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
            if (PandIDWarningAutoCADDLG.WaitExists(2 * 1000))
            {
                PandIDWarningAutoCADDLG.SetActive();
                PandIDWarningAutoCADDLG.No.Click();
            }
            PandIDValidationSummaryDLG PandIDValidationSummaryDLG = new PandIDValidationSummaryDLG();
            if (PandIDValidationSummaryDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 3))
            {
                PandIDValidationSummaryDLG.Dismiss();
               
            }
            else
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
               
            }
        }

        public override void Dismiss()
        {
            PandIDFunctions.DeleteAllDrawings();

        }

        public override void Verify()
        {
        }
    }
}
