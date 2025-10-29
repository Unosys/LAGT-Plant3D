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
	public class DataManagerClose_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcDataManagerClose_DB = new List<Command>
		{
			new DataManagerClose_DB()
		};
	}

	public class DataManagerClose_DB : Command
	{
		public override void Launch()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			CmdOpt_Engine.SendCmd("_DataManager");
			System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.SendCmd("_ToolPalettesClose");
			CmdOpt_Engine.SendCmd("DataManagerClose");
			System.Threading.Thread.Sleep(5000);
			AdResultLog.Current.Print(1);
		}

		public override void Dismiss()
		{
			DataManagerDLG DataManagerDLG = new DataManagerDLG();
			if (DataManagerDLG.M_ToolBtnExport.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
			}
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}
}
