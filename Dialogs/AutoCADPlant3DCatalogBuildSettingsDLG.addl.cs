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
    public partial class AutoCADPlant3DCatalogBuildSettingsDLG : Autodesk.GUIHarness.Window
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			//Tag = "$CatalogSettingDlg";
            Tag = "Autodesk AutoCAD Plant 3D Catalog Builder Settings|$Window_1";
		}

		public void Invoke()
		{
			CreateCatalogTemplateDLG CreateCatalogTemplateDLG = new CreateCatalogTemplateDLG();
			CreateCatalogTemplateDLG.Invoke();
			CreateCatalogTemplateDLG.SetActive();
			CreateCatalogTemplateDLG.FileNameTB.SetText("Test");
			CreateCatalogTemplateDLG.Ok.Click();
            System.Threading.Thread.Sleep(3000);
			AutoCADPlant3DCatalogBuilderApplicationDLG AutoCADPlant3DCatalogBuilderApplicationDLG = new AutoCADPlant3DCatalogBuilderApplicationDLG();
            if (AutoCADPlant3DCatalogBuilderApplicationDLG.MaximizePB.Exists)
            {
                AutoCADPlant3DCatalogBuilderApplicationDLG.MaximizePB.Click();
            }
            AutoCADPlant3DCatalogBuilderApplicationDLG.IdSettings.Click();
		}

		public void Dismiss()
		{
			AutoCADPlant3DCatalogBuildSettingsDLG AutoCADPlant3DCatalogBuildSettingsDLG = new AutoCADPlant3DCatalogBuildSettingsDLG();
			AutoCADPlant3DCatalogBuildSettingsDLG.Cancel.Click();
			AutoCADPlant3DCatalogBuilderApplicationDLG AutoCADPlant3DCatalogBuilderApplicationDLG = new AutoCADPlant3DCatalogBuilderApplicationDLG();
			AutoCADPlant3DCatalogBuilderApplicationDLG.Dismiss();
		}
    }
}
