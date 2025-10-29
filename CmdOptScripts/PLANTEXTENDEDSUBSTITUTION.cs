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
	public class PLANTEXTENDEDSUBSTITUTIONCLASS
    {
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTEXTENDEDSUBSTITUTION = new List<Command>
		{
			new PLANTEXTENDEDSUBSTITUTION(),
			new PLANTEXTENDEDSUBSTITUTION_OFF(),
			new PLANTEXTENDEDSUBSTITUTION_ON()
		};
	}

	public class PLANTEXTENDEDSUBSTITUTION : Command
	{
		public override void Launch()
		{
			
            CmdOpt_Engine.SendCmd("PLANTEXTENDEDSUBSTITUTION");
        }

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTEXTENDEDSUBSTITUTION_OFF : PLANTEXTENDEDSUBSTITUTION
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTEXTENDEDSUBSTITUTION");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("OFF");
			}
			else if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN) {
				string sString = (Plant3DMainWin.cBabel(4750, 211, "OFF"));
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
			else
			{
				string sString = (Plant3DMainWin.cBabel(23067, 2, "OFF"));
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}

	public class PLANTEXTENDEDSUBSTITUTION_ON : PLANTEXTENDEDSUBSTITUTION
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTEXTENDEDSUBSTITUTION");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("ON");
			}
			else if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
			{
				string sString = Plant3DMainWin.cBabel(4750, 210, "ON");
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
			else
			{
				string sString = Plant3DMainWin.cBabel(23067, 1, "ON");
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
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
