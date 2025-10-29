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
	public class PLANTORTHOLOCATECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOLOCATE = new List<Command>
		{
			new PLANTORTHOLOCATE()
		};
	}

	public class PLANTORTHOLOCATE : Command
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateOrtho() Plant3DFunctions.CreateOrtho() = Window.Current<Plant3DFunctions.CreateOrtho()>();
            Plant3DFunctions.CreateOrthoDrawingColurStyle();
			CmdOpt_Engine.SendCmd("_Line");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(50,20);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("PLANTORTHOLOCATE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("_Last");
			//DeleteOrthoDrawing() DeleteOrthoDrawing() = Window.Current<DeleteOrthoDrawing()>();
			Plant3DFunctions.DeleteOrthoDrawing();
		//	CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}
}
