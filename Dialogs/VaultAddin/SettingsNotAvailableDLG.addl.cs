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
    public partial class SettingsNotAvailableDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]" + AcMainWin.cBabel(23165, 25, "Settings Not Available");
		}

		public override void Invoke()
		{
            //CheckInDLG CheckInDLG = new CheckInDLG();
            //CheckInDLG.Invoke();
            //CheckInDLG.SetActive();
            //CheckInDLG.OK.Click();
            //ProjectDataMergedVaultDLG ProjectDataMergedVaultDLG = Current<ProjectDataMergedVaultDLG>();
            //ProjectDataMergedVaultDLG.SetActive();
            //ProjectDataMergedVaultDLG.BtnOk.Click();
            //Drawing.Current.TypeE("_PLANTVAULTLOGOUT");
            //VaultLogOutDLG VaultLogOutDLG = Current<VaultLogOutDLG>();
            //VaultLogOutDLG.ClosePB.Click();
            //ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
            //Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //Plant3DFunctions.ExpandTreeP3D(wTreeView, 8,"1, 2, 1");
            //PROJECTMANAGERDLG.TreeViewTV.Click(MouseButton.Right, 29,7);
            //PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<Down 10> <Enter>");
            //System.Threading.Thread.Sleep(5000);
            //SettingsNotAvailableDLG SettingsNotAvailableDLG = Current<SettingsNotAvailableDLG>();
            //SettingsNotAvailableDLG.SetActive();
            Plant3DFunctions.OpenVaultProject("TestVault");
            Drawing.Current.TypeE("_PLANTVAULTLOGOUT");
            VaultLogOutDLG VaultLogOutDLG = new VaultLogOutDLG();
            VaultLogOutDLG.SetActive();
            VaultLogOutDLG.ClosePB.Click();
            Drawing.Current.TypeE("_PROJECTSETUP");
            SettingsNotAvailableDLG SettingsNotAvailableDLG = new SettingsNotAvailableDLG ();
            SettingsNotAvailableDLG.SetActive();


        }

		public override void Dismiss()
		{
            SettingsNotAvailableDLG SettingsNotAvailableDLG = new SettingsNotAvailableDLG();
            SettingsNotAvailableDLG.SetActive();
			SettingsNotAvailableDLG.NoPB.Click();
            Drawing.Current.TypeE("_PLANTVAULTLOGIN");
            VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            VaultLogInDLG.OK.Click();
            System.Threading.Thread.Sleep(3000);
			Plant3DFunctions.SetToDefault();
		}
    }
}
