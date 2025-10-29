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
	public class NewProjectCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcNewProject = new List<Command>
		{
			new NEWPROJECT(),
			new NEWPROJECT_PID(),
			new NEWPROJECT_3D()
		};
	}

	public class NEWPROJECT : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("-NewProject");
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

	public class NEWPROJECT_PID : NEWPROJECT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_-NewProject");
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

	public class NEWPROJECT_3D : NEWPROJECT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_-NewProject");
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
