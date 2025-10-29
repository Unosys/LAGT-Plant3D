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
	public class PLANTDYNAMICTOOLPALETTECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTDYNAMICTOOLPALETTE = new List<Command>
		{
			new PLANTDYNAMICTOOLPALETTE(),
			new PLANTDYNAMICTOOLPALETTE_ENABLE(),
			new PLANTDYNAMICTOOLPALETTE_DISABLE()
		};
	}

	public class PLANTDYNAMICTOOLPALETTE : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTDYNAMICTOOLPALETTE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_Disable");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTDYNAMICTOOLPALETTE_ENABLE : PLANTDYNAMICTOOLPALETTE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTDYNAMICTOOLPALETTE");
			CmdOpt_Engine.SendOption("Enable",1,2);
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}

	public class PLANTDYNAMICTOOLPALETTE_DISABLE : PLANTDYNAMICTOOLPALETTE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTDYNAMICTOOLPALETTE");
			CmdOpt_Engine.SendOption("Disable",2,2);
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}
}
