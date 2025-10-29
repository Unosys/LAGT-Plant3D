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
    public partial class SpecUtilityCatalogImportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
					Tag = AcMainWin.cBabel(275, 6, "Open") + "|" + Plant3DFunctions.GetLocString("OpenImageDLG");
					break;

                default:
                    Tag = "[DialogBox]" + AcMainWin.cBabel(250, 14, "Open");
                    break;

            }
        }

		public override void Invoke()
		{
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.OpenSpec(LAGT.CommonFiles.Product.Variables.TestFilesDir+"CS150 Flanged.pspx");
			SpecEditorDLG.SetActive();
            SpecEditorDLG.CatalogEditor.Click();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.WaitExists(5000);
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.SetActive();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.ImportFromExcel.Click();
			SpecUtilityCatalogImportDLG SpecUtilityCatalogImportDLG = new SpecUtilityCatalogImportDLG();
            //SpecUtilityCatalogImportDLG.WaitExists(5000);
            System.Threading.Thread.Sleep(20000);
			SpecUtilityCatalogImportDLG.SetActive();
		}

		public override void Dismiss()
		{
			SpecUtilityCatalogImportDLG SpecUtilityCatalogImportDLG = new SpecUtilityCatalogImportDLG();
			SpecUtilityCatalogImportDLG.SetActive();
			SpecUtilityCatalogImportDLG.CancelPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();
			//SpecEditorDLG.CloseAll.Pick();
			SpecEditorDLG.Dismiss();
		}
    }
}
