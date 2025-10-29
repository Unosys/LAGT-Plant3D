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
	public class PLANTORTHODELETECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHODELETE = new List<Command>
		{
			new PLANTORTHODELETE()
		};
	}

	public class PLANTORTHODELETE : Command
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateOrtho() Plant3DFunctions.CreateOrtho() = Window.Current<Plant3DFunctions.CreateOrtho()>();
            Plant3DFunctions.CreateOrthoDrawingColurStyle();
			CmdOpt_Engine.SendCmd("PLANTORTHODELETE");
		}

		public override void Dismiss()
		{
			Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
			AppWnd.TypeKeys("<Esc>");
			//DeleteOrthoDrawing() DeleteOrthoDrawing() = Window.Current<DeleteOrthoDrawing()>();
			Plant3DFunctions.DeleteOrthoDrawing();
		}

		public override void Verify()
		{
		}
	}
}
