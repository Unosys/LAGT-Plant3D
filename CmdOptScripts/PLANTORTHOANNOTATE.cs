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
	public class PLANTORTHOANNOTATECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOANNOTATE = new List<Command>
		{
			new PLANTORTHOANNOTATE(),
			new PLANTORTHOANNOTATE_Rotate(),
			new PLANTORTHOANNOTATE_disableLeader()
		};
	}

	public class PLANTORTHOANNOTATE : Command
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
            ProjManUndocked PROJECTMANAGERDLG = Window.Current<ProjManUndocked>();
            Window wDlg = PROJECTMANAGERDLG;
			RECT rPaletteWnd = wDlg.GetRect(true);
			PROJECTMANAGERDLG.SetActive();
			//PROJECTMANAGERDLG.DoubleClick(MouseButton.Left, rPaletteWnd.xSize-10,rPaletteWnd.ySize/2);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
			SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
			SelectReferenceModelsDLG.SetActive();
			SelectReferenceModelsDLG.TypeKeys("<End>");
			SelectReferenceModelsDLG.TypeKeys("<Space>");
            System.Threading.Thread.Sleep(1000);
            SelectReferenceModelsDLG.M_btnOK.Click();
			if (SelectReferenceModelsDLG.Exists) {
                SelectReferenceModelsDLG.M_btnOK.Click();
            }
			System.Threading.Thread.Sleep(10000);
			CmdOpt_Engine.SendCmd("_PROJECTMANAGERCLOSE");
            System.Threading.Thread.Sleep(3000);
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH || Harness.Current.AppWnd.Language == LANG_ID.ITALIAN)
            {

                AppWnd.TypeKeys("<alt-Space>n");
            }
            if (Harness.Current.AppWnd.Language == LANG_ID.POLISH)
            {

                AppWnd.TypeKeys("<alt-Space>s");
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

            System.Threading.Thread.Sleep(3000);
            System.Threading.Thread.Sleep(10000);
			Drawing.Current.TypeE("5,5");
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTORTHOANNOTATE");

           
        }

		public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(50,50);
            CmdOpt_Engine.EnterText("?");
            CmdOpt_Engine.EnterText("*");
            Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			
		}

		public override void Verify()
		{
		}
	}

	public class PLANTORTHOANNOTATE_Rotate : PLANTORTHOANNOTATE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTORTHOANNOTATE");
            CmdOpt_Engine.EnterPoint(50,50);
            CmdOpt_Engine.EnterText("Top");
			CmdOpt_Engine.SendOption("Rotate",1,2);
			CmdOpt_Engine.EnterAngle(90);
            CmdOpt_Engine.EnterPoint(50,50);
            CmdOpt_Engine.EnterPoint(50,70);
        }

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			
		}

		public override void Verify()
		{
		}
	}

	public class PLANTORTHOANNOTATE_disableLeader : PLANTORTHOANNOTATE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTORTHOANNOTATE");
            CmdOpt_Engine.EnterPoint(50, 50);
            CmdOpt_Engine.EnterText("Top");
			CmdOpt_Engine.SendOption("enableLeader",2,2);
            CmdOpt_Engine.EnterPoint(50, 50);
            CmdOpt_Engine.EnterPoint(50, 70);
        }

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
            var AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();

            if (Harness.Current.AppWnd.Language == LANG_ID.POLISH)
            {

                AppWnd.TypeKeys("<alt-Space>P");
            }
            else
            {
                AppWnd.TypeKeys("<alt-Space>r");
            }
            System.Threading.Thread.Sleep(2000);
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


            Plant3DFunctions.DeleteOrthoDrawing();
            Plant3DFunctions.DeleteDrawing("P3D");
        }

		public override void Verify()
		{
		}
	}
}
