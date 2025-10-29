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
    public partial class InsertTitleBlockAttributes_RequiredExelDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$IsometricTitleBlockAttributeSetupFrm";
		}

		public void Invoke()
		{
			IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
			IsometricDWGSettingsTitleBlockandDisplayDLG.Invoke();
			System.Threading.Thread.Sleep(5000);
            IsometricDWGSettingsTitleBlockandDisplayDLG.SetupTitleBlockPB.Click();
			while(!Drawing.Current.Exists);
			System.Threading.Thread.Sleep(2000);
			Drawing.Current.TypeE("_PLANTISOTBATTRIBUTESETUP");
			System.Threading.Thread.Sleep(5000);
			InsertTitleBlockAttributes_RequiredExelDLG InsertTitleBlockAttributes_RequiredExelDLG = new InsertTitleBlockAttributes_RequiredExelDLG();
			InsertTitleBlockAttributes_RequiredExelDLG.AttributeCategoryPL.Select(6);
		}

        public void Dismiss()
		{
            InsertTitleBlockAttributes_RequiredExelDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributes_RequiredExelDLG();
			InsertTitleBlockAttributesDLG.M_closeButton.Click();
            System.Threading.Thread.Sleep(3000);
            Drawing.Current.TypeKeys("_plantisotbclose");
            Drawing.Current.TypeKeys("<tab><enter>");
            
			System.Threading.Thread.Sleep(2000);
			BlockChangesNotSavedDLG BlockChangesNotSavedDLG = new BlockChangesNotSavedDLG();
            if (BlockChangesNotSavedDLG.Exists)
            {
                BlockChangesNotSavedDLG.TypeKeys("<tab><enter>");
            }
			if (BlockChangesNotSavedDLG.Exists)
			{
                BlockChangesNotSavedDLG.DiscardTheChangesAndPB.Click();
			}
            if (BlockChangesNotSavedDLG.WaitExists(100))
            {
                BlockChangesNotSavedDLG.DiscardTheChangesAndPB.Click();
            }
            
            Desktop.Current.TypeKeys("<tab><enter>");
			BlockSaveParameterChangesDLG BlockSaveParameterChangesDLG = new BlockSaveParameterChangesDLG();
			if (BlockSaveParameterChangesDLG.Exists)
			{
				BlockSaveParameterChangesDLG.TypeKeys("<tab><Enter>");
			}
			IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
			if (IsometricDWGSettingsTitleBlockandDisplayDLG.Exists)
			{
				IsometricDWGSettingsTitleBlockandDisplayDLG.Dismiss();
			}
		}
    }
}
