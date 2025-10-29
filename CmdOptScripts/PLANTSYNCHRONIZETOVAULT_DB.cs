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
	public class PLANTSYNCHRONIZETOVAULT_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSYNCHRONIZETOVAULT_DB = new List<Command>
		{
			new PLANTSYNCHRONIZETOVAULT_DB()
		};
	}

	public class PLANTSYNCHRONIZETOVAULT_DB : Command
	{
		public override void Launch()
		{
			OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
			OpenProjectFromVaultDLG.Invoke();
			//Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc") Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc") = Window.Current<Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc")>();
			Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc");
			CmdOpt_Engine.SendCmd("PLANTSYNCHRONIZETOVAULT");
			SynchronizeProjectToServerDLG SynchronizeProjectToServerDLG = Window.Current<SynchronizeProjectToServerDLG>();
			SynchronizeProjectToServerDLG.SetActive();
			if (!SynchronizeProjectToServerDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
			}
			SynchronizeProjectToServerDLG.TypeKeys("<Enter>");
			SynchronizeUpDLG SynchronizeUpDLG = new SynchronizeUpDLG();
			if (SynchronizeUpDLG.Exists)
			{
				SynchronizeUpDLG.SetActive();
				SynchronizeUpDLG.No.Click();
			}
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//SetToDefault() SetToDefault() = Window.Current<SetToDefault()>();
			//SetToDefault();
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}
}
