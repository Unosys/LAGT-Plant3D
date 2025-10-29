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
    public partial class DataFilterCollectionEditorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$DataFilterCollectionForm";
		}

		public  void Invoke()
		{
            ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            ChartWizardChartDLG.Invoke();

            ChartWizardChartDLG.SetActive();
            //ChartWizardChartDLG.PageListPG.Select(1);
            RECT r = ChartWizardChartDLG.OptionsPANE.GetRect(true);
            ChartWizardChartDLG.Click(MouseButton.Left, r.xPos + 5, r.yPos - 5);
            ChartWizardChartDLG.TypeKeys("<Right>");
            System.Threading.Thread.Sleep(3000);
            if (LAGT.CommonFiles.Product.Variables.Language == "DEU")
            {
                ChartWizardChartDLG.TypeKeys("<Tab 20><Right><Tab 10>");
            }
            else {
                ChartWizardChartDLG.TypeKeys("<Tab 20><Right><Tab 10>");
                System.Threading.Thread.Sleep(3000);
                ChartWizardChartDLG.DataFiltersWIN.Click();
            }
           
            Desktop Desktop = new Desktop();
            SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\dots.bmp");//...
            Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            System.Threading.Thread.Sleep(3000);
            //if (!this.Exists) {

            //    RECT r = ChartWizardChartDLG.DataFiltersWIN.GetRect(true);
            //    ChartWizardChartDLG.Click(MouseButton.Left, r.xPos + r.xSize-3, r.yPos + 3);
            //}
        }

		public  void Dismiss()
		{
			DataFilterCollectionEditorDLG DataFilterCollectionEditorDLG = new DataFilterCollectionEditorDLG();
			DataFilterCollectionEditorDLG.SetActive();
			DataFilterCollectionEditorDLG.TypeKeys("<Alt-F4>");
			ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
			ChartWizardChartDLG.SetActive();
			ChartWizardChartDLG.Dismiss();
		}
    }
}
