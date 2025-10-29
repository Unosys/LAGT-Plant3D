// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
    public partial class OpenVaultProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23165,20, "Open Vault Project");
		}

		public override void Invoke()
		{
			Drawing.Current.TypeE("_PROJECTMANAGER");
			VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
			if (VaultLogInDLG.Exists)
			{
				VaultLogInDLG.UserNameTextBox.SetText("Administrator");
				VaultLogInDLG.OK.Click();
				System.Threading.Thread.Sleep(2000);
			}
			PROJECTMANAGERDLG PROJECTMANAGERDLG = Current<PROJECTMANAGERDLG>();
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.CurrentProjectPL.SetFocus();
			PROJECTMANAGERDLG.CurrentProjectPL.Select(AcMainWin.cBabel(23165,10,"Open From Vault..."));
			System.Threading.Thread.Sleep(2000);
			OpenProjectFromVaultDLG OpenProjectFromVaultDLG = Current<OpenProjectFromVaultDLG>();
			OpenProjectFromVaultDLG.SetActive();
			OpenProjectFromVaultDLG.TypeKeys("<Down 4>");
			OpenProjectFromVaultDLG.OpenPB.Click();
		}

		public override void Dismiss()
		{
			OpenVaultProjectDLG OpenVaultProjectDLG = Current<OpenVaultProjectDLG>();
			OpenVaultProjectDLG.SetActive();
			OpenVaultProjectDLG.NoPB.Click();
		}

        // public partial class DirectUIHWND1Class : CustomWin
        // {
            //  partial void OnInitialize()
            // {
            // }
        // }

        // public partial class CtrlNotifySink1Class : CustomWin
        // {
            //  partial void OnInitialize()
            // {
            // }
        // }

        // public partial class CtrlNotifySink2Class : CustomWin
        // {
            //  partial void OnInitialize()
            // {
            // }
        // }
    }
}
