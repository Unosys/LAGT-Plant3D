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
    public class PLANTSPECNOTIFYCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2017";
        public List<Command> lcPLANTSPECNOTIFY = new List<Command>
		{
			new PLANTSPECNOTIFY(),
			new PLANTSPECNOTIFY_Off(),
            new PLANTSPECNOTIFY_On()
		};
    }
    public class PLANTSPECNOTIFY : Command
	{
		public override void Launch()
		{
            CmdOpt_Engine.SendCmd("PLANTSPECNOTIFY");
        }
        public override void Dismiss()
		{
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
        public override void Verify()
        {
        }
    }
    public class PLANTSPECNOTIFY_Off : PLANTSPECNOTIFY
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTSPECNOTIFY");
            if (AdOS.IsAsianLanguage)
            {
                CmdOpt_Engine.EnterText("Off");
            }
            else
            {
                string sString = (Plant3DMainWin.cBabel(23078, 1, "Off"));
                //int iLen = Len(sString);
                CmdOpt_Engine.EnterText(sString);
            }
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
    }
    public class PLANTSPECNOTIFY_On : PLANTSPECNOTIFY
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTSPECNOTIFY");
            if (AdOS.IsAsianLanguage)
            {
                CmdOpt_Engine.EnterText("On");
            }
            else
            {
                string sString = (Plant3DMainWin.cBabel(23078, 2, "On"));
                //int iLen = Len(sString);
                CmdOpt_Engine.EnterText(sString);
            }
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
    }
    
}
