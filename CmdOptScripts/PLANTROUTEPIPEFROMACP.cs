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
	public class PLANTROUTEPIPEFROMACPCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTROUTEPIPEFROMACP = new List<Command>
		{
			new PLANTROUTEPIPEFROMACP(),
			new PLANTROUTEPIPEFROMACP_pipeFitting(),
			new PLANTROUTEPIPEFROMACP_Size(),
			new PLANTROUTEPIPEFROMACP_SPecification(),
			new PLANTROUTEPIPEFROMACP_Plane(),
			new PLANTROUTEPIPEFROMACP_Cutbackelbow(),
			new PLANTROUTEPIPEFROMACP_Rollelbow(),
			new PLANTROUTEPIPEFROMACP_STubin(),
			new PLANTROUTEPIPEFROMACP_Elevation(),
			new PLANTROUTEPIPEFROMACP_Offset(),
			new PLANTROUTEPIPEFROMACP_baseCOmponent()
		};
	}

	public class PLANTROUTEPIPEFROMACP : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_pipeFitting : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("pipeFitting",1,10);
			Window wActive = Desktop.Current.GetActive();
			AdResultLog.Current.Print(wActive);
			Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (!AppWnd.IsEnabled && AppWnd.IsActive())
            //{
            //    CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
            //    CmdOpt_ErrorReport.ReportError(sError);
            //}
            //else
            //{
            //    wActive.TypeKeys("<Esc>");
            //}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTROUTEPIPEFROMACP_Size : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("Size",2,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(4);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_SPecification : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("SPecification",3,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_Plane : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("Plane",4,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_Cutbackelbow : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("Cutbackelbow",5,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_Rollelbow : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("Rollelbow",6,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,65);
			CmdOpt_Engine.EnterPoint(68,0);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_STubin : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("STub",7,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(62,60);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_Elevation : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("Elevation",8,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(5);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_Offset : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("Offset",9,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTROUTEPIPEFROMACP_baseCOmponent : PLANTROUTEPIPEFROMACP
	{
		public override void Launch()
		{
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,100);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendCmd("PLANTROUTEPIPEFROMACP");
			CmdOpt_Engine.EnterPoint(70,70);
			CmdOpt_Engine.SendOption("COmponent",10,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(52,50);
			CmdOpt_Engine.EnterPoint(80,50);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
