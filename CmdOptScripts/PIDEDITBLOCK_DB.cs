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
    public class PIDEDITBLOCK_DBCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPIDEDITBLOCK_DB = new List<Command>
        {
            new PIDEDITBLOCK_DB()
        };
    }

    public class PIDEDITBLOCK_DB : Command
    {
        public override void Launch()
        {
            //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            //PROJECTMANAGERDLG.Invoke();
            //Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //PandIDFunctions.ExpandTreeP3D(wTreeView,3,"1,1");
            //SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = Window.Current<SelectDrawingsToCopyToProDLG>();
            //SelectDrawingsToCopyToProDLG.SetActive();
            //SelectDrawingsToCopyToProDLG.FileName.Text = LAGT.CommonFiles.Product.Variables.TestFilesDir + "TagEquipment.dwg";
            //SelectDrawingsToCopyToProDLG.Open.Click();
            //System.Threading.Thread.Sleep(5000);
            //Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
            //if (Plant3DProjectSomeFilesDLG.WaitExists(3 * 1000))
            //{
            //    Plant3DProjectSomeFilesDLG.SetActive();
            //    Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            //}
            //ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            //if (ProjectDataMergedDLG.WaitExists(5 * 1000))
            //{
            //    ProjectDataMergedDLG.SetActive();
            //    ProjectDataMergedDLG.BtnOk.Click();
            //}
            PandIDFunctions.CopyDrawing("PandID\\TagEquipment.dwg");
            //PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "1, 1, 1");
            CmdOpt_Engine.SendCmd("PIDEDITBLOCK");
            CmdOpt_Engine.EnterPoint(11.7, 12.8);
            System.Threading.Thread.Sleep(5000);
            PandIDEditPIDObjectSBlockDLG PandIDEditPIDObjectSBlockDLG = new PandIDEditPIDObjectSBlockDLG();
            if (!PandIDEditPIDObjectSBlockDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
            else
            {
                //EditPIDObjectSBlockDLG.SetActive();
                PandIDEditPIDObjectSBlockDLG.Dismiss();
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

