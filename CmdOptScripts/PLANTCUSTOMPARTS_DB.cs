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
	public class PLANTCUSTOMPARTS_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTCUSTOMPARTS_DB = new List<Command>
		{
			new PLANTCUSTOMPARTS_DB()
		};
	}

	public class PLANTCUSTOMPARTS_DB : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_PROJECTMANAGERCLOSE");
			CmdOpt_Engine.SendCmd("PLANTCUSTOMPARTS");
			//System.Threading.Thread.Sleep(7000);
            CustomPartsDLG CustomPartsDLG = new CustomPartsDLG();
            if (CustomPartsDLG.WaitExists(7000))
            {
                CustomPartsDLG.SetActive();
            }
            else
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
            }
			//Window wActive = Desktop.Current.GetActive();
			//AdResultLog.Current.Print(wActive);
			//Dialogs.Plant3D AppWnd = Window.Current<Dialogs.Plant3D>();
            //if (!AppWnd.IsEnabled && AppWnd.IsActive())
            //{
            //    CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
            //    CmdOpt_ErrorReport.ReportError(sError);
            //}
            //else
            //{
            //    //wActive wActive = Window.Current<wActive>();
            //    wActive.TypeKeys("<Esc 2>");
            //}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendCmd("_PROJECTMANAGER");
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
