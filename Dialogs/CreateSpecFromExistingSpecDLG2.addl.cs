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
    public partial class CreateSpecFromExistingSpecDLG2 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$NewFileWindow";
		}

		public override void Invoke()
		{
			CreateSpecFromExistingSpecDLG1 CreateSpecFromExistingSpecDLG1 = new CreateSpecFromExistingSpecDLG1();
			CreateSpecFromExistingSpecDLG1.Invoke();
			CreateSpecFromExistingSpecDLG1.SetActive();
            CreateSpecFromExistingSpecDLG1.PushButton1PB.Click();
            CreateSpecFromExistingSpecDLG1.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir+ "CS150 Flanged.pspx");
            CreateSpecFromExistingSpecDLG1.OpenPB.Click();
			CreateSpecFromExistingSpecDLG2 CreateSpecFromExistingSpecDLG2 = new CreateSpecFromExistingSpecDLG2();
			CreateSpecFromExistingSpecDLG2.SetActive();
		}

		public override void Dismiss()
		{
			CreateSpecFromExistingSpecDLG2 CreateSpecFromExistingSpecDLG2 = new CreateSpecFromExistingSpecDLG2();
			CreateSpecFromExistingSpecDLG2.SetActive();
			CreateSpecFromExistingSpecDLG1 CreateSpecFromExistingSpecDLG1 = new CreateSpecFromExistingSpecDLG1();
            CreateSpecFromExistingSpecDLG1.CancelPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Dismiss();
		}
    }
}
