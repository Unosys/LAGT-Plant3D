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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SelectVaultLocationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$SelectEntityFromVaultDialog";
        }


        public override void Invoke()
        {
            ProjectSetupWizardVaultDLG ProjectSetupWizardVaultDLG = new ProjectSetupWizardVaultDLG();
            ProjectSetupWizardVaultDLG.Invoke();
            System.Threading.Thread.Sleep(6000);
            if (ProjectSetupWizardVaultDLG.PushButton1PB.IsEnabled)
            {
                ProjectSetupWizardVaultDLG.PushButton1PB.Click();
            }
            System.Threading.Thread.Sleep(6000);

        }
        public override void Dismiss()
        {
            this.ClosePB.Click();
            System.Threading.Thread.Sleep(2000);
            ProjectSetupWizardVaultDLG ProjectSetupWizardVaultDLG = new ProjectSetupWizardVaultDLG();
            ProjectSetupWizardVaultDLG.Dismiss();
        }

    }
}
