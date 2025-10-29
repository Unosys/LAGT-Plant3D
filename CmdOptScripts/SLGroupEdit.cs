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
    public class SLGroupEditCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcSLGroupEdit = new List<Command>
        {
            new SLGroupEdit(),
            new SLGroupEdit_Add(),
            new SLGroupEdit_Linenumber(),
            new SLGroupEdit_Service(),
            new SLGroupEdit_Remove(),
            new SLGroupEdit_Ungroup()
        };
    }

    public class SLGroupEdit : Command
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
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(12, 3);
            CmdOpt_Engine.EnterPoint(12, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("SLGroupEdit");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(12, 10);
            CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            //PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }

    public class SLGroupEdit_Add : SLGroupEdit
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            //PandIDFunctions.CreateDrawing();
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            //Drawing.Current.TypeE("_ZOOM");
            //Drawing.Current.TypeE("_EXTENTS");
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(12, 3);
            CmdOpt_Engine.EnterPoint(12, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroup");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterPoint(12.05, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroupEdit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Add", 1, 5);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            //PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }
    public class SLGroupEdit_Linenumber : SLGroupEdit
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            //PandIDFunctions.CreateDrawing();
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            //Drawing.Current.TypeE("_ZOOM");
            //Drawing.Current.TypeE("_EXTENTS");
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(12, 3);
            CmdOpt_Engine.EnterPoint(12, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroup");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterPoint(12.05, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroupEdit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("_a");
            CmdOpt_Engine.EnterPoint(12, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendOption("Linenumber", 4, 5);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            //PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }

    public class SLGroupEdit_Service : SLGroupEdit
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            //PandIDFunctions.CreateDrawing();
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            //Drawing.Current.TypeE("_ZOOM");
            //Drawing.Current.TypeE("_EXTENTS");
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(12, 3);
            CmdOpt_Engine.EnterPoint(12, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroup");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterPoint(12.05, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroupEdit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("_a");
            CmdOpt_Engine.EnterPoint(12, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendOption("Service", 5, 5);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
        }

        public override void Verify()
        {
        }
    }
    public class SLGroupEdit_Remove : SLGroupEdit
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            //PandIDFunctions.CreateDrawing();
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            //Drawing.Current.TypeE("_ZOOM");
            //Drawing.Current.TypeE("_EXTENTS");
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(12, 3);
            CmdOpt_Engine.EnterPoint(12, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroup");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterPoint(12.05, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroupEdit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Remove", 2, 5);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            //PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }
    public class SLGroupEdit_Ungroup : SLGroupEdit
    {
        public override void Launch()
        {
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            //PandIDFunctions.CreateDrawing();
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            //Drawing.Current.TypeE("_ZOOM");
            //Drawing.Current.TypeE("_EXTENTS");
            //CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(12, 3);
            CmdOpt_Engine.EnterPoint(12, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroup");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterPoint(12.05, 10);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLGroupEdit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Ungroup", 3, 5);
        }

        public override void Dismiss()
        {
            //CmdOpt_Engine.EnterPoint(8.05, 10);
            //CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.EnterCR();
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
