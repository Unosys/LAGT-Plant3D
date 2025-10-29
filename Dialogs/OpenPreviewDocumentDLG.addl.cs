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
    public partial class OpenPreviewDocumentDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "*" + AcMainWin.cBabel(250, 14, "Open") + "*|" + AcMainWin.cBabel(275, 6, "Open");
		}

		public override void Invoke()
		{
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Invoke();
			System.Threading.Thread.Sleep(4000);
			PreviewDLG.SetActive();
			PreviewDLG.Open1PB.Click();
			//ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\FileOpen3_Button_new.bmp");//FileOpen3_Button.bmp
			//         PreviewDLG.SetActive();
			//         Desktop Desktop = new Desktop();
			//         Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
			//System.Threading.Thread.Sleep(5000);
			OpenPreviewDocumentDLG OpenPreviewDocumentDLG = new OpenPreviewDocumentDLG();
			OpenPreviewDocumentDLG.SetActive();
		}

		public override void Dismiss()
		{
			OpenPreviewDocumentDLG OpenPreviewDocumentDLG = new OpenPreviewDocumentDLG();
			OpenPreviewDocumentDLG.SetActive();
			OpenPreviewDocumentDLG.Cancel.Click();
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Dismiss();
		}
    }
}
