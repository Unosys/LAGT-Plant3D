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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDProjectReportSelectionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$SheetSelectionDlg";
		}

		public override void Invoke()
		{
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDFunctions.CreateDrawing();
            Drawing.Current.TypeE("_erase");
            Drawing.Current.TypeE("_all");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_SLINE");
            Drawing.Current.TypeE("14,16");
            Drawing.Current.TypeE("14,8");
            Drawing.Current.TypeE("");
            PandIDPROJECTMANAGERDLG.Dismiss();
            Drawing.Current.TypeE("_DATAMANAGER");
            System.Threading.Thread.Sleep(2000);
            DataManagerDLG PandIDDataManagerDLG = new DataManagerDLG();
         //   PandIDDataManagerDLG.Close();   //Additional added//
            PandIDDataManagerDLG.M_dataModeCombo.TypeKeys("<End>");//P&ID
            

            RECT rect = PandIDDataManagerDLG.TreeViewTV.GetItemRect(0);
            
            PandIDDataManagerDLG.TreeViewTV.Click(MouseButton.Right, rect.xPos + rect.xSize / 2, rect.yPos + rect.ySize / 2);
            System.Threading.Thread.Sleep(100);
            PandIDDataManagerDLG.TreeViewTV.TypeKeys("<Down 3><Enter>");
            PandIDAutoCADPIDDLG PandIDAutoCADPIDDLG = new PandIDAutoCADPIDDLG();
            if (PandIDAutoCADPIDDLG.Exists)
            {
                PandIDAutoCADPIDDLG.M_OKButton.Click();
            }
            PandIDImportFromDLG PandIDImportFromDLG = new PandIDImportFromDLG();
            if (LAGT.CommonFiles.Product.Variables.Language == "FRA")
            {
                PandIDImportFromDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ProjectExcel\\Project FRA.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "KOR")
            {
                PandIDImportFromDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ProjectExcel\\Project KOR.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "RUS")
            {
                PandIDImportFromDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ProjectExcel\\Project RUS.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "JPN")
            {
                PandIDImportFromDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ProjectExcel\\Project JPN.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
            {
                PandIDImportFromDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ProjectExcel\\Project CHS.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language.ToUpper() == "DEU")
            {
                PandIDImportFromDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ProjectExcel\\Project DEU.xlsx");
            }
            else
            {
                PandIDImportFromDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ProjectExcel\\Project ENU.xlsx");

            }
            PandIDImportFromDLG.OpenPB.Click();
		}

		public override void Dismiss()
		{
            this.Close();
            Drawing.Current.TypeE("DATAMANAGERCLOSE");
            Drawing.Current.TypeE("_ProjectManager");
            PandIDFunctions.DeleteDrawing();
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Dismiss();
		}
    }
}
