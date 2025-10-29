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
    public partial class SaveAsRTFDocumentDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
			System.Threading.Thread.Sleep(6000);
			PreviewDLG.SetActive();
			PreviewDLG.TypeKeys("<Alt>");
			PreviewDLG.TypeKeys("<Down 4>");
			PreviewDLG.TypeKeys("<Right>");
			PreviewDLG.TypeKeys("<Down 4><Enter>");
			System.Threading.Thread.Sleep(3000);
			RTFExportOptionsDLG RTFExportOptionsDLG = new RTFExportOptionsDLG();
			RTFExportOptionsDLG.OKPB.Click();
		}

		public override void Dismiss()
		{
			SaveAsRTFDocumentDLG SaveAsRTFDocumentDLG = new SaveAsRTFDocumentDLG();
			SaveAsRTFDocumentDLG.SetActive();
			SaveAsRTFDocumentDLG.Cancel.Click();
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Dismiss();
		}
    }
}
