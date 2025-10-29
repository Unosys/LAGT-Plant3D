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
    public partial class SpecAndCatalogMigrationCompleteDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Window]$TaskDialog_Enhanced";
		}

		public override void Invoke()
		{
			SelectSpecsAndCatalogsToMigrateDLG SelectSpecsAndCatalogsToMigrateDLG = new SelectSpecsAndCatalogsToMigrateDLG();
			SelectSpecsAndCatalogsToMigrateDLG.Invoke();
			SelectSpecsAndCatalogsToMigrateDLG.FileNameCB.ClearText();
			SelectSpecsAndCatalogsToMigrateDLG.FileNameCB.SetText(Path.Combine(LAGT.CommonFiles.Product.Variables.TestFilesDir, "Hadrian_Catalogs", "AME Plastic Pipes.pcat"));
			SelectSpecsAndCatalogsToMigrateDLG.OpenPB.Click();
			System.Threading.Thread.Sleep(8000);
			SupportingContentUnavailableDLG SupportingContentUnavailableDLG = new SupportingContentUnavailableDLG();
			SupportingContentUnavailableDLG.ContinueConversionWithoutSupportingST.Click();
			System.Threading.Thread.Sleep(1000);
			if (SupportingContentUnavailableDLG.Exists) 
			{ 
			RECT rSize = SupportingContentUnavailableDLG.Image3IMG.GetRect();
				SupportingContentUnavailableDLG.Click(MouseButton.Left, rSize.xPos+50, rSize.yPos+2);
		     }
			System.Threading.Thread.Sleep(8000);
			SpecAndCatalogMigrationCompleteDLG SpecAndCatalogMigrationCompleteDLG = new SpecAndCatalogMigrationCompleteDLG();
			SpecAndCatalogMigrationCompleteDLG.SetActive();
		}

		public override void Dismiss()
		{
			SpecAndCatalogMigrationCompleteDLG SpecAndCatalogMigrationCompleteDLG = new SpecAndCatalogMigrationCompleteDLG();
			//SpecAndCatalogMigrationCompleteDLG.SetActive();
            SpecAndCatalogMigrationCompleteDLG.ClosePB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Dismiss();
		}
    }
}
