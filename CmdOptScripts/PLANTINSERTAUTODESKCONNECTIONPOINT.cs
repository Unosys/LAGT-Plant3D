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
	public class PLANTINSERTAUTODESKCONNECTIONPOINTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTINSERTAUTODESKCONNECTIONPOINT = new List<Command>
		{
			new PLANTINSERTAUTODESKCONNECTIONPOINT()
		};
	}

	public class PLANTINSERTAUTODESKCONNECTIONPOINT : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.SendOpt("_Size");
			CmdOpt_Engine.EnterText("10\"");
			CmdOpt_Engine.EnterPoint(50,50);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.SendCmd("PLANTINSERTAUTODESKCONNECTIONPOINT");
		}

		public override void Dismiss()
		{
            CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterPoint(50,50);
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
