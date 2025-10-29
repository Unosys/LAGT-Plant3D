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
	public class PLANTSTEELSETREPCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELSETREP = new List<Command>
		{
			new PLANTSTEELSETREP(),
			new PLANTSTEELSETREP_Line(),
			new PLANTSTEELSETREP_Symbol(),
			new PLANTSTEELSETREP_Outline(),
			new PLANTSTEELSETREP_sHape()
		};
	}

	public class PLANTSTEELSETREP : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELSETREP");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELSETREP_Line : PLANTSTEELSETREP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTSTEELSETREP");
			CmdOpt_Engine.SendOption("Line",1,4);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELSETREP_Symbol : PLANTSTEELSETREP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTSTEELSETREP");
			CmdOpt_Engine.SendOption("Symbol",2,4);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELSETREP_Outline : PLANTSTEELSETREP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTSTEELSETREP");
			CmdOpt_Engine.SendOption("Outline",3,4);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELSETREP_sHape : PLANTSTEELSETREP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTSTEELSETREP");
			CmdOpt_Engine.SendOption("sHape",4,4);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 3>");
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
