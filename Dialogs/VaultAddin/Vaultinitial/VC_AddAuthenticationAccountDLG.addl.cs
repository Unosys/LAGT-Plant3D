// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2020 by Autodesk, Inc.
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
    public partial class VC_AddAuthenticationAccountDLG : Autodesk.GUIHarness.Pane
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$UserAccountsDialog";

            this.WindowsAuthenticationCK.Tag = this.WindowsAuthenticationCK.Tag.Replace("Windows Authentication", Plant3DFunctions.GetLocString("WindowsAuthentication"));
            this.VaultAccountCK.Tag = this.VaultAccountCK.Tag.Replace("Vault Account", Plant3DFunctions.GetLocString("VaultAccount"));
            this.AutodeskIDCK.Tag = this.AutodeskIDCK.Tag.Replace("Autodesk ID", Plant3DFunctions.GetLocString("AutodeskID"));
        }

        public void Invoke()
        {
            VC_NewUserDLG VC_NewUserDLG = new VC_NewUserDLG();
            VC_NewUserDLG.Invoke();
            VC_NewUserDLG.AccountsPB.Click();
        }

        public void Dismiss()
        {
            this.CancelPB.Click();
            VC_NewUserDLG VC_NewUserDLG = new VC_NewUserDLG();
            VC_NewUserDLG.Dismiss();
        }
    }
}
