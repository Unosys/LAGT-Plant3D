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
    public class PLANTUNDOCHECKOUTCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTUNDOCHECKOUT = new List<Command>
		{
			new PLANTUNDOCHECKOUT()
		};
    }

    public class PLANTUNDOCHECKOUT : Command
    {
        public override void Launch()
        {
            CollaborationCheckInDLG CollaborationCheckInDLG = new CollaborationCheckInDLG();
            CollaborationCheckInDLG.Invoke();
            CollaborationCheckInDLG.OKPB.Click();
            System.Threading.Thread.Sleep(9000);
            PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 10, "0,2,1");
            System.Threading.Thread.Sleep(3000);
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2,1");
            System.Threading.Thread.Sleep(4000);
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(20,100);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTUNDOCHECKOUT");
            PlantUndoCheckOutDLG PlantUndoCheckOutDLG = new PlantUndoCheckOutDLG();
            PlantUndoCheckOutDLG.SetActive();
            if (!PlantUndoCheckOutDLG.WaitExists(2000))
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
   
            }
            else
            {
                PlantUndoCheckOutDLG.CancelPB.Click();
            }

        }

        public override void Dismiss()
        {
            //Plant3DFunctions.DeleteVaultDrawing("P3D");
            Plant3DFunctions.SetToDefault();
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D appwnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            appwnd.Exit1();
        }

        public override void Verify()
        {

        }
    }
}

