using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using LAGT.CommonFiles.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
	public class PLANTANNOTATEDYNAMICINSTRUMENTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTANNOTATEDYNAMICINSTRUMENT = new List<Command>
		{
			new PLANTANNOTATEDYNAMICINSTRUMENT(),
			new PLANTANNOTATEDYNAMICINSTRUMENT_OFF(),
			new PLANTANNOTATEDYNAMICINSTRUMENT_ON()
		};
	}

	public class PLANTANNOTATEDYNAMICINSTRUMENT : Command
	{
		public override void Launch()
        {//NOTE : this command is removed refer :https://jira.autodesk.com/browse/PLANT-29702

            CmdOpt_Engine.SendCmd("PLANTANNOTATEDYNAMICINSTRUMENT");
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendCmd("PLANTANNOTATEDYNAMICINSTRUMENT");
			CmdOpt_Engine.EnterInt(0);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}
	public class PLANTANNOTATEDYNAMICINSTRUMENT_OFF : Command
	{
		public override void Launch()
		{

			CmdOpt_Engine.SendCmd("_PLANTANNOTATEDYNAMICINSTRUMENT");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("Off");
			}
			else
			{
				string sString = (Plant3DMainWin.cBabel(23078, 1, "Off"));
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}
	public class PLANTANNOTATEDYNAMICINSTRUMENT_ON : Command
	{
		public override void Launch()
		{

			CmdOpt_Engine.SendCmd("_PLANTANNOTATEDYNAMICINSTRUMENT");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("On");
			}
			else
			{
				string sString = (Plant3DMainWin.cBabel(23078, 2, "On"));
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
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
