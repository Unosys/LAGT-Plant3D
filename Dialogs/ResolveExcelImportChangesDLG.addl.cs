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
using Autodesk.GUIHarness.Plant3d.Core;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ResolveExcelImportChangesDLG : Autodesk.GUIHarness.Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$ResolveExcelImportChanges";
		}

		public  void Invoke()
		{
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Invoke();
            SpecEditorDLG.FileMI.Pick();
            SpecEditorDLG.OpenCatalog.Pick();
			SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
            //SpecUtilityOpenCatDLG.TypeKeys("C:\\AutoCAD Plant 3D 2025 Content\\CPak AME\\AME Ductile Iron Pipes.pcat");
            SpecUtilityOpenCatDLG.TypeKeys(Plant3dConstants.Contentpath + "\\CPak AME\\AME Ductile Iron Pipes.pcat");

            System.Threading.Thread.Sleep(2000);
			SpecUtilityOpenCatDLG.TypeKeys("<Enter>");
			System.Threading.Thread.Sleep(10000);
			SpecEditorDLG.SetActive();
            SpecEditorDLG.CatalogEditor.Click();
			System.Threading.Thread.Sleep(10000);
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.SetActive();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.ImportFromExcel.Click();
			SpecUtilityCatalogImportDLG SpecUtilityCatalogImportDLG = new SpecUtilityCatalogImportDLG();
            if (LAGT.CommonFiles.Product.Variables.Language == "FRA") {
                SpecUtilityCatalogImportDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ResolveExcelImportChanges\\Exported_Catalog\\FRA_Exported_Catalog.xlsx");

            }else if (LAGT.CommonFiles.Product.Variables.Language == "KOR")
            {
                SpecUtilityCatalogImportDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ResolveExcelImportChanges\\Exported_Catalog\\KOR_Exported_Catalog.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "JPN")
            {
                SpecUtilityCatalogImportDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ResolveExcelImportChanges\\Exported_Catalog\\JPN_Exported_Catalog.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "RUS")
            {
                SpecUtilityCatalogImportDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ResolveExcelImportChanges\\Exported_Catalog\\RUS_Exported_Catalog.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
            {
                SpecUtilityCatalogImportDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ResolveExcelImportChanges\\Exported_Catalog\\CHS_Exported_Catalog.xlsx");

            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "DEU")
            {
                SpecUtilityCatalogImportDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ResolveExcelImportChanges\\Exported_Catalog\\DEU_Exported_Catalog.xlsx");

            }
            else
            {
                SpecUtilityCatalogImportDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ResolveExcelImportChanges\\Exported_Catalog\\ENU_Exported_Catalog.xlsx");

            }
            SpecUtilityCatalogImportDLG.OpenPB.SetFocus();
			SpecUtilityCatalogImportDLG.OpenPB.Click();
            System.Threading.Thread.Sleep(30000);
            if (!this.Exists) {
                System.Threading.Thread.Sleep(30000);
            }
            //ResolveExcelImportChangesDLG ResolveExcelImportChangesDLG = new ResolveExcelImportChangesDLG();
            //ResolveExcelImportChangesDLG.SetActive();
        }

		public  void Dismiss()
		{
			ResolveExcelImportChangesDLG ResolveExcelImportChangesDLG = new ResolveExcelImportChangesDLG();
			ResolveExcelImportChangesDLG.SetActive();
            ResolveExcelImportChangesDLG.CancelPB.Click();
            //ResolveExcelImportChangesDLG.TypeKeys("<Esc>");
            AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.SetActive();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.Dismiss();
		}
    }
}
