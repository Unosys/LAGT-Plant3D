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
	public class PLANTSTEELRESTORECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTSTEELRESTORE = new List<Command>
		{
			new PLANTSTEELRESTORE(),
            new PLANTSTEELRESTORE_Undo()
		};
	}

	public class PLANTSTEELRESTORE : Command
	{
		public override void Launch()
		{
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTSTEELRESTORE");
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
			
		}

		public override void Verify()
		{
		}
	}
    public class PLANTSTEELRESTORE_Undo : PLANTSTEELRESTORE
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("PLANTSTEELRESTORE");
            CmdOpt_Engine.SendOption("Undo", 1, 1);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC 2>");
            Plant3DFunctions.DeleteAllDrawings();
        }

        public override void Verify()
        {
        }
    }
}
