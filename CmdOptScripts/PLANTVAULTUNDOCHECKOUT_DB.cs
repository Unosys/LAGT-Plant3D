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
	public class PLANTVAULTUNDOCHECKOUT_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTVAULTUNDOCHECKOUT_DB = new List<Command>
		{
			new PLANTVAULTUNDOCHECKOUT_DB()
		};
	}

	public class PLANTVAULTUNDOCHECKOUT_DB : Command
	{
		public override void Launch()
		{
			////Plant3DFunctions.OpenProjectFromVault() Plant3DFunctions.OpenProjectFromVault() = Window.Current<Plant3DFunctions.OpenProjectFromVault()>();
			//Plant3DFunctions.OpenProjectFromVault();
			//Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc") Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc") = Window.Current<Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc")>();
			Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc");
			CmdOpt_Engine.SendCmd("_PLANTVAULTCHECKIN");
			CheckInDLG CheckInDLG = Window.Current<CheckInDLG>();
			CheckInDLG.SetActive();
			if (CheckInDLG.Exists)
			{
				CheckInDLG.SetActive();
				CheckInDLG.OK.Click();
				ProjectDataMergedVaultDLG ProjectDataMergedVaultDLG = Window.Current<ProjectDataMergedVaultDLG>();
				ProjectDataMergedVaultDLG.SetActive();
				ProjectDataMergedVaultDLG.BtnOk.Click();
			}
			CmdOpt_Engine.SendCmd("PLANTVAULTCHECKOUT");
			CheckOutFileDLG CheckOutFileDLG = Window.Current<CheckOutFileDLG>();
			CheckOutFileDLG.SetActive();
			CheckOutFileDLG.M_okBtn.Click();
			CmdOpt_Engine.SendCmd("PLANTVAULTUNDOCHECKOUT");
			UndoCheckoutDLG UndoCheckoutDLG = new UndoCheckoutDLG();
			if (UndoCheckoutDLG.Exists)
			{
				UndoCheckoutDLG.SetActive();
				UndoCheckoutDLG.TypeKeys("<Enter>");
			}
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//SetToDefault() SetToDefault() = Window.Current<SetToDefault()>();
			//SetToDefault();
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}
}
