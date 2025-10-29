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
    public class PLANTSPECNOTIFYTIMECLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2017";
        public List<Command> lcPLANTSPECNOTIFYTIME = new List<Command>
		{
			new PLANTSPECNOTIFYTIME(),
			new PLANTSPECNOTIFYTIME_0(),
            new PLANTSPECNOTIFYTIME_1(),
            new PLANTSPECNOTIFYTIME_2(),
            new PLANTSPECNOTIFYTIME_3(),
            new PLANTSPECNOTIFYTIME_4(),
            new PLANTSPECNOTIFYTIME_5()
		};
    }
    public class PLANTSPECNOTIFYTIME : Command
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("PLANTSPECNOTIFYTIME");
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
    public class PLANTSPECNOTIFYTIME_0 : PLANTSPECNOTIFYTIME
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTSPECNOTIFYTIME");
            CmdOpt_Engine.EnterInt(0);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
    }
    public class PLANTSPECNOTIFYTIME_1 : PLANTSPECNOTIFYTIME
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTSPECNOTIFYTIME");
            CmdOpt_Engine.EnterInt(1);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
    }
    public class PLANTSPECNOTIFYTIME_2 : PLANTSPECNOTIFYTIME
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTSPECNOTIFYTIME");
            CmdOpt_Engine.EnterInt(2);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
    }
    public class PLANTSPECNOTIFYTIME_3 : PLANTSPECNOTIFYTIME
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTSPECNOTIFYTIME");
            CmdOpt_Engine.EnterInt(3);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
    }
    public class PLANTSPECNOTIFYTIME_4 : PLANTSPECNOTIFYTIME
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTSPECNOTIFYTIME");
            CmdOpt_Engine.EnterInt(4);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
    }
    public class PLANTSPECNOTIFYTIME_5 : PLANTSPECNOTIFYTIME
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTSPECNOTIFYTIME");
            CmdOpt_Engine.EnterInt(5);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
        }
    }
}
