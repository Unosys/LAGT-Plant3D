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
	public class PLANTISOTIMEOUTCLASS
    {
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTISOTIMEOUT = new List<Command>
		{
			new PLANTISOTIMEOUT()
		};
	}

	public class PLANTISOTIMEOUT : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTISOTIMEOUT");
            CmdOpt_Engine.EnterInt(1441);
            CmdOpt_Engine.EnterInt(-1);
            CmdOpt_Engine.EnterInt(40);
            CmdOpt_Engine.EnterInt(30);
            CmdOpt_Engine.SendCmd("PLANTISOTIMEOUT");
        }

		public override void Dismiss()
		{
            
          
            Drawing.Current.TypeKeys("<Esc>");
        }

		public override void Verify()
		{
		}
	}
}
