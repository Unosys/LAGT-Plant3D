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
	public class PLANTEDITCOGCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTEDITCOG = new List<Command>
		{
			new PLANTEDITCOG(),
			new PLANTEDITCOG_Edit(),
			new PLANTEDITCOG_ResetCOG(),
			new PLANTEDITCOG_Selectanotherobject(),
			new PLANTEDITCOG_Undo(),
			new PLANTEDITCOG_eNdCommand()
		};
	}

	public class PLANTEDITCOG : Command
	{
		public override void Launch()
		{
			//CopyDrawing("P3D", "PLANTEDITCOG CopyDrawing("P3D", "PLANTEDITCOG = Window.Current<CopyDrawing("P3D", "PLANTEDITCOG>();
			Plant3DFunctions.CopyDrawing("PLANTEDITCOG.dwg");
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_PROJECTMANAGERCLOSE");
            CmdOpt_Engine.SendCmd("_ZOOM");
            CmdOpt_Engine.SendOpt("_E");
			CmdOpt_Engine.SendCmd("PLANTEDITCOG");
		}

		public override void Dismiss()
		{

            //BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
            //BeditModeDLG.Click(MouseButton.Left, 330, 195);
            CmdOpt_Engine.EnterPoint( -1974,1425);
            //CmdOpt_Engine.SendOpt("_last");
			CmdOpt_Engine.SendOpt("_eNd");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTEDITCOG_Edit : PLANTEDITCOG
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTEDITCOG");
            //BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
            //BeditModeDLG.Click(MouseButton.Left, 330, 195);
            CmdOpt_Engine.EnterPoint(-1974,1425);
            //CmdOpt_Engine.SendOpt("_last");
			CmdOpt_Engine.SendOption("Edit",1,5);
		}

		public override void Dismiss()
		{
            //BeditModeDLG BeditModeDLG = new BeditModeDLG();
            //BeditModeDLG.Click(MouseButton.Left, 240, 228);
            //Drawing.Current.Click(MouseButton.Left, -1974, 1425);
            CmdOpt_Engine.EnterPoint(50, 50);
			CmdOpt_Engine.SendOpt("_eNd");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTEDITCOG_ResetCOG : PLANTEDITCOG
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTEDITCOG");
            //BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
            //BeditModeDLG.Click(MouseButton.Left, 330, 195);
            CmdOpt_Engine.EnterPoint(-1974, 1425);
            //CmdOpt_Engine.SendOpt("_last");
			CmdOpt_Engine.SendOption("Reset",2,5);
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}

	public class PLANTEDITCOG_Selectanotherobject : PLANTEDITCOG
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTEDITCOG");
            //BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
            //BeditModeDLG.Click(MouseButton.Left, 330, 195);
            //CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterPoint(-1974, 1425);
            CmdOpt_Engine.SendOption("Select another object", 3, 5);
		}

		public override void Dismiss()
		{
            //BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
            //BeditModeDLG.Click(MouseButton.Left, 307, 297);
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(-1974, 1425);
            //Desktop.Current.Click(MouseButton.Left, 330, 240);
            CmdOpt_Engine.SendOpt("_eNd");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTEDITCOG_Undo : PLANTEDITCOG
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTEDITCOG");
            //BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
            //BeditModeDLG.Click(MouseButton.Left, 330, 195);
            //CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterPoint(-1974, 1425);
            CmdOpt_Engine.SendOption("Undo",4,5);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_eNd");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTEDITCOG_eNdCommand : PLANTEDITCOG
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTEDITCOG");
            //BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
            //BeditModeDLG.Click(MouseButton.Left, 330, 195);
            //CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterPoint(-1974, 1425);
            CmdOpt_Engine.SendOption("eNd",5,5);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendCmd("_ProjectManager");
            //DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            Plant3DFunctions.DeleteAllDrawings();
        }

		public override void Verify()
		{
		}
	}
}
