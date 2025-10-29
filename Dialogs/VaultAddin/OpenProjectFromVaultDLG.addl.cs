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
using System.IO;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class OpenProjectFromVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$frmOpenFromVault";
        }

        public override void Invoke()
        {
            if (!File.Exists("C:\\temp\\CreateVaultProject.txt"))
            {
                Plant3DFunctions.CreateVaultProject("TestVault");
                File.Create("C:\\temp\\CreateVaultProject.txt").Close();
            }
            System.Threading.Thread.Sleep(5000);
            VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            if (VaultLogInDLG.Exists)
            {
                VaultLogInDLG.UserNameTextBox.ClearText();
                VaultLogInDLG.UserNameTextBox.SetText(Plant3DFunctions.GetLocString("Administrator"));
                VaultLogInDLG.OK.Click();
            }
            System.Threading.Thread.Sleep(2000);

            Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            //string sText = PROJECTMANAGERDLG.CurrentProjectPL.GetItemText(1);
            //PROJECTMANAGERDLG.CurrentProjectPL.Select(sText);
            try
            {
                //PROJECTMANAGERDLG.CurrentProjectPL.Select(AcMainWin.cBabel(23165, 10, "Open From Vault"));
                PROJECTMANAGERDLG.OpenPB.Click();
                PROJECTMANAGERDLG.OpenPB.TypeKeys("<Home><Down 2><Enter>");
            }
            catch
            {
                //PROJECTMANAGERDLG.OpenPB.Click();
                //PROJECTMANAGERDLG.OpenPB.TypeKeys("<Home><Down 2><Enter>");

            }

            System.Threading.Thread.Sleep(1000);
            if (VaultLogInDLG.Exists)
            {
                VaultLogInDLG.UserNameTextBox.SetText(Plant3DFunctions.GetLocString("Administrator"));
                VaultLogInDLG.OK.Click();

            }
            System.Threading.Thread.Sleep(5000);
            OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
            while (!OpenProjectFromVaultDLG.Exists)
            {
                System.Threading.Thread.Sleep(10000);
            }
            OpenProjectFromVaultDLG.SetActive();

        }
        public override void Dismiss()
        {
            OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
            OpenProjectFromVaultDLG.SetActive();
            OpenProjectFromVaultDLG.ClosePB.Click();
            //Plant3DFunctions.DeleteVaultDrawing("P3D");
            Plant3DFunctions.SetToDefault();
        }
    }
}
