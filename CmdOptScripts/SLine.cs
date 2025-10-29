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
    public class SLineCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcSLine = new List<Command>
        {
            new SLine(),
            new SLine_Style(),
            new SLine_CotinueSlineGroup(),
            new SLine_NewSlineGroup(),
            new SLine_Linkslinesegment(),
            new SLine_Undo()
        };
    }

    public class SLine : Command
    {
        public override void Launch()
        {

            PandIDFunctions.CreateDrawing("PID");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("SLINE");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.EnterPoint(14, 7);
            CmdOpt_Engine.EnterCR();

        }

        public override void Verify()
        {
        }
    }

    public class SLine_Style : SLine
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLINE");
            CmdOpt_Engine.SendOption("Style", 1, 1);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.EnterPoint(14, 7);
            CmdOpt_Engine.EnterCR();

        }

        public override void Verify()
        {
        }
    }

    public class SLine_CotinueSlineGroup : SLine
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLINE");
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.SendOption("Continue sline group", 1, 4);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.EnterPoint(14, 7);
            Drawing.Current.TypeKeys("<ESC><ESC>");
        }

        public override void Verify()
        {
        }
    }

    public class SLine_NewSlineGroup : SLine
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLINE");
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.SendOption("New sline group", 2, 4);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(14, 7);
            CmdOpt_Engine.EnterCR();

        }

        public override void Verify()
        {
        }
    }

    public class SLine_Linkslinesegment : SLine
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLINE");
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.EnterPoint(20, 16);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_ZOOM");
            CmdOpt_Engine.SendOption("_E");
            CmdOpt_Engine.SendCmd("_SLINE");
            CmdOpt_Engine.EnterPoint(14, 8);
            CmdOpt_Engine.SendOption("Link sline segment", 3, 4);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.EnterCR();

        }

        public override void Verify()
        {
        }
    }

    public class SLine_Undo : SLine
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLINE");
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.SendOption("Undo", 4, 4);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(14, 16);
            CmdOpt_Engine.EnterPoint(20, 16);
            CmdOpt_Engine.EnterCR();
            PandIDFunctions.DeleteAllDrawings();
        }

        public override void Verify()
        {
        }
    }
}
