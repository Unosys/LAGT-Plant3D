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
	public class PLANTORTHOPLACEBOMCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOPLACEBOM = new List<Command>
		{
			new PLANTORTHOPLACEBOM()
		};
	}

	public class PLANTORTHOPLACEBOM : Command
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
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            Window wDlg = PROJECTMANAGERDLG;
			RECT rPaletteWnd = wDlg.GetRect(true);
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.DoubleClick(MouseButton.Left, rPaletteWnd.xSize-10,rPaletteWnd.ySize/2);
			CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
			SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
			SelectReferenceModelsDLG.SetActive();
			SelectReferenceModelsDLG.TypeKeys("<End>");
			SelectReferenceModelsDLG.TypeKeys("<Space>");
			SelectReferenceModelsDLG.M_btnOK.Click();
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

            System.Threading.Thread.Sleep(3000);
            Desktop Desktop = new Desktop();
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\OK.bmp");
            Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);            
            System.Threading.Thread.Sleep(10000);

            CmdOpt_Engine.EnterPoint(5,5);
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTORTHOPLACEBOM");
			//CmdOpt_Engine.EnterCR();
		}

		public override void Dismiss()
		{
            CmdOpt_Engine.EnterPoint(5, 5);
            CmdOpt_Engine.EnterPoint(5, 0);
            CmdOpt_Engine.EnterPoint(6, 0);
            Drawing.Current.TypeKeys("<Esc>");
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();

            if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
            {

                AppWnd.TypeKeys("<alt-Space><Down><Enter>");
            }
            else
            {
                AppWnd.TypeKeys("<alt-Space>r");
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.SendCmd("_PROJECTMANAGER");
            CmdOpt_Engine.SendCmd("_Close");
            System.Threading.Thread.Sleep(3000);
            var SaveChangesMSG = new Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.No.Click();
            }
          
			Plant3DFunctions.DeleteOrthoDrawing();
			Plant3DFunctions.DeleteDrawing("P3D");
		}

		public override void Verify()
		{
		}
	}
}
