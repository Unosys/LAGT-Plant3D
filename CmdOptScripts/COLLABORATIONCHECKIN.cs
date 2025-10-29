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
using Autodesk.GUIHarness.Plant3D;
using Autodesk.GUIHarness.Plant3D.Dialogs;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
    public class COLLABORATIONCHECKINCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcCOLLABORATIONCHECKIN = new List<Command>
		{
			new COLLABORATIONCHECKIN()
		};
    }

    public class COLLABORATIONCHECKIN : Command
    {
        public override void Launch()
        {
            Plant3DFunctions.OpenCollaborationProject("Imperial_ENU_03");
            Random rand = new Random();
            String number = "Draw" + (rand.Next(2, 9));
            Plant3DFunctions.CreateVaultDrawing("P3D", "no", number);
            CmdOpt_Engine.SendCmd("_PlantCheckIn");
            System.Threading.Thread.Sleep(12000);
            CollaborationCheckInDLG CollaborationCheckInDLG = new CollaborationCheckInDLG();
            CollaborationCheckInDLG.SetActive();
            if (!CollaborationCheckInDLG.WaitExists(2000))
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
            else
            {
                CollaborationCheckInDLG.ClosePB.Click();
            }
        }

        public override void Dismiss()
        {
            Plant3DFunctions.DeleteVaultDrawing("P3D");
            Plant3DFunctions.SetToDefault();

            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D appwnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            appwnd.Exit1();
        }

        public override void Verify()
        {

        }
    }
}

