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
    public partial class SpecandCatalogsConversionCompleteDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
			var SelectSpecsAndCatalogsDLG = new SelectSpecsAndCatalogsDLG();
			SelectSpecsAndCatalogsDLG.Invoke();
			SelectSpecsAndCatalogsDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir+"150.spc");
			SelectSpecsAndCatalogsDLG.OpenPB.Click();
			ConvertCADWorxSpecsDLG ConvertCADWorxSpecsDLG = new ConvertCADWorxSpecsDLG();
			ConvertCADWorxSpecsDLG.SelectTheStandardLibraryTF.SetText("C:\\Temp");
			ConvertCADWorxSpecsDLG.SelectTheCadWorxDatafiletblTF.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir+"DataFile.tbl");
            ConvertCADWorxSpecsDLG.SelectTheFolderForTF.SetText("C:\\Temp");
            //ConvertCADWorxSpecsDLG.FolderConvertedSpecs.SetSelRange(0, 1, 0, 1);
			ConvertCADWorxSpecsDLG.ConvertPB.Click();
			System.Threading.Thread.Sleep(10000);
			ErrorCannotOpenCADWorxDataFileDLG ErrorCannotOpenCADWorxDataFileDLG = new ErrorCannotOpenCADWorxDataFileDLG();
			if (ErrorCannotOpenCADWorxDataFileDLG.Exists)
			{
				ErrorCannotOpenCADWorxDataFileDLG.OkPB.Click();
			}
			System.Threading.Thread.Sleep(20000);

			var SpecandCatalogsConversionCompleteDLG = new SpecandCatalogsConversionCompleteDLG();
            if (!SpecandCatalogsConversionCompleteDLG.Exists)
            {
                ConvertCADWorxSpecsDLG.ConvertPB.Click();
            }
            else
            {
                SpecandCatalogsConversionCompleteDLG.SetActive();
            }
			
		}

		public override void Dismiss()
		{
			var SpecandCatalogsConversionCompleteDLG = new SpecandCatalogsConversionCompleteDLG();
			SpecandCatalogsConversionCompleteDLG.SetActive();
            SpecandCatalogsConversionCompleteDLG.CancelPB.Click();
			var SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Dismiss();
		}
    }
}
