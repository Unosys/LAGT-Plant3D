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
    public partial class SpecUtilityErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]"+AcMainWin.cBabel(23053, 53, "Error.");
		}

		public override void Invoke()
		{
			CreateSpecFromExistingSpecDLG1 CreateSpecFromExistingSpecDLG1 = new CreateSpecFromExistingSpecDLG1();
			CreateSpecFromExistingSpecDLG1.Invoke();
            CreateSpecFromExistingSpecDLG1.SourceSpecNameTF.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "CS150 Flanged.pspx");
            CreateSpecFromExistingSpecDLG1.NewSpecNameTF.SetText("C:\\Temp\\ExistDummy.pspx");       // need to check manually with addlspy
            CreateSpecFromExistingSpecDLG1.CreatePB.Click();
            System.Threading.Thread.Sleep(5000);
			SpecFromExistingInvalidName SpecFromExistingInvalidName = new SpecFromExistingInvalidName();
			if (SpecFromExistingInvalidName.Exists)
			{
				SpecFromExistingInvalidName.YES.Click();
			}
            System.Threading.Thread.Sleep(20000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			
            SpecEditorDLG.FileMI.Pick();
            SpecEditorDLG.CloseAll.Pick();
            System.Threading.Thread.Sleep(3000);
			CreateSpecFromExistingSpecDLG1.Invoke();
            
            CreateSpecFromExistingSpecDLG1.SourceSpecNameTF.SetText("Dummy.pspx");     // need to check manually with addlspy
            CreateSpecFromExistingSpecDLG1.NewSpecNameTF.SetText("C:\\Temp\\ExistDummy.pspx");
            CreateSpecFromExistingSpecDLG1.CreatePB.Click();
            System.Threading.Thread.Sleep(2000);
			if (SpecFromExistingInvalidName.Exists)
			{
				SpecFromExistingInvalidName.YES.Click();
			}
            System.Threading.Thread.Sleep(2000);
			SpecUtilityErrorDLG SpecUtilityErrorDLG = new SpecUtilityErrorDLG();
			
			SpecUtilityErrorDLG.SetActive();
		}

		public override void Dismiss()
		{
			SpecUtilityErrorDLG SpecUtilityErrorDLG = new SpecUtilityErrorDLG();
			SpecUtilityErrorDLG.SetActive();
			System.Threading.Thread.Sleep(2000);
			SpecUtilityErrorDLG.OkPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Dismiss();
		}
    }
}
