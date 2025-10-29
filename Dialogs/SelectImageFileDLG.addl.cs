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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SelectImageFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        /// <summary>
        /// OnInitialize() is used to contain additional initialization code
        /// Uncomment the code block below to use it
        /// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$DXImageEditorForm";
        }
        public override void Invoke()
        {
            ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            ChartWizardChartDLG.Invoke();
            System.Threading.Thread.Sleep(3000);
            ChartWizardChartDLG.PageListPG.selectTab(1);
            System.Threading.Thread.Sleep(1000);

            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "JPN":
                    ChartWizardChartDLG.TypeKeys("<Tab 9><Right><Down>", 250);
                    break;
                //case "FRA":
                case "CHS":
                    ChartWizardChartDLG.TypeKeys("<Tab 3><Right><Down 3>", 250);
                    break;
                case "RUS":
                    ChartWizardChartDLG.TypeKeys("<Tab 9><Right><Down 3>",250);
                    break;
                case "DEU":
                    ChartWizardChartDLG.TypeKeys("<Tab 5><Right 3>",250);
                    break;
                default:
                    ChartWizardChartDLG.TypeKeys("<Tab 4><Right 2>",250);
                    break;
                    
            }
            SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\DXImage.bmp");
            Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCenter, SAM.iYCenter);
            this.SetActive();
        }

        public override void Dismiss()
        {
            SelectImageFileDLG SelectImageFileDLG = new SelectImageFileDLG();
            SelectImageFileDLG.SetActive();
            SelectImageFileDLG.CancelPB.Click();
            ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            ChartWizardChartDLG.Dismiss();
        }
    }
}
