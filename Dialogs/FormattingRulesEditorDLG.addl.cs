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
    public partial class FormattingRulesEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$FormattingRulesEditorForm";
        }

        public override void Invoke()
        {

            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportDesignerApplicationDLG.Invoke();
            //ReportDesignerApplicationDLG.TypeKeys("<Ctrl-N>");
            ReportDesignerApplicationDLG.SetActive();
            RECT rPos = ReportDesignerApplicationDLG.CornerPanel.GetRect();
            ReportDesignerApplicationDLG.CornerPanel.Click(MouseButton.Left, rPos.xSize - 5, rPos.ySize - 5);
            Desktop Desktop = new Desktop();
            System.Threading.Thread.Sleep(3000);
            ReportDesignerPropertiesDLG ReportDesignerPropertiesDLG = new ReportDesignerPropertiesDLG();
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                //case "JPN":

                //    Desktop.Click(MouseButton.Left, 370, 527);//Styles Sheet
                //    break;
                //case "RUS":

                //    Desktop.Click(MouseButton.Left, 370, 516);//Styles Sheet
                //    break;
                default:
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\StyleSheet\\StyleSheet.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCenter, SAM.iTop + 2);

                    break;

            }
        }

        public override void Dismiss()
        {
            FormattingRulesEditorDLG FormattingRulesEditorDLG = new FormattingRulesEditorDLG();
            FormattingRulesEditorDLG.SetActive();
            FormattingRulesEditorDLG.Close();
            //FormattingRulesEditorDLG.CancelPB.Click();
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportDesignerApplicationDLG.Dismiss();

        }
        public void Close()
        {
            FormattingRulesEditorDLG FormattingRulesEditorDLG = new FormattingRulesEditorDLG();

            RECT r = FormattingRulesEditorDLG.GetRect(true);
            Desktop.Current.Click(MouseButton.Right, r.xPos + 5, r.yPos + 5);
            Desktop.Current.TypeKeys("<Up><Enter>");


        }
    }
}
