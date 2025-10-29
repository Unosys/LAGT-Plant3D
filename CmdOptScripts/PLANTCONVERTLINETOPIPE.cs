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
	public class PLANTCONVERTLINETOPIPECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTCONVERTLINETOPIPE = new List<Command>
		{
			new PLANTCONVERTLINETOPIPE(),
			new PLANTCONVERTLINETOPIPE_Size(),
			new PLANTCONVERTLINETOPIPE_SPecification(),
			new PLANTCONVERTLINETOPIPE_Erase(),
			new PLANTCONVERTLINETOPIPE_Erase_Yes(),
			new PLANTCONVERTLINETOPIPE_Erase_No()
		};
	}

	public class PLANTCONVERTLINETOPIPE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTCONVERTLINETOPIPE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_SPecification");
			CmdOpt_Engine.EnterText("SS600");
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(3);
			if (!sCmdOpt.Contains("SS600"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "The line has not been converted.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTCONVERTLINETOPIPE_Size : PLANTCONVERTLINETOPIPE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCONVERTLINETOPIPE");
			CmdOpt_Engine.SendOption("Size",1,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(2);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(3);
			if (!sCmdOpt.Contains("2"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "The size has not been converted.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTCONVERTLINETOPIPE_SPecification : PLANTCONVERTLINETOPIPE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCONVERTLINETOPIPE");
			CmdOpt_Engine.SendOption("SPecification",2,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("SS600");
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(3);
			if (!sCmdOpt.Contains("SS600"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "The specification has not been converted.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTCONVERTLINETOPIPE_Erase : PLANTCONVERTLINETOPIPE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCONVERTLINETOPIPE");
			CmdOpt_Engine.SendOption("Erase",3,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_No");
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(3);
			if (!sCmdOpt.Contains("No"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "The line has not been erased.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTCONVERTLINETOPIPE_Erase_Yes : PLANTCONVERTLINETOPIPE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCONVERTLINETOPIPE");
			CmdOpt_Engine.SendOpt("_Erase");
			CmdOpt_Engine.SendOption("Yes",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(3);
			if (!sCmdOpt.Contains("Yes"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "The line has been erased.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTCONVERTLINETOPIPE_Erase_No : PLANTCONVERTLINETOPIPE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCONVERTLINETOPIPE");
			CmdOpt_Engine.SendOpt("_Erase");
			CmdOpt_Engine.SendOption("No",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(3);
			if (!sCmdOpt.Contains("No"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "The line has not been erased.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}
	}
}
