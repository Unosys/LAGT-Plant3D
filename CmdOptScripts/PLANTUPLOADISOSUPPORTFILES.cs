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
	public class PLANTUPLOADISOSUPPORTFILESCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTUPLOADISOSUPPORTFILES = new List<Command>
		{
			new PLANTUPLOADISOSUPPORTFILES(),
			new PLANTUPLOADISOSUPPORTFILES_OFF(),
			new PLANTUPLOADISOSUPPORTFILES_ON()
		};
	}

	public class PLANTUPLOADISOSUPPORTFILES : Command
	{
		public override void Launch()
		{
			
			CmdOpt_Engine.SendCmd("PLANTUPLOADISOSUPPORTFILES");
			CmdOpt_Engine.EnterInt(0);
			CmdOpt_Engine.SendCmd("PLANTUPLOADISOSUPPORTFILES");
			CmdOpt_Engine.EnterInt(1);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}
	public class PLANTUPLOADISOSUPPORTFILES_OFF : Command
	{
		public override void Launch()
		{

			CmdOpt_Engine.SendCmd("_PLANTUPLOADISOSUPPORTFILES");
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
	public class PLANTUPLOADISOSUPPORTFILES_ON : Command
	{
		public override void Launch()
		{

			CmdOpt_Engine.SendCmd("_PLANTUPLOADISOSUPPORTFILES");
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
