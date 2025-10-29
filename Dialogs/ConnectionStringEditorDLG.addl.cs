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
    public partial class ConnectionStringEditorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$OLAPConnectionEditorForm";
		}

		public  void Invoke()
		{
			PivotGridTasksDLG PivotGridTasksDLG = new PivotGridTasksDLG();
			PivotGridTasksDLG.Invoke();
            Desktop Desktop = new Desktop();
            System.Threading.Thread.Sleep(1000);
            Desktop.TypeKeys("<Tab 3><Enter>");///OLAP Connection string
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ChartWizardBrowse_button.bmp");//....
            System.Threading.Thread.Sleep(1000);
            Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord -2);
            System.Threading.Thread.Sleep(5000);
            
            //PivotGridTasksDLG.DevExpressXtraPrintingNative.Click(MouseButton.Left, 160, 9);
			//ConnectionStringEditorDLG ConnectionStringEditorDLG = new ConnectionStringEditorDLG();
			//if (!ConnectionStringEditorDLG.Exists)
			//{
   //             Desktop.TypeKeys("<Esc>");
			//}
			//ConnectionStringEditorDLG.SetActive();
		}

		public  void Dismiss()
		{
			ConnectionStringEditorDLG ConnectionStringEditorDLG = new ConnectionStringEditorDLG();
			ConnectionStringEditorDLG.SetActive();
			ConnectionStringEditorDLG.TypeKeys("<Alt-F4>");
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
