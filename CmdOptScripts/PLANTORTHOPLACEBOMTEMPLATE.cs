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
    public class PLANTORTHOPLACEBOMTEMPLATECLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTORTHOPLACEBOMTEMPLATE = new List<Command>
        {
            new PLANTORTHOPLACEBOMTEMPLATE(),
            new PLANTORTHOPLACEBOMTEMPLATE_Billofmaterials(),
            new PLANTORTHOPLACEBOMTEMPLATE_Equipment(),
            new PLANTORTHOPLACEBOMTEMPLATE_Nozzles(),
            new PLANTORTHOPLACEBOMTEMPLATE_sTeel(),
            new PLANTORTHOPLACEBOMTEMPLATE_Spool()
        };
    }

    public class PLANTORTHOPLACEBOMTEMPLATE : Command
    {
        public override void Launch()
        {
            ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = new ProjectSetupTitleBlockandDisplayDLG();
            ProjectSetupTitleBlockandDisplayDLG.Invoke();
            ProjectSetupTitleBlockandDisplayDLG.BtnSetupBlk.Click();
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.StartLog();
            CmdOpt_Engine.SendCmd("PLANTORTHOPLACEBOMTEMPLATE");

        }

        public override void Dismiss()
        {
            CmdOpt_Engine.SendOpt("_B");
            CmdOpt_Engine.EnterPoint(9, 10, 0);
            CmdOpt_Engine.EnterPoint(20, 7, 0);
            CmdOpt_Engine.SendCmd("_ERASE");
            CmdOpt_Engine.SendOpt("_ALL");
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC 3>");

        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOPLACEBOMTEMPLATE_Billofmaterials : PLANTORTHOPLACEBOMTEMPLATE
    {
        public override void Launch()
        {


            CmdOpt_Engine.SendCmd("_PLANTORTHOPLACEBOMTEMPLATE");
            System.Threading.Thread.Sleep(1000);
           
            if (CmdOpt_Engine.sTestType == "UNDERSCORE")
            {
                CmdOpt_Engine.SendOpt("_B");
            }
            else 
            {
                CmdOpt_Engine.SendOption("Bill", 1, 5);
            }

        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(9, 10, 0);
            CmdOpt_Engine.EnterPoint(20, 7, 0);
            CmdOpt_Engine.SendCmd("_ERASE");
            CmdOpt_Engine.SendOpt("_ALL");
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOPLACEBOMTEMPLATE_Equipment : PLANTORTHOPLACEBOMTEMPLATE
    {
        public override void Launch()
        {

            CmdOpt_Engine.SendCmd("_PLANTORTHOPLACEBOMTEMPLATE");
            System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.SendOption("Equipment", 2, 5);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(9, 10, 0);
            CmdOpt_Engine.EnterPoint(20, 7, 0);
            CmdOpt_Engine.SendCmd("_ERASE");
            CmdOpt_Engine.SendOpt("_ALL");
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOPLACEBOMTEMPLATE_Nozzles : PLANTORTHOPLACEBOMTEMPLATE
    {
        public override void Launch()
        {

            CmdOpt_Engine.SendCmd("_PLANTORTHOPLACEBOMTEMPLATE");
            System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.SendOption("Nozzles", 3, 5);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(9, 10, 0);
            CmdOpt_Engine.EnterPoint(20, 7, 0);
            CmdOpt_Engine.SendCmd("_ERASE");
            CmdOpt_Engine.SendOpt("_ALL");
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOPLACEBOMTEMPLATE_sTeel : PLANTORTHOPLACEBOMTEMPLATE
    {
        public override void Launch()
        {

            CmdOpt_Engine.SendCmd("_PLANTORTHOPLACEBOMTEMPLATE");
            System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.SendOption("sTeel", 4, 5);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(9, 10, 0);
            CmdOpt_Engine.EnterPoint(20, 7, 0);
            CmdOpt_Engine.SendCmd("_ERASE");
            CmdOpt_Engine.SendOpt("_ALL");
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOPLACEBOMTEMPLATE_Spool : PLANTORTHOPLACEBOMTEMPLATE
    {
        public override void Launch()
        {

            CmdOpt_Engine.SendCmd("_PLANTORTHOPLACEBOMTEMPLATE");
            System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.SendOption("Spool", 5, 5);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(9, 10, 0);
            CmdOpt_Engine.EnterPoint(20, 7, 0);
            CmdOpt_Engine.SendCmd("_ERASE");
            CmdOpt_Engine.SendOpt("_ALL");
            CmdOpt_Engine.EnterCR();
            Drawing.Current.TypeKeys("<ESC 3>");
            Drawing.Current.TypeE("_Close");
            var SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            System.Threading.Thread.Sleep(10000);
            ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = new ProjectSetupTitleBlockandDisplayDLG();
            ProjectSetupTitleBlockandDisplayDLG.WaitExists(20000);
            ProjectSetupTitleBlockandDisplayDLG.Dismiss();
           
        }

        public override void Verify()
        {
        }
    }

}
