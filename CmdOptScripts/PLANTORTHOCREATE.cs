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
	public class PLANTORTHOCREATECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOCREATE = new List<Command>
		{
			new PLANTORTHOCREATE(),
            new PLANTORTHOCREATE_General(),
            new PLANTORTHOCREATE_General_Name(),
            new PLANTORTHOCREATE_General_View(),
            new PLANTORTHOCREATE_General_Scale(),
            new PLANTORTHOCREATE_BoundaryGeometry(),
            new PLANTORTHOCREATE_CreateOrthoView()
        };
	}

	public class PLANTORTHOCREATE : Command
	{
		public override void Launch()
		{
			
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Plant3DFunctions.CreateDrawing("P3D");
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetActive();
            Plant3DFunctions.CreateOrthoDrawingColurStyle("P3D");
            System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
            System.Threading.Thread.Sleep(3000);
            SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
            SelectOrthographicDrawingDLG SelectOrthographicDrawingDLG = new SelectOrthographicDrawingDLG();
            if (SelectReferenceModelsDLG.Exists)
            {
                SelectReferenceModelsDLG.SetActive();
                SelectReferenceModelsDLG.TypeKeys("<End>");
                SelectReferenceModelsDLG.TypeKeys("<Space>");
                SelectReferenceModelsDLG.M_btnOK.Click();
                System.Threading.Thread.Sleep(2000);
            }
            if (SelectOrthographicDrawingDLG.Exists)
            {
                SelectOrthographicDrawingDLG.TypeKeys("<Down 5>");//select p3d
                SelectOrthographicDrawingDLG.M_btnOK.Click();
                System.Threading.Thread.Sleep(2000);
            }
            CmdOpt_Engine.SendCmd("_.-PLANTORTHOCREATE");
        }

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_General");
			CmdOpt_Engine.SendOpt("_Name");
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC 3>");


		}

		public override void Verify()
		{
		}
	}


	public class PLANTORTHOCREATE_General : PLANTORTHOCREATE
	{
		public override void Launch()
		{
			
			CmdOpt_Engine.SendCmd("_.-PLANTORTHOCREATE");
			CmdOpt_Engine.SendOption("General", 1, 3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendOpt("_Name");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}
	public class PLANTORTHOCREATE_General_Name : PLANTORTHOCREATE
	{
		public override void Launch()
		{

			CmdOpt_Engine.SendCmd("_.-PLANTORTHOCREATE");
			CmdOpt_Engine.SendOpt("_General");
			CmdOpt_Engine.SendOption("Name", 1, 3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("Test");
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}
	public class PLANTORTHOCREATE_General_View : PLANTORTHOCREATE
	{
		public override void Launch()
		{

			CmdOpt_Engine.SendCmd("_.-PLANTORTHOCREATE");
			CmdOpt_Engine.SendOpt("_General");
			System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.SendOption("View", 2, 3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}
	public class PLANTORTHOCREATE_General_Scale : PLANTORTHOCREATE
	{
		public override void Launch()
		{

			CmdOpt_Engine.SendCmd("_.-PLANTORTHOCREATE");
			CmdOpt_Engine.SendOpt("_General");
			CmdOpt_Engine.SendOption("Scale", 3, 3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}
	public class PLANTORTHOCREATE_BoundaryGeometry : PLANTORTHOCREATE
	{
		public override void Launch()
		{

			CmdOpt_Engine.SendCmd("_.-PLANTORTHOCREATE");
			System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.SendOption("Boundary Geometry", 2, 3);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.EnterCR();
			Drawing.Current.TypeKeys("<ESC 3>");
		}

		public override void Verify()
		{
		}
	}
	public class PLANTORTHOCREATE_CreateOrthoView : PLANTORTHOCREATE
	{
		public override void Launch()
		{
			
			CmdOpt_Engine.SendCmd("_.-PLANTORTHOCREATE");
			System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.SendOption("Create Ortho View", 3, 3);
		}

		public override void Dismiss()
		{
			
			Drawing.Current.TypeKeys("<ESC 3>");
			System.Threading.Thread.Sleep(1000);
			Drawing.Current.TypeE("_Close");
			Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_Close");
			System.Threading.Thread.Sleep(1000);
            if (SaveChangesMSG.WaitExists(1000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(1000);
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            //Plant3DFunctions.DeleteAllDrawings();
			Plant3DFunctions.DeleteOrthoDrawing();
			
		}

		public override void Verify()
		{
		}
	}
	public class PLANTORTHOCREATE_CREATENEW : PLANTORTHOCREATE
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			//Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_.-PLANTORTHOCREATE");
			CmdOpt_Engine.SendOption("0...CreateNew", 1, 1);
		}

		public override void Dismiss()
		{
			Random rand = new Random();
			string sPname = "TestOrtho_" + (rand.Next(1, 100));
			CmdOpt_Engine.EnterText(sPname);
			System.Threading.Thread.Sleep(10000);
			CmdOpt_Engine.SendOpt("_Create");
			CmdOpt_Engine.EnterPoint(3, 3);
			Drawing.Current.TypeKeys("<ESC>");
			System.Threading.Thread.Sleep(1000);
			CmdOpt_Engine.SendCmd("_Close");
			System.Threading.Thread.Sleep(1000);
			PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
			if (PandIDWarningAutoCADDLG.Exists)
			{
				PandIDWarningAutoCADDLG.No.Click();
			}

			Plant3DFunctions.DeleteOrthoDrawing();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
