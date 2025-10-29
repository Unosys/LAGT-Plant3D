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
    public partial class PlaceProjectInVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = /*"[DialogBox]" + */AcMainWin.cBabel(23165, 6, "Place Project in Vault");
        }

        public override void Invoke()
        {
            ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = new ProjectSetupWizardFinishDLG();
            ProjectSetupWizardFinishDLG.Invoke();
            ProjectSetupWizardFinishDLG.SetActive();
            ProjectSetupWizardFinishDLG.M_buttonFinish.Click();
            System.Threading.Thread.Sleep(15000);
            Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc");
            //Drawing.Current.TypeE("<Esc>");
            //Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("_PLANTPROJECTTOVAULT");
            System.Threading.Thread.Sleep(3000);
            VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            if (VaultLogInDLG.Exists)
            {
                VaultLogInDLG.UserNameTextBox.SetText(Plant3DFunctions.GetLocString("Administrator"));
                VaultLogInDLG.OK.Click();
            }
            System.Threading.Thread.Sleep(15000);

            PlaceProjectInVaultDLG PlaceProjectInVaultDLG = new PlaceProjectInVaultDLG();
            if (!PlaceProjectInVaultDLG.Exists)
            {
                System.Threading.Thread.Sleep(15000);
            }
            PlaceProjectInVaultDLG.SetActive();
        }

        public override void Dismiss()
        {
            PlaceProjectInVaultDLG PlaceProjectInVaultDLG = new PlaceProjectInVaultDLG();
            PlaceProjectInVaultDLG.No.Click();
            Drawing.Current.TypeE("_CLOSE");
            System.Threading.Thread.Sleep(2000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.SetToDefault();
        }
    }
}
