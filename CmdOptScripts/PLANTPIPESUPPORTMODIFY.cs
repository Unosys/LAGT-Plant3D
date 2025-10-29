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
	public class PLANTPIPESUPPORTMODIFYCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPIPESUPPORTMODIFY = new List<Command>
		{
			new PLANTPIPESUPPORTMODIFY()
		};
	}

	public class PLANTPIPESUPPORTMODIFY : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			Drawing.Current.SetSysVar("DYNMODE", -3);
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(50,50);
			System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.SetSysVar("DYNMODE", 0);
			CmdOpt_Engine.SendCmd("_Zoom");
			CmdOpt_Engine.SendOpt("_Extents");
			CmdOpt_Engine.SendCmd("_PLANTPIPESUPPORTADD");
			CmdOpt_Engine.EnterPoint(69,50,0);
			System.Threading.Thread.Sleep(5000);
			BeditModeDLG BeditModeDLG = new BeditModeDLG();
			if (BeditModeDLG.Exists)
			{
				BeditModeDLG.Click(MouseButton.Left, 257,205);
			}
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("PLANTPIPESUPPORTMODIFY");
		}

		public override void Dismiss()
		{
			BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
			BeditModeDLG.Click(MouseButton.Left, 255,186);
			System.Threading.Thread.Sleep(5000);
			ModifyPipeSupportDLG ModifyPipeSupportDLG = new ModifyPipeSupportDLG();
			if (ModifyPipeSupportDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 5))
			{
				ModifyPipeSupportDLG.SetActive();
				ModifyPipeSupportDLG.Cancel.Click();
			}
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}
}
