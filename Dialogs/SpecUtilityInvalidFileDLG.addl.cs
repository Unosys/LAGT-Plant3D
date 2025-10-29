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
    public partial class SpecUtilityInvalidFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23053, 12, "Invalid File");
		}

		public override void Invoke()
		{
			CreateSpecDLG CreateSpecDLG = new CreateSpecDLG();
			CreateSpecDLG.Invoke();
            System.Threading.Thread.Sleep(2000);
            CreateSpecDLG.NewSpecNameTF.SetText("C:\\Temp\\Dummy.pspx");
			CreateSpecDLG.CreatePB.Click();
			SpecUtilityInvalidNameDLG1 SpecUtilityInvalidNameDLG1 = new SpecUtilityInvalidNameDLG1();
			if (SpecUtilityInvalidNameDLG1.Exists)
			{
				SpecUtilityInvalidNameDLG1.YesPB.Click();
			}
            SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
            SpecEditorDLG.FileMI.Pick();
            SpecEditorDLG.New.Pick();
            SpecEditorDLG.NewSpec.Pick();
            System.Threading.Thread.Sleep(3000);
            CreateSpecDLG.NewSpecNameTF.SetText("C:\\Temp\\Dummy.pspx");
			CreateSpecDLG.CreatePB.Click();
			SpecUtilityInvalidNameDLG1.SetActive();
			SpecUtilityInvalidNameDLG1.YesPB.Click();
			SpecUtilityInvalidFileDLG SpecUtilityInvalidFileDLG = new SpecUtilityInvalidFileDLG();
			SpecUtilityInvalidFileDLG.SetActive();
		}

		public override void Dismiss()
		{
			SpecUtilityInvalidFileDLG SpecUtilityInvalidFileDLG = new SpecUtilityInvalidFileDLG();
			SpecUtilityInvalidFileDLG.SetActive();
			SpecUtilityInvalidFileDLG.OkPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();
            SpecEditorDLG.FileMI.Pick();
            SpecEditorDLG.CloseAll.Pick();
			SpecEditorDLG.Dismiss();
		}
    }
}
