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
	public class PLANTSTEELLADDERCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELLADDER = new List<Command>
		{
			new PLANTSTEELLADDER(),
            new PLANTSTEELLADDER_Settings()
		};
	}

	public class PLANTSTEELLADDER : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELLADDER");
			CmdOpt_Engine.EnterPoint(658,120);
			CmdOpt_Engine.EnterPoint(1650,800);
			CmdOpt_Engine.EnterPoint(300,200);
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
    public class PLANTSTEELLADDER_Settings : PLANTSTEELLADDER
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_erase _all ");
            CmdOpt_Engine.SendCmd("_PLANTSTEELLADDER");
            CmdOpt_Engine.SendOption("Settings", 1, 1);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 2>"); ;
            Plant3DFunctions.DeleteAllDrawings();
        }

        public override void Verify()
        {
        }
    }
}
