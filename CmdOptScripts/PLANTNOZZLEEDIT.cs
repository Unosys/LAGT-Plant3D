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
	public class PLANTNOZZLEEDITCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTNOZZLEEDIT = new List<Command>
		{
			new PLANTNOZZLEEDIT()
		};
	}

	public class PLANTNOZZLEEDIT : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
			System.Threading.Thread.Sleep(7000);
			P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
			if (P3DCreateEquipmentDLG.WaitExists(2 * 1000))
			{
				P3DCreateEquipmentDLG.SetActive();
				P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
			}
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.EnterPoint(200,200);
			CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_ZOOM");
            CmdOpt_Engine.SendOpt("_Extent");
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
			CmdOpt_Engine.EnterText("_last");
			CmdOpt_Engine.SendOpt("_Height");
			CmdOpt_Engine.EnterInt(20);
			Drawing.Current.TypeKeys("<ESC>");
			CmdOpt_Engine.SendCmd("PLANTNOZZLEEDIT");
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 2>");
            Plant3DFunctions.DeleteDrawing("P3D");
        }

		public override void Verify()
		{
		}
	}
}
