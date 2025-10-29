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
    public class PLANTADMINPROJECTBACKUPCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTADMINPROJECTBACKUP = new List<Command>
		{
			new PLANTADMINPROJECTBACKUP()
		};
    }

    public class PLANTADMINPROJECTBACKUP : Command
    {
        public override void Launch()
        {
            Plant3DFunctions.CreateProj();
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            ProjManUndocked.Plant3DDrawingsTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Down 3><Enter>");
            SelectDrawingsToCopyToProDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PP2equipment.dwg");
            SelectDrawingsToCopyToProDLG.Open.Click();
            System.Threading.Thread.Sleep(4000);
            CmdOpt_Engine.SendCmd("PLANTADMINPROJECTBACKUP");
            System.Threading.Thread.Sleep(4000);
            PlantProjectBackupDLG PlantProjectBackupDLG = new PlantProjectBackupDLG();
            if (!PlantProjectBackupDLG.Exists)
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
            else
            {
                PlantProjectBackupDLG.Dismiss();
            }
        }

        public override void Dismiss()
        {
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }
}
