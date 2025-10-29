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
	public class PLANTORTHOADJACENTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOADJACENT = new List<Command>
		{
			new PLANTORTHOADJACENT()
		};
	}

	public class PLANTORTHOADJACENT : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			//Plant3DFunctions.CreateOrtho() Plant3DFunctions.CreateOrtho() = Window.Current<Plant3DFunctions.CreateOrtho()>();
			//Plant3DFunctions.CreateOrtho();
			CmdOpt_Engine.SendCmd("_-vport");
			CmdOpt_Engine.EnterPoint(3,18);
			CmdOpt_Engine.EnterPoint(23,4);
			CmdOpt_Engine.SendCmd("_plantorthocreate");
			SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
			if (SelectReferenceModelsDLG.WaitExists(2 * 1000))
			{
				SelectReferenceModelsDLG.SetActive();
				//SelectReferenceModelsDLG.ProjectModels.Select(0);
				//SelectReferenceModelsDLG.OK.Click();
				System.Threading.Thread.Sleep(4000);
			}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("0...CreateNew");
			CmdOpt_Engine.EnterText("Ortho");
			System.Threading.Thread.Sleep(15000);
			Drawing.Current.TypeKeys("<ESC 2>");
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteDrawing();
			//DeleteOrthoDrawing() DeleteOrthoDrawing() = Window.Current<DeleteOrthoDrawing()>();
			Plant3DFunctions.DeleteOrthoDrawing();
		}

		public override void Verify()
		{
		}
	}
}
