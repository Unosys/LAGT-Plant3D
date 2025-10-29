using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using LAGT.CommonFiles.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
    public class PLANTAUTOMAPPIPELINECLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTAUTOMAPPIPELINE = new List<Command>
        {
            new PLANTAUTOMAPPIPELINE(),
            new PLANTAUTOMAPPIPELINE_OFF(),
            new PLANTAUTOMAPPIPELINE_ON()
        };
    }

    public class PLANTAUTOMAPPIPELINE : Command
    {
        public override void Launch()
        {

            CmdOpt_Engine.SendCmd("PLANTAUTOMAPPIPELINE");
            CmdOpt_Engine.EnterInt(0);
            CmdOpt_Engine.SendCmd("PLANTAUTOMAPPIPELINE");
            CmdOpt_Engine.EnterInt(1);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTAUTOMAPPIPELINE_OFF : Command
    {
        public override void Launch()
        {

            CmdOpt_Engine.SendCmd("_PLANTAUTOMAPPIPELINE");
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
            Drawing.Current.TypeKeys("<ESC>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTAUTOMAPPIPELINE_ON : Command
    {
        public override void Launch()
        {

            CmdOpt_Engine.SendCmd("_PLANTAUTOMAPPIPELINE");
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
            Drawing.Current.TypeKeys("<ESC>");
        }

        public override void Verify()
        {
        }
    }
}
