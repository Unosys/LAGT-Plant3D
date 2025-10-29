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
	public class PIDTag_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPIDTag_DB = new List<Command>
		{
			new PIDTag_DB()
		};
	}

    public class PIDTag_DB : Command
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing("PID");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_All");
            //CmdOpt_Engine.EnterCR();
            //Drawing.Current.TypeE("_ZOOM");
            //Drawing.Current.TypeE("_EXTENTS");
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            Drawing.Current.TypeE("_s");
            Drawing.Current.TypeE("Primary Style");
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("PIDTAG");
            CmdOpt_Engine.EnterPoint(8, 12);
            CmdOpt_Engine.EnterCR();
            System.Threading.Thread.Sleep(7000);
            PandIDAssignTagDLG AssignTagDLG = new PandIDAssignTagDLG();
            if (AssignTagDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
            {
                AssignTagDLG.CancelPB.Click();
                //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
                //PROJECTMANAGERDLG.Invoke();
            }
            else
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
                //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
                //PROJECTMANAGERDLG.Invoke();
            }
        }

        public override void Dismiss()
        {
        }

        public override void Verify()
        {
        }
    }
}
