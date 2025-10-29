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
	public class PLANTORTHODWGTABLESETUP_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHODWGTABLESETUP_DB = new List<Command>
		{
			new PLANTORTHODWGTABLESETUP_DB()
		};
	}

	public class PLANTORTHODWGTABLESETUP_DB : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(0,0);
			CmdOpt_Engine.EnterPoint(50,0);
			CmdOpt_Engine.SendOpt("_routingOffset");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterCR();
			Plant3DFunctions.CreateOrthoDrawingColurStyle();
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window wDlg = PROJECTMANAGERDLG;
			RECT rPaletteWnd = wDlg.GetRect(true);
			PROJECTMANAGERDLG.DoubleClick(MouseButton.Left, rPaletteWnd.xSize-10,rPaletteWnd.ySize/2);
			CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
			SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
			SelectReferenceModelsDLG.SetActive();
			SelectReferenceModelsDLG.TypeKeys("<End>");
			SelectReferenceModelsDLG.TypeKeys("<Space>");
			SelectReferenceModelsDLG.M_btnOK.Click();
			System.Threading.Thread.Sleep(10000);
			CmdOpt_Engine.SendCmd("_PROJECTMANAGERCLOSE");
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH || Harness.Current.AppWnd.Language == LANG_ID.ITALIAN)
            {

                AppWnd.TypeKeys("<alt-Space>n");
            }
            if (Harness.Current.AppWnd.Language == LANG_ID.POLISH)
            {

                AppWnd.TypeKeys("<alt-Space>s");
            }
            else
            {

                AppWnd.TypeKeys("<alt-Space>x");
            }
            System.Threading.Thread.Sleep(3000);
            //SAM.GetCoords("S:\\Harness\\dialogs\\Plant3D\\SamScreenshots\\OrthoCheckMark1 SAM.GetCoords("S:\\Harness\\dialogs\\Plant3D\\SamScreenshots\\OrthoCheckMark1 = Window.Current<SAM.GetCoords("S:\\Harness\\dialogs\\Plant3D\\SamScreenshots\\OrthoCheckMark1>();
            //SAM.GetCoords("C:\\LAGT\\Plant3D\\Tools\\SamScreenshots\\OK.bmp");

            Desktop Desktop = new Desktop();
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\OK.bmp");
            Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
			ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\OK.bmp");
			Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);

			System.Threading.Thread.Sleep(3000);
            Drawing.Current.TypeE("5,5");
			System.Threading.Thread.Sleep(8000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTORTHODWGTABLESETUP");
			OrthoDWGSettingsTableSetupDLG OrthoDWGSettingsTableSetupDLG = new OrthoDWGSettingsTableSetupDLG();
			if (OrthoDWGSettingsTableSetupDLG.WaitExists(1000))
			{
				OrthoDWGSettingsTableSetupDLG.SetActive();
				OrthoDWGSettingsTableSetupDLG.CancelPB.Click();
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
            CmdOpt_Engine.SendCmd("_Close");
            System.Threading.Thread.Sleep(3000);
            var SaveChangesMSG = new Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.No.Click();
            }
            System.Threading.Thread.Sleep(2000);
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.No.Click();
            }

            System.Threading.Thread.Sleep(2000);
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
			if (WarningAutoCADDLG.WaitExists(3 * 1000))
			{
				WarningAutoCADDLG.No.Click();
			}
			CmdOpt_Engine.SendCmd("_PROJECTMANAGER");
			Plant3DFunctions.DeleteOrthoDrawing();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
