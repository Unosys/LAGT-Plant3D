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
    public partial class SpecUtilityInvalidPathDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$Window_TaskDialog";

			//Tag = "[Window]" + AcMainWin.cBabel(23053, 18, "Invalid Path")+"|" +"$Window_TaskDialog";
		}

		public override void Invoke()
		{
			SelectSpecsAndCatalogsDLG SelectSpecsAndCatalogsDLG = new SelectSpecsAndCatalogsDLG();
			SelectSpecsAndCatalogsDLG.Invoke();
			SelectSpecsAndCatalogsDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir+"DummyCADWORX.spc");
			SelectSpecsAndCatalogsDLG.OpenPB.Click();
			ConvertCADWorxSpecsDLG ConvertCADWorxSpecsDLG = new ConvertCADWorxSpecsDLG();
			ConvertCADWorxSpecsDLG.SelectTheStandardLibraryTF.SetText("C:\\CAD");
			ConvertCADWorxSpecsDLG.SelectTheCadWorxDatafiletblTF.SetText("S:\\Test Files\\Plant3D\\DataFile.tbl");
			//ConvertCADWorxSpecsDLG.FolderConvertedSpecs.SetText("C:\\CAD");
			ConvertCADWorxSpecsDLG.SelectTheFolderForTF.SetText("0,0");
            System.Threading.Thread.Sleep(10000);
            ConvertCADWorxSpecsDLG.ConvertPB.SetFocus();
			ConvertCADWorxSpecsDLG.ConvertPB.Click();
            System.Threading.Thread.Sleep(3000);
            SpecUtilityInvalidPathDLG SpecUtilityInvalidPathDLG = new SpecUtilityInvalidPathDLG();
            if (!SpecUtilityInvalidPathDLG.Exists)
            {
                ConvertCADWorxSpecsDLG.ConvertPB.Click();
            }			
			SpecUtilityInvalidPathDLG.SetActive();
		}

		public override void Dismiss()
		{
			SpecUtilityInvalidPathDLG SpecUtilityInvalidPathDLG = new SpecUtilityInvalidPathDLG();
			SpecUtilityInvalidPathDLG.SetActive();
			SpecUtilityInvalidPathDLG.ClosePB.Click();
			ConvertCADWorxSpecsDLG ConvertCADWorxSpecsDLG = new ConvertCADWorxSpecsDLG();
			ConvertCADWorxSpecsDLG.Dismiss();
		}
    }
}
