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
    public partial class SpecUtilityInvalidNameDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23053, 11, "Invalid Name");
		}

		public override void Invoke()
		{
			SpecUtilitySaveAsDLG SpecUtilitySaveAsDLG = new SpecUtilitySaveAsDLG();
			SpecUtilitySaveAsDLG.Invoke();
			SpecUtilitySaveAsDLG.SetActive();
			System.Threading.Thread.Sleep(1000);
			SpecUtilitySaveAsDLG.TypeKeys("<Tab 10>");
			CreateSpecDLG CreateSpecDLG = new CreateSpecDLG();
            SpecUtilitySaveAsDLG.FileNameCB.ClearText();
            SpecUtilitySaveAsDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "CS150 Flanged.pspx");   // need to check with addlspy
            SpecUtilitySaveAsDLG.SavePB.Click();
			System.Threading.Thread.Sleep(1000);
            //CreateSpecDLG.SaveAs.ConfirmSaveAs.SetActive();                   // need to check manually with addlspy
            //CreateSpecDLG.SaveAs.ConfirmSaveAs.TypeKeys("<Tab><Enter>");
            CreateSpecDLG.YesPB.Click();
			System.Threading.Thread.Sleep(1000);
			CreateSpecDLG.SetActive();
			CreateSpecDLG.CreatePB.Click();
			System.Threading.Thread.Sleep(1000);
			SpecUtilityInvalidNameDLG1 SpecUtilityInvalidNameDLG1 = new SpecUtilityInvalidNameDLG1();
			SpecUtilityInvalidNameDLG1.SetActive();
		}

		public override void Dismiss()
		{
			SpecUtilityInvalidNameDLG1 SpecUtilityInvalidNameDLG1 = new SpecUtilityInvalidNameDLG1();
			SpecUtilityInvalidNameDLG1.SetActive();
			SpecUtilityInvalidNameDLG1.NoPB.Click();
			CreateSpecDLG CreateSpecDLG = new CreateSpecDLG();
			CreateSpecDLG.SetActive();
			CreateSpecDLG.Dismiss();
		}
    }
}
