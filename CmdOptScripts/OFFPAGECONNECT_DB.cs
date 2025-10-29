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
    public class OFFPAGECONNECT_DBCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcOFFPAGECONNECT_DB = new List<Command>
        {
            new OFFPAGECONNECT_DB()
        };
    }

    public class OFFPAGECONNECT_DB : Command
    {
        public override void Launch()
        {
            //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            //PROJECTMANAGERDLG.Invoke();
            //Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            ////ExpandTreePID(wTreeView,3,1,1) ExpandTreePID(wTreeView,3,1,1) = Window.Current<ExpandTreePID(wTreeView,3,1,1)>();
            //PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "1, 1");
            //SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = Window.Current<SelectDrawingsToCopyToProDLG>();
            //SelectDrawingsToCopyToProDLG.SetActive();
            //SelectDrawingsToCopyToProDLG.FileName.Text = LAGT.CommonFiles.Product.Variables.TestFilesDir + "OffPageConector.dwg";
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
            //string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + PandIDMainWin.AcadRoot + "\\" + PandIDMainWin.AcadNumber, "DefaultProject", "") as string;
            //string sFileName = sProjectPath + "PID_DWG\\OffPageConector.dwg";
            //Drawing.Current.TypeE("_Open");
            //Drawing.Current.TypeKeys(sFileName);
            //Drawing.Current.TypeKeys("<Enter>");
            //CmdOpt_Engine.SendCmd("_ZOOM");
            //CmdOpt_Engine.SendOpt("_Extents");
            //System.Threading.Thread.Sleep(1000);
            PandIDFunctions.CopyDrawing("OffPageConector.dwg");
            CmdOpt_Engine.StartLog();
            CmdOpt_Engine.SendCmd("_ZOOM");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("OFFPAGECONNECT");
            CmdOpt_Engine.EnterPoint(26.8487, 24.2053);
            //CmdOpt_Engine.EnterPoint(26.6,24);
            System.Threading.Thread.Sleep(4000);
            PandIDCreateConnectionDLG PandIDCreateConnectionDLG = new PandIDCreateConnectionDLG();
            if (!PandIDCreateConnectionDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
            else
            {
                PandIDCreateConnectionDLG.SetActive();
                PandIDCreateConnectionDLG.Dismiss();
            }
        }

        public override void Dismiss()
        {
            //DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            PandIDFunctions.DeleteAllDrawings();
        }

        public override void Verify()
        {
        }
    }
}
