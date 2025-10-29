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
    public partial class SpecEditorLongDescriptionStyleDeletionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$TaskDialog_Enhanced";
		}

		public override void Invoke()
		{
			SpecUtilitySaveAsNewStyleDLG SpecUtilitySaveAsNewStyleDLG = new SpecUtilitySaveAsNewStyleDLG();
			SpecUtilitySaveAsNewStyleDLG.Invoke();
            SpecUtilitySaveAsNewStyleDLG.StyleNameTF.SetText("Dummy");
			System.Threading.Thread.Sleep(5000);
			SpecUtilitySaveAsNewStyleDLG.TypeKeys("<TAB><ENTER>",1);
			EditLongDescriptionStyleDLG EditLongDescriptionStyleDLG = new EditLongDescriptionStyleDLG();
			EditLongDescriptionStyleDLG.SetActive();
			EditLongDescriptionStyleDLG.DeletePB.Click();
            System.Threading.Thread.Sleep(2000);
			SpecEditorLongDescriptionStyleDeletionDLG SpecEditorLongDescriptionStyleDeletionDLG = new SpecEditorLongDescriptionStyleDeletionDLG();
			SpecEditorLongDescriptionStyleDeletionDLG.SetActive();
		}

		public override void Dismiss()
		{
			SpecEditorLongDescriptionStyleDeletionDLG SpecEditorLongDescriptionStyleDeletionDLG = new SpecEditorLongDescriptionStyleDeletionDLG();
			SpecEditorLongDescriptionStyleDeletionDLG.SetActive();
            SpecEditorLongDescriptionStyleDeletionDLG.CancelPB.Click();

			EditLongDescriptionStyleDLG EditLongDescriptionStyleDLG = new EditLongDescriptionStyleDLG();
			EditLongDescriptionStyleDLG.Dismiss();
		}
    }
}
