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
	public class PLANTREMOVEORPHANFASTENERSCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTREMOVEORPHANFASTENERS = new List<Command>
		{
			new PLANTREMOVEORPHANFASTENERS()
		};
	}

	public class PLANTREMOVEORPHANFASTENERS : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTREMOVEORPHANFASTENERS");
		}

		public override void Dismiss()
		{
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteDrawing();
		}

		public override void Verify()
		{
		}
	}
}
