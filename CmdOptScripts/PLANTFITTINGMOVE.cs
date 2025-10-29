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
	public class PLANTFITTINGMOVECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTFITTINGMOVE = new List<Command>
		{
			new PLANTFITTINGMOVE(),
			new PLANTFITTINGMOVE_NEXT(),
            new PLANTFITTINGMOVE_COPY()
		};
	}

	public class PLANTFITTINGMOVE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTFITTINGADD");
			CmdOpt_Engine.EnterText("Elbow");
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.EnterText("8\"");
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("PLANTFITTINGMOVE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("_Last");
			CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

    public class PLANTFITTINGMOVE_NEXT : PLANTFITTINGMOVE
    {
        public override void Launch()
        {
            //CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
            Plant3DFunctions.CreateDrawing("P3D");
            CmdOpt_Engine.SendCmd("_-PLANTFITTINGADD");
            CmdOpt_Engine.EnterText("Elbow");
            CmdOpt_Engine.EnterInt(1);
            CmdOpt_Engine.EnterText("8\"");
            CmdOpt_Engine.EnterPoint(100, 50);
            CmdOpt_Engine.EnterInt(0);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTFITTINGMOVE");
            CmdOpt_Engine.EnterText("_Last");
            CmdOpt_Engine.SendOption("NEXT", 1, 2);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(130, 70);
            //DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            Plant3DFunctions.DeleteAllDrawings();
        }
    }
        public class PLANTFITTINGMOVE_COPY : PLANTFITTINGMOVE
	    {
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_-PLANTFITTINGADD");
			CmdOpt_Engine.EnterText("Elbow");
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.EnterText("8\"");
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_PLANTFITTINGMOVE");
			CmdOpt_Engine.EnterText("_Last");
			CmdOpt_Engine.SendOption("COPY", 2, 2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(130,70);
            CmdOpt_Engine.EnterInt(45);
            CmdOpt_Engine.EnterPoint(10, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterCR();
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
