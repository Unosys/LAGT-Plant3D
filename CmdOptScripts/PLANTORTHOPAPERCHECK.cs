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
	public class PLANTORTHOPAPERCHECKCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOPAPERCHECK = new List<Command>
		{
			new PLANTORTHOPAPERCHECK(),
			new PLANTORTHOPAPERCHECK_OFF(),
			new PLANTORTHOPAPERCHECK_ON()
		};
	}

	public class PLANTORTHOPAPERCHECK : Command
	{
		public override void Launch()
		{
            Plant3DFunctions.CreateDrawing("P3D");
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(0, 0);
            CmdOpt_Engine.EnterPoint(50, 0);
            CmdOpt_Engine.EnterPoint(50, 100);
            CmdOpt_Engine.EnterPoint(100, 50);
            CmdOpt_Engine.EnterCR();
            //CreateOrthoDrawingColurStyle() CreateOrthoDrawingColurStyle() = Window.Current<CreateOrthoDrawingColurStyle()>();
            Plant3DFunctions.CreateOrthoDrawingColurStyle();
            CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
            SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
            SelectReferenceModelsDLG.SetActive();
            SelectReferenceModelsDLG.TypeKeys("<Space>");
            System.Threading.Thread.Sleep(5000);
            SelectReferenceModelsDLG.M_btnOK.Click();
            System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTORTHOPAPERCHECK");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTORTHOPAPERCHECK_OFF : PLANTORTHOPAPERCHECK
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTORTHOPAPERCHECK");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("OFF");
			}
			else  if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
			{
				string sString = (Plant3DMainWin.cBabel(4750, 210, "ON"));
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
			else
			{
				string sString =(Plant3DMainWin.cBabel(23067,2,"OFF"));
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

	public class PLANTORTHOPAPERCHECK_ON : PLANTORTHOPAPERCHECK
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTORTHOPAPERCHECK");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("ON");
			}
			else if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
			{
				string sString = (Plant3DMainWin.cBabel(4750, 210, "ON"));
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
			else
			{
				string sString =(Plant3DMainWin.cBabel(23067,1,"ON"));
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
            //System.Threading.Thread.Sleep(3000);
            //if (SaveChangesMSG.WaitExists(2 * 1000))
            //{
            //	SaveChangesMSG.NoPB.Click();
            //}
            System.Threading.Thread.Sleep(3000);
            CmdOpt_Engine.SendCmd("_Close");
            System.Threading.Thread.Sleep(3000);
            if (SaveChangesMSG.WaitExists(2 * 1000))
			{
				SaveChangesMSG.NoPB.Click();
			}
			System.Threading.Thread.Sleep(3000);
			//if (SaveChangesMSG.WaitExists(2 * 1000))
			//{
			//	SaveChangesMSG.NoPB.Click();
			//}
			Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.DeleteOrthoDrawing();
        }

		public override void Verify()
		{
		}
	}
}
