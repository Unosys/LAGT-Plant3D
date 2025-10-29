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
    public partial class PreviewFindDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            //Tag = "$SearchDialog";
            Tag = "$PrintPreviewFormExBase";
        }

		public void Invoke()
		{
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Invoke();
			System.Threading.Thread.Sleep(4000);
			PreviewDLG.SearchPB.Click();
			//ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "\\SamScreenshots\\Search_button_new.bmp");//Search_button.bmp
			//         Desktop Desktop = new Desktop();
			//         Desktop.Click(MouseButton.Left,ProductTestSuite.CommonFiles.SAM.iXCoord+2,ProductTestSuite.CommonFiles.SAM.iYCoord+2);
			//System.Threading.Thread.Sleep(2000);
		}

		public void Dismiss()
		{
			//PreviewFindDLG PreviewFindDLG = new PreviewFindDLG();
			//PreviewFindDLG.SetActive();
			//PreviewFindDLG.BtnClose.Click();
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Dismiss();
		}
    }
}
