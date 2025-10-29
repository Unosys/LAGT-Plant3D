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
	public class PLANTINVENTOREQUIPMENTCONVERTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTINVENTOREQUIPMENTCONVERT = new List<Command>
		{
			new PLANTINVENTOREQUIPMENTCONVERT()
		};
	}

	public class PLANTINVENTOREQUIPMENTCONVERT : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTINVENTOREQUIPMENTCONVERT");
			ImportInventorComponentDLG ImportInventorComponentDLG = Window.Current<ImportInventorComponentDLG>();
			ImportInventorComponentDLG.SetActive();
			ImportInventorComponentDLG.FileNameCB.Text = "S:\\Test Files\\Plant3D\\ADSKSample.adsk";
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
