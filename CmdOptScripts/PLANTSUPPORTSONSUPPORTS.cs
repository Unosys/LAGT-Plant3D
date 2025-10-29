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
	public class PLANTSUPPORTSONSUPPORTSCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSUPPORTSONSUPPORTS = new List<Command>
		{
			new PLANTSUPPORTSONSUPPORTS(),
			new PLANTSUPPORTSONSUPPORTS_Disconnect()
		};
	}

	public class PLANTSUPPORTSONSUPPORTS : Command
	{
		public override void Launch()
		{
			//CopyDrawing("P3D", "PipeSupporton CopyDrawing("P3D", "PipeSupporton = Window.Current<CopyDrawing("P3D", "PipeSupporton>();
			Plant3DFunctions.CopyDrawing("PipeSupporton.dwg");
			CmdOpt_Engine.SendCmd("PLANTSUPPORTSONSUPPORTS");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(59.8091,50.3750,110.3750);
			CmdOpt_Engine.EnterPoint(79.9654,50.3750,110.3750);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTSUPPORTSONSUPPORTS_Disconnect : PLANTSUPPORTSONSUPPORTS
	{
		public override void Launch()
		{
            CmdOpt_Engine.SendCmd("_PLANTSUPPORTSONSUPPORTS");
			CmdOpt_Engine.SendOption("Disconnect",1,1);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(59.8091,50.3750,110.3750);
			CmdOpt_Engine.EnterPoint(79.9654,50.3750,110.3750);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC>");
			//CmdOpt_Engine.SendCmd("_close");
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
			Plant3DFunctions.DeleteAllDrawings();
		}
	}
}
