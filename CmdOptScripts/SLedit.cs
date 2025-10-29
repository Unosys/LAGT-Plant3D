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
    public class SLeditCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcSLedit = new List<Command>
        {
            new SLedit(),
            new SLedit_Attach(),
            new SLedit_Detach(),
            new SLedit_Gap(),
            new SLedit_uNgap(),
            new SLedit_Straighten(),
            new SLedit_Corner(),
            new SLedit_Reverseflow(),
            new SLedit_Join(),
            new SLedit_Link(),
            new SLedit_Unlink(),
            new SLedit_Break(),
            new SLedit_eXit()
        };
    }

    public class SLedit : Command
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
            ////CmdOpt_Engine.SendCmd("_ProjectManagerClose");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("SLedit");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("_eXit");
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            //PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }

    public class SLedit_Attach : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Attach", 1, 12);
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

    public class SLedit_Detach : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Detach", 2, 12);
        }

        public override void Dismiss()
        {
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

    public class SLedit_Gap : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Gap", 3, 12);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterPoint(8.05, 12);
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

    public class SLedit_uNgap : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("uNgap", 4, 12);
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

    public class SLedit_Straighten : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Straighten", 5, 12);
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

    public class SLedit_Corner : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Corner", 6, 12);
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

    public class SLedit_Reverseflow : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Reverseflow", 7, 12);
        }

        public override void Dismiss()
        {
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

    public class SLedit_Join : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Join", 8, 12);
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

    public class SLedit_Break : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8, 10);
            CmdOpt_Engine.SendOption("Break", 9, 12);
        }

        public override void Dismiss()
        {
            //Drawing.Current.TypeKeys("8,12 8,15  ");
            Drawing.Current.TypeKeys("<ESC 3>"); //nothing else works
                                                 //CmdOpt_Engine.EnterPoint(8,12);
                                                 //CmdOpt_Engine.EnterPoint(8,15);
                                                 //CmdOpt_Engine.EnterCR();
                                                 //CmdOpt_Engine.EnterCR();
                                                 //CmdOpt_Engine.SendCmd("_ProjectManager");
                                                 //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
                                                 //PandIDFunctions.DeleteAllDrawings();
                                                 //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }

    public class SLedit_Link : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Link", 10, 12);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(8.05, 10);
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

    public class SLedit_Unlink : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Unlink", 11, 12);
        }

        public override void Dismiss()
        {
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

    public class SLedit_eXit : SLedit
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
            PandIDAlertAddDwgDLG PandIDAlertAddDwgDLG = new PandIDAlertAddDwgDLG();
            if (PandIDAlertAddDwgDLG.Exists)
            {
                PandIDAlertAddDwgDLG.Yes.Click();
                CmdOpt_Engine.SendCmd("_Sline");
            }
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLedit");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("eXit", 12, 12);
        }

        public override void Dismiss()
        {
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
            //WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            //if (WarningAutoCADDLG.Exists)
            //{
            //    WarningAutoCADDLG.No.Click();
            //}
        }

        public override void Verify()
        {
        }
    }
}
