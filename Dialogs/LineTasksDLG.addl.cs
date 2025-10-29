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
    public partial class LineTasksDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "DevExpress.XtraReports.Design.XRSmartTagService+PopupForm|#1";
		}

		public  void Invoke()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Invoke();

			ReportDesignerApplicationDLG.TypeKeys("<Ctrl-n>");
            
			//Plant3DFunctions.StandardControls(8);
			//System.Threading.Thread.Sleep(4000);
            System.Threading.Thread.Sleep(4000);
            Desktop Desktop = new Desktop();
            //Plant3DFunctions.StandardControls(4);//Double Click 'Rich Text' in the 'Tool Box'
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Line.bmp");
            Desktop.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
            System.Threading.Thread.Sleep(4000);

            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ReportDesignerExpand_Button.bmp");
           
            Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
			System.Threading.Thread.Sleep(2000);
			LineTasksDLG LineTasksDLG = new LineTasksDLG();
			LineTasksDLG.SetActive();
		}

		public  void Dismiss()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
