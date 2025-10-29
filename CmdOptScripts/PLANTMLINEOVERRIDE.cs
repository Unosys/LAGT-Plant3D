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
	public class PLANTMLINEOVERRIDECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTMLINEOVERRIDE = new List<Command>
		{
			new PLANTMLINEOVERRIDE()
		};
	}

	public class PLANTMLINEOVERRIDE : Command
	{
		public override void Launch()
		{
			
			CmdOpt_Engine.SendCmd("PLANTMLINEOVERRIDE");
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendCmd("PLANTMLINEOVERRIDE");
			CmdOpt_Engine.EnterInt(2);
			CmdOpt_Engine.SendCmd("PLANTMLINEOVERRIDE");
			CmdOpt_Engine.EnterInt(3);
			CmdOpt_Engine.SendCmd("PLANTMLINEOVERRIDE");
			CmdOpt_Engine.EnterInt(3);
			
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}
}
