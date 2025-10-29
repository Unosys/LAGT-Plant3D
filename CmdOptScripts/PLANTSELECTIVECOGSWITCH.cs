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
	public class PLANTSELECTIVECOGSWITCHCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSELECTIVECOGSWITCH = new List<Command>
		{
			new PLANTSELECTIVECOGSWITCH(),
			new PLANTSELECTIVECOGSWITCH_OFF(),
			new PLANTSELECTIVECOGSWITCH_ON()
		};
	}

	public class PLANTSELECTIVECOGSWITCH : Command
	{
		public override void Launch()
		{
			////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTSELECTIVECOGSWITCH");
			CmdOpt_Engine.EnterCR();
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSELECTIVECOGSWITCH_OFF : PLANTSELECTIVECOGSWITCH
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTSELECTIVECOGSWITCH");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("OFF");
			}
			else if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN) {
				string sString = Plant3DMainWin.cBabel(4750, 74, "OFF");
				CmdOpt_Engine.EnterText(sString);
			}
			else
			{
				string sString = Plant3DMainWin.cBabel(23067, 2, "OFF");
				CmdOpt_Engine.EnterText(sString);
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSELECTIVECOGSWITCH_ON : PLANTSELECTIVECOGSWITCH
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTSELECTIVECOGSWITCH");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("ON");
			}
			else if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
			{
				string sString = Plant3DMainWin.cBabel(4750, 73, "ON");
				CmdOpt_Engine.EnterText(sString);
			}
			else
			{
				string sString = Plant3DMainWin.cBabel(23067, 1, "ON");
				CmdOpt_Engine.EnterText(sString);
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");

			//Plant3DFunctions.DeleteDrawing();
			Plant3DFunctions.DeleteDrawing("P3D");
		}

		public override void Verify()
		{
		}
	}
}
