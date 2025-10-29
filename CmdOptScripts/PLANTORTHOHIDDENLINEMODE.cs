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
	public class PLANTORTHOHIDDENLINEMODECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOHIDDENLINEMODE = new List<Command>
		{
			new PLANTORTHOHIDDENLINEMODE(),
			new PLANTORTHOHIDDENLINEMODE_Nohiddenlines(),
			new PLANTORTHOHIDDENLINEMODE_hiddenPipingonly(),
			new PLANTORTHOHIDDENLINEMODE_Allhiddenlines()
		};
	}

	public class PLANTORTHOHIDDENLINEMODE : Command
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
			CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
			SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
			SelectReferenceModelsDLG.SetActive();
			SelectReferenceModelsDLG.TypeKeys("<Space>");
			System.Threading.Thread.Sleep(5000);
			SelectReferenceModelsDLG.M_btnOK.Click();
			CmdOpt_Engine.SendCmd("PLANTORTHOHIDDENLINEMODE");
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTORTHOHIDDENLINEMODE_Nohiddenlines : PLANTORTHOHIDDENLINEMODE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTORTHOHIDDENLINEMODE");
			CmdOpt_Engine.SendOption("Nohiddenlines",1,3);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTORTHOHIDDENLINEMODE_hiddenPipingonly : PLANTORTHOHIDDENLINEMODE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTORTHOHIDDENLINEMODE");
			CmdOpt_Engine.SendOption("hiddenPipingonly",2,3);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTORTHOHIDDENLINEMODE_Allhiddenlines : PLANTORTHOHIDDENLINEMODE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTORTHOHIDDENLINEMODE");
			CmdOpt_Engine.SendOption("Allhiddenlines",3,3);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
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
            System.Threading.Thread.Sleep(1000);
            Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
