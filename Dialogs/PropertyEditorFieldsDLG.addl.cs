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
    public partial class PropertyEditorFieldsDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$DesignerForm";// "$BaseDesignerForm";
		}

		public  void Invoke()
		{
			PivotGridTasksDLG PivotGridTasksDLG = new PivotGridTasksDLG();
            Desktop Desktop = new Desktop();
			PivotGridTasksDLG.Invoke();
            //Desktop.TypeKeys("<Tab 7><Enter>");

            Desktop.TypeKeys("<Up 1><Enter>");
            System.Threading.Thread.Sleep(3000);
            RECT rPos = this.Pane6PANE.GetRect();
            this.Pane6PANE.DoubleClick(MouseButton.Left, 40, 55);//Field
                                                                  //PivotGridTasksDLG.TypeKeys("<Tab 7><Enter>");
                                                                  //         PropertyEditorFieldsDLG PropertyEditorFieldsDLG = new PropertyEditorFieldsDLG();
                                                                  //PropertyEditorFieldsDLG.SetActive();
                                                                  //System.Threading.Thread.Sleep(4000);
                                                                  //ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\PropertyEditor_Fields_Button.bmp");

            //         Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
            //System.Threading.Thread.Sleep(2000);
            //PropertyEditorFieldsDLG.SetActive();
        }

		public  void Dismiss()
		{
			PropertyEditorFieldsDLG PropertyEditorFieldsDLG = new PropertyEditorFieldsDLG();
			PropertyEditorFieldsDLG.SetActive();
            PropertyEditorFieldsDLG.Close2PB.Click();//TypeKeys("<Alt-F4>");
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
