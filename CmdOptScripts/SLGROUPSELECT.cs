using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using ProductTestSuite.CommonFiles;
using Autodesk.GUIHarness.Plant3D.Dialogs;

using LAGT.CommonFiles.Classes;
namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
    public class SLGROUPSELECTCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcSLGROUPSELECT = new List<Command>
        {
            new SLGROUPSELECT()
        };
    }

    public class SLGROUPSELECT : Command
    {
        public override void Launch()
        {
            //CreateDrawing() CreateDrawing() = Window.Current<CreateDrawing()>();
            PandIDFunctions.CreateDrawing("PID");
            //CmdOpt_Engine.SendCmd("_Erase");
            //CmdOpt_Engine.SendOpt("_All");
            //CmdOpt_Engine.EnterCR();
            //Drawing.Current.TypeE("_ZOOM");
            //Drawing.Current.TypeE("_EXTENTS");
            ////CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(14, 3);
            CmdOpt_Engine.EnterPoint(14, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroup");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterPoint(14.05, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("SLGROUPSELECT");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(8.05, 10);
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }
}
