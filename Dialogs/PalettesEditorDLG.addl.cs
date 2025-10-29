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
    public partial class PalettesEditorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$PaletteEditorForm";
		}

		public  void Invoke()
		{
			ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
			ChartWizardChartDLG.Invoke();
			ChartWizardChartDLG.WaitExists(5000);
			ChartWizardChartDLG.SetActive();
            ChartWizardChartDLG.ClosePB.Click();
            System.Threading.Thread.Sleep(4000);
			ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ReportDesignerExpand_Button.bmp");//...
            Desktop Desktop = new Desktop();
            Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
			System.Threading.Thread.Sleep(2000);
			
			switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
			{
				case "RUS":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartTasks\\RUS_Palettes.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                    break;
				case "KOR":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartTasks\\KOR_Palettes.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                    break;
				case "CHS":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartTasks\\CHS_Palettes.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                    break;
                case "FRA":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartTasks\\FRA_Palettes.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                    break;
                case "DEU":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartTasks\\DEU_Palettes.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                    break;
                case "JPN":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartTasks\\JPN_Palettes.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                    break;
                default:
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartTasks\\Palettes.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                    break;

			}
		}

		public  void Dismiss()
		{
			PalettesEditorDLG PalettesEditorDLG = new PalettesEditorDLG();
			PalettesEditorDLG.SetActive();
			PalettesEditorDLG.TypeKeys("<Alt-F4>");
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
