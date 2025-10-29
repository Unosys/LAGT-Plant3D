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
	public class PLANTSTEELMEMBERCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELMEMBER = new List<Command>
		{
			new PLANTSTEELMEMBER(),
			new PLANTSTEELMEMBER_Line(),
			new PLANTSTEELMEMBER_Settings()
		};
	}

	public class PLANTSTEELMEMBER : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELMEMBER");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(1);
			//if (!sCmdOpt.Contains("[*/*]"))
            if (!sCmdOpt.WcMatch("*[*/*]*"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTSTEELMEMBER_Line : PLANTSTEELMEMBER
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTSTEELMEMBER");
			CmdOpt_Engine.SendOption("Line",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(1);
			if (sCmdOpt.Contains("[*/*]"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "Line should be selected.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTSTEELMEMBER_Settings : PLANTSTEELMEMBER
	{
		public override void Launch()
		{
			Drawing.Current.SetSysVar("filedia",0);
			Drawing.Current.SetSysVar("cmddia", 1);
			CmdOpt_Engine.SendCmd("PLANTSTEELMEMBER");
			CmdOpt_Engine.SendOption("Settings",2,2);
			System.Threading.Thread.Sleep(2000);
			AutoCADSteelMemberErrorDLG AutoCADSteelMemberErrorDLG = new AutoCADSteelMemberErrorDLG();
			if (AutoCADSteelMemberErrorDLG.Exists) 
			{
				AutoCADSteelMemberErrorDLG.OKPB.Click();
			}
			MemberSettingsDLG MemberSettingsDLG = new MemberSettingsDLG();

			if (MemberSettingsDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 5))
			{
				MemberSettingsDLG.SetActive();
				MemberSettingsDLG.Cancel.Click();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("cmddia", 0);
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            Plant3DFunctions.DeleteAllDrawings();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}
}
