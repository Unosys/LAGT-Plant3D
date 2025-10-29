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
    public partial class ProjectReportSelectionDLG : Pane
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

        public void Invoke()
        {
            DataManagerDLG DataManagerDLG = new DataManagerDLG();
            DataManagerDLG.Invoke();
            //DataManagerDLG.M_dataModeCombo.Select(2);
            DataManagerDLG.M_dataModeCombo.Click();
            DataManagerDLG.TypeKeys("<Home><Down 2>");
            DataManagerDLG.ImportPB.Click();
            System.Threading.Thread.Sleep(5000);
            AutoCADP3DWarningDLG AutoCADP3DWarningDLG = new AutoCADP3DWarningDLG();
            if (AutoCADP3DWarningDLG.Exists)
            {
                AutoCADP3DWarningDLG.M_OKButton.Click();

            }
            ImportFromDLG ImportFromDLG = new ImportFromDLG();
            ImportFromDLG.FileName.ClearText(); 
            if (LAGT.CommonFiles.Product.Variables.Language == "FRA") {
                ImportFromDLG.FileName.SetText(@"C:\LAGT\Plant3D\TestFiles\ProjectExcel\Project FRA.xlsx");
            }
            else if ( LAGT.CommonFiles.Product.Variables.Language == "KOR")
            {
                ImportFromDLG.FileName.SetText(@"C:\LAGT\Plant3D\TestFiles\ProjectExcel\Project KOR.xlsx");

            }
            else if(LAGT.CommonFiles.Product.Variables.Language == "JPN")
            {
                ImportFromDLG.FileName.SetText(@"C:\LAGT\Plant3D\TestFiles\ProjectExcel\Project JPN.xlsx");

            }
            else if(LAGT.CommonFiles.Product.Variables.Language == "RUS")
            {
                ImportFromDLG.FileName.SetText(@"C:\LAGT\Plant3D\TestFiles\ProjectExcel\Project RUS.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
            {
                ImportFromDLG.FileName.SetText(@"C:\LAGT\Plant3D\TestFiles\ProjectExcel\Project CHS.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "DEU")
            {
                ImportFromDLG.FileName.SetText(@"C:\LAGT\Plant3D\TestFiles\ProjectExcel\Project DEU.xlsx");
            }
            else
            {
                ImportFromDLG.FileName.SetText(@"C:\LAGT\Plant3D\TestFiles\ProjectExcel\Project ENU.xlsx");
            }

            ImportFromDLG.Open.Click();
            System.Threading.Thread.Sleep(5000);
        }

        public void Dismiss()
        {
            ProjectReportSelectionDLG ProjectReportSelectionDLG = new ProjectReportSelectionDLG();
            ProjectReportSelectionDLG.SetActive();
            ProjectReportSelectionDLG.ClosePB.Click();
            DataManagerDLG DataManagerDLG = new DataManagerDLG();
            //DataManagerDLG.M_dataModeCombo.typekeys("<Home>");
            Drawing.Current.TypeE("DATAMANAGERCLOSE");
        }
    }
}
