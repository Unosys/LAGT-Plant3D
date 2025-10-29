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
	public class EXPORTTOAUTOCADCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcEXPORTTOAUTOCAD = new List<Command>
		{
			new EXPORTTOAUTOCAD(),
			new EXPORTTOAUTOCAD_2007(),
			new EXPORTTOAUTOCAD_2010(),
			new EXPORTTOAUTOCAD_2013(),
			new EXPORTTOAUTOCAD_2018()
		};
	}

	public class EXPORTTOAUTOCAD : Command
	{
		public override void Launch()
		{
            //CreateDraw() CreateDraw() = Window.Current<CreateDraw()>();
            PandIDFunctions.CreateDrawing();
			CmdOpt_Engine.SendCmd("_Save");
			CmdOpt_Engine.EnterCR();
			//CmdOpt_Engine.SendOpt("_YES");
			CmdOpt_Engine.SendCmd("-EXPORTTOAUTOCAD");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_2010");
			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//DeleteDrawing() DeleteDrawing() = Window.Current<DeleteDrawing()>();
			PandIDFunctions.DeleteDrawing();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}

	public class EXPORTTOAUTOCAD_2007 : EXPORTTOAUTOCAD
	{
		public override void Launch()
		{
			if (System.IO.File.Exists(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"))
			{
				System.IO.File.Delete(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"); ;
			}
			PandIDFunctions.CreateDrawing();

            CmdOpt_Engine.SendCmd("_Save");
			CmdOpt_Engine.EnterCR();
			//CmdOpt_Engine.SendOpt("_YES");
			CmdOpt_Engine.SendCmd("_-EXPORTTOAUTOCAD");
			CmdOpt_Engine.SendOption("2007",1,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"); ;

			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//DeleteDrawing() DeleteDrawing() = Window.Current<DeleteDrawing()>();
			PandIDFunctions.DeleteDrawing();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}

	public class EXPORTTOAUTOCAD_2010 : EXPORTTOAUTOCAD
	{
		public override void Launch()
		{
			if (System.IO.File.Exists(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"))
			{
				System.IO.File.Delete(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"); ;
			}
			PandIDFunctions.CreateDrawing();
			CmdOpt_Engine.SendCmd("_Save");
			CmdOpt_Engine.EnterCR();
			//CmdOpt_Engine.SendOpt("_YES");
			CmdOpt_Engine.SendCmd("_-EXPORTTOAUTOCAD");
			CmdOpt_Engine.SendOption("2010",2,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"); ;

			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
            //DeleteDrawing() DeleteDrawing() = Window.Current<DeleteDrawing()>();
            PandIDFunctions.DeleteDrawing();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}
    public class EXPORTTOAUTOCAD_2013 : EXPORTTOAUTOCAD
    {
        public override void Launch()
        {
			if (System.IO.File.Exists(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"))
			{
				System.IO.File.Delete(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"); ;
			}
			PandIDFunctions.CreateDrawing();
            CmdOpt_Engine.SendCmd("_Save");
            CmdOpt_Engine.EnterCR();
            //CmdOpt_Engine.SendOpt("_YES");
            CmdOpt_Engine.SendCmd("_-EXPORTTOAUTOCAD");
            CmdOpt_Engine.SendOption("2013", 3, 4);
        }

        public override void Dismiss()
        {
			CmdOpt_Engine.EnterText(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"); ;

			Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            //DeleteDrawing() DeleteDrawing() = Window.Current<DeleteDrawing()>();
            PandIDFunctions.DeleteDrawing();
            //CmdOpt_Engine.SendCmd("_Close");
        }

        public override void Verify()
        {
        }
    }
	public class EXPORTTOAUTOCAD_2018 : EXPORTTOAUTOCAD
	{
		public override void Launch()
		{
			if (System.IO.File.Exists(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"))
			{
				System.IO.File.Delete(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"); ;
			}
			PandIDFunctions.CreateDrawing();
			CmdOpt_Engine.SendCmd("_Save");
			CmdOpt_Engine.EnterCR();
			//CmdOpt_Engine.SendOpt("_YES");
			CmdOpt_Engine.SendCmd("_-EXPORTTOAUTOCAD");
			CmdOpt_Engine.SendOption("2018", 4, 4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText(LAGT.CommonFiles.AutomationTests.Variables.AutomationResultsDir + "EXPORTTOAUTOCAD.dwg"); ;

			Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeKeys("<Esc>");
			//DeleteDrawing() DeleteDrawing() = Window.Current<DeleteDrawing()>();
			PandIDFunctions.DeleteDrawing();
			//CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}
}
