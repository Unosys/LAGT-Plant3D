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
	public class PLANTWELDADDCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTWELDADD = new List<Command>
		{
			new PLANTWELDADD(),
			new PLANTWELDADD_Type(),
			new PLANTWELDADD_Type_Shop(),
			new PLANTWELDADD_Type_Field(),
			new PLANTWELDADD_Type_fieldfiT(),
			new PLANTWELDADD_autoplacementDistance(),
			new PLANTWELDADD_Point_Autoplacement(),
			new PLANTWELDADD_Point_Undo(),
			new PLANTWELDADD_Point_eXit()
		};
	}

	public class PLANTWELDADD : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(60,70);
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_zoom");
			CmdOpt_Engine.SendOpt("_Extents");
			CmdOpt_Engine.SendCmd("PLANTWELDADD");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_Type : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.SendOption("Type",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_Type_Shop : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.SendOpt("_Type");
			CmdOpt_Engine.SendOption("Shop",1,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_Type_Field : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.SendOpt("_Type");
			CmdOpt_Engine.SendOption("Field",2,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_Type_fieldfiT : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.SendOpt("_Type");
			CmdOpt_Engine.SendOption("fiT",3,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_autoplacementDistance : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.SendOption("Distance",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(240);
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_Point_BaseComponent : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.SendOption("Base",1,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_Point_Autoplacement : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.SendOption("Autoplacement",2,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_Point_Undo : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.SendOption("Undo",3,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTWELDADD_Point_eXit : PLANTWELDADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTWELDADD");
			CmdOpt_Engine.EnterPoint(100,70);
			CmdOpt_Engine.SendOption("eXit",4,4);
		}

		public override void Dismiss()
		{
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
