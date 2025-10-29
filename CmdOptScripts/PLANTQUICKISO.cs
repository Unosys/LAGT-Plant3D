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
	public class PLANTQUICKISOCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTQUICKISO = new List<Command>
		{
			new PLANTQUICKISO(),
			new PLANTQUICKISO_LINENUMBER()
		};
	}

	public class PLANTQUICKISO : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_LINE");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_Extents");
			CmdOpt_Engine.SendCmd("PLANTQUICKISO");
			CmdOpt_Engine.EnterPoint(50,75);
			CmdOpt_Engine.EnterCR();
			//System.Threading.Thread.Sleep(1000);
			CreateQuickIsoDLG CreateQuickIsoDLG = new CreateQuickIsoDLG();
			if (CreateQuickIsoDLG.WaitExists(10000))
			{
				CreateQuickIsoDLG.Button_Cancel.Click();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}

	public class PLANTQUICKISO_LINENUMBER : PLANTQUICKISO
	{
		public override void Launch()
		{
            CmdOpt_Engine.SendCmd("_Erase _All ");
            CmdOpt_Engine.SendCmd("_LINE");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTQUICKISO");
			CmdOpt_Engine.SendOption("LINE NUMBER",1,1);
			//System.Threading.Thread.Sleep(1000);
            //Pane CreateQuickIsoDLG = new Pane("$SelectQuickIso");
            if (new Pane("$SelectQuickIso").WaitExists(10000))
            {
                new Pane("$SelectQuickIso").PushButton("$button_Cancel").Click();
            }
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
