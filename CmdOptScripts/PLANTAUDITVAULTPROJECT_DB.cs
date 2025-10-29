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
	public class PLANTAUDITVAULTPROJECT_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTAUDITVAULTPROJECT_DB = new List<Command>
		{
			new PLANTAUDITVAULTPROJECT_DB()
		};
	}

	public class PLANTAUDITVAULTPROJECT_DB : Command
	{
		public override void Launch()
		{
			CheckInDLG CheckInDLG = new CheckInDLG();
			CheckInDLG.Invoke();
			//CheckInDLG CheckInDLG = Window.Current<CheckInDLG>();
			CheckInDLG.SetActive();
			CheckInDLG.OK.Click();
			ProjectDataMergedVaultDLG ProjectDataMergedVaultDLG = Window.Current<ProjectDataMergedVaultDLG>();
			ProjectDataMergedVaultDLG.SetActive();
			ProjectDataMergedVaultDLG.BtnOk.Click();
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			CmdOpt_Engine.SendCmd("PLANTAUDITVAULTPROJECT");
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//CheckOutDrawing() CheckOutDrawing() = Window.Current<CheckOutDrawing()>();
			//CheckOutDrawing();
			//SetToDefault() SetToDefault() = Window.Current<SetToDefault()>();
			//SetToDefault();
		}

		public override void Verify()
		{
		}
	}
}
