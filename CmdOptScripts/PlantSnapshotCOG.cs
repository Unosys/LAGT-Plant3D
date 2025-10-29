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
	public class PlantSnapshotCOGCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPlantSnapshotCOG = new List<Command>
		{
			new PLANTSNAPSHOTCOG()
		};
	}

	public class PLANTSNAPSHOTCOG : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CopyDrawing("PLANTEDITCOG.dwg");
			CmdOpt_Engine.StartLog();
			CmdOpt_Engine.SendCmd("PLANTSNAPSHOTCOG");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
		}

		public override void Dismiss()
		{
			//BeditModeDLG BeditModeDLG = Window.Current<BeditModeDLG>();
			//BeditModeDLG.Click(MouseButton.Left, 304, 189);
			//CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_close");
            Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();
            }
            Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
