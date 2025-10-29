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
    public partial class ChartWizardChartDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$DesignerFormBase";// "$WizardFormBase";
		}

		public  void Invoke()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Invoke();
			ReportDesignerApplicationDLG.SetActive();           
			ReportDesignerApplicationDLG.TypeKeys("<Ctrl-n>");            
			ReportDesignerApplicationDLG.SetActive();
            System.Threading.Thread.Sleep(3000);
            //Plant3DFunctions.StandardControls(12);////Click 'Chart' in the 'Tool Box'
            SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartWizard.bmp");
            ReportDesignerApplicationDLG.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
            System.Threading.Thread.Sleep(4000);
			ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            if (!ChartWizardChartDLG.Exists) { 
                SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartWizard.bmp");
                ReportDesignerApplicationDLG.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                System.Threading.Thread.Sleep(4000);
            }

        }

		public  void Dismiss()
		{
			ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
			ChartWizardChartDLG.SetActive();
            ChartWizardChartDLG.ClosePB.Click();// TypeKeys("<Alt-F4>");

            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
        }
        public void SelectTab(int i = 1)
        {
            ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            RECT r = ChartWizardChartDLG.OptionsPANE.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r.xPos + 10, r.yPos - 10);
            if (i != 1)
            {
                Desktop.Current.TypeKeys("<Right " + (i - 1).ToString() + ">");
            }
        }
    }
}
