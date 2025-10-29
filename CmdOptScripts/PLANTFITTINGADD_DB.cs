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
	public class PLANTFITTINGADD_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTFITTINGADD_DB = new List<Command>
		{
			new PLANTFITTINGADD_DB()
		};
	}

	public class PLANTFITTINGADD_DB : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTFITTINGADD");
			//System.Threading.Thread.Sleep(7000);
            PlantFittingAddDLG PlantFittingAddDLG = Window.Current<PlantFittingAddDLG>(); //add dialog declaration later!!!
            PlantFittingAddDLG.SetActive();
            if (PlantFittingAddDLG.WaitExists(10000))
            {
                Desktop.Current.TypeKeys("<ESC>");
                //PlantFittingAddDLG.Close();
            }
            else
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);
                Drawing.Current.TypeKeys("<Esc 2>");
            }
		}

		public override void Dismiss()
		{
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
