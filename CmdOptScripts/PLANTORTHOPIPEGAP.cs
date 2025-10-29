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
	public class PLANTORTHOPIPEGAPCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOPIPEGAP = new List<Command>
		{
			new PLANTORTHOPIPEGAP()
		};
	}

	public class PLANTORTHOPIPEGAP : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(0,0);
			CmdOpt_Engine.EnterPoint(50,0);
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterCR();
			Plant3DFunctions.CreateOrthoDrawingColurStyle();
            //CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
            //SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
            //SelectReferenceModelsDLG.SetActive();
            //SelectReferenceModelsDLG.TypeKeys("<Space>");
            //System.Threading.Thread.Sleep(5000);
            //SelectReferenceModelsDLG.M_btnOK.Click();
            //System.Threading.Thread.Sleep(5000);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window wDlg = PROJECTMANAGERDLG;
            RECT rPaletteWnd = wDlg.GetRect(true);
            //PROJECTMANAGERDLG.DoubleClick(MouseButton.Left, rPaletteWnd.xSize - 10, rPaletteWnd.ySize / 2);
            CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
            SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
            if (SelectReferenceModelsDLG.Exists)
            {
                SelectReferenceModelsDLG.SetActive();
                SelectReferenceModelsDLG.TypeKeys("<End>");
                SelectReferenceModelsDLG.TypeKeys("<Space>");
                System.Threading.Thread.Sleep(2000);
                SelectReferenceModelsDLG.M_btnOK.Click();
                System.Threading.Thread.Sleep(2000);
            }
            System.Threading.Thread.Sleep(2000);
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
            System.Threading.Thread.Sleep(5000);
            if (AppWnd.OKPB.Exists)
            {
                AppWnd.OKPB.Click();
            }
            else
            {
                RECT r = AppWnd.OKPB.GetRect(true);
                Desktop Desktop = new Desktop();
                ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\OK.bmp");
                Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
                //ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\OK.bmp");
                //Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
                Desktop.Click(MouseButton.Left, r.xPos + r.xSize / 2 - 10, r.yPos + r.ySize + 20);
            }
            System.Threading.Thread.Sleep(10000);


            Drawing.Current.TypeE("5,5");
            System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTORTHOPIPEGAP");
            System.Threading.Thread.Sleep(1000);
        }

		public override void Dismiss()
		{
            CmdOpt_Engine.EnterPoint(50,50);
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();

            if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
            {

                AppWnd.TypeKeys("<alt-Space><Down><Enter>");
            }
            else if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH)
            {

                AppWnd.TypeKeys("<alt-Space>R");
            }
            else if (Harness.Current.AppWnd.Language == LANG_ID.GERMAN)
            {

                AppWnd.TypeKeys("<alt-Space>W");
            }
            else
            {
                AppWnd.TypeKeys("<alt-Space>R");
            }
            System.Threading.Thread.Sleep(2000);

   //         CmdOpt_Engine.SendOpt("_last");
			//Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
            CmdOpt_Engine.SendCmd("_PROJECTMANAGER");
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

            Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.DeleteOrthoDrawing();
        }

		public override void Verify()
		{
		}
	}
}
