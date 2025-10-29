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
	public class PLANTSTEELLENGTHENCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELLENGTHEN = new List<Command>
		{
			new PLANTSTEELLENGTHEN(),
			new PLANTSTEELLENGTHEN_Delta(),
			new PLANTSTEELLENGTHEN_Total()
		};
	}

	public class PLANTSTEELLENGTHEN : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PlantSteelLadder");
			CmdOpt_Engine.EnterPoint(658,120);
			CmdOpt_Engine.EnterPoint(1650,800);
			CmdOpt_Engine.EnterPoint(300,200);
			CmdOpt_Engine.SendCmd("PLANTSTEELLENGTHEN");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTSTEELLENGTHEN_Delta : PLANTSTEELLENGTHEN
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PlantSteelLadder");
			CmdOpt_Engine.EnterPoint(658,120);
			CmdOpt_Engine.EnterPoint(1650,800);
			CmdOpt_Engine.EnterPoint(300,200);
			CmdOpt_Engine.SendCmd("PLANTSTEELLENGTHEN");
			CmdOpt_Engine.SendOption("Delta",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(10);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTSTEELLENGTHEN_Total : PLANTSTEELLENGTHEN
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PlantSteelLadder");
			CmdOpt_Engine.EnterPoint(658,120);
			CmdOpt_Engine.EnterPoint(1650,800);
			CmdOpt_Engine.EnterPoint(300,200);
			CmdOpt_Engine.SendCmd("PLANTSTEELLENGTHEN");
			CmdOpt_Engine.SendOption("Total",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(100);
			CmdOpt_Engine.EnterCR();
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
