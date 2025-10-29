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
	public class PLANTSNAPTOCONTENTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSNAPTOCONTENT = new List<Command>
		{
			new PLANTSNAPTOCONTENT(),
			new PLANTSNAPTOCONTENT_0(),
			new PLANTSNAPTOCONTENT_1()
		};
	}

	public class PLANTSNAPTOCONTENT : Command
	{
		public override void Launch()
		{
			
            CmdOpt_Engine.SendCmd("PLANTSNAPTOCONTENT");
        }

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSNAPTOCONTENT_0 : PLANTSNAPTOCONTENT
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTSNAPTOCONTENT");
            CmdOpt_Engine.EnterInt(0);
        }

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}

	public class PLANTSNAPTOCONTENT_1 : PLANTSNAPTOCONTENT
    {
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTSNAPTOCONTENT");
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
