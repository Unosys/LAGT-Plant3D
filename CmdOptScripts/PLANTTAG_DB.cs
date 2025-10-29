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
	public class PLANTTAG_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTTAG_DB = new List<Command>
		{
			new PLANTTAG_DB()
		};
	}

	public class PLANTTAG_DB : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(10,10);
			CmdOpt_Engine.EnterPoint(20,20);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("PLANTTAG");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("DYNMODE", 0);
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteDrawing();
		}

		public override void Verify()
		{
		}
	}
}
