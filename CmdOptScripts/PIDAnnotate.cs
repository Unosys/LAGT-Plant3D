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
	public class PIDAnnotateCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPIDAnnotate = new List<Command>
		{
			new PIDAnnotate()
		};
	}

	public class PIDAnnotate : Command
	{
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing("PID");
            //int rOld = Agent.GetOption(AgentOptions.OPT_KEYBOARD_DELAY);
            //Agent.SetOption(AgentOptions.OPT_KEYBOARD_DELAY, 0.2);
            CmdOpt_Engine.SendCmd("_Sline");
            CmdOpt_Engine.EnterPoint(50, 50);
            CmdOpt_Engine.EnterPoint(100, 50);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("PIDANNOTATE");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(70, 50);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(74, 50);
            Drawing.Current.TypeKeys("<Esc>");
        }

        public override void Verify()
		{
		}
	}
}
