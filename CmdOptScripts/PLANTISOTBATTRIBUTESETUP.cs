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
	public class PLANTISOTBATTRIBUTESETUPCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTISOTBATTRIBUTESETUP = new List<Command>
		{
			new PLANTISOTBATTRIBUTESETUP()
		};
	}

	public class PLANTISOTBATTRIBUTESETUP : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
            Plant3DFunctions.SetupTitleBlock();
			System.Threading.Thread.Sleep(20000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTISOTBATTRIBUTESETUP");
			InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributesDLG();
			if (InsertTitleBlockAttributesDLG.WaitExists(10000))
			{
                InsertTitleBlockAttributesDLG.M_closeButton.Click();
            }
			else
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			//SetupTitleBlockClose() SetupTitleBlockClose() = Window.Current<SetupTitleBlockClose()>();
            Plant3DFunctions.SetupTitleBlockClose();
			Drawing.Current.TypeE("_close");
			WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
			if (WarningAutoCADDLG.WaitExists(3 * 1000))
			{
				WarningAutoCADDLG.No.Click();
			}
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBATTRIBUTESETUP_Insert : PLANTISOTBATTRIBUTESETUP
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_DYNMODE");
			CmdOpt_Engine.EnterInt(-3);
			//SetupTitleBlock() SetupTitleBlock() = Window.Current<SetupTitleBlock()>();
            Plant3DFunctions.SetupTitleBlock();
			System.Threading.Thread.Sleep(20000);
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("_PLANTISOTBATTRIBUTESETUP");
			InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributesDLG();
			if (! InsertTitleBlockAttributesDLG.WaitExists(LAGT.CommonFiles.Core.Variables.Timeout * 2))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
			else
			{
				//InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = Window.Current<InsertTitleBlockAttributesDLG>();
				InsertTitleBlockAttributesDLG.M_closeButton.Click();
				Drawing.Current.TypeKeys("<Esc>");
				CmdOpt_Engine.SendCmd("_bclose");
				BlockChangesNotSavedDLG BlockChangesNotSavedDLG = new BlockChangesNotSavedDLG();
				if (BlockChangesNotSavedDLG.WaitExists(2 * 1000))
				{
					BlockChangesNotSavedDLG.TypeKeys("<tab><Enter>");
				}
                BlockChangesNotSavedDLG2 BlockChangesNotSavedDLG2 = new BlockChangesNotSavedDLG2();
                if (BlockChangesNotSavedDLG2.WaitExists(2 * 1000))
                {
                    BlockChangesNotSavedDLG2.SetActive();
                    BlockChangesNotSavedDLG2.DiscardTheChangesAndPB.Click();
                }
				CmdOpt_Engine.SendCmd("_Erase");
				CmdOpt_Engine.SendOpt("_All");
				CmdOpt_Engine.EnterCR();
				CmdOpt_Engine.SendCmd("_PLANTISOTBATTRIBUTESETUP");
				CmdOpt_Engine.SendOption("Insert", 1, 1);
			}
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
			if (!Drawing.Current.GetCmdLine().Contains("[*/*/*/*/*/*]"))
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("OPT_NOT_WORKING", "The insert option should prompt for Basepoint and other parameters", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
		}
	}

	public class PLANTISOTBATTRIBUTESETUP_Insert_Basepoint : PLANTISOTBATTRIBUTESETUP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBATTRIBUTESETUP");
			CmdOpt_Engine.SendOpt("I");
			CmdOpt_Engine.SendOption("Basepoint",1,6);
			CmdOpt_Engine.EnterPoint(12,12);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBATTRIBUTESETUP_Insert_Scale : PLANTISOTBATTRIBUTESETUP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBATTRIBUTESETUP");
			CmdOpt_Engine.SendOpt("I");
			CmdOpt_Engine.SendOption("Scale",2,6);
			CmdOpt_Engine.EnterInt(1);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBATTRIBUTESETUP_Insert_X : PLANTISOTBATTRIBUTESETUP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBATTRIBUTESETUP");
			CmdOpt_Engine.SendOpt("I");
			CmdOpt_Engine.SendOption("X",3,6);
			CmdOpt_Engine.EnterInt(1);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBATTRIBUTESETUP_Insert_Y : PLANTISOTBATTRIBUTESETUP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBATTRIBUTESETUP");
			CmdOpt_Engine.SendOpt("I");
			CmdOpt_Engine.SendOption("Y",4,6);
			CmdOpt_Engine.EnterInt(1);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBATTRIBUTESETUP_Insert_Z : PLANTISOTBATTRIBUTESETUP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBATTRIBUTESETUP");
			CmdOpt_Engine.SendOpt("I");
			CmdOpt_Engine.SendOption("Z",5,6);
			CmdOpt_Engine.EnterInt(1);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTISOTBATTRIBUTESETUP_Insert_Rotate : PLANTISOTBATTRIBUTESETUP
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTBATTRIBUTESETUP");
			CmdOpt_Engine.SendOpt("I");
			CmdOpt_Engine.SendOption("Rotate",6,6);
			CmdOpt_Engine.EnterInt(45);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc>");
			//SetupTitleBlockClose() SetupTitleBlockClose() = Window.Current<SetupTitleBlockClose()>();
            Plant3DFunctions.SetupTitleBlockClose();
			//DeleteAllDrawings() DeleteAllDrawings() = Window.Current<DeleteAllDrawings()>();
			Plant3DFunctions.DeleteAllDrawings();
			CmdOpt_Engine.SendCmd("_Close");
		}

		public override void Verify()
		{
		}
	}
}
