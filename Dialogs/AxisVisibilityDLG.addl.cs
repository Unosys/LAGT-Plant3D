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
    public partial class AxisVisibilityDLG : Autodesk.GUIHarness.Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$AxisVisibilityInPanesForm";
		}

		public  void Invoke()
		{
			ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
			ChartWizardChartDLG.Invoke();
			if (ChartWizardChartDLG.WaitExists(5000))
            {
                ChartWizardChartDLG.SetActive();
                //Plant3DFunctions.ChartWizardPresentation(7) Plant3DFunctions.ChartWizardPresentation(7) = new Plant3DFunctions.ChartWizardPresentation(7)();
			    Plant3DFunctions.ChartWizardPresentation(7);
            }
			System.Threading.Thread.Sleep(10000);
			//GetCoords("S:\Harness\dialogs\Plant3D\SamScreenshots\ChartWizardBrowse_button GetCoords("S:\Harness\dialogs\Plant3D\SamScreenshots\ChartWizardBrowse_button = new GetCoords("S:\Harness\dialogs\Plant3D\SamScreenshots\ChartWizardBrowse_button();
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "\\SamScreenshots\\ChartWizardBrowse_button.bmp");//...
			Desktop Desktop = new Desktop();
            Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
			System.Threading.Thread.Sleep(1000);
			AxisVisibilityDLG AxisVisibilityDLG = new AxisVisibilityDLG();
			AxisVisibilityDLG.SetActive();
		}

		public  void Dismiss()
		{
			AxisVisibilityDLG AxisVisibilityDLG = new AxisVisibilityDLG();
			AxisVisibilityDLG.SetActive();
			AxisVisibilityDLG.TypeKeys("<Alt-F4>");
			ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
			ChartWizardChartDLG.SetActive();
			ChartWizardChartDLG.Dismiss();
		}
    }
}
