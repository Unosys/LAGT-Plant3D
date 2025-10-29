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
	public class PLANTPARTCONVERTCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTPARTCONVERT = new List<Command>
		{
			new PLANTPARTCONVERT(),
			new PLANTPARTCONVERT_ADD(),
			new PLANTPARTCONVERT_ADD_FLIPDIRECTION(),
			new PLANTPARTCONVERT_ADD_UNDO(),
			new PLANTPARTCONVERT_ADD_ACCEPT(),
			new PLANTPARTCONVERT_DELETE(),
			new PLANTPARTCONVERT_MOVE(),
			new PLANTPARTCONVERT_EXIT()
		};
	}

	public class PLANTPARTCONVERT : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_RECTANGLE");
			CmdOpt_Engine.EnterPoint(10,10);
			CmdOpt_Engine.EnterPoint(60,60);
			CmdOpt_Engine.SendCmd("_BLOCK");
			BlockDefinitionDLG BlockDefinitionDLG = new BlockDefinitionDLG();
			if (BlockDefinitionDLG.WaitExists(2 * 1000))
			{
				BlockDefinitionDLG.SetActive();
				BlockDefinitionDLG.NameCB.Text = "Temp";
				BlockDefinitionDLG.OK.Click();
				BlockNoObjectsSelectedTaskDLG BlockNoObjectsSelectedTaskDLG = new BlockNoObjectsSelectedTaskDLG();
				if (BlockNoObjectsSelectedTaskDLG.WaitExists(1 * 1000))
				{
					BlockNoObjectsSelectedTaskDLG.SetActive();
					BlockNoObjectsSelectedTaskDLG.TypeKeys("<enter>");
				}
			}
			System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.EnterCR();
			//BlockDefinitionDLG BlockDefinitionDLG = new BlockDefinitionDLG();
			if (BlockDefinitionDLG.WaitExists(2 * 1000))
			{
				BlockDefinitionDLG.SetActive();
				BlockDefinitionDLG.OK.Click();
                Autodesk.GUIHarness.AutoCAD.Dialogs.BlocksRedefineBlockDLG BlocksRedefineBlockDLG = new Autodesk.GUIHarness.AutoCAD.Dialogs.BlocksRedefineBlockDLG();
				if (BlocksRedefineBlockDLG.WaitExists(1 * 1000))
				{
					BlocksRedefineBlockDLG.SetActive();
					BlocksRedefineBlockDLG.TypeKeys("<TAB>");
					BlocksRedefineBlockDLG.TypeKeys("<ENTER>");
				}
			}
            //CmdOpt_Engine.StartLog();
            CmdOpt_Engine.SendCmd("PLANTPARTCONVERT");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOpt("_eXit");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_ADD : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOption("Add",1,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendOpt("_Undo");
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_ADD_FLIPDIRECTION : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOpt("_Add");
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendOption("Flip direction",1,3);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 2>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_ADD_UNDO : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOpt("_Add");
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendOption("Undo",2,3);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 2>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_ADD_ACCEPT : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOpt("_Add");
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendOption("Accept",3,3);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_DELETE : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOpt("_Add");
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendOpt("_Accept");
			CmdOpt_Engine.SendOption("Delete",2,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_DELETE_UNDO : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOpt("_Add");
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendOpt("_Accept");
			CmdOpt_Engine.SendOpt("_Delete");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOption("Undo",1,2);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC 2>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_DELETE_ACCEPT : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOpt("_Add");
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendOpt("_Accept");
			CmdOpt_Engine.SendOpt("_Delete");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOption("Accept",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_eXit");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_MOVE : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOpt("_Add");
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterInt(1);
			CmdOpt_Engine.SendOpt("_Accept");
			CmdOpt_Engine.SendOption("Move",3,4);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterPoint(70,30);
			CmdOpt_Engine.EnterPoint(150,100);
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC>");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTPARTCONVERT_EXIT : PLANTPARTCONVERT
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTPARTCONVERT");
			CmdOpt_Engine.EnterText("_LAST");
			CmdOpt_Engine.SendOption("eXit",4,4);
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<ESC>");
			//DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
			Plant3DFunctions.DeleteDrawing();
		}

		public override void Verify()
		{
		}
	}
}
