// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2015 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DExcelImportDLG_Collaboration : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Window]$Window_1";
        }

        public override void Invoke()
        {
            Plant3DFunctions.OpenCollaborationProject("SampleProject_Auto");
             //Plant3DFunctions.OpenCollaborationProject("SampleProject_Auto01");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Plant3DFunctions.RightClickTreeP3D(PROJECTMANAGERDLG.TreeViewTV, "1", "", false, 1, 1, 2);
            System.Threading.Thread.Sleep(10000);
            var appwnd = new Plant3D();
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(20000);
                if (appwnd.IsActive || appwnd.IsEnabled)
                {
                    break;
                }
            }
            DATAMANAGER DATAMANAGER = new DATAMANAGER();
            DATAMANAGER.Invoke();
            //DATAMANAGER.PopupListPL.Select(1);///P&ID Project Data
            DATAMANAGER.DropDownButtonPB.Click();
            Desktop.Current.TypeKeys("<Home><Down><Enter>");
            DATAMANAGER.TreeViewTV.Select(AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 19, "Nozzles") + "/" + AcMainWin.cBabel(21100, 20, "Flanged Nozzle"));
            DATAMANAGER.ImportPB.Click();
            System.Threading.Thread.Sleep(3000);
            AutoCADP3DWarningDLG AutoCADP3DWarningDLG = new AutoCADP3DWarningDLG();
            AutoCADP3DWarningDLG.M_OKButton.Click();
            ImportFromDLG ImportFromDLG = new ImportFromDLG();
            ImportFromDLG.FileName.ClearText();
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "JPN":
                    ImportFromDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "1-A1-1002\\Collaboration\\SampleProject-Flanged Nozzle_JPN.xlsx");
                    break;
                case "CHS":
                    ImportFromDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "1-A1-1002\\Collaboration\\SampleProject-Flanged Nozzle_CHS.xlsx");
                    break;
                case "FRA":
                    ImportFromDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "1-A1-1002\\Collaboration\\SampleProject-Flanged Nozzle_FRA.xlsx");
                    break;
                case "KOR":
                    ImportFromDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "1-A1-1002\\Collaboration\\SampleProject-Flanged Nozzle_KOR.xlsx");
                    break;
                case "RUS":
                    ImportFromDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "1-A1-1002\\Collaboration\\SampleProject-Flanged Nozzle_RUS.xlsx");
                    break;
                case "DEU":
                    ImportFromDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "1-A1-1002\\Collaboration\\SampleProject-Flanged Nozzle_DEU.xlsx");
                    break;
                default:
                    ImportFromDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "1-A1-1002\\Collaboration\\SampleProject-Flanged Nozzle_ENU.xlsx");
                    break;

            }
            ImportFromDLG.Open.Click();
            System.Threading.Thread.Sleep(5000);
            ImportDataDLG ImportDataDLG = new ImportDataDLG();
            ImportDataDLG.OKPB.Click();
            System.Threading.Thread.Sleep(1000);
            DATAMANAGER.AcceptAllPB.Click();
            System.Threading.Thread.Sleep(3000);
            this.Size(750,640);
            this.SetActive();
        }

        public override void Dismiss()
        {
            //this.CancelPB.Click();
            this.ClosePB.Click();
            DATAMANAGER DATAMANAGER = new DATAMANAGER();
            DATAMANAGER.Dismiss();
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(8000);
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            if (WarningAutoCADDLG.Exists)
            {
                WarningAutoCADDLG.No.Click();
            }
            Plant3DFunctions.SetToDefault();
        }
    }
}
