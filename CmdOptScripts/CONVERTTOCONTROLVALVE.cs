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
using LoadUnloadApplicationsDLG = Autodesk.GUIHarness.Plant3D.Dialogs.LoadUnloadApplicationsDLG;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
	public class CONVERTTOCONTROLVALVECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcCONVERTTOCONTROLVALVE = new List<Command>
		{
			new CONVERTTOCONTROLVALVE()
		};
	}

	public class CONVERTTOCONTROLVALVE : Command
	{
		public override void Launch()
		{
			var PandIDActuatorBrowserDLG = new PandIDActuatorBrowserDLG();
			PandIDActuatorBrowserDLG.Invoke();
			PandIDActuatorBrowserDLG.CancelPB.Click();
            CmdOpt_Engine.SendCmd("_CONVERTTOCONTROLVALVE");
            PandIDActuatorBrowserDLG.BackPressureRegulatorTVI.Click();
			PandIDActuatorBrowserDLG.OKPB.Click();
            CmdOpt_Engine.EnterAngle(90);
			var PandIDAssignTagDLG = new PandIDAssignTagDLG();
			PandIDAssignTagDLG.AssignPB.Click();
			CmdOpt_Engine.StartLog();
            CmdOpt_Engine.SendCmd("CONVERTTOCONTROLVALVE");
        }

		public override void Dismiss()
		{
            CmdOpt_Engine.EnterPoint(10,10);
            CmdOpt_Engine.EnterPoint(20,20);           
            Drawing.Current.TypeKeys("<Esc>");
            PandIDFunctions.DeleteDrawing();
        }

		public override void Verify()
		{
		}
	}
}
