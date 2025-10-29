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
	public class PLANTCUSTOMPARTSCLOSECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTCUSTOMPARTSCLOSE = new List<Command>
		{
			new PLANTCUSTOMPARTSCLOSE()
		};
	}

	public class PLANTCUSTOMPARTSCLOSE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTCUSTOMPARTS");
			CustomPartsDLG CustomPartsDLG = new CustomPartsDLG();
			if (CustomPartsDLG.Exists)
			{
				CustomPartsDLG.SetActive();
				CustomPartsDLG.TypeKeys("<Alt-F4>");
			}
			CmdOpt_Engine.SendCmd("PLANTCUSTOMPARTSCLOSE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
