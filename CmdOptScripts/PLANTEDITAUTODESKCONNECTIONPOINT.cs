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
	public class PLANTEDITAUTODESKCONNECTIONPOINTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTEDITAUTODESKCONNECTIONPOINT = new List<Command>
		{
			new PLANTEDITAUTODESKCONNECTIONPOINT()
		};
	}

	public class PLANTEDITAUTODESKCONNECTIONPOINT : Command
	{
		public override void Launch()
		{
			//CopyDrawing("P3D", "AUTODESKCONNECTIONPOINT CopyDrawing("P3D", "AUTODESKCONNECTIONPOINT = Window.Current<CopyDrawing("P3D", "AUTODESKCONNECTIONPOINT>();
			Plant3DFunctions.CopyDrawing("AUTODESKCONNECTIONPOINT.dwg");
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_Extents");
			CmdOpt_Engine.SendCmd("PLANTEDITAUTODESKCONNECTIONPOINT");
			System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(47.8431,50.37);
            System.Threading.Thread.Sleep(5000);
            //PushButton CancelBtn = new Pane("#1").PushButton("Cancel|#3");
            //if (!CancelBtn.Exists)
            //{
            //    CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
            //    CmdOpt_ErrorReport.ReportError(sError);
            //}
            //else
            //{
            //    CancelBtn.Click();
            //}
            Autodesk.GUIHarness.Plant3D.Dialogs.AutodeskConnectionPointEditorDLG AutodeskConnectionPointEditorDLG = new Autodesk.GUIHarness.Plant3D.Dialogs.AutodeskConnectionPointEditorDLG();
			if (!AutodeskConnectionPointEditorDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
				AutodeskConnectionPointEditorDLG.CancelPB.Click();
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
