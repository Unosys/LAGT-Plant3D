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
	public class PLANTORTHOTEMPLATETABLESETUP_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOTEMPLATETABLESETUP_DB = new List<Command>
		{
			new PLANTORTHOTEMPLATETABLESETUP_DB()
		};
	}

	public class PLANTORTHOTEMPLATETABLESETUP_DB : Command
	{
		public override void Launch()
		{
			////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = new ProjectSetupTitleBlockandDisplayDLG();
			ProjectSetupTitleBlockandDisplayDLG.Invoke();
			//ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = Window.Current<ProjectSetupTitleBlockandDisplayDLG>();
			ProjectSetupTitleBlockandDisplayDLG.BtnSetupBlk.Click();
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_PLANTORTHOTEMPLATETABLESETUP");
			OrthoDWGSettingsTableSetupDLG OrthoDWGSettingsTableSetupDLG = new OrthoDWGSettingsTableSetupDLG();
			if (OrthoDWGSettingsTableSetupDLG.WaitExists(20000))
			{
				OrthoDWGSettingsTableSetupDLG.SetActive();
				OrthoDWGSettingsTableSetupDLG.CancelPB.Click();
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeE("_close");
			//while(!ProjectSetupTitleBlockandDisplayDLG while(!ProjectSetupTitleBlockandDisplayDLG = Window.Current<while(!ProjectSetupTitleBlockandDisplayDLG>();
            ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = new ProjectSetupTitleBlockandDisplayDLG();
            if (ProjectSetupTitleBlockandDisplayDLG.WaitExists(20000))
            {
			    ProjectSetupTitleBlockandDisplayDLG.Dismiss();
			    //System.Threading.Thread.Sleep(1000);
            }
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
            System.Threading.Thread.Sleep(1000);
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
