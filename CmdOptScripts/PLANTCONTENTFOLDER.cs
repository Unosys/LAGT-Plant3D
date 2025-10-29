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
	public class PLANTCONTENTFOLDERCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTCONTENTFOLDER = new List<Command>
		{
			new PLANTCONTENTFOLDER()
		};
	}

	public class PLANTCONTENTFOLDER : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTCONTENTFOLDER");
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
			if (! Drawing.Current.GetCmdLineHistory(1).Contains("3D 2015"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}
}
