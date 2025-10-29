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
	public class PLANTSTEELCUTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELCUT = new List<Command>
		{
			new PLANTSTEELCUT(),
			new PLANTSTEELCUT_cutBoth(),
			new PLANTSTEELCUT_Gap(),
			new PLANTSTEELCUT_cutBoth_cutOne(),
			new PLANTSTEELCUT_cutBoth_Gap()
		};
	}

	public class PLANTSTEELCUT : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELCUT");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELCUT_cutBoth : PLANTSTEELCUT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTSTEELCUT");
			CmdOpt_Engine.SendOption("Both",1,2);
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

	public class PLANTSTEELCUT_Gap : PLANTSTEELCUT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTSTEELCUT");
			CmdOpt_Engine.SendOption("Gap",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(10);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELCUT_cutBoth_cutOne : PLANTSTEELCUT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTSTEELCUT");
			CmdOpt_Engine.SendOpt("_Both");
			CmdOpt_Engine.SendOption("One",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELCUT_cutBoth_Gap : PLANTSTEELCUT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTSTEELCUT");
			CmdOpt_Engine.SendOpt("_Both");
			CmdOpt_Engine.SendOption("Gap",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(10);
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteDrawing();
		}

		public override void Verify()
		{
		}
	}
}
