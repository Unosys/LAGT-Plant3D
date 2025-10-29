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
using System.IO;
using Autodesk.GUIHarness.Plant3d.Core;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
	public class PLANTMODIFYSHAREDCONTENTFOLDERCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTMODIFYSHAREDCONTENTFOLDER = new List<Command>
		{
			new PLANTMODIFYSHAREDCONTENTFOLDER(),
			new PLANTMODIFYSHAREDCONTENTFOLDER_Yes(),
			new PLANTMODIFYSHAREDCONTENTFOLDER_No()
		};
	}

	public class PLANTMODIFYSHAREDCONTENTFOLDER : Command
	{
		public override void Launch()
		{
            String sPathcopy = "C:\\Temp1";
            if (!Directory.Exists(sPathcopy))
            {
                Directory.CreateDirectory(sPathcopy);
            }
            CmdOpt_Engine.SendCmd("-PLANTMODIFYSHAREDCONTENTFOLDER");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterText("C:\\Temp1");
			System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.SendOpt("_No");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTMODIFYSHAREDCONTENTFOLDER_Yes : PLANTMODIFYSHAREDCONTENTFOLDER
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_-PLANTMODIFYSHAREDCONTENTFOLDER");
			CmdOpt_Engine.EnterText("C:\\Temp1");
			CmdOpt_Engine.EnterCR();
			CmdOpt_Engine.SendCmd("_-PLANTMODIFYSHAREDCONTENTFOLDER");
			CmdOpt_Engine.EnterText("C:\\Temp2");
			System.Threading.Thread.Sleep(5000);
			CmdOpt_Engine.SendOption("Yes",1,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendCmd("_-PLANTMODIFYSHAREDCONTENTFOLDER");
			CmdOpt_Engine.EnterText(Plant3dConstants.Contentpath);//C:\\AutoCAD Plant 3D 2021 Content
            CmdOpt_Engine.SendOpt("_No");
		}

		public override void Verify()
		{
		}
	}

	public class PLANTMODIFYSHAREDCONTENTFOLDER_No : PLANTMODIFYSHAREDCONTENTFOLDER
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_-PLANTMODIFYSHAREDCONTENTFOLDER");
			CmdOpt_Engine.EnterText("C:\\Temp1");
			CmdOpt_Engine.SendOption("No",2,2);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.SendCmd("_-PLANTMODIFYSHAREDCONTENTFOLDER");
            CmdOpt_Engine.EnterText(Plant3dConstants.Contentpath);//C:\\AutoCAD Plant 3D 2021 Content

            CmdOpt_Engine.SendOpt("_No");
		}

		public override void Verify()
		{
		}
	}
}
