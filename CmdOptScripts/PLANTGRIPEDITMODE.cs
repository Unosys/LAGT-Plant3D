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
	public class PLANTGRIPEDITMODECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTGRIPEDITMODE = new List<Command>
		{
			new PLANTGRIPEDITMODE(),
			new PLANTGRIPEDITMODE_PIPESEGMENT(),
			new PLANTGRIPEDITMODE_PIPELINE()
		};
	}

	public class PLANTGRIPEDITMODE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTGRIPEDITMODE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_pipeSegment");
			//Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTGRIPEDITMODE_PIPESEGMENT : PLANTGRIPEDITMODE
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PLANTGRIPEDITMODE");
			CmdOpt_Engine.SendOption("pipeSegment",1,2);
		}

		public override void Dismiss()
		{
            Drawing.Current.TypeKeys("<ESC>");
            //Plant3DFunctions.DeleteAllDrawings();
        }

		public override void Verify()
		{
		}
	}

	public class PLANTGRIPEDITMODE_PIPELINE : PLANTGRIPEDITMODE
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PLANTGRIPEDITMODE");
			CmdOpt_Engine.SendOption("pipeLine",2,2);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
            Plant3DFunctions.DeleteAllDrawings();
        }

		public override void Verify()
		{
		}
	}
}
