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
	public class PLANTISOTBDRAWAREACLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTISOTBDRAWAREA = new List<Command>
		{
			new PLANTISOTBDRAWAREA(),
            new PLANTISOTBDRAWAREA_Replacedrawarea(),
            new PLANTISOTBDRAWAREA_addNodrawarea(),
            new PLANTISOTBDRAWAREA_toggleVisibility(),
			new PLANTISOTBDRAWAREA_Replacedrawarea_Undo(),
			new PLANTISOTBDRAWAREA_Replacedrawarea_eXit()
		};
	}

	public class PLANTISOTBDRAWAREA : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			//SetupTitleBlock() SetupTitleBlock() = Window.Current<SetupTitleBlock()>();
            Plant3DFunctions.SetupTitleBlock();
			System.Threading.Thread.Sleep(20000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTISOTBDRAWAREA");
			if (!Drawing.Current.GetCmdLine().Contains("[*/*/*]"))
			{
				CmdOpt_Engine.EnterPoint(17,15);
				CmdOpt_Engine.EnterPoint(21,11);
				CmdOpt_Engine.SendCmd("PLANTISOTBDRAWAREA");
			}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_Replace");
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<Esc 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBDRAWAREA_Replacedrawarea : PLANTISOTBDRAWAREA
	{
		public override void Launch()
		{
			//CmdOpt_Engine.SendCmd("_DYNMODE");
			//CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			if (!Drawing.Current.GetCmdLine().Contains("[*/*/*]"))
			{
				CmdOpt_Engine.EnterPoint(17,15);
				CmdOpt_Engine.EnterPoint(21,11);
				CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			}
			CmdOpt_Engine.SendOption("Replace",1,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<Esc 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBDRAWAREA_addNodrawarea : PLANTISOTBDRAWAREA
	{
		public override void Launch()
		{
			//CmdOpt_Engine.SendCmd("_DYNMODE");
			//CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			if (!Drawing.Current.GetCmdLine().Contains("[*/*/*]"))
			{
				CmdOpt_Engine.EnterPoint(17,15);
				CmdOpt_Engine.EnterPoint(21,11);
				CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			}
			CmdOpt_Engine.SendOption("No-draw",2,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<Esc 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBDRAWAREA_toggleVisibility : PLANTISOTBDRAWAREA
	{
		public override void Launch()
		{
			//CmdOpt_Engine.SendCmd("_DYNMODE");
			//CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			if (!Drawing.Current.GetCmdLine().Contains("[*/*/*]"))
			{
				CmdOpt_Engine.EnterPoint(17,15);
				CmdOpt_Engine.EnterPoint(21,11);
				CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			}
			CmdOpt_Engine.SendOption("Visibility",3,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<Esc 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBDRAWAREA_Replacedrawarea_Undo : PLANTISOTBDRAWAREA
	{
		public override void Launch()
		{
			//CmdOpt_Engine.SendCmd("_DYNMODE");
			//CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			if (!Drawing.Current.GetCmdLine().Contains("[*/*/*]"))
			{
				CmdOpt_Engine.EnterPoint(17,15);
				CmdOpt_Engine.EnterPoint(21,11);
				CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			}
			CmdOpt_Engine.SendOpt("_Replace");
			CmdOpt_Engine.SendOption("Undo",1,2);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBDRAWAREA_Replacedrawarea_eXit : PLANTISOTBDRAWAREA
	{
		public override void Launch()
		{
			//CmdOpt_Engine.SendCmd("_DYNMODE");
			//CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			if (!Drawing.Current.GetCmdLine().Contains("[*/*/*]"))
			{
				CmdOpt_Engine.EnterPoint(17,15);
				CmdOpt_Engine.EnterPoint(21,11);
				CmdOpt_Engine.SendCmd("_PLANTISOTBDRAWAREA");
			}
			CmdOpt_Engine.SendOpt("_Replace");
			CmdOpt_Engine.SendOption("eXit",2,2);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc 3>");
			//SetupTitleBlockClose() SetupTitleBlockClose() = Window.Current<SetupTitleBlockClose()>();
			Plant3DFunctions.SetupTitleBlockClose();
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
