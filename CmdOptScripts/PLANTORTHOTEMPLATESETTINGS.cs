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
	public class PLANTORTHOTEMPLATESETTINGSCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOTEMPLATESETTINGS = new List<Command>
		{
			new PLANTORTHOTEMPLATESETTINGS()
		};
	}

	public class PLANTORTHOTEMPLATESETTINGS : Command
	{
		public override void Launch()
		{
			ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = new ProjectSetupTitleBlockandDisplayDLG();
			ProjectSetupTitleBlockandDisplayDLG.Invoke();
			//ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = Window.Current<ProjectSetupTitleBlockandDisplayDLG>();
			ProjectSetupTitleBlockandDisplayDLG.BtnSetupBlk.Click();
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTORTHOTEMPLATESETTINGS");
            OrthoGenerationSettingsDLG OrthoGenerationSettingsDLG = new OrthoGenerationSettingsDLG();
            if (OrthoGenerationSettingsDLG.WaitExists(4 * 1000))
            {
                OrthoGenerationSettingsDLG.SetActive();
                OrthoGenerationSettingsDLG.BtnCancel.Click();
            }
            else
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
            //Drawing.Current.TypeKeys("<Esc>");
            //CmdOpt_Engine.SendCmd("_Close");
            //Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG();
            //if (SaveChangesMSG.WaitExists(2 * 1000))
            //{
            //    SaveChangesMSG.No.Click();
            //}
            System.Threading.Thread.Sleep(3000);
            System.Threading.Thread.Sleep(15000);
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            if (ProjectSetupProjectDetailsDLG.Exists)
            {
                ProjectSetupProjectDetailsDLG.Dismiss();
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
