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
    public partial class IsometricDWGSettingsSymbolsAndReference : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]Project Setup|$EditProjectSettingsDlg";
        }

        public override void Invoke()
        {
            ProjectSetupIsometricDWGSettingsDLG ProjectSetupIsometricDWGSettingsDLG = new ProjectSetupIsometricDWGSettingsDLG();
            ProjectSetupIsometricDWGSettingsDLG.Invoke();
            ProjectSetupIsometricDWGSettingsDLG.IsoStyleSetupTVI.Click();
            ProjectSetupIsometricDWGSettingsDLG.TypeKeys("<Up>");
            //ProjectSetupIsometricDWGSettingsDLG ProjectSetupIsometricDWGSettingsDLG = new ProjectSetupIsometricDWGSettingsDLG();
            //ProjectSetupIsometricDWGSettingsDLG.Invoke();
            //ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            //ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(23035, 5, "Isometric DWG Settings") + "/" + AcMainWin.cBabel(23035, 1, "Symbols and Reference"));
            IsometricDWGSettingsSymbolsAndReference IsometricDWGSettingsSymbolsAndReference = new IsometricDWGSettingsSymbolsAndReference();
            IsometricDWGSettingsSymbolsAndReference.SetActive();
        }

        public override void Dismiss()
        {
            IsometricDWGSettingsSymbolsAndReference IsometricDWGSettingsSymbolsAndReference = new IsometricDWGSettingsSymbolsAndReference();
            IsometricDWGSettingsSymbolsAndReference.CancelPB.Click();
            //ProjectSetupIsometricDWGSettingsDLG ProjectSetupIsometricDWGSettingsDLG = new ProjectSetupIsometricDWGSettingsDLG();
            //ProjectSetupIsometricDWGSettingsDLG.Dismiss();

        }
    }
}
