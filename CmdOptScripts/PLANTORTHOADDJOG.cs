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
	public class PLANTORTHOADDJOGCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOADDJOG = new List<Command>
		{
			new PLANTORTHOADDJOG()
		};
	}

	public class PLANTORTHOADDJOG : Command
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
			SelectReferenceModelsDLG.SetActive();
			SelectReferenceModelsDLG.TypeKeys("<Space>");
			System.Threading.Thread.Sleep(5000);
			SelectReferenceModelsDLG.M_btnOK.Click();
			CmdOpt_Engine.SendCmd("PLANTORTHOADDJOG");
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc 2>");			
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(2000);
            Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(2000);
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.DeleteOrthoDrawing();
			Plant3DFunctions.DeleteDrawing();
		}

		public override void Verify()
		{
		}
	}
}
