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
	public class NEWPROJECTDWGCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcNEWPROJECTDWG = new List<Command>
		{
			new NEWPROJECTDWG(),
			new NEWPROJECTDWG_PID(),
			new NEWPROJECTDWG_3D()
		};
	}

	public class NEWPROJECTDWG : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("-NewProjectDWG");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_3D");
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class NEWPROJECTDWG_PID : NEWPROJECTDWG
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_-NewProjectDWG");
			CmdOpt_Engine.SendOption("PID",1,2);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class NEWPROJECTDWG_3D : NEWPROJECTDWG
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_-NewProjectDWG");
			CmdOpt_Engine.SendOption("3D",2,2);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}
}
