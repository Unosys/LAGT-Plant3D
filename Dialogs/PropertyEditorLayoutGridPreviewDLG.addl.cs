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
    public partial class PropertyEditorLayoutGridPreviewDLG : Pane
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
            RECT rPos = this.Pane5PANE.GetRect();
            this.Pane5PANE.DoubleClick(MouseButton.Left, 40, 85);//Layout
            //this.Pane6PANE.DoubleClick(MouseButton.Left, 40, 85);//Layout
            //PropertyEditorFieldsDLG PropertyEditorFieldsDLG = new PropertyEditorFieldsDLG();
            //PropertyEditorFieldsDLG.Invoke();
            //PropertyEditorFieldsDLG.SetActive();
            //System.Threading.Thread.Sleep(3000);
            //ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\PropertyEditor_Layout_Button.bmp");
            //         Desktop Desktop = new Desktop();
            //         Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
            //System.Threading.Thread.Sleep(1000);
            //PropertyEditorLayoutGridPreviewDLG PropertyEditorLayoutGridPreviewDLG = new PropertyEditorLayoutGridPreviewDLG();
            //PropertyEditorLayoutGridPreviewDLG.SetActive();
        }

		public  void Dismiss()
		{
			PropertyEditorLayoutGridPreviewDLG PropertyEditorLayoutGridPreviewDLG = new PropertyEditorLayoutGridPreviewDLG();
			PropertyEditorLayoutGridPreviewDLG.SetActive();
			PropertyEditorLayoutGridPreviewDLG.TypeKeys("<Alt-F4>");
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
