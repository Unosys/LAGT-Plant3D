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
    public class PLANTORTHOSINGLELINEPIPINGCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTORTHOSINGLELINEPIPING = new List<Command>
        {
            new PLANTORTHOSINGLELINEPIPING(),
            new PLANTORTHOSINGLELINEPIPING_Allpiping(),
            new PLANTORTHOSINGLELINEPIPING_Allpiping_Update(),
            new PLANTORTHOSINGLELINEPIPING_Allpiping_eXit(),
            new PLANTORTHOSINGLELINEPIPING_byLinenumber(),
            new PLANTORTHOSINGLELINEPIPING_bySize(),
            new PLANTORTHOSINGLELINEPIPING_byProperty(),
            new PLANTORTHOSINGLELINEPIPING_bySElection(),
            new PLANTORTHOSINGLELINEPIPING_DoubleLinepiping(),
            new PLANTORTHOSINGLELINEPIPING_sInglelinepiping(),
            new PLANTORTHOSINGLELINEPIPING_eXit()

        };
    }

    public class PLANTORTHOSINGLELINEPIPING : Command
    {
        public override void Launch()
        {
            Plant3DFunctions.OpenSampleProject();
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetTab(2);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");

            PROJECTMANAGERDLG.SetActive();
            Plant3DFunctions.ExpandTreeP3D(PROJECTMANAGERDLG.TreeViewTV, 4, "0,1");//open Area1_Plan
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEDISPLAY");
            CmdOpt_Engine.EnterInt(1);
            CmdOpt_Engine.SendCmd("_ZOOM");
            CmdOpt_Engine.SendOpt("_ALL");
            CmdOpt_Engine.SendCmd("PLANTORTHOSINGLELINEPIPING");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOpt("_Allpiping");
            CmdOpt_Engine.SendOpt("_eXit");
            Drawing.Current.TypeKeys("<Esc 2>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_Allpiping : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOption("Allpiping", 1, 7);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.SendOpt("_eXit");
            Drawing.Current.TypeKeys("<Esc 2>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_Allpiping_Update : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOpt("_Allpiping");
            CmdOpt_Engine.SendOption("Update", 1, 2);
        }

        public override void Dismiss()
        {
            System.Threading.Thread.Sleep(5000);
            OrthoGenerationDLG OrthoGenerationDLG = new OrthoGenerationDLG();
            for (int i = 0; i < 3; i++)
            {
                if (OrthoGenerationDLG.WaitExists(5000))
                {
                    System.Threading.Thread.Sleep(10000);
                }
            }
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_Allpiping_eXit : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOpt("_Allpiping");
            CmdOpt_Engine.SendOption("eXit", 2, 2);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_byLinenumber : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOption("byLinenumber", 2, 7);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterPoint(1400.610, 1229.145);
            CmdOpt_Engine.EnterPoint(629.997, 1237.155);
            Drawing.Current.TypeKeys("<ESC>");
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_bySize : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOption("bySize", 3, 7);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterInt(5);
            CmdOpt_Engine.EnterInt(1);
            CmdOpt_Engine.SendOpt("_eXit");
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_byProperty : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOption("byProperty", 4, 7);
        }


        public override void Dismiss()
        {
            CmdOpt_Engine.EnterText("Area1_Plan");
            CmdOpt_Engine.EnterText("test");
            CmdOpt_Engine.SendOpt("_eXit");
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_bySElection : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            if (CmdOpt_Engine.sTestType == "UNDERSCORE")
            {
                CmdOpt_Engine.SendOpt("_SE");
            }
            else
            {
                CmdOpt_Engine.SendOption("bySElection", 5, 7);
            }
        }

        public override void Dismiss()
        {
            System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.EnterPoint(2082.924, 219.943);
            CmdOpt_Engine.EnterPoint(1464.828, 259.991);
            Drawing.Current.TypeKeys("<Enter>");
            System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.SendOpt("_eXit");
            Drawing.Current.TypeKeys("<ESC 3>");

        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_DoubleLinepiping : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {

            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOption("Double line piping", 6, 7);
        }

        public override void Dismiss()
        {

            CmdOpt_Engine.SendOpt("_eXit");
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_sInglelinepiping : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOpt("_Double");

            //CmdOpt_Engine.SendOption("sIngle line piping", 2, 3);
            if (CmdOpt_Engine.sTestType == "UNDERSCORE")
            {
                CmdOpt_Engine.SendOpt("_I");
            }
            else
            {
                CmdOpt_Engine.SendOption("sIngle line piping", 5, 6);
            }
        }

        public override void Dismiss()
        {
            System.Threading.Thread.Sleep(1000);
            CmdOpt_Engine.SendOpt("_eXit");
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTORTHOSINGLELINEPIPING_eXit : PLANTORTHOSINGLELINEPIPING
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTORTHOSINGLELINEPIPING");
            CmdOpt_Engine.EnterPoint(1.217, 13.269);
            CmdOpt_Engine.SendOption("eXit", 7, 7);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 3>");
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.TypeE("_Close");
           var SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();

            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.SetToDefault();
            //Dialogs.Plant3D appwnd = new Dialogs.Plant3D();
            ////appwnd.Exit();

        }

        public override void Verify()
        {
        }
    }
}
