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
using System.Diagnostics;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReportWizardSelectFieldsDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "Report Wizard|#2"; // "DevExpress.XtraEditors.XtraMessageBoxForm";
		}

		public  void Invoke()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Invoke();
			ReportDesignerApplicationDLG.TypeKeys("<Ctrl-w>");
			System.Threading.Thread.Sleep(3000);
			ReportWizardDLG ReportWizardDLG = new ReportWizardDLG();
            ReportWizardDLG.FinishPB.Click();       // need to be checked manually with addlspy
			System.Threading.Thread.Sleep(1000);
		}

		public  void Dismiss()
		{
            this.TypeKeys("<Alt-F4>");
            ReportWizardDLG ReportWizardDLG = new ReportWizardDLG();
            ReportWizardDLG.Dismiss();
            //Process.Start("taskkill /f /im PnPReportCreator.exe");
		}
    }
}
