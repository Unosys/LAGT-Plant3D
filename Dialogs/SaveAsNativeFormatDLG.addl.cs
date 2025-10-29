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
    public partial class SaveAsNativeFormatDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(491, 4, "Save As");
        }

		public override void Invoke()
		{
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Invoke();
			System.Threading.Thread.Sleep(4000);
			PreviewDLG.SavePB.Click();
			//ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Save2_Button_new.bmp");//Save2_Button.bmp
			//         Desktop Desktop = new Desktop();
			//         Desktop.Click(MouseButton.Left,ProductTestSuite.CommonFiles.SAM.iXCoord+2,ProductTestSuite.CommonFiles.SAM.iYCoord+2);
			//System.Threading.Thread.Sleep(2000);
		}

		public override void Dismiss()
		{
			SaveAsNativeFormatDLG SaveAsNativeFormatDLG = new SaveAsNativeFormatDLG();
			SaveAsNativeFormatDLG.SetActive();
			SaveAsNativeFormatDLG.Cancel.Click();
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Dismiss();
		}
    }
}
