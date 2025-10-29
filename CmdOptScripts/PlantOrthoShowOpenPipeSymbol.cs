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
	public class PlantOrthoShowOpenPipeSymbolCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPlantOrthoShowOpenPipeSymbol = new List<Command>
		{
			new PlantOrthoShowOpenPipeSymbol(),
			new PlantOrthoShowOpenPipeSymbol_1(),
            new PlantOrthoShowOpenPipeSymbol_2(),
			new PlantOrthoShowOpenPipeSymbol_0()
		};
	}

	public class PlantOrthoShowOpenPipeSymbol : Command
	{
		public override void Launch()
		{
			////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(0,0);
			CmdOpt_Engine.EnterPoint(50,0);
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterCR();
			//CreateOrthoDrawingColurStyle() CreateOrthoDrawingColurStyle() = Window.Current<CreateOrthoDrawingColurStyle()>();
			Plant3DFunctions.CreateOrthoDrawingColurStyle();
			CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
			SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
			SelectReferenceModelsDLG.WaitExists(10000);
			SelectReferenceModelsDLG.SetActive();
			SelectReferenceModelsDLG.TypeKeys("<Space>");
			System.Threading.Thread.Sleep(1000);
			SelectReferenceModelsDLG.M_btnOK.Click();
			System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.SendCmd("PlantOrthoShowOpenPipeSymbol");
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
            //CmdOpt_Engine.SendCmd("_Close");
            //Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG();
            //if (SaveChangesMSG.WaitExists(2000))
            //{
            //    SaveChangesMSG.No.Click();
            //}
            //System.Threading.Thread.Sleep(2000);
            ////SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            //if (SaveChangesMSG.WaitExists(2000))
            //{
            //    SaveChangesMSG.No.Click();
            //}
            //Plant3DFunctions.DeleteAllDrawings();
            //Plant3DFunctions.DeleteOrthoDrawing();
		}

		public override void Verify()
		{
		}
	}

	public class PlantOrthoShowOpenPipeSymbol_1 : PlantOrthoShowOpenPipeSymbol
	{
		public override void Launch()
		{
			////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(0,0);
            //CmdOpt_Engine.EnterPoint(50,0);
            //CmdOpt_Engine.EnterPoint(50,100);
            //CmdOpt_Engine.EnterPoint(100,50);
            //CmdOpt_Engine.EnterCR();
            ////CreateOrthoDrawingColurStyle() CreateOrthoDrawingColurStyle() = Window.Current<CreateOrthoDrawingColurStyle()>();
            //Plant3DFunctions.CreateOrthoDrawingColurStyle();
            //CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
            //SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
            //SelectReferenceModelsDLG.WaitExists(10000);
            //SelectReferenceModelsDLG.SetActive();
            //SelectReferenceModelsDLG.TypeKeys("<end><Space>");
            //System.Threading.Thread.Sleep(1000);
            //SelectReferenceModelsDLG.M_btnOK.Click();
            //System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.SendCmd("_PlantOrthoShowOpenPipeSymbol");
			CmdOpt_Engine.EnterInt(1);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc 3>");
			
            //CmdOpt_Engine.SendCmd("_Close");
            //Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG();
            //if (SaveChangesMSG.WaitExists(2000))
            //{
            //    SaveChangesMSG.No.Click();
            //}
            //System.Threading.Thread.Sleep(2000);
            ////SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            //if (SaveChangesMSG.WaitExists(2000))
            //{
            //    SaveChangesMSG.No.Click();
            //}
            //Plant3DFunctions.DeleteAllDrawings();
            //Plant3DFunctions.DeleteOrthoDrawing();
        }

		public override void Verify()
		{
		}
	}

    public class PlantOrthoShowOpenPipeSymbol_2 : PlantOrthoShowOpenPipeSymbol
    {
        public override void Launch()
        {
            ////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(0,0);
            //CmdOpt_Engine.EnterPoint(50,0);
            //CmdOpt_Engine.EnterPoint(50,100);
            //CmdOpt_Engine.EnterPoint(100,50);
            //CmdOpt_Engine.EnterCR();
            ////CreateOrthoDrawingColurStyle() CreateOrthoDrawingColurStyle() = Window.Current<CreateOrthoDrawingColurStyle()>();
            //Plant3DFunctions.CreateOrthoDrawingColurStyle();
            //CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
            //SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
            //SelectReferenceModelsDLG.WaitExists(10000);
            //SelectReferenceModelsDLG.SetActive();
            //SelectReferenceModelsDLG.TypeKeys("<end><Space>");
            //System.Threading.Thread.Sleep(1000);
            //SelectReferenceModelsDLG.M_btnOK.Click();
            //System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.SendCmd("_PlantOrthoShowOpenPipeSymbol");
            CmdOpt_Engine.EnterInt(2);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc 3>");
            //CmdOpt_Engine.SendCmd("_Close");
            //Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG();
            //if (SaveChangesMSG.WaitExists(2000))
            //{
            //    SaveChangesMSG.No.Click();
            //}
            //System.Threading.Thread.Sleep(2000);
            ////SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            //if (SaveChangesMSG.WaitExists(2000))
            //{
            //    SaveChangesMSG.No.Click();
            //}
            //Plant3DFunctions.DeleteAllDrawings();
            //Plant3DFunctions.DeleteOrthoDrawing();
        }

        public override void Verify()
        {
        }
    }

	public class PlantOrthoShowOpenPipeSymbol_0 : PlantOrthoShowOpenPipeSymbol
	{
		public override void Launch()
		{
			////CreateDrawing("P3D") CreateDrawing("P3D") = Window.Current<CreateDrawing("P3D")>();
            //Plant3DFunctions.CreateDrawing("P3D");
            //CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            //CmdOpt_Engine.EnterPoint(0,0);
            //CmdOpt_Engine.EnterPoint(50,0);
            //CmdOpt_Engine.EnterPoint(50,100);
            //CmdOpt_Engine.EnterPoint(100,50);
            //CmdOpt_Engine.EnterCR();
            ////CreateOrthoDrawingColurStyle() CreateOrthoDrawingColurStyle() = Window.Current<CreateOrthoDrawingColurStyle()>();
            //Plant3DFunctions.CreateOrthoDrawingColurStyle();
            //CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
            //System.Threading.Thread.Sleep(1000);
            //SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
            //SelectReferenceModelsDLG.WaitExists(10000);
            //SelectReferenceModelsDLG.SetActive();
            //SelectReferenceModelsDLG.TypeKeys("<Space>");
            //System.Threading.Thread.Sleep(1000);
            //SelectReferenceModelsDLG.M_btnOK.Click();
            //System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.SendCmd("_PlantOrthoShowOpenPipeSymbol");
			CmdOpt_Engine.EnterInt(0);
		}

		public override void Dismiss()
		{
            Drawing.Current.TypeKeys("<Esc 3>");
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
            Plant3DFunctions.DeleteAllDrawings();
        }

		public override void Verify()
		{
		}
	}
}
