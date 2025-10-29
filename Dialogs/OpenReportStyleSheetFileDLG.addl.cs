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
    public partial class OpenReportStyleSheetFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
					Tag = Plant3DFunctions.GetLocString("OpenImageDLG") + "|" + AcMainWin.cBabel(250, 14, "Open");

					break;
                default:
                    Tag = AcMainWin.cBabel(250, 14, "Open") + "|" + AcMainWin.cBabel(275, 6, "Open");
                    break;

            }
           
		}

		public override void Invoke()
		{
			StylesEditorDLG StylesEditorDLG = new StylesEditorDLG();
			StylesEditorDLG.Invoke();
			StylesEditorDLG.SetActive();
			StylesEditorDLG.PushButton2PB.Click();
			//SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Styke_Open.bmp");
			//         Desktop Desktop = new Desktop();
			//         Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
			//System.Threading.Thread.Sleep(2000);
			//OpenReportStyleSheetFileDLG OpenReportStyleSheetFileDLG = new OpenReportStyleSheetFileDLG();
			//OpenReportStyleSheetFileDLG.SetActive();
		}

		public override void Dismiss()
		{
			OpenReportStyleSheetFileDLG OpenReportStyleSheetFileDLG = new OpenReportStyleSheetFileDLG();
			OpenReportStyleSheetFileDLG.SetActive();
			OpenReportStyleSheetFileDLG.TypeKeys("<Alt-F4>");
			StylesEditorDLG StylesEditorDLG = new StylesEditorDLG();
			StylesEditorDLG.SetActive();
			StylesEditorDLG.Dismiss();
		}
    }
}
