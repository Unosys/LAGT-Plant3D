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
    public partial class InsertTitleBlockAttributesDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$IsometricTitleBlockAttributeSetupFrm";
		}

		public  void Invoke()
		{
            
			IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
			IsometricDWGSettingsTitleBlockandDisplayDLG.Invoke();
            IsometricDWGSettingsTitleBlockandDisplayDLG.SetupTitleBlockPB.Click();
			//while(!Drawing.Current.Exists);
			System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_RIBBON");
			Drawing.Current.TypeE("_PLANTISOTBATTRIBUTESETUP");
            System.Threading.Thread.Sleep(2000);
		}

		public  void Dismiss()
		{
			InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributesDLG();
			InsertTitleBlockAttributesDLG.M_closeButton.Click();
            System.Threading.Thread.Sleep(2000);
            //Drawing.Current.TypeE("_plantisotbclose");
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(1000);
            PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
            if (PandIDWarningAutoCADDLG.Exists)
            {
                PandIDWarningAutoCADDLG.No.Click();
            }
   //         Desktop Desktop = new Desktop();
   //         Desktop.TypeKeys("<tab><Enter>");
   //         BlockChangesNotSavedDLG BlockChangesNotSavedDLG = new BlockChangesNotSavedDLG();
   //         //BlockChangesNotSavedDLG.SetActive();
   //         //BlockChangesNotSavedDLG.DiscardTheChangesAndPB.Click();
   //         System.Threading.Thread.Sleep(2000);
   //         if (BlockChangesNotSavedDLG.Exists)
			//{
   //             BlockChangesNotSavedDLG.SetActive();
   //             BlockChangesNotSavedDLG.TypeKeys("<tab><Enter>");
			//}
   //         if (BlockChangesNotSavedDLG.Exists)
   //         {
                
   //             BlockChangesNotSavedDLG.TypeKeys("<tab><Enter>");
   //         }
          
   //         BlockSaveParameterChangesDLG BlockSaveParameterChangesDLG = new BlockSaveParameterChangesDLG();
			//if (BlockSaveParameterChangesDLG.Exists)
			//{
			//	BlockSaveParameterChangesDLG.TypeKeys("<tab><Enter>");
			//}
            System.Threading.Thread.Sleep(10000);
            IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
			if (IsometricDWGSettingsTitleBlockandDisplayDLG.Exists)
			{
				IsometricDWGSettingsTitleBlockandDisplayDLG.Dismiss();
			}
            //Plant3D AppWnd = new Plant3D();
            //AppWnd.Exit1();

        }
    }
}
