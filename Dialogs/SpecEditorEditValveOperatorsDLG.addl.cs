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
    public partial class SpecEditorEditValveOperatorsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$ModifyValveOperatorMappingWindow";
		}

		public override void Invoke()
		{
			SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
			SpecUtilityOpenCatDLG.Invoke();
			SpecUtilityOpenCatDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir+"CS150.pspx");
			
			SpecUtilityOpenCatDLG.Open.Click();
            System.Threading.Thread.Sleep(30000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
            SpecEditorDLG.SpecPB.Click();
            SpecEditorDLG.SpecsMI.Pick();
            SpecEditorDLG.EditValveOperators.Pick();           
			System.Threading.Thread.Sleep(10000);
            this.Size(1120,701);
		}

		public override void Dismiss()
		{
			SpecEditorEditValveOperatorsDLG SpecEditorEditValveOperatorsDLG = new SpecEditorEditValveOperatorsDLG();
			SpecEditorEditValveOperatorsDLG.SetActive();
			SpecEditorEditValveOperatorsDLG.CancelPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Dismiss();
		}
    }
}
