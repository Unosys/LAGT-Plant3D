using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using LAGT.CommonFiles.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness.Plant3D.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
	public class PLANTINSULATIONCOLORCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTINSULATIONCOLOR = new List<Command>
		{
			new PLANTINSULATIONCOLOR()
		};
	}

	public class PLANTINSULATIONCOLOR : Command
	{
		public override void Launch()
		{
			
			CmdOpt_Engine.SendCmd("PLANTINSULATIONCOLOR");
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.SendCmd("PLANTINSULATIONCOLOR");
			CmdOpt_Engine.EnterInt(255);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendCmd("_PLANTINSULATIONCOLOR");
			CmdOpt_Engine.EnterInt(256);
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}
}
