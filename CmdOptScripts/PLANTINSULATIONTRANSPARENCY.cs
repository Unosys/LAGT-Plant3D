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
	public class PLANTINSULATIONTRANSPARENCYCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTINSULATIONTRANSPARENCY = new List<Command>
		{
			new PLANTINSULATIONTRANSPARENCY()
		};
	}

	public class PLANTINSULATIONTRANSPARENCY : Command
	{
		public override void Launch()
		{
			
			CmdOpt_Engine.SendCmd("PLANTINSULATIONTRANSPARENCY");
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.SendCmd("PLANTINSULATIONTRANSPARENCY");
			CmdOpt_Engine.EnterInt(-2);
			CmdOpt_Engine.SendCmd("PLANTINSULATIONTRANSPARENCY");
			CmdOpt_Engine.EnterInt(-1);
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
