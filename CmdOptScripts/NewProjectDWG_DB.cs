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
	public class NewProjectDWG_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcNewProjectDWG_DB = new List<Command>
		{
			new NewProjectDWG_DB()
		};
	}

	public class NewProjectDWG_DB : Command
	{
		public override void Launch()
		{
			//DlgBoxStringsinit() DlgBoxStringsinit() = Window.Current<DlgBoxStringsinit()>();
			//DlgBoxStringsinit(); //cannot find this function!
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			//PROJECTMANAGERDLG PROJECTMANAGERDLG = Window.Current<PROJECTMANAGERDLG>();
			PROJECTMANAGERDLG.Undock();
			PROJECTMANAGERDLG.SetActive();
			Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			//gCmdOpt_Variables gCmdOpt_Variables = new gCmdOpt_Variables();
            //if (gCmdOpt_Variables.sProductName == "AutoCAD P and ID")
            //{
            //    ExpandTreeP3D(wTreeView,4,1,1) ExpandTreeP3D(wTreeView,4,1,1) = Window.Current<ExpandTreeP3D(wTreeView,4,1,1)>();
            //    ExpandTreeP3D(wTreeView,4,1,1);
            //    CmdWnd CmdWnd = Window.Current<CmdWnd>();
            //    CmdWnd.Click(MouseButton.Left,20,20);
            //}
            //else
            //{
            //    ExpandTreeP3D(wTreeView,4,1,2) ExpandTreeP3D(wTreeView,4,1,2) = Window.Current<ExpandTreeP3D(wTreeView,4,1,2)>();
            //    ExpandTreeP3D(wTreeView,4,1,2);
            //    CmdWnd CmdWnd = Window.Current<CmdWnd>();
            //    CmdWnd.Click(MouseButton.Left,20,20);
            //}
            //ExpandTreeP3D(wTreeView,4,1,2) ExpandTreeP3D(wTreeView,4,1,2) = Window.Current<ExpandTreeP3D(wTreeView,4,1,2)>();
            Plant3DFunctions.ExpandTreeP3D(wTreeView,4,"1,2");
            CmdWnd CmdWnd = Window.Current<CmdWnd>();
            CmdWnd.Click(MouseButton.Left,20,20);
			Drawing.Current.SetSysVar("SDI", 0);
			CmdOpt_Engine.SendCmd("NEWPROJECTDWG");
			System.Threading.Thread.Sleep(2000);
			NewDWG1DLG NewDWG1DLG = new NewDWG1DLG();
			if (NewDWG1DLG.BtnCancel.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				AdResultLog.Current.Print(1);
				NewDWG1DLG.SetActive();
				NewDWG1DLG.TypeKeys("<ESC>");
				Drawing.Current.TypeKeys("<ESC>");
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
