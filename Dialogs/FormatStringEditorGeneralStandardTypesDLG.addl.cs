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
    public partial class FormatStringEditorGeneralStandardTypesDLG : Pane
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$FormatStringEditorForm";
        }

        public void Invoke()
        {
            LabelTasksDLG LabelTasksDLG = new LabelTasksDLG();
            LabelTasksDLG.Invoke();

            //ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            //ReportDesignerApplicationDLG.RibbonTabsPG.Select(3);//View tab
            //System.Threading.Thread.Sleep(2000);
            //ReportDesignerApplicationDLG.WindowsMI.Click();
            //System.Threading.Thread.Sleep(3000);
            //ReportDesignerApplicationDLG.TypeKeys("<Down 3><Space>");
            //System.Threading.Thread.Sleep(3000);
            //ReportDesignerApplicationDLG.SetActive();
            //Desktop Desktop = new Desktop();
            //ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\data.bmp");
            //Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
            //System.Threading.Thread.Sleep(1000);
            //ReportDesignerPropertiesDLG ReportDesignerPropertiesDLG = new ReportDesignerPropertiesDLG();
            //RECT r1 = ReportDesignerPropertiesDLG.TableTBL.GetRect(true);
            //RECT r2 = ReportDesignerPropertiesDLG.TextField1TF.GetRect(true);
            //Desktop.Click(MouseButton.Left, r1.xPos + (r2.xPos - r1.xPos) / 6 * 3, r1.yPos + 2);
            Desktop Desktop = new Desktop();
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {

                //case "JPN":
                   
                //    break;
                //case "DEU":
                   
                //    break;
                //case "FRA":
                 
                //    break;
                //case "RUS":
                   
                //    break;
                //case "CHS":
                    
                //    break;
                //case "KOR":
                    
                //    break;
                default:
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Format.bmp");
                    Desktop.Click(MouseButton.Left, SAM.iXCenter, SAM.iYCenter);
                    break;

            }
        }

        public void Dismiss()
        {
            FormatStringEditorGeneralStandardTypesDLG FormatStringEditorGeneralStandardTypesDLG = new FormatStringEditorGeneralStandardTypesDLG();
            FormatStringEditorGeneralStandardTypesDLG.SetActive();
            FormatStringEditorGeneralStandardTypesDLG.CancelPB.Click();
            //FormatStringEditorStandardTypesDLG.TypeKeys("<Alt-F4>");
            LabelTasksDLG LabelTasksDLG = new LabelTasksDLG();
            LabelTasksDLG.Dismiss();
        }
        public void SelectTab(int i = 1)
        {
           
            RECT r = this.StandardTypesPANE.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r.xPos + 10, r.yPos - 10);
            if (i != 1)
            {
                Desktop.Current.TypeKeys("<Right " + (i - 1).ToString() + ">");
            }
        }
    }
}
