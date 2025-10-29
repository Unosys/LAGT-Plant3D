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
using static Autodesk.GUIHarness.Plant3D.CmdOptScripts.PLANTORTHOUPDATE;
using SaveChangesMSG = Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
    public class PLANTORTHOUPDATECLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTORTHOUPDATE = new List<Command>
        {
            new PLANTORTHOUPDATE(),
            new PLANTORTHOUPDATE_ALL()
        };
    }

    public class PLANTORTHOUPDATE : Command
    {
        public override void Launch()
        {
            Plant3DFunctions.OpenSampleProject();
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            Plant3DFunctions.ExpandTreeOrtho(PROJECTMANAGERDLG.TreeViewTV, 4, "0,1,1");
            System.Threading.Thread.Sleep(8000);

            CmdOpt_Engine.SendCmd("PLANTORTHOUPDATE");
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 2>");

        }

        public override void Verify()
        {
        }
        public class PLANTORTHOUPDATE_ALL : Command
        {
            public override void Launch()
            {

                CmdOpt_Engine.SendCmd("_PLANTORTHOUPDATE");
                CmdOpt_Engine.SendOption("All", 1, 1);

            }


            public override void Dismiss()
            {
                Drawing.Current.TypeKeys("<ESC 2>");
                System.Threading.Thread.Sleep(5000);
                ViewisUptoDateDLG ViewisUptoDateDLG = new ViewisUptoDateDLG();
                if (ViewisUptoDateDLG.Exists)
                {
                    ViewisUptoDateDLG.CancelPB.Click();
                   
                }
                Drawing.Current.TypeE("_Close");
                System.Threading.Thread.Sleep(2000);
                SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
                if (SaveChangesMSG.Exists)
                {
                    SaveChangesMSG.NoPB.Click();

                }
                Plant3DFunctions.SetToDefault();
            }

            public override void Verify()
            {
            }
        }
    }
}
