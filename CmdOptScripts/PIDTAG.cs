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
    public class PIDTAGCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPIDTAG = new List<Command>
        {
            new PIDTAG()
        };
    }

    public class PIDTAG : Command
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing("PID");
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            AlertAddDwgDLG AlertAddDwgDLG = new AlertAddDwgDLG();
            if (AlertAddDwgDLG.Exists)
            {
                AlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.SendOpt("_S");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            if (!Drawing.Current.ReadyForNextCommand())
            {
                CmdOpt_Engine.EnterCR();
            }
            CmdOpt_Engine.SendCmd("PIDTAG");
            CmdOpt_Engine.EnterPoint(8, 12);
            CmdOpt_Engine.EnterCR();
            System.Threading.Thread.Sleep(1000);
            PandIDAssignTagDLG AssignTagDLG = new PandIDAssignTagDLG();
            AssignTagDLG.SetActive();
            AssignTagDLG.CancelPB.Click();
        }

        public override void Dismiss()
        {
        }

        public override void Verify()
        {
        }
    }

    public class PIDTAG_SIZE : PIDTAG
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing("PID");
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            AlertAddDwgDLG AlertAddDwgDLG = new AlertAddDwgDLG();
            if (AlertAddDwgDLG.Exists)
            {
                AlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.SendOpt("_s");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            if (!Drawing.Current.ReadyForNextCommand())
            {
                CmdOpt_Engine.EnterCR();
            }
            CmdOpt_Engine.SendCmd("_PIDTAG");
            CmdOpt_Engine.EnterPoint(8, 12);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendOption("Size", 1, 4);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC>");
            Drawing.Current.TypeKeys("<ESC>");
        }

        public override void Verify()
        {
        }
    }

    public class PIDTAG_SPEC : PIDTAG
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing();
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            AlertAddDwgDLG AlertAddDwgDLG = new AlertAddDwgDLG();
            if (AlertAddDwgDLG.Exists)
            {
                AlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.SendOpt("_s");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            if (!Drawing.Current.ReadyForNextCommand())
            {
                CmdOpt_Engine.EnterCR();
            }
            CmdOpt_Engine.SendCmd("_PIDTAG");
            CmdOpt_Engine.EnterPoint(8, 12);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendOption("Spec", 2, 4);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC>");
            Drawing.Current.TypeKeys("<ESC>");
        }

        public override void Verify()
        {
        }
    }

    public class PIDTAG_SERVICE : PIDTAG
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing();
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            AlertAddDwgDLG AlertAddDwgDLG = new AlertAddDwgDLG();
            if (AlertAddDwgDLG.Exists)
            {
                AlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.SendOpt("_s");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            if (!Drawing.Current.ReadyForNextCommand())
            {
                CmdOpt_Engine.EnterCR();
            }
            CmdOpt_Engine.SendCmd("_PIDTAG");
            CmdOpt_Engine.EnterPoint(8, 12);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendOption("Service", 3, 4);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC>");
            Drawing.Current.TypeKeys("<ESC>");
        }

        public override void Verify()
        {
        }
    }

    public class PIDTAG_LINENUMBER : PIDTAG
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing();
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            AlertAddDwgDLG AlertAddDwgDLG = new AlertAddDwgDLG();
            if (AlertAddDwgDLG.Exists)
            {
                AlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.SendOpt("_s");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            if (!Drawing.Current.ReadyForNextCommand())
            {
                CmdOpt_Engine.EnterCR();
            }
            CmdOpt_Engine.SendCmd("_PIDTAG");
            CmdOpt_Engine.EnterPoint(8, 12);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendOption("LineNumber", 4, 4);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC>");
            Drawing.Current.TypeKeys("<ESC>");
        }

        public override void Verify()
        {
        }
    }
}
