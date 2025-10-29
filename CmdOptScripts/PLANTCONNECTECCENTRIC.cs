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
	public class PLANTCONNECTECCENTRICCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTCONNECTECCENTRIC = new List<Command>
		{
			new PLANTCONNECTECCENTRIC(),
			new PLANTCONNECTECCENTRIC_OFF(),
			new PLANTCONNECTECCENTRIC_ON()
		};
	}

	public class PLANTCONNECTECCENTRIC : Command
	{
		public override void Launch()
		{
            Plant3DFunctions.CopyDrawing("2026\\ReducingParts.dwg");
            CmdOpt_Engine.SendCmd("PLANTCONNECTECCENTRIC");
        }

		public override void Dismiss()
		{
            Drawing.Current.TypeKeys("<Esc>");
        }

		public override void Verify()
		{
		}
	}

	public class PLANTCONNECTECCENTRIC_OFF : PLANTCONNECTECCENTRIC
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTCONNECTECCENTRIC");
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

	public class PLANTCONNECTECCENTRIC_ON : PLANTCONNECTECCENTRIC
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTCONNECTECCENTRIC");
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
			CmdOpt_Engine.SendCmd("_Close");
			System.Threading.Thread.Sleep(3000);
			Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
			if (SaveChangesMSG.WaitExists(2 * 1000))
			{
				SaveChangesMSG.NoPB.Click();
			}
			System.Threading.Thread.Sleep(3000);
			Plant3DFunctions.DeleteAllDrawings();
			
		}

		public override void Verify()
		{
		}
	}
}
