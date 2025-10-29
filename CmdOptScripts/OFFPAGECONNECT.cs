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
	public class OFFPAGECONNECTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcOFFPAGECONNECT = new List<Command>
		{
			new OFFPAGECONNECT()
		};
	}

	public class OFFPAGECONNECT : Command
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateDrawing("P3D");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
			Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            ////ExpandTreePID(wTreeView,3,1,1) ExpandTreePID(wTreeView,3,1,1) = Window.Current<ExpandTreePID(wTreeView,3,1,1)>();
            //Plant3DFunctions.ExpandTreeP3D(wTreeView,3, "1");
            //PROJECTMANAGERDLG.PIDDrawingsTVI.Select();
            //PROJECTMANAGERDLG.PIDDrawingsTVI.Click(MouseButton.Right);
            //Desktop.Current.TypeKeys("<Down 3><Enter>");     
            
            PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1");//check manually
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = Window.Current<SelectDrawingsToCopyToProDLG>();
			SelectDrawingsToCopyToProDLG.SetActive();
			SelectDrawingsToCopyToProDLG.FileName.Text = LAGT.CommonFiles.Product.Variables.TestFilesDir+"OffPageConector.dwg";
			SelectDrawingsToCopyToProDLG.Open.Click();
			System.Threading.Thread.Sleep(5000);
			Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
			if (Plant3DProjectSomeFilesDLG.WaitExists(3 * 1000))
			{
				Plant3DProjectSomeFilesDLG.SetActive();
				Plant3DProjectSomeFilesDLG.M_btnOk.Click();
			}
			ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
			if (ProjectDataMergedDLG.WaitExists(5 * 1000))
			{
				ProjectDataMergedDLG.SetActive();
				ProjectDataMergedDLG.BtnOk.Click();
			}
			PROJECTMANAGERDLG.Invoke();
			PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");
			//check manually
   //      //   Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "1,1");
   //         Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
   //         RECT wWind = WTreeView.GetRect();
			//if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
			//{
   //         WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 50);
			//}
			//else
			//{
			//WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 60);
			//}
   //         Desktop.Current.TypeKeys("<Down 1><Enter>");
			System.Threading.Thread.Sleep(5000);
			DrawingCheckerDLG DrawingCheckerDLG = new DrawingCheckerDLG();
			if (DrawingCheckerDLG.Exists) {
				DrawingCheckerDLG.Close();
			}

			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_ZOOM");
			CmdOpt_Engine.SendOpt("_Extents");
			CmdOpt_Engine.SendCmd("OFFPAGECONNECT");
			System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.SendOpt("_last");
			CreateConnectionDLG CreateConnectionDLG = new CreateConnectionDLG();
			if (CreateConnectionDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				CreateConnectionDLG.SetActive();
				CreateConnectionDLG.Dismiss();
                //System.Threading.Thread.Sleep(2000);
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{		
			Plant3DFunctions.DeleteAllDrawings();
		
		}

		public override void Verify()
		{
		}
	}
}
