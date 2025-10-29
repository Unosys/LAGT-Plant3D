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
	public class PLANTPIPESUPPORTCONVERTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPIPESUPPORTCONVERT = new List<Command>
		{
			new PLANTPIPESUPPORTCONVERT()
		};
	}

	public class PLANTPIPESUPPORTCONVERT : Command
	{
		public override void Launch()
		{
			//Plant3DFunctions.CopyDrawing("AUTODESKCONNECTIONPOINT.dwg");
			//CmdOpt_Engine.SendCmd("_Zoom");
			//CmdOpt_Engine.SendOpt("_Extents");
			//CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTADD");
			//         System.Threading.Thread.Sleep(5000);
			//         AddPipeSupportDLG AddPipeSupportDLG = Window.Current<AddPipeSupportDLG>();
			//AddPipeSupportDLG.SetActive();
			//System.Threading.Thread.Sleep(5000);
			//AddPipeSupportDLG.Click(MouseButton.Left, 290, 171);
			//AddPipeSupportDLG.OK.Click();
			//CmdOpt_Engine.EnterPoint(50,50,100);
			//CmdOpt_Engine.EnterAngle(90);
			//CmdOpt_Engine.EnterCR();

			////Drawing.Current.TypeKeys("<ESC>");
			////Drawing.Current.TypeKeys("<ESC>");
			////Drawing.Current.SetSysVar("DYNMODE", 0);
			//CmdOpt_Engine.SendCmd("_Zoom");
			//CmdOpt_Engine.SendOpt("_E");
			//CmdOpt_Engine.SendCmd("PLANTPIPESUPPORTCONVERT");
			//CmdOpt_Engine.EnterText("_last");
			//CmdOpt_Engine.EnterCR();
			//CmdOpt_Engine.EnterPoint(139.812,50.420,0);
			//Drawing.Current.TypeKeys("<ESC>");
			Plant3DFunctions.CreateDrawing("P3D");
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50, 50);
			CmdOpt_Engine.EnterPoint(100, 50);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("DYNMODE", 0);
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_E");
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTADD");
			System.Threading.Thread.Sleep(5000);
			AddPipeSupportDLG AddPipeSupportDLG = Window.Current<AddPipeSupportDLG>();
			AddPipeSupportDLG.SetActive();
			System.Threading.Thread.Sleep(10000);
			AddPipeSupportDLG.Click(MouseButton.Left, 121, 171);
			AddPipeSupportDLG.OK.Click();
			CmdOpt_Engine.EnterPoint(50, 45.4200);
			CmdOpt_Engine.EnterAngle(90);
			CmdOpt_Engine.EnterCR();
			//CmdOpt_Engine.EnterCR();
			//Drawing.Current.TypeKeys("<ESC>");
			//Drawing.Current.TypeKeys("<ESC>");
			CmdOpt_Engine.SendCmd("PLANTPIPESUPPORTCONVERT");
		}

		public override void Dismiss()
        {           CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(139.812, 50.420, 0);
            Drawing.Current.TypeKeys("<ESC>");
            Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
