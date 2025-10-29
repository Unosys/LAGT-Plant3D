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
	public class PLANTORTHONOZZLEDIRECTIONCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHONOZZLEDIRECTION = new List<Command>
		{
			new PLANTORTHONOZZLEDIRECTION(),
			new PLANTORTHONOZZLEDIRECTION_OFF(),
			new PLANTORTHONOZZLEDIRECTION_ON()
		};
	}

	public class PLANTORTHONOZZLEDIRECTION : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CopyDrawing("2026\\ReducingParts.dwg");
			Plant3DFunctions.CreateOrthoDrawingColurStyle("P3D");
            Drawing.Current.TypeE("_PLANTORTHOCREATE");
            SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
            SelectReferenceModelsDLG.SetActive();
            SelectReferenceModelsDLG.TypeKeys("<End>");
            SelectReferenceModelsDLG.TypeKeys("<Space>");
            SelectReferenceModelsDLG.M_btnOK.Click();
            System.Threading.Thread.Sleep(2000);
            System.Threading.Thread.Sleep(10000);
            CmdOpt_Engine.SendCmd("_PROJECTMANAGERCLOSE");
            System.Threading.Thread.Sleep(3000);
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH || Harness.Current.AppWnd.Language == LANG_ID.ITALIAN)
            {

                AppWnd.TypeKeys("<alt-Space>n");
            }
            if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
            {

                AppWnd.TypeKeys("<alt-Space><Down 5><Enter>");
            }
            else
            {

                AppWnd.TypeKeys("<alt-Space>x");
            }
            System.Threading.Thread.Sleep(3000);
            Desktop Desktop = new Desktop();
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\OK.bmp");
            Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\OK.bmp");
            System.Threading.Thread.Sleep(3000);
            CmdOpt_Engine.EnterPoint(5, 5);
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.StartLog();
            CmdOpt_Engine.SendCmd("PLANTORTHONOZZLEDIRECTION");
        }

		public override void Dismiss()
		{
            Drawing.Current.TypeKeys("<Esc>");

        }

        public override void Verify()
		{
		}
	}

	public class PLANTORTHONOZZLEDIRECTION_OFF : PLANTORTHONOZZLEDIRECTION
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTORTHONOZZLEDIRECTION");
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

	public class PLANTORTHONOZZLEDIRECTION_ON : PLANTORTHONOZZLEDIRECTION
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTORTHONOZZLEDIRECTION");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("ON");
			}
			else if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
			{
				string sString = Plant3DMainWin.cBabel(4750, 210, "ON");
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
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();

            if (Harness.Current.AppWnd.Language == LANG_ID.POLISH)
            {

                AppWnd.TypeKeys("<alt-Space>P");
            }
            if (Harness.Current.AppWnd.Language == LANG_ID.GERMAN)
            {

                AppWnd.TypeKeys("<alt-Space>W");
            }
            else
            {
                AppWnd.TypeKeys("<alt-Space>r");
            }
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_Close");
            var SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_Close");

            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }

            System.Threading.Thread.Sleep(2000);
            //WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            //if (WarningAutoCADDLG.WaitExists(3 * 1000))
            //{
            //    WarningAutoCADDLG.No.Click();
            //}
            CmdOpt_Engine.SendCmd("_PROJECTMANAGER");
            Plant3DFunctions.DeleteOrthoDrawing();
            Plant3DFunctions.DeleteAllDrawings();
        }

		public override void Verify()
		{
		}
	}
}
