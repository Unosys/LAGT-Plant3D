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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PreviewInvalidXMLDataErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox//Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "~ActiveApp/[DialogBox]" + AcMainWin.cBabel(275, 6,"Open")+"|"+ AcMainWin.cBabel(250, 14, "Open"); // "DevExpress.XtraEditors.XtraMessageBoxForm";
		}

        public override void Invoke()
		{
			OpenPreviewDocumentDLG OpenPreviewDocumentDLG = new OpenPreviewDocumentDLG();
			OpenPreviewDocumentDLG.Invoke();
			OpenPreviewDocumentDLG.FileNameTextField.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir+"PRNX.prnx");
			OpenPreviewDocumentDLG.Open.Click();
		}

        public override void Dismiss()
		{
			PreviewInvalidXMLDataErrorDLG PreviewInvalidXMLDataErrorDLG = new PreviewInvalidXMLDataErrorDLG();
			PreviewInvalidXMLDataErrorDLG.SetActive();
            PreviewInvalidXMLDataErrorDLG.ClosePB.Click();
            OpenPreviewDocumentDLG OpenPreviewDocumentDLG = new OpenPreviewDocumentDLG();
            OpenPreviewDocumentDLG.Dismiss();
		}
    }
}
