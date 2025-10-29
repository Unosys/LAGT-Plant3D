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
    public partial class VaultErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[DialogBox]" + AcMainWin.cBabel(23165, 9, "Error");
        }

        public override void Invoke()
        {
            Drawing.Current.TypeE("_PLANTVAULTLOGOUT");
            System.Threading.Thread.Sleep(1000);
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
                VaultLogInDLG.UserNameTextBox.SetText("Limited User");
                VaultLogInDLG.OK.Click();
                System.Threading.Thread.Sleep(10000);
            }
            System.Threading.Thread.Sleep(1000);
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            try
            {
                //PROJECTMANAGERDLG.CurrentProjectPL.Select(AcMainWin.cBabel(23165, 10, "Open From Vault"));
                PROJECTMANAGERDLG.OpenPB.Click();
                PROJECTMANAGERDLG.OpenPB.TypeKeys("<Home><Down 2><Enter>");
            }
            catch
            {
                System.Threading.Thread.Sleep(3000);
            }
            System.Threading.Thread.Sleep(20000);
            OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
            //OpenProjectFromVaultDLG.VaultLocationLV.Select("TestVault");
            OpenProjectFromVaultDLG.TestVaultLBI.Click(MouseButton.Left, 5, 5);
            if (OpenProjectFromVaultDLG.ChangePB.Exists) {
                OpenProjectFromVaultDLG.ChangePB.Click();

            }
            System.Threading.Thread.Sleep(2000);
            BrowseForFolderVaultDLG BrowseForFolderVaultDLG = new BrowseForFolderVaultDLG();
            BrowseForFolderVaultDLG.OpenPB.Click();
            //BrowseForFolderVaultDLG.TypeKeys("<Tab 6><Enter>");
        }

        public override void Dismiss()
        {
            this.OK.Click();
            System.Threading.Thread.Sleep(1000);
            BrowseForFolderVaultDLG BrowseForFolderVaultDLG = new BrowseForFolderVaultDLG();
            BrowseForFolderVaultDLG.Dismiss();
          
        }
    }
        }
