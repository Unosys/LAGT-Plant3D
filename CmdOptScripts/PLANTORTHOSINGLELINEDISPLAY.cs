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
	public class PLANTORTHOSINGLELINEDISPLAYCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2023";
		public List<Command> lcPLANTORTHOSINGLELINEDISPLAY = new List<Command>
		{
			new PLANTORTHOSINGLELINEDISPLAY()
		};
	}

	public class PLANTORTHOSINGLELINEDISPLAY : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.OpenSampleProject();
			ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
			PROJECTMANAGERDLG.SetActive();
			System.Threading.Thread.Sleep(2000);
			PROJECTMANAGERDLG.SetTab(2);
			Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			//Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");

			PROJECTMANAGERDLG.SetActive();
			Plant3DFunctions.ExpandTreeP3D(PROJECTMANAGERDLG.TreeViewTV, 4, "0,1");
			System.Threading.Thread.Sleep(2000);			
			CmdOpt_Engine.SendCmd("_ZOOM");
			CmdOpt_Engine.SendOpt("_ALL");
			CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEDISPLAY");
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.SendCmd("PLANTORTHOSINGLELINEDISPLAY");
			CmdOpt_Engine.EnterInt(1);

		}

		public override void Dismiss()
		{

			Drawing.Current.TypeE("_Close");
			System.Threading.Thread.Sleep(2000);
			Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
			if (SaveChangesMSG.WaitExists(2000))
			{
				SaveChangesMSG.NoPB.Click();

			}
			Plant3DFunctions.SetToDefault();
		}

		public override void Verify()
		{
		}
	}
}
