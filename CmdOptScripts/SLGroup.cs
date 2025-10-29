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
    public class SLGroupCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcSLGroup = new List<Command>
        {
            new SLGroup(),
            new SLGroup_Linenumber(),
            new SLGroup_Linenumber_Nextavailable(),
            new SLGroup_Service(),
            new SLGroup_Service_Nextavailable()
        };
    }

    public class SLGroup : Command
    {
        public override void Launch()
        {
            PandIDFunctions.CreateDrawing("PID");
            CmdOpt_Engine.SendCmd("_Model");
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(8, 3);
            CmdOpt_Engine.EnterPoint(8, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_SLine");
            CmdOpt_Engine.EnterPoint(12, 3);
            CmdOpt_Engine.EnterPoint(12, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("SLGroup");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.EnterPoint(12.05, 10);
            CmdOpt_Engine.EnterCR();
            Plant3DFunctions.DeleteDrawing("PID");
        }

        public override void Verify()
        {
        }
    }

    public class SLGroup_Linenumber : SLGroup
    {
        public override void Launch()
        {
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
            CmdOpt_Engine.SendCmd("_SLGroup");
            CmdOpt_Engine.EnterPoint(8.05, 10);
            CmdOpt_Engine.SendOption("Linenumber", 1, 2);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC 3>");
            Plant3DFunctions.DeleteDrawing("PID");
            //DialogBox Registered = new DialogBox("[DialogBox]Etiquette en cours d'utilisation|#1");
            //if (Registered.WaitExists(100))
            //{
            //    CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Unexpected Dialog was invoked.", "", "", "");
            //    CmdOpt_ErrorReport.ReportError(sError);
            //    //int iCount = 1;
            //    //while (Registered.WaitExists(100))
            //    //{
            //    Desktop.Current.TypeKeys("<ESC 3>");
            //    System.Threading.Thread.Sleep(1000);
            //    Drawing.Current.TypeKeys("<Esc 3>");
            //    //CmdOpt_Engine.EnterInt(iCount);
            //    //iCount++;
            //    //}
            //}
            //else
            //{
            //CmdOpt_Engine.EnterCR();
            //}
            //CmdOpt_Engine.EnterInt(1);// .SendOpt("1");
            //CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            //PandIDFunctions.DeleteAllDrawings();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }

    public class SLGroup_Linenumber_Nextavailable : SLGroup
    {
        public override void Launch()
        {
            PandIDFunctions.CreateDrawing("PID");
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
            CmdOpt_Engine.SendOpt("_Linenumber");
            CmdOpt_Engine.SendOption("Nextavailable", 2, 2);

            //DialogBox Registered = new DialogBox("[DialogBox]Etiquette en cours d'utilisation|#1");
            //if (Registered.WaitExists(100))
            //{
            //    CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Unexpected Dialog was invoked.", "", "", "");
            //    CmdOpt_ErrorReport.ReportError(sError);
            //    int iCount = 1;
            //    while (Registered.WaitExists(100))
            //    {
            //        Desktop.Current.TypeKeys("<ESC 3>");
            //        System.Threading.Thread.Sleep(1000);
            //        Drawing.Current.TypeKeys("<Esc 3>");
            //        CmdOpt_Engine.EnterInt(iCount);
            //        iCount++;
            //    }
            //}
            //else
            //{
            //    CmdOpt_Engine.EnterCR();
            //}
            var Registered = new TaginUseDLG();
            if (Registered.WaitExists(100))
            {
                //CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Unexpected Dialog was invoked.", "", "", "");
                //CmdOpt_ErrorReport.ReportError(sError);
                int iCount = 1;
                while (Registered.WaitExists(100))
                {
                    Registered.OKPB.Click();
                    CmdOpt_Engine.EnterInt(iCount);
                    iCount++;
                }
            }
            else
            {
                CmdOpt_Engine.EnterCR();
            }
        }

        public override void Dismiss()
        {
            //CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 3>");
            Plant3DFunctions.DeleteDrawing("PID");
           
        }

        public override void Verify()
        {
        }
    }

    public class SLGroup_Service : SLGroup
    {
        public override void Launch()
        {
            PandIDFunctions.CreateDrawing("PID");
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
            CmdOpt_Engine.SendOption("Service", 2, 2);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<Esc 3>");
            Plant3DFunctions.DeleteDrawing("PID");
        }

        public override void Verify()
        {
        }
    }

    public class SLGroup_Service_Nextavailable : SLGroup
    {
        public override void Launch()
        {
            PandIDFunctions.CreateDrawing("PID");
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
            CmdOpt_Engine.SendOpt("_Service");
            CmdOpt_Engine.SendOption("Nextavailable", 2, 2);
            var Registered = new TaginUseDLG();
            if (Registered.WaitExists(100))
            {
                //CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Unexpected Dialog was invoked.", "", "", "");
                //CmdOpt_ErrorReport.ReportError(sError);
                int iCount = 1;
                while (Registered.WaitExists(100))
                {
                    Registered.OKPB.Click();
                    CmdOpt_Engine.EnterInt(iCount);
                    iCount++;
                }
            }
            else
            {
                CmdOpt_Engine.EnterCR();
            }
        }

        public override void Dismiss()
        {
           
            Drawing.Current.TypeKeys("<Esc 3>");
            Plant3DFunctions.DeleteDrawing("PID");

        }

        public override void Verify()
        {
        }
    }
}
