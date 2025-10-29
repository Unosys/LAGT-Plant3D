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
	public class PLANTDWGCHECKERCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTDWGCHECKER = new List<Command>
		{
			new PLANTDWGCHECKER()
		};
	}

	public class PLANTDWGCHECKER : Command
	{
		public override void Launch()
		{
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            CmdOpt_Engine.SendCmd("_ProjectManager");
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
        //    Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "1");
            PROJECTMANAGERDLG.PIDDrawingsTVI.Select();
            PROJECTMANAGERDLG.PIDDrawingsTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Down 3><Enter>");       
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = Window.Current<SelectDrawingsToCopyToProDLG>();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.Text = LAGT.CommonFiles.Product.Variables.TestFilesDir+"EditAnnotation.dwg";
            SelectDrawingsToCopyToProDLG.Open.Click();
           
            //Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
            //if (Plant3DProjectSomeFilesDLG.WaitExists(3000))
            //{
            //    Plant3DProjectSomeFilesDLG.SetActive();
            //    Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            //}
            AutoCADPIDMigrationDLG AutoCADPIDMigrationDLG = new AutoCADPIDMigrationDLG();
            if (AutoCADPIDMigrationDLG.WaitExists(2000))
            {
                AutoCADPIDMigrationDLG.ChkboxBackup.Uncheck();
                Desktop.Current.TypeKeys("<enter>"); //close migration
                System.Threading.Thread.Sleep(5000);
                Desktop.Current.TypeKeys("<enter>");
            }
            System.Threading.Thread.Sleep(3000);
            ProjectDataMerged ProjectDataMerged = new ProjectDataMerged();
            if (ProjectDataMerged.Exists)
            {
                ProjectDataMerged.OKPB.Click();

            }
            //Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
            //if (Plant3DProjectSomeFilesDLG.WaitExists(3000))
            //{
            //    Plant3DProjectSomeFilesDLG.SetActive();
            //    Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            //Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "1");
            //SelectDrawingsToCopyToProDLG.SetActive();
            //SelectDrawingsToCopyToProDLG.FileName.Text = LAGT.CommonFiles.Product.Variables.TestFilesDir+"OffPageConnector.dwg";
            //SelectDrawingsToCopyToProDLG.Open.Click();
            //System.Threading.Thread.Sleep(5000);      
            //}
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
            //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            //PROJECTMANAGERDLG.Invoke();
            PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");
   //         Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
   //         RECT wWind = WTreeView.GetRect();
   //         	if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
			//{
   //         WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 50);
			//}
			//else
			//{
			//WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 60);
			//}
			//Desktop.Current.TypeKeys("<Down 1><Enter>");
            CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTDWGCHECKER");
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
