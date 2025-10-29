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
using Autodesk.GUIHarness.Plant3D;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
    public class ExportToAutoCAD_DBCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcExportToAutoCAD_DB = new List<Command>
        {
            new ExportToAutoCAD_DB()
        };
    }

    public class ExportToAutoCAD_DB : Command
    {
        public override void Launch()
        {

            PandIDFunctions.CreateDrawing();
            CmdOpt_Engine.SendCmd("_Save ");
            //Drawing.Current.TypeKeys("<Enter>");
            System.Threading.Thread.Sleep(1000);
            //CmdOpt_Engine.SendOpt("_YES");
            CmdOpt_Engine.SendCmd("EXPORTTOAUTOCAD");
            System.Threading.Thread.Sleep(1000);
            PandIDExportToAutoCADDLG PandIDExportToAutoCADDLG = new PandIDExportToAutoCADDLG();
            if (PandIDExportToAutoCADDLG.WaitExists(2000))
            {
                PandIDExportToAutoCADDLG.Cancel.Click();
                //Drawing.Current.TypeKeys("<ESC>");
            }
            else
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
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
