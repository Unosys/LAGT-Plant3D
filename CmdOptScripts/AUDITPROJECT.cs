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
	public class AUDITPROJECTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcAUDITPROJECT = new List<Command>
		{
			new AUDITPROJECT()
		};
	}

	public class AUDITPROJECT : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("AUDITPROJECT");
            System.Threading.Thread.Sleep(3000);
            var Plant3DAuditProjectDLG = new Plant3DAuditProjectDLG();
            if (!Plant3DAuditProjectDLG.Exists)
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
            else
            {
                Plant3DAuditProjectDLG.ClosePB.Click();
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
