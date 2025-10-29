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
	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTROUTEFROMAUTODESKCONNECTIONPOINT = new List<Command>
		{
			new PLANTROUTEFROMAUTODESKCONNECTIONPOINT(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_pipeFitting(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Size(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_SPecification(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Cutbackelbow(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Rollelbow(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_STubin(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_pipeBEnd(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_rountingOffset(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_baseCOmponent(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Plane(),
            new PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Elevation()
		};
	}

	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT : Command
	{
		public override void Launch()
		{
            //////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
            //Plant3DFunctions.CreateDrawing("P3D");
            Plant3DFunctions.CopyDrawing("AUTODESKCONNECTIONPOINT.dwg");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50, 50, 0);
            //CmdOpt_Engine.EnterPoint(140, 50, 0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            ////CmdOpt_Engine.EnterPoint(140, 50, 0);
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50, 50, 0);
            //CmdOpt_Engine.SendCmd("_Zoom");
            //CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
		}

		public override void Dismiss()
		{
            Drawing.Current.TypeKeys("<Enter>");
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
            //Drawing.Current.Close();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_pipeFitting : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            ////Plant3DFunctions.CreateDrawing("P3D");
            ////Plant3DFunctions.CopyDrawing("AUTODESKCONNECTIONPOINT.dwg");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50, 50, 0);
            //CmdOpt_Engine.EnterPoint(140, 50, 0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            ////CmdOpt_Engine.EnterPoint(140, 50, 0);
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50, 50, 0);
            //CmdOpt_Engine.SendCmd("_Zoom");
            //CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			//CmdOpt_Engine.EnterPoint(48.4835,50.0880,0.0000);
            CmdOpt_Engine.EnterPoint(50, 50);
			CmdOpt_Engine.SendOption("pipeFitting",1,11);
            //Window CancelBtn = Desktop.Current.GetActive();
            ////Window CancelBtn = new Window("#1");
            ////RECT rClick = CancelBtn.GetRect(true);
            //AdResultLog.Current.Print(CancelBtn);
            //if (CancelBtn.Exists)
            //{
            //    //Desktop.Current.Click(MouseButton.Left, rClick.xPos + 10, rClick.yPos + 10);
            //    //CancelBtn.Click();
            //    CancelBtn.TypeKeys("<esc>");
            //}
            PipeFittingDLG PipeFittingDLG = new PipeFittingDLG();
            if (PipeFittingDLG.WaitExists(2000))
            {
                //PipeFittingDLG.SetActive();
                //PipeFittingDLG.CancelST.Click();
                Desktop.Current.TypeKeys("<Esc>");
            }
            else
            {
            CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
            CmdOpt_ErrorReport.ReportError(sError);
            }
		
			//AdResultLog.Current.Print(wActive);
			//Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            // if (!AppWnd.IsEnabled && AppWnd.IsActive())
            //{
            //    CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
            //    CmdOpt_ErrorReport.ReportError(sError);
            //}
            //else
            //{
            //    //wActive = Window.Current<wActive>();
            //    wActive.TypeKeys("<Esc>");
            //}
		}

		public override void Dismiss()
		{
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Size : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("Size",2,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(4);
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_SPecification : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("SPecification",3,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}


	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Cutbackelbow : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            ////Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            ////CopyDrawing("P3D", "AUTODESKCONNECTIONPOINT CopyDrawing("P3D", "AUTODESKCONNECTIONPOINT = Window.Current<CopyDrawing("P3D", "AUTODESKCONNECTIONPOINT>();
            ////Plant3DFunctions.CopyDrawing("AUTODESKCONNECTIONPOINT.dwg");
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
            System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendOption("Cutbackelbow",5,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterCR();
            //Drawing.Current.TypeKeys("<Esc>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            Drawing.Current.TypeKeys("<Esc 2>");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
        }

		public override void Verify()
		{
		}
	}

	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Rollelbow : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("Rollelbow",6,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(100,65);
			CmdOpt_Engine.EnterPoint(68,0);
			CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_STubin : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("STub-in",7,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(62,60);
			CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_pipeBEnd : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("pipeBEnd",8,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}


	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_rountingOffset : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("routingOffset",10,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_baseCOmponent : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("baseCOmponent",11,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(52,50);
			CmdOpt_Engine.EnterPoint(80,50);
			CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
			
		}
	}
	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Plane : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //Plant3DFunctions.CopyDrawing("AUTODESKCONNECTIONPOINT.dwg");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("Plane",4,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
			//Drawing.Current.SetSysVar("SDI", 0);
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
	public class PLANTROUTEFROMAUTODESKCONNECTIONPOINT_Elevation : PLANTROUTEFROMAUTODESKCONNECTIONPOINT
	{
		public override void Launch()
		{
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_DYNMODE");
            //CmdOpt_Engine.EnterInt(-3);
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(50,50,0);
            //CmdOpt_Engine.EnterPoint(140,50,0);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_PLANTINSERTAUTODESKCONNECTIONPOINT");
            //CmdOpt_Engine.EnterText("_last");
            //CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.SendCmd("PLANTROUTEFROMAUTODESKCONNECTIONPOINT");
			//System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.SendOption("Elevation",9,11);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(5);
			CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>");
            CmdOpt_Engine.SendCmd("_Undo 2");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_all");
            //CmdOpt_Engine.EnterCR();
            Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
