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
	public class PLANTPIPESUPPORTMOVECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPIPESUPPORTMOVE = new List<Command>
		{
			new PLANTPIPESUPPORTMOVE(),
			new PLANTPIPESUPPORTMOVE_coPy(),
			new PLANTPIPESUPPORTMOVE_Lockpointofsupport()
			//new PLANTPIPESUPPORTMOVE_Basepoint(),
			//new PLANTPIPESUPPORTMOVE_orieNtation(),
			//new PLANTPIPESUPPORTMOVE_baseComponent(),
			//new PLANTPIPESUPPORTMOVE__coPy(),
			//new PLANTPIPESUPPORTMOVE__Lockpointofsupport(),
			//new PLANTPIPESUPPORTMOVE_Undo(),
			//new PLANTPIPESUPPORTMOVE_eXit()
		};
	}

	public class PLANTPIPESUPPORTMOVE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("DYNMODE", 0);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTADD");
            System.Threading.Thread.Sleep(5000);
            AddPipeSupportDLG AddPipeSupportDLG = Window.Current<AddPipeSupportDLG>();
			AddPipeSupportDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            AddPipeSupportDLG.MBtnFilter3.Click(MouseButton.Left, 3, 3);
			System.Threading.Thread.Sleep(10000);
			AddPipeSupportDLG.SetActive();
			RECT  rAddPipeRect = AddPipeSupportDLG.GetRect(true);
			Desktop Desktop = Window.Current<Desktop>();
			Desktop.Click(MouseButton.Left,  rAddPipeRect.xPos +125,  rAddPipeRect.yPos +200);
			AddPipeSupportDLG.OK.Click();
			CmdOpt_Engine.EnterPoint(50,50,100);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC 2>");
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_Extents");
			CmdOpt_Engine.SendCmd("PLANTPIPESUPPORTMOVE");
		}

		public override void Dismiss()
		{
			//CmdOpt_Engine.EnterPoint(50,50,100);
            CmdOpt_Engine.SendOpt("_last");
			//CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(60,50,100);
			CmdOpt_Engine.SendOpt("_Plane");
            CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_ERASE");
            //CmdOpt_Engine.SendOpt("_ALL");
            //CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC>");

		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE_coPy : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			////Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
			//CmdOpt_Engine.EnterPoint(50,50,100);
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.SendOption("coPy",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(70,50,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE_Lockpointofsupport : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			//Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
            CmdOpt_Engine.SendOpt("_last");
            //CmdOpt_Engine.EnterPoint(50,50,100);
			CmdOpt_Engine.SendOption("Lockpointofsupport",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_Lockpointofsupport");
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE_Basepoint : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("DYNMODE", -3);
            CmdOpt_Engine.SendCmd("_-OSNAP");
            CmdOpt_Engine.SendOpt("_mid");
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
            //CmdOpt_Engine.EnterPoint(70, 50, 100);
            System.Threading.Thread.Sleep(2000);
            SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\Support.bmp");
            Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            System.Threading.Thread.Sleep(2000);
            //Desktop.Current.Click(MouseButton.Left, 226, 319);
            CmdOpt_Engine.SendOption("Basepoint",1,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,50);
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE_orieNtation : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
			//CmdOpt_Engine.EnterPoint(100,50,100);
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.SendOption("orieNtation",2,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(70,50);
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE_baseComponent : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
			//CmdOpt_Engine.EnterPoint(70,50,100);
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.SendOption("baseComponent",3,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(30,50);
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE__coPy : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
            CmdOpt_Engine.SendOpt("_last");
            //CmdOpt_Engine.EnterPoint(70,50,100);
			CmdOpt_Engine.SendOption("coPy",4,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,50);
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE__Lockpointofsupport : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
			//CmdOpt_Engine.EnterPoint(70,50,100);
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.SendOption("Lockpointofsupport",5,7);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(70,50);
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE_Undo : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
			//CmdOpt_Engine.EnterPoint(70,50,100);
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.SendOption("Undo",6,7);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTMOVE_eXit : PLANTPIPESUPPORTMOVE
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTMOVE");
			//CmdOpt_Engine.EnterPoint(70,50,100);
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.SendOption("eXit",7,7);
		}

		public override void Dismiss()
		{
			//CmdOpt_Engine.EnterPoint(70,50);
			Drawing.Current.TypeKeys("<ESC>");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}
}
