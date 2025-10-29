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
	public class PlantDWGCheckerAutoCheckCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPlantDWGCheckerAutoCheck = new List<Command>
		{
			new PlantDWGCheckerAutoCheck(),
			new PlantDWGCheckerAutoCheck_oN(),
			new PlantDWGCheckerAutoCheck_Off()
		};
	}

	public class PlantDWGCheckerAutoCheck : Command
	{
		public override void Launch()
		{
			//CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            Plant3DFunctions.CreateDrawing("PID");
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PlantDWGCheckerAutoCheck");
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Enter>");
			//DeleteDrawing() DeleteDrawing() = Window.Current<DeleteDrawing()>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PlantDWGCheckerAutoCheck_oN : PlantDWGCheckerAutoCheck
	{
		public override void Launch()
		{
			//CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            Plant3DFunctions.CreateDrawing("PID");
			CmdOpt_Engine.SendCmd("PlantDWGCheckerAutoCheck");
			CmdOpt_Engine.SendOption("oN",1,2);
		}

		public override void Dismiss()
		{
			//DeleteDrawing() DeleteDrawing() = Window.Current<DeleteDrawing()>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PlantDWGCheckerAutoCheck_Off : PlantDWGCheckerAutoCheck
	{
		public override void Launch()
		{
			//CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            Plant3DFunctions.CreateDrawing("PID");
			CmdOpt_Engine.SendCmd("PlantDWGCheckerAutoCheck");
			CmdOpt_Engine.SendOption("Off",2,2);
		}

		public override void Dismiss()
		{
			//DeleteDrawing() DeleteDrawing() = Window.Current<DeleteDrawing()>();
            Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
