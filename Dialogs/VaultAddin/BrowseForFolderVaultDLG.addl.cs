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
    public partial class BrowseForFolderVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23073, 21, "Browse For Folder")+"|"+ AcMainWin.cBabel(23031, 1,"Browse For Folder");
		}

		public override void Invoke()
		{
            Drawing.Current.TypeE("_PLANTVAULTLOGOUT");
            System.Threading.Thread.Sleep(2000);
            VaultLogOutDLG VaultLogOutDLG = new VaultLogOutDLG();
            if (VaultLogOutDLG.Exists)
            {
                VaultLogOutDLG.ClosePB.Click();
            }
            Drawing.Current.TypeE("_PLANTVAULTLOGIN");
            System.Threading.Thread.Sleep(2000);
            VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            if (VaultLogInDLG.Exists)
            {
                VaultLogInDLG.SetActive();
                VaultLogInDLG.UserNameTextBox.ClearText();
                VaultLogInDLG.UserNameTextBox.SetText("Limited User");
                VaultLogInDLG.OK.Click();
                System.Threading.Thread.Sleep(20000);
            }
            while (VaultLogInDLG.Exists)//(!Drawing.Current.ReadyForNextCommand())
            {
                System.Threading.Thread.Sleep(5000);
            }
            Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            try {
                //PROJECTMANAGERDLG.CurrentProjectPL.Select(AcMainWin.cBabel(23165, 10, "Open From Vault"));
                PROJECTMANAGERDLG.OpenPB.Click();
                PROJECTMANAGERDLG.OpenPB.TypeKeys("<Home><Down 2><Enter>");

            }
            catch
            {
            System.Threading.Thread.Sleep(5000);
            }
            OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
            while (!OpenProjectFromVaultDLG.Exists)
            {
                System.Threading.Thread.Sleep(10000);
            }
           
            OpenProjectFromVaultDLG.ChangePB.Click();

		}

		public override void Dismiss()
		{
           this.CancelPB.Click();
            System.Threading.Thread.Sleep(1000);
            OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
            OpenProjectFromVaultDLG.Cancel.Click();
            Drawing.Current.TypeE("_PLANTVAULTLOGOUT");
            System.Threading.Thread.Sleep(2000);
            VaultLogOutDLG VaultLogOutDLG = new VaultLogOutDLG();
            if (VaultLogOutDLG.Exists)
            {
                VaultLogOutDLG.ClosePB.Click();
            }
            Drawing.Current.TypeE("_PLANTVAULTLOGIN");
            VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            VaultLogInDLG.UserNameTextBox.SetText(Plant3DFunctions.GetLocString("Administrator"));
            VaultLogInDLG.OK.Click();
            System.Threading.Thread.Sleep(8000);

        }

        
    }
}
