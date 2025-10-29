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
using System;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SpecUtilityImportFromDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23053, 34, "Import From");
		}

		public override void Invoke()
		{
            
            string Title = DateTime.Now.ToString();
            Title = Title.Replace(":", "_").Replace("/", "_");
			//Title = StrTran(Title, ":", "_"); // Title = Title.Replace(":", "_");   // need to refer mscorlib.dll to get System.Object.String.Replace() method
			CreateSpecDLG CreateSpecDLG = new CreateSpecDLG();
			CreateSpecDLG.Invoke();
            //CreateSpecDLG.NewSpecNameTF.SetFocus();
            //CreateSpecDLG.NewSpecNameTF.SetText(Title);
            
            CreateSpecDLG.PushButtonPB.Click();
            System.Threading.Thread.Sleep(2000);
            //CreateSpecDLG.FileNameCB.SetText(Title);
            //CreateSpecDLG.SavePB.Click();SpecUtilitySaveAsDLG
            SpecUtilitySaveAsDLG SpecUtilitySaveAsDLG = new SpecUtilitySaveAsDLG();
            SpecUtilitySaveAsDLG.FileNameCB.ClearText();
            SpecUtilitySaveAsDLG.FileNameCB.SetText(Title);   // need to check with addlspy
            SpecUtilitySaveAsDLG.SavePB.Click();
            System.Threading.Thread.Sleep(1000);
            CreateSpecDLG.CreatePB.Click();
			System.Threading.Thread.Sleep(5000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
            SpecEditorDLG.ImportFromExcel.SetFocus();
			SpecEditorDLG.ImportFromExcel.Click();
            System.Threading.Thread.Sleep(3000);
           
			SpecUtilityImportFromDLG SpecUtilityImportFromDLG = new SpecUtilityImportFromDLG();
            if (!SpecUtilityImportFromDLG.Exists) {

                SpecEditorDLG.ImportFromExcel.Click();
            }
			SpecUtilityImportFromDLG.SetActive();
		}

		public override void Dismiss()
		{
			SpecUtilityImportFromDLG SpecUtilityImportFromDLG = new SpecUtilityImportFromDLG();
			SpecUtilityImportFromDLG.SetActive();
			SpecUtilityImportFromDLG.CancelPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();
			//SpecEditorDLG.CloseAll.Pick();
			SpecEditorDLG.Dismiss();
		}
    }
}
