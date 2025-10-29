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
	public class PLANTSTEELRAILINGCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELRAILING = new List<Command>
		{
			new PLANTSTEELRAILING(),
			new PLANTSTEELRAILING_Object(),
			new PLANTSTEELRAILING_Object_2Point(),
			new PLANTSTEELRAILING_Object_Settings(),
			new PLANTSTEELRAILING_Settings()
		};
	}

	public class PLANTSTEELRAILING : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELRAILING");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELRAILING_Object : PLANTSTEELRAILING
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("PLANTSTEELRAILING");
			CmdOpt_Engine.SendOption("Object",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELRAILING_Object_2Point : PLANTSTEELRAILING
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("PLANTSTEELRAILING");
			CmdOpt_Engine.SendOpt("_Object");
			CmdOpt_Engine.SendOption("2Point",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELRAILING_Object_Settings : PLANTSTEELRAILING
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("filedia",0);
			CmdOpt_Engine.SendCmd("PLANTSTEELRAILING");
			CmdOpt_Engine.SendOpt("_Object");
			CmdOpt_Engine.SendOption("Settings",2,2);
			RailingSettingsDLG RailingSettingsDLG = new RailingSettingsDLG();
			if (RailingSettingsDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 7))
			{
				RailingSettingsDLG.SetActive();
				RailingSettingsDLG.Cancel.Click();
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSTEELRAILING_Settings : PLANTSTEELRAILING
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_Erase");
			CmdOpt_Engine.SendOpt("_All");
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("filedia",0);
			CmdOpt_Engine.SendCmd("PLANTSTEELRAILING");
			CmdOpt_Engine.SendOption("Settings",2,2);
			RailingSettingsDLG RailingSettingsDLG = new RailingSettingsDLG();
			if (RailingSettingsDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 7))
			{
				RailingSettingsDLG.SetActive();
				RailingSettingsDLG.Cancel.Click();
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
