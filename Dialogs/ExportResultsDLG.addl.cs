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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ExportResultsDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$ExportResultsForm";
		}

		public void Invoke()
		{
			NewReportConfigurationDLG NewReportConfigurationDLG = new NewReportConfigurationDLG();
			NewReportConfigurationDLG.Invoke();
			NewReportConfigurationDLG.M_templateReportRadioBtn.Click();
			NewReportConfigurationDLG.M_repConfigCmbBox.TypeKeys("<F4><Down 3><Enter>");
			NewReportConfigurationDLG.M_okBtn.Click();
			ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();
			ReportConfigurationDLG.TypeKeys("<Tab 11><Up 8><Down>");
			if (!ReportConfigurationDLG.M_showPrintOptionsChkBox.IsChecked)
			{
				ReportConfigurationDLG.M_showPrintOptionsChkBox.Check();
			}
			ReportConfigurationDLG.M_okBtn.Click();
            System.Threading.Thread.Sleep(3000);
            ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
			ReportCreatorDLG.M_printBtn.Click();
            System.Threading.Thread.Sleep(8000);
			PDFExportOptionsDLG PDFExportOptionsDLG = new PDFExportOptionsDLG();
			PDFExportOptionsDLG.OKPB.Click();
            System.Threading.Thread.Sleep(8000);
			this.SetActive();
		}

		public void Dismiss()
		{
            System.Threading.Thread.Sleep(2000);
			ExportResultsDLG ExportResultsDLG = new ExportResultsDLG();
			ExportResultsDLG.SetActive();
            ExportResultsDLG.M_okBtn.Click();
			ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
			ReportCreatorDLG.Dismiss();
		}
    }
}
