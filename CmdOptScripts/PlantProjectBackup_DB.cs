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
    public class PlantProjectBackup_DBCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPlantProjectBackup_DB = new List<Command>
		{
			new PLANTPROJECTBACKUP_DB()
		};
    }

    public class PLANTPROJECTBACKUP_DB : Command
    {
        public override void Launch()
        {
            Plant3DFunctions.CreateProj();
            Plant3DFunctions.CreateDrawing("P3D");
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
            
        }

        public override void Verify()
        {
        }
    }
}
