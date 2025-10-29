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
	public class PLANTPIPESUPPORTADDCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPIPESUPPORTADD = new List<Command>
		{
			new PLANTPIPESUPPORTADD()
		};
	}

	public class PLANTPIPESUPPORTADD : Command
	{
		public override void Launch()
		{
			////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.EnterPoint(100,50,0);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("DYNMODE", 0);
			CmdOpt_Engine.SendCmd("PLANTPIPESUPPORTADD");
            System.Threading.Thread.Sleep(5000);
            AddPipeSupportDLG AddPipeSupportDLG = Window.Current<AddPipeSupportDLG>();
			AddPipeSupportDLG.SetActive();
			System.Threading.Thread.Sleep(5000);
			AddPipeSupportDLG.MBtnFilter3.Select();
			System.Threading.Thread.Sleep(5000);
			AddPipeSupportDLG.Click(MouseButton.Left, 121, 171);
			AddPipeSupportDLG.OK.Click();
			CmdOpt_Engine.EnterPoint(50,50,0);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTADD_Basepoint : PLANTPIPESUPPORTADD
	{
		public override void Launch()
		{
			//ShowManualSteps(PLANTPIPESUPPORTADD);
			CmdOpt_Engine.SendOption("Base point",1,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(70,50);
			CmdOpt_Engine.SendOpt("_Exit");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTADD_Undo : PLANTPIPESUPPORTADD
	{
		public override void Launch()
		{
			//ShowManualSteps(PLANTPIPESUPPORTADD);
			CmdOpt_Engine.SendOption("Undo",2,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_Exit");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPIPESUPPORTADD_eXit : PLANTPIPESUPPORTADD
	{
		public override void Launch()
		{
			//ShowManualSteps(PLANTPIPESUPPORTADD);
			CmdOpt_Engine.SendOption("eXit",3,3);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
