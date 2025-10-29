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
	public class PLANTCOMPASSCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTCOMPASS = new List<Command>
		{
			new PLANTCOMPASS(),
			new PLANTCOMPASS_On(),
			new PLANTCOMPASS_OFf(),
			new PLANTCOMPASS_Tickmarks(),
			new PLANTCOMPASS_Tickmarks_On(),
			new PLANTCOMPASS_Tickmarks_OFf(),
			new PLANTCOMPASS_Snapincrement(),
			new PLANTCOMPASS_Snapincrement_On(),
			new PLANTCOMPASS_Snapincrement_OFf(),
			new PLANTCOMPASS_TOlerancerouting(),
			new PLANTCOMPASS_compassDiameter(),
			new PLANTCOMPASS_Color()
		};
	}

	public class PLANTCOMPASS : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTCOMPASS");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_On : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOption("On",1,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_OFf : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOption("OFf",2,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_Tickmarks : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOption("Tickmarks",3,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_On");
			CmdOpt_Engine.EnterInt(45);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_Tickmarks_On : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOpt("_Tickmarks");
			CmdOpt_Engine.SendOption("On",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(45);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_Tickmarks_OFf : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOpt("_Tickmarks");
			CmdOpt_Engine.SendOption("OFf",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_Snapincrement : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOption("Snapincrement",4,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_On");
			CmdOpt_Engine.EnterInt(45);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_Snapincrement_On : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOpt("_Snapincrement");
			CmdOpt_Engine.SendOption("On",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(45);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_Snapincrement_OFf : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOpt("_Snapincrement");
			CmdOpt_Engine.SendOption("OFf",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_TOlerancerouting : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOption("TOlerancerouting",5,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_compassDiameter : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOption("compassDiameter",6,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(150);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTCOMPASS_Color : PLANTCOMPASS
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTCOMPASS");
			CmdOpt_Engine.SendOption("Color",7,7);
            System.Threading.Thread.Sleep(2000);
            SelectColorDLG SelectColorDLG = new SelectColorDLG();
            if (SelectColorDLG.Exists)
            {
              
                SelectColorDLG.SetActive();
                SelectColorDLG.Cancel.Click();
            }
            PushButton CancelBtn = new DialogBox("#1").PushButton("Cancel|$2");
            if (CancelBtn.Exists)
            {
                CancelBtn.Click();
            }
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
