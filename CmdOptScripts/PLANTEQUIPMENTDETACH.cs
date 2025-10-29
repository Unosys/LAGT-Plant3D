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
	public class PLANTEQUIPMENTDETACHCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTEQUIPMENTDETACH = new List<Command>
		{
			new PLANTEQUIPMENTDETACH()
		};
	}

	public class PLANTEQUIPMENTDETACH : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTEQUIPMENTCREATE");
			System.Threading.Thread.Sleep(20000);
			P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
			if (P3DCreateEquipmentDLG.Exists)
			{
				P3DCreateEquipmentDLG.SetActive();
				P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
			}
			CmdOpt_Engine.EnterPoint(2000,500);
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("PLANTEQUIPMENTDETACH");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(2000,500);
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
