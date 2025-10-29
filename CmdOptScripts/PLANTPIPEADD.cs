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
	public class PLANTPIPEADDCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPIPEADD = new List<Command>
		{
			new PLANTPIPEADD(),
			new PLANTPIPEADD_RoutingOffset(),
			new PLANTPIPEADD_RoutingOffset_Top(),
			new PLANTPIPEADD_RoutingOffset_Cop(),
			new PLANTPIPEADD_RoutingOffset_Bop(),
			new PLANTPIPEADD_RoutingOffset_TL(),
			new PLANTPIPEADD_RoutingOffset_TR(),
			new PLANTPIPEADD_RoutingOffset_cL(),
			new PLANTPIPEADD_RoutingOffset_cR(),
			new PLANTPIPEADD_RoutingOffset_BL(),
			new PLANTPIPEADD_RoutingOffset_BR(),
			new PLANTPIPEADD_RoutingOffset_offsetDistance()
		};
	}

	public class PLANTPIPEADD : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("PLANTPIPEADD");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTPIPEADD_Size : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOption("Size",1,5);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("?");
			CmdOpt_Engine.EnterText("10");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTPIPEADD_SPecification : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOption("SPecification",2,5);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("?");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTPIPEADD_STubin : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOption("STub",3,5);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTPIPEADD_Elevation : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOption("Elevation",4,5);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(5);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTPIPEADD_Elevation_Relative : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOpt("_Elevation");
			CmdOpt_Engine.SendOption("Relative",1,1);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(12);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTPIPEADD_RoutingOffset : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOption("routingOffset",5,5);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTPIPEADD_RoutingOffset_Top : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("Top",1,10);
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
			//Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
			else
			{
				Drawing.Current.TypeKeys("<Esc>");
				Drawing.Current.TypeKeys("<Esc>");
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_Cop : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("Cop",2,10);
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
            //Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(5);
			CmdOpt_Engine.EnterInt(5);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_Bop : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("Bop",3,10);
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
            //Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_TL : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("TL",4,10);
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
            //Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_TR : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("TR",5,10);
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
            //Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_cL : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("cL",6,10);
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
            //Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_cR : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("cR",7,10);
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
            //Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_BL : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("BL",8,10);
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
            //Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_BR : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("BR",9,10);
			//Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            PushButton OkBtn = new DialogBox("#1|$MessageBox").PushButton("OK|$2");
            //if (AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Exists)
            //{
            //    AppWnd.AcDialogBox("#1|$MessageBox").AdPushButton("OK|$2").Click();
            //}
            if (OkBtn.Exists)
            {
                OkBtn.Click();
            }
        }

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_RoutingOffset_offsetDistance : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.SendOption("offsetDistance",10,10);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(5);
			CmdOpt_Engine.EnterInt(5);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_pipeFitting : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("pipeFitting",1,12);
			System.Threading.Thread.Sleep(7000);
			//Window wActive = Desktop.GetActive();
			//AdResultLog.Current.Print(wActive);
            //Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (!AppWnd.IsEnabled && AppWnd.IsActive())
            //{
            //    CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
            //    CmdOpt_ErrorReport.ReportError(sError);
            //}
            //else
            //{
            //    //wActive wActive = Window.Current<wActive>();
            //    wActive.TypeKeys("<Esc 2>");
            //}
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_Plane : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("Plane",4,12);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_Cutbackelbow : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("Cutbackelbow",5,12);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_baseCOmponent : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("baseCOmponent",11,12);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_Rollelbow : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.SendOption("Rollelbow",6,12);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(80,60);
			CmdOpt_Engine.EnterPoint(80,45);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_pipeBEnd : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("pipeBEnd",8,12);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPEADD_Undo : PLANTPIPEADD
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,100);
			CmdOpt_Engine.SendOption("Undo",12,12);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteDrawing();
		}

		public override void Verify()
		{
		}
	}

    //public class MessageBox : PLANTPIPEADD
    //{
    //    public override void ()
    //    {
    //    }

    //    public override void ()
    //    {
    //    }

    //    public override void ()
    //    {
    //        tag "$2" tag "$2" = Window.Current<tag "$2">();
    //        tag "$2";
    //    }

    //    public override void ()
    //    {
    //        tag "$65535" tag "$65535" = Window.Current<tag "$65535">();
    //        tag "$65535";
    //    }
    //}
}
