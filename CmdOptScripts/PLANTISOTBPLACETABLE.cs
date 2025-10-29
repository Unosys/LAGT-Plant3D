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
	public class PLANTISOTBPLACETABLECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTISOTBPLACETABLE = new List<Command>
		{
			new PLANTISOTBPLACETABLE(),
           

            new PLANTISOTBPLACETABLE_Billofmaterials(),
            new PLANTISOTBPLACETABLE_Billofmaterials_Addtoexistingarea(),
            new PLANTISOTBPLACETABLE_Billofmaterials_Undo(),
            new PLANTISOTBPLACETABLE_Billofmaterials_eXit(),
            new PLANTISOTBPLACETABLE_Cutpiece(),
            new PLANTISOTBPLACETABLE_Weld(),
             new PLANTISOTBPLACETABLE_Spool()
        };
	}

	public class PLANTISOTBPLACETABLE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			//SetupTitleBlock() SetupTitleBlock() = Window.Current<SetupTitleBlock()>();
            Plant3DFunctions.SetupTitleBlock();
			System.Threading.Thread.Sleep(15000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTISOTBPLACETABLE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendOpt("_eXit");
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBPLACETABLE_Billofmaterials : PLANTISOTBPLACETABLE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBPLACETABLE");
            CmdOpt_Engine.SendOption("Bill of materials", 1, 4);
			CmdOpt_Engine.EnterCR();
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_eXit");
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBPLACETABLE_Billofmaterials_Addtoexistingarea : PLANTISOTBPLACETABLE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBPLACETABLE");
            CmdOpt_Engine.SendOption("Bill of materials", 1, 4);
            CmdOpt_Engine.SendOption("Add to existing area", 1, 3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_eXit");
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBPLACETABLE_Billofmaterials_Undo : PLANTISOTBPLACETABLE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBPLACETABLE");
            CmdOpt_Engine.SendOption("Bill of materials", 1, 4);
			CmdOpt_Engine.SendOption("Undo",2,3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_eXit");
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBPLACETABLE_Billofmaterials_eXit : PLANTISOTBPLACETABLE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBPLACETABLE");
            CmdOpt_Engine.SendOption("Bill of materials", 1, 4);
			CmdOpt_Engine.SendOption("eXit",3,3);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBPLACETABLE_Cutpiece : PLANTISOTBPLACETABLE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBPLACETABLE");
            CmdOpt_Engine.SendOption("Cut piece", 2, 4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_eXit");
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBPLACETABLE_Weld : PLANTISOTBPLACETABLE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBPLACETABLE");
			CmdOpt_Engine.SendOption("Weld",3,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_eXit");
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBPLACETABLE_Spool : PLANTISOTBPLACETABLE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBPLACETABLE");
            System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.SendOption("Spool",4,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_eXit");
            System.Threading.Thread.Sleep(10000);
            Drawing.Current.TypeKeys("<Esc 3>");
            CmdOpt_Engine.SendCmd("_CLOSE");
            System.Threading.Thread.Sleep(20000);
            IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
            if (IsometricDWGSettingsTitleBlockandDisplayDLG.WaitExists(2000))
            {
                IsometricDWGSettingsTitleBlockandDisplayDLG.Dismiss();
                System.Threading.Thread.Sleep(10000);
            }
            //SetupTitleBlockClose() SetupTitleBlockClose() = Window.Current<SetupTitleBlockClose()>();
            //Plant3DFunctions.SetupTitleBlockClose();
            //DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            //System.Threading.Thread.Sleep(16000);
            //Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
