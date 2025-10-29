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
	public class PLANTEDITBENDCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTEDITBEND = new List<Command>
		{
			new PLANTEDITBEND(),
            new PLANTEDITBEND_Radius(),
            new PLANTEDITBEND_Tangentlength1(),
            new PLANTEDITBEND_tangeNtlength2(),
            new PLANTEDITBEND_Angle()
		};
	}

	public class PLANTEDITBEND : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("PLANTROUTEBEND");
			CmdOpt_Engine.SendOpt("_ON");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOpt("_Size");
            CmdOpt_Engine.EnterText("10\"");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.SendCmd("PLANTEDITBEND");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(80,50);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTEDITBEND_Radius : PLANTEDITBEND
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("PLANTROUTEBEND");
			CmdOpt_Engine.SendOpt("_ON");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOpt("_Size");
            CmdOpt_Engine.EnterText("10\"");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.SendCmd("_PLANTEDITBEND");
			CmdOpt_Engine.EnterPoint(80,50);
			CmdOpt_Engine.SendOption("Radius",1,4);
		}

		public override void Dismiss()
		{
            CmdOpt_Engine.EnterText("10");
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTEDITBEND_Tangentlength1 : PLANTEDITBEND
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("PLANTROUTEBEND");
			CmdOpt_Engine.SendOpt("_ON");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOpt("_Size");
            CmdOpt_Engine.EnterText("10\"");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.SendCmd("_PLANTEDITBEND");
			CmdOpt_Engine.EnterPoint(80,50);
			CmdOpt_Engine.SendOption("Tangentlength1",2,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("20");
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTEDITBEND_tangeNtlength2 : PLANTEDITBEND
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("PLANTROUTEBEND");
			CmdOpt_Engine.SendOpt("_ON");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOpt("_Size");
            CmdOpt_Engine.EnterText("10\"");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.SendCmd("_PLANTEDITBEND");
			CmdOpt_Engine.EnterPoint(80,50);
			CmdOpt_Engine.SendOption("tangeNtlength2",3,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("35");
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTEDITBEND_Angle : PLANTEDITBEND
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("PLANTROUTEBEND");
			CmdOpt_Engine.SendOpt("_ON");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOpt("_Size");
            CmdOpt_Engine.EnterText("10\"");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.SendCmd("_PLANTEDITBEND");
			CmdOpt_Engine.EnterPoint(80,50);
			CmdOpt_Engine.SendOption("Angle",4,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("80");
			CmdOpt_Engine.EnterCR();
            System.Threading.Thread.Sleep(4000);
            Plant3DPipingErrorDLG Plant3DPipingErrorDLG = new Plant3DPipingErrorDLG();
			if (Plant3DPipingErrorDLG.Exists)
			{
				Plant3DPipingErrorDLG.BtnClose.Click();
			}
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
