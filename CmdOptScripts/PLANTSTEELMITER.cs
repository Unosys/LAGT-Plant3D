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
	public class PLANTSTEELMITERCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELMITER = new List<Command>
		{
			new PLANTSTEELMITER(),
			new PLANTSTEELMITER_Alignedges(),
			new PLANTSTEELMITER_Alignedges_Bisector(),
			new PLANTSTEELMITER_Alignedges_Gap(),
			new PLANTSTEELMITER_Gap()
		};
	}

	public class PLANTSTEELMITER : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELMITER");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            //Plant3DFunctions.DeleteAllDrawings();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELMITER_Alignedges : PLANTSTEELMITER
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELMITER");
            CmdOpt_Engine.SendOption("Align edges", 1, 2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            //Plant3DFunctions.DeleteAllDrawings();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELMITER_Alignedges_Bisector : PLANTSTEELMITER
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELMITER");
			CmdOpt_Engine.SendOpt("_Align");
            CmdOpt_Engine.SendOption("Bisector", 1, 2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            //Plant3DFunctions.DeleteAllDrawings();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELMITER_Alignedges_Gap : PLANTSTEELMITER
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELMITER");
			CmdOpt_Engine.SendOpt("_Align");
			CmdOpt_Engine.SendOption("Gap",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(10);
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            //Plant3DFunctions.DeleteAllDrawings();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELMITER_Gap : PLANTSTEELMITER
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELMITER");
			CmdOpt_Engine.SendOption("Gap",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(10);
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            //Plant3DFunctions.DeleteAllDrawings();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}
}
