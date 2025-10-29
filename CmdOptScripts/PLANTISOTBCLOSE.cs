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
	public class PLANTISOTBCLOSECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTISOTBCLOSE = new List<Command>
		{
			new PLANTISOTBCLOSE()
		};
	}

	public class PLANTISOTBCLOSE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			//SetupTitleBlock() SetupTitleBlock() = Window.Current<SetupTitleBlock()>();
            Plant3DFunctions.SetupTitleBlock();
			System.Threading.Thread.Sleep(15000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTISOTBCLOSE");
			System.Threading.Thread.Sleep(10000);
			IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
			if (IsometricDWGSettingsTitleBlockandDisplayDLG.Exists)
			{
				IsometricDWGSettingsTitleBlockandDisplayDLG.Dismiss();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		//	CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}
}
