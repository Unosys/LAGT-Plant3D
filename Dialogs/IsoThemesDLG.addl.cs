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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class IsoThemesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			//Tag = "$IsoThemesDlg";
            Tag = "[Pane]$IsoThemesDlg";
		}

		public override void Invoke()
		{
			IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
			IsometricDWGSettingsTitleBlockandDisplayDLG.Invoke();
            IsometricDWGSettingsTitleBlockandDisplayDLG.SetupTitleBlockPB.Click();
			System.Threading.Thread.Sleep(20000);
            Drawing.Current.TypeE("_RIBBON");
			Drawing.Current.TypeE("_PLANTISOTHEMESSETUP");
		}

		public override void Dismiss()
		{
			IsoThemesDLG IsoThemesDLG = new IsoThemesDLG();
			IsoThemesDLG.SetActive();
			IsoThemesDLG.BtnCancel.Click();
			Drawing.Current.TypeE("_close");
			WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
			if (WarningAutoCADDLG.Exists)
			{
				WarningAutoCADDLG.No.Click();
			}
			System.Threading.Thread.Sleep(5000);
			IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
			IsometricDWGSettingsTitleBlockandDisplayDLG.Dismiss();
		}
    }
}
