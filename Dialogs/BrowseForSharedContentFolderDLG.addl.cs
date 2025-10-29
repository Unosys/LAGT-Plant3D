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
    public partial class BrowseForSharedContentFolderDLG : DialogBox 
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]" + AcMainWin.cBabel(23073, 21, "Browse For Folder")+"|"+ AcMainWin.cBabel(362, 1, "Browse For Folder") + "|" + AcMainWin.cBabel(47, 1, "Browse For Folder") + "|" + AcMainWin.cBabel(295, 14, "Select Folder") + "|*" + AcMainWin.cBabel(545, 17, "Browse") + "*";
        }

		public override void Invoke()
		{
			ModifySharedContentFolderDLG ModifySharedContentFolderDLG = new ModifySharedContentFolderDLG();
			ModifySharedContentFolderDLG.Invoke();
            ModifySharedContentFolderDLG.BtSharedContentFolder.Click();
            BrowseForSharedContentFolderDLG BrowseForSharedContentFolderDLG = new BrowseForSharedContentFolderDLG();
            BrowseForSharedContentFolderDLG.SetActive();
        }

		public override void Dismiss()
		{
			BrowseForSharedContentFolderDLG BrowseForSharedContentFolderDLG = new BrowseForSharedContentFolderDLG();
			BrowseForSharedContentFolderDLG.SetActive();
			BrowseForSharedContentFolderDLG.Cancel.Click();
			ModifySharedContentFolderDLG ModifySharedContentFolderDLG = new ModifySharedContentFolderDLG();
			ModifySharedContentFolderDLG.Dismiss();
			//Drawing.Current.SetSysVar("cmddia", 0);
		}
    }
}
