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
	public class PIDConvertCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPIDConvert = new List<Command>
		{
			new PIDConvert()
		};
	}

    public class PIDConvert : Command
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing("PID");
            CmdOpt_Engine.SendCmd("_Sline");
            CmdOpt_Engine.EnterPoint(50, 50);
            CmdOpt_Engine.EnterPoint(100, 50);
            if (!Drawing.Current.ReadyForNextCommand())
            {
                CmdOpt_Engine.EnterCR();
            }
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("PIDCONVERT");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(70, 50);
            CmdOpt_Engine.EnterCR();
            //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            //PROJECTMANAGERDLG.Invoke();
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }
}
