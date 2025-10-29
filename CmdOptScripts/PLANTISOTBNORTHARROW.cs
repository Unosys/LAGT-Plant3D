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
	public class PLANTISOTBNORTHARROWCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTISOTBNORTHARROW = new List<Command>
		{
			new PLANTISOTBNORTHARROW(),
			new PLANTISOTBNORTHARROW_upperLeft(),
			new PLANTISOTBNORTHARROW_uppeRight(),
			new PLANTISOTBNORTHARROW_lowerleFt(),
			new PLANTISOTBNORTHARROW_lowerrighT()
		};
	}

	public class PLANTISOTBNORTHARROW : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			//SetupTitleBlock() SetupTitleBlock() = Window.Current<SetupTitleBlock()>();
            Plant3DFunctions.SetupTitleBlock();
			System.Threading.Thread.Sleep(20000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTISOTBNORTHARROW");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterPoint(10,10);
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBNORTHARROW_upperLeft : PLANTISOTBNORTHARROW
	{
		public override void Launch()
		{
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_PLANTISOTBNORTHARROW");
			CmdOpt_Engine.SendOption("Left",1,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(10,10);
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBNORTHARROW_uppeRight : PLANTISOTBNORTHARROW
	{
		public override void Launch()
		{
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_PLANTISOTBNORTHARROW");
			CmdOpt_Engine.SendOption("Right",2,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(10,10);
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBNORTHARROW_lowerleFt : PLANTISOTBNORTHARROW
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBNORTHARROW");
			CmdOpt_Engine.SendOption("leFt",3,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(10,10);
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBNORTHARROW_lowerrighT : PLANTISOTBNORTHARROW
	{
		public override void Launch()
		{
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_PLANTISOTBNORTHARROW");
			CmdOpt_Engine.SendOption("righT",4,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(10,10);
			//SetupTitleBlockClose() SetupTitleBlockClose() = Window.Current<SetupTitleBlockClose()>();
            Plant3DFunctions.SetupTitleBlockClose();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			//Plant3DFunctions.DeleteAllDrawings();
	//		CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}
}
