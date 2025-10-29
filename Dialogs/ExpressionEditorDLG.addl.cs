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
    public partial class ExpressionEditorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2019";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$ReportExpressionCollectionEditorForm";
        }

		public  void Invoke()
		{
            RichTextTasksDLG RichTextTasksDLG = new RichTextTasksDLG();
            RichTextTasksDLG.Invoke();
            Desktop Desktop = new Desktop();
            //Desktop.Current.TypeE("<Tab 2>");
            ////Desktop.Click(MouseButton.Left, 660, 456);
            ////click First "..."
            //ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartWizardBrowse_button.bmp");//....
            //System.Threading.Thread.Sleep(1000);
            //Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord - 2);
            //System.Threading.Thread.Sleep(5000);
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                //case "JPN":
                //    Desktop.Click(MouseButton.Left, 537, 457);
                //    break;
                //case "RUS":
                //    Desktop.Click(MouseButton.Left, 578, 453);
                //    break;
                //case "FRA":
                //    Desktop.Click(MouseButton.Left, 615, 453);
                //    break;
                //case "KOR":
                //    Desktop.Click(MouseButton.Left, 555, 463);
                //    break;
                default:
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ExpressEdit\\ExpressionEditor.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 15, SAM.iYCoord + 5);
                    break;

            }


        }

        public  void Dismiss()
		{
            this.CancelPB.Click();
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportDesignerApplicationDLG.SetActive();
            ReportDesignerApplicationDLG.Dismiss();
        }
    }
}
