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
	public class PLANTPRODUCTIONISOCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPRODUCTIONISO = new List<Command>
		{
			new PLANTPRODUCTIONISO(),
            new PLANTPRODUCTIONISO_LINENUMBERS(),
            new PLANTPRODUCTIONISO_ISOTYPE(),
            new PLANTPRODUCTIONISO_DWFCREATE(),
            new PLANTPRODUCTIONISO_OVERWRITEEXISTING(),
            new PLANTPRODUCTIONISO_CREATE()
        };
	}

	public class PLANTPRODUCTIONISO : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("-PLANTPRODUCTIONISO");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_LineNumbers");
			CmdOpt_Engine.EnterInt(0);
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPRODUCTIONISO_LINENUMBERS : PLANTPRODUCTIONISO
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTPRODUCTIONISO");
			CmdOpt_Engine.SendOption("Line Numbers",1,5);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(0);
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPRODUCTIONISO_ISOTYPE : PLANTPRODUCTIONISO
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTPRODUCTIONISO");
			CmdOpt_Engine.SendOption("Iso Type()",2,5);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPRODUCTIONISO_DWFCREATE : PLANTPRODUCTIONISO
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTPRODUCTIONISO");
			CmdOpt_Engine.SendOption("DWF Create",3,5);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPRODUCTIONISO_OVERWRITEEXISTING : PLANTPRODUCTIONISO
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTPRODUCTIONISO");
			CmdOpt_Engine.SendOption("Overwrite Existing",4,5);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPRODUCTIONISO_CREATE : PLANTPRODUCTIONISO
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTPRODUCTIONISO");
			CmdOpt_Engine.SendOption("Create",5,5);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
            Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
