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
	public class PLANTSTEELEDGECUTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELEDGECUT = new List<Command>
		{
			new PLANTSTEELEDGECUT()
		};
	}

	public class PLANTSTEELEDGECUT : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTEQUIPMENTCREATE");
			//System.Threading.Thread.Sleep(10000);
			P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
			if (P3DCreateEquipmentDLG.WaitExists(10000))
			{
				P3DCreateEquipmentDLG.SetActive();
				P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
			}
			CmdOpt_Engine.EnterPoint(500,300);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_all");
			CmdOpt_Engine.SendCmd("PLANTSTEELEDGECUT");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterInt(10);
			CmdOpt_Engine.EnterPoint(500,300);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			string sCmdOpt = Drawing.Current.GetCmdLineHistory(1);
            //AdResultLog.Current.Print(sCmdOpt);
            if (!sCmdOpt.WcMatch("0*0*1*"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "1 object should have been removed from selection'.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteDrawing();
		}
	}
}
