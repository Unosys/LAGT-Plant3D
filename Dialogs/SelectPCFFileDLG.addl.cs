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
    public partial class SelectPCFFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23035, 13, "Select PCF File");
		}

		public override void Invoke()
		{
			ProjectSetupIsometricDWGSettingsDLG ProjectSetupIsometricDWGSettingsDLG = new ProjectSetupIsometricDWGSettingsDLG();
			ProjectSetupIsometricDWGSettingsDLG.Invoke();
			ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
			ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(23035,5,"Isometric DWG Settings") + "/" + AcMainWin.cBabel(23035,12,"Live Preview"));
			IsometricDWGSettingsLivePreviewDLG IsometricDWGSettingsLivePreviewDLG = new IsometricDWGSettingsLivePreviewDLG();
			IsometricDWGSettingsLivePreviewDLG.BtnBrowse.Click();
		}

		public override void Dismiss()
		{
			SelectPCFFileDLG SelectPCFFileDLG = new SelectPCFFileDLG();
			SelectPCFFileDLG.SetActive();
			SelectPCFFileDLG.Cancel.Click();
			ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
			ProjectSetupPlant3DDWG.Dismiss();
		}
    }
}
