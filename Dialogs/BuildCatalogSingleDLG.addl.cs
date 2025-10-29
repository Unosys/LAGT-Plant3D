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
    public partial class BuildCatalogSingleDLG : Autodesk.GUIHarness.MainWin
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "Build Catalog|$Window_1";
		}

		public void Invoke()
		{
			AutoCADPlant3DCatalogBuilderApplicationDLG AutoCADPlant3DCatalogBuilderApplicationDLG = new AutoCADPlant3DCatalogBuilderApplicationDLG();
			AutoCADPlant3DCatalogBuilderApplicationDLG.Invoke();
			AutoCADPlant3DCatalogBuilderApplicationDLG.SetActive();
			AutoCADPlant3DCatalogBuilderApplicationDLG.IdBuildCatalog.Click();
            System.Threading.Thread.Sleep(1000);
			SelectExcelFilesToBuildCalogAppicationDLG SelectExcelFilesToBuildCalogAppicationDLG = new SelectExcelFilesToBuildCalogAppicationDLG();
			SelectExcelFilesToBuildCalogAppicationDLG.SetActive();
			SelectExcelFilesToBuildCalogAppicationDLG.TypeKeys("<Tab 10>");
            if (LAGT.CommonFiles.Product.Variables.Language == "FRA"||LAGT.CommonFiles.Product.Variables.Language == "RUS"||LAGT.CommonFiles.Product.Variables.Language == "DEU")
			{SelectExcelFilesToBuildCalogAppicationDLG.FileName1.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "test1234.xlsx");// CS150-FlangeBlind.xlsx");//"test1234.xlsx");
			}else{
			SelectExcelFilesToBuildCalogAppicationDLG.FileName1.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "CS150-FlangeBlind.xlsx");//"test1234.xlsx");
			}
			SelectExcelFilesToBuildCalogAppicationDLG.Open.Click();
			NoExcelMSGDLG NoExcelMSGDLG = new NoExcelMSGDLG();
            BuildCatalogSingleDLG BuildCatalogSingleDLG = new BuildCatalogSingleDLG();
			if (NoExcelMSGDLG.Exists)
			{
                NoExcelMSGDLG.Dismiss();
			}
			else
			{
				//while !(BuildCatalogSingleDLG while !(BuildCatalogSingleDLG = new while !(BuildCatalogSingleDLG();
                while (!BuildCatalogSingleDLG.Exists);
			}
			System.Threading.Thread.Sleep(10000);
			//BuildCatalogSingleDLG BuildCatalogSingleDLG = new BuildCatalogSingleDLG();
			BuildCatalogSingleDLG.SetActive();
		}

		public void Dismiss()
		{
			BuildCatalogSingleDLG BuildCatalogSingleDLG = new BuildCatalogSingleDLG();
			BuildCatalogSingleDLG.SetActive();
			BuildCatalogSingleDLG.TypeKeys("<Alt-F4>");
			AutoCADPlant3DCatalogBuilderApplicationDLG AutoCADPlant3DCatalogBuilderApplicationDLG = new AutoCADPlant3DCatalogBuilderApplicationDLG();
			AutoCADPlant3DCatalogBuilderApplicationDLG.Dismiss();
		}
    }
}
