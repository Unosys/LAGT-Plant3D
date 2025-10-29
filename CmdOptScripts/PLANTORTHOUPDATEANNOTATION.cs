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
	public class PLANTORTHOUPDATEANNOTATIONCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOUPDATEANNOTATION = new List<Command>
		{
			new PLANTORTHOUPDATEANNOTATION()
		};
	}

	public class PLANTORTHOUPDATEANNOTATION : Command
	{
		public override void Launch()
		{
			//Plant3DFunctions.CreateOrtho() Plant3DFunctions.CreateOrtho() = Window.Current<Plant3DFunctions.CreateOrtho()>();
            Plant3DFunctions.CreateOrthoDrawingColurStyle();
			CmdOpt_Engine.SendCmd("PLANTORTHOUPDATEANNOTATION");
            System.Threading.Thread.Sleep(3000);
            string sCmdOpt = Drawing.Current.GetCmdLineHistory(1);
            if (!sCmdOpt.Contains(" ..."))
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "The view has not been updated.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
        }

		public override void Dismiss()
		{
			//DeleteOrthoDrawing() DeleteOrthoDrawing() = Window.Current<DeleteOrthoDrawing()>();
			Plant3DFunctions.DeleteOrthoDrawing();
			//string sCmdOpt = Drawing.Current.GetCmdLineHistory(2);
			//if (!sCmdOpt.Contains(" ..."))
			//{
			//	CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "The view has not been updated.", "", "", "");
			//	CmdOpt_ErrorReport.ReportError(sError);
			//}
           //CmdOpt_Engine.SendCmd("_Close");
           //Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.AutoCAD.Dialogs.SaveChangesMSG();
           //if (SaveChangesMSG.WaitExists(2 * 1000))
           //{
           //    SaveChangesMSG.No.Click();
           //}

		}

		public override void Verify()
		{
		}
	}
}
