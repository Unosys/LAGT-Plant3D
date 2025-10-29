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
	public class PLANTPIPESLOPECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPIPESLOPE = new List<Command>
		{
			new PLANTPIPESLOPE()
		};
	}

	public class PLANTPIPESLOPE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("PLANTPIPESLOPE");
			CmdOpt_Engine.EnterText("_last");
			System.Threading.Thread.Sleep(2000);
			EditSlopeDLG EditSlopeDLG = new EditSlopeDLG();
			if (EditSlopeDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				EditSlopeDLG.M_bt_Cancel.Click();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
				//SetDynIpt(0) SetDynIpt(0) = Window.Current<SetDynIpt(0)>();
				//SetDynIpt(0);
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
