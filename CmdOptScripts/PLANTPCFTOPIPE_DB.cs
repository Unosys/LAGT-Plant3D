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
    public class PLANTPCFTOPIPE_DBCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTPCFTOPIPE_DB = new List<Command>
		{
			new PLANTPCFTOPIPE_DB()
        };
    }

    public class PLANTPCFTOPIPE_DB : Command
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("PLANTPCFTOPIPE");
            PCFINSelectFileDLG PCFINSelectFileDLG = new PCFINSelectFileDLG();
            if (PCFINSelectFileDLG.WaitExists(2*1000))
            {
                PCFINSelectFileDLG.SetActive();
                PCFINSelectFileDLG.FileNameCB.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir);
                PCFINSelectFileDLG.OpenPB.Click();
                PCFINSelectFileDLG.ListViewLV.Click(MouseButton.Left, 20, 40);
                PCFINSelectFileDLG.ListViewLV.TypeKeys("10");
                PCFINSelectFileDLG.ListViewLV.TypeKeys("<Shift-Down 2>");
                PCFINSelectFileDLG.OpenPB.Click();
                PCFINListDLG PCFINListDLG = Window.Current <PCFINListDLG>();
                PCFINListDLG.CreatePipingPB.Click();
                System.Threading.Thread.Sleep(2000);
                PCFINCompleteDLG PCFINCompleteDLG = Window.Current<PCFINCompleteDLG>();
                PCFINCompleteDLG.Close1PB.Click();

            }
            else
            {
                CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
                CmdOpt_ErrorReport.ReportError(sError);              
            }
        }

        public override void Dismiss()
        {
            
        }

        public override void Verify()
        {
        }        
    }
}
