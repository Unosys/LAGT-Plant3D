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
	public class PLANTSTEELEXPLODECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELEXPLODE = new List<Command>
		{
			new PLANTSTEELEXPLODE()
		};
	}

	public class PLANTSTEELEXPLODE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PlantSteelLadder");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.SendCmd("PLANTSTEELEXPLODE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("_last");
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
