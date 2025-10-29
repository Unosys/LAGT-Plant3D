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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ChartWizardSeriesViewsFibonacciIndicatorsLevelsDLG : Pane
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
            //ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            //ChartWizardChartDLG.Invoke();
            //System.Threading.Thread.Sleep(1000);
            //Desktop Desktop = new Desktop();
            //SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\SeriesViews.bmp");
            //Desktop.DoubleClick(MouseButton.Left, SAM.iXCoord, SAM.iYCoord);
            //System.Threading.Thread.Sleep(1000);
            //ChartWizardSeriesDLG ChartWizardSeriesDLG = new ChartWizardSeriesDLG();
            //ChartWizardSeriesDLG.PageListPG.Select(4);
            //System.Threading.Thread.Sleep(1000);
            //ChartWizardSeriesDLG.AddPB.Click();
            ChartWizardSeriesViewsGeneralDLG ChartWizardSeriesViewsGeneralDLG = new ChartWizardSeriesViewsGeneralDLG();
            ChartWizardSeriesViewsGeneralDLG.Invoke();
            ChartWizardSeriesViewsGeneralDLG.PageListPG.Select(4);
            System.Threading.Thread.Sleep(2000);
            ChartWizardSeriesViewsGeneralDLG.AddPB.Click();
            FibonacciIndicatorKindsDLG FibonacciIndicatorKindsDLG = new FibonacciIndicatorKindsDLG();
            FibonacciIndicatorKindsDLG.ListBoxLB.Select(2);
            FibonacciIndicatorKindsDLG.OKPB.Click();
        }

		public  void Dismiss()
		{
			ChartWizardSeriesViewsFibonacciIndicatorsLevelsDLG ChartWizardSeriesViewsFibonacciIndicatorsLevelsDLG = new ChartWizardSeriesViewsFibonacciIndicatorsLevelsDLG();
			ChartWizardSeriesViewsFibonacciIndicatorsLevelsDLG.SetActive();
            ChartWizardSeriesViewsFibonacciIndicatorsLevelsDLG.CancelPB.Click();
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
