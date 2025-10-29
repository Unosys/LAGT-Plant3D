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
    public class PLANTATTACHEXTERNALREFRENCESFORCOLLABORATIONCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTATTACHEXTERNALREFRENCESFORCOLLABORATION = new List<Command>
		{
			new PLANTATTACHEXTERNALREFRENCESFORCOLLABORATION()
		};
    }

    public class PLANTATTACHEXTERNALREFRENCESFORCOLLABORATION : Command
    {
        public override void Launch()
        {
            Plant3DFunctions.OpenCollaborationProject("Auto");//Imperail_ENU_03
            Plant3DFunctions.CreateDrawing("P3D");
            CmdOpt_Engine.SendCmd("_PLANTATTACH");
            System.Threading.Thread.Sleep(4000);
            AttachExternalReferencesForCollaborationDLG AttachExternalReferencesForCollaborationDLG = new AttachExternalReferencesForCollaborationDLG();
            if (!AttachExternalReferencesForCollaborationDLG.Exists)
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
            else
            {
                AttachExternalReferencesForCollaborationDLG.ClosePB.Click();
            }
        }

        public override void Dismiss()
        {
            Plant3DFunctions.DeleteClaudDrawing("P3D");
            Plant3DFunctions.SetToDefault();
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D appwnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            appwnd.Exit1();
        }

        public override void Verify()
        {

        }
    }
}

