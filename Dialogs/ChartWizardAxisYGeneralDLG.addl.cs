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
    public partial class ChartWizardAxisYGeneralDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$WizardFormBase";
		}

		public  void Invoke()
		{
			ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
			ChartWizardChartDLG.Invoke();
			ChartWizardChartDLG.SetActive();
			Plant3DFunctions.ChartWizardPresentation(7);
            
            ChartWizardChartDLG.Click(MouseButton.Left, 940, 130);//Click General
			ChartWizardAxisYGeneralDLG ChartWizardAxisYGeneralDLG = new ChartWizardAxisYGeneralDLG();
			ChartWizardAxisYGeneralDLG.SetActive();
		}

		public  void Dismiss()
		{
			ChartWizardAxisYGeneralDLG ChartWizardAxisYGeneralDLG = new ChartWizardAxisYGeneralDLG();
			ChartWizardAxisYGeneralDLG.SetActive();
			ChartWizardAxisYGeneralDLG.TypeKeys("<Alt-F4>");
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
