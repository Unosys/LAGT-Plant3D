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
    public partial class UnitConversionConfirmationTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23071, 7, "Unit conversion confirmation")+"|#1";
		}

		public override void Invoke()
		{
			AutoCADPlant3DCatalogBuildSettingsDLG AutoCADPlant3DCatalogBuildSettingsDLG = new AutoCADPlant3DCatalogBuildSettingsDLG();
			AutoCADPlant3DCatalogBuildSettingsDLG.Invoke();
            AutoCADPlant3DCatalogBuildSettingsDLG.UnitsPL.Select(2);
			AutoCADPlant3DCatalogBuildSettingsDLG.ConvertBtn.Click();
		}

		public override void Dismiss()
		{
			UnitConversionConfirmationTaskDLG UnitConversionConfirmationTaskDLG = new UnitConversionConfirmationTaskDLG();
			UnitConversionConfirmationTaskDLG.SetActive();
			UnitConversionConfirmationTaskDLG.Cancel.Click();
			AutoCADPlant3DCatalogBuildSettingsDLG AutoCADPlant3DCatalogBuildSettingsDLG = new AutoCADPlant3DCatalogBuildSettingsDLG();
			AutoCADPlant3DCatalogBuildSettingsDLG.Dismiss();
		}
    }
}
