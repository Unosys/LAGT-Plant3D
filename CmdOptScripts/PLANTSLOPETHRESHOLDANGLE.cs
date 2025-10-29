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
	public class PLANTSLOPETHRESHOLDANGLECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSLOPETHRESHOLDANGLE = new List<Command>
		{
			new PLANTSLOPETHRESHOLDANGLE()
		};
	}

	public class PLANTSLOPETHRESHOLDANGLE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSLOPETHRESHOLDANGLE");
            CmdOpt_Engine.EnterInt(8);
            CmdOpt_Engine.SendCmd("PLANTSLOPETHRESHOLDANGLE");

        }

		public override void Dismiss()
		{
            Plant3DFunctions.DeleteDrawing();
        }

		public override void Verify()
        {
            
            string sCmdOpt = Drawing.Current.GetCmdLineHistory(2);
            
            AdResultLog.Current.Print(sCmdOpt);
            //if (!sCmdOpt.EndsWith("<*>*: 8"))
            if (!sCmdOpt.Contains("<8>"))
            {
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "New value is not entered.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			//
		}
	}
}
