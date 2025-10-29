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
	public class PLANTFITTINGADDCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTFITTINGADD = new List<Command>
		{
			new PLANTFITTINGADD(),
			new PLANTFITTINGADD_NEXT(),
			new PLANTFITTINGADD_PLANE()
		};
	}

	public class PLANTFITTINGADD : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("-PLANTFITTINGADD");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("Elbow");
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.EnterText("8\"");
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.EnterCR();
			System.Threading.Thread.Sleep(2000);
            ProjManUndocked ProjManUndocked = Window.Current<ProjManUndocked>();
            ProjManUndocked.SetActive();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTFITTINGADD_NEXT : PLANTFITTINGADD
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTFITTINGADD");
			CmdOpt_Engine.EnterText("Elbow");
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.EnterText("8\"");
			CmdOpt_Engine.SendOption("Next",1,1);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTFITTINGADD_PLANE : PLANTFITTINGADD
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTFITTINGADD");
			CmdOpt_Engine.EnterText("Elbow");
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.EnterText("8\"");
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.SendOption("Plane",1,1);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
