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
	public class PLANTP360AUTOCHECKINCLASS
    {
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTP360AUTOCHECKIN = new List<Command>
		{
			new PLANTP360AUTOCHECKIN(),
			new PLANTP360AUTOCHECKIN_0(),
			new PLANTP360AUTOCHECKIN_1()
		};
	}

	public class PLANTP360AUTOCHECKIN : Command
	{
		public override void Launch()
		{
			
            CmdOpt_Engine.SendCmd("PLANTP360AUTOCHECKIN");
        }

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTP360AUTOCHECKIN_0 : PLANTP360AUTOCHECKIN
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTP360AUTOCHECKIN");
            CmdOpt_Engine.EnterInt(0);
        }

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}

	public class PLANTP360AUTOCHECKIN_1 : PLANTP360AUTOCHECKIN
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTP360AUTOCHECKIN");
            CmdOpt_Engine.EnterInt(1);
        }

		public override void Dismiss()
		{
			
		}

		public override void Verify()
		{
		}
	}
}
