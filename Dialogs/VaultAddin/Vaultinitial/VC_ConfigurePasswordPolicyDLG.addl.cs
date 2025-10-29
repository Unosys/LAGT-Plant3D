// (C) Copyright 2023 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;

using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class VC_ConfigurePasswordPolicyDLG : Pane
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$ConfigurePasswordPolicyForm";
        }

        public void Invoke()
        {
            VM_GlobalSettingsDLG VM_GlobalSettingsDLG = new VM_GlobalSettingsDLG();
            VM_GlobalSettingsDLG.Invoke();
            VM_GlobalSettingsDLG_pagelist VM_GlobalSettingsDLG_pagelist = new VM_GlobalSettingsDLG_pagelist();
            VM_GlobalSettingsDLG_pagelist.PageListPG.Select(0);
            VM_GlobalSettingsDLG.EnforcePasswordPolicyCK.Check();
            VM_GlobalSettingsDLG.ConfigurePB_Password.Click();
            this.SetActive();
            System.Threading.Thread.Sleep(2000);
        }

        public void Dismiss()
        {
            this.CancelPB.Click();
            VM_GlobalSettingsDLG VM_GlobalSettingsDLG = new VM_GlobalSettingsDLG();
            VM_GlobalSettingsDLG.EnforcePasswordPolicyCK.Uncheck();
            VM_GlobalSettingsDLG.Dismiss();
        }

        public void enablePolicy(bool min, bool lowercase, bool uppercase, bool number, bool special)
        {
            string disenablePolicy = VaultProFunctions.tempFolder + "disenablePolicy.txt";
            if (File.Exists(disenablePolicy))
            {
                File.Delete(disenablePolicy);
            }

            VC_ConfigurePasswordPolicyDLG VC_ConfigurePasswordPolicyDLG = new VC_ConfigurePasswordPolicyDLG();
            VC_ConfigurePasswordPolicyDLG.Invoke();
            //set minimum length
            if (min)
            {
                VC_ConfigurePasswordPolicyDLG.MinimumPasswordLengthCK.Check();
                VC_ConfigurePasswordPolicyDLG.SpinWIN.Click(MouseButton.Left, 10, 10);
                VC_ConfigurePasswordPolicyDLG.SpinWIN.TypeKeys("<Ctrl-A><Delete 3>8", 250);
            }
            else
            {
                VC_ConfigurePasswordPolicyDLG.MinimumPasswordLengthCK.Uncheck();
            }
            //set lowercase
            if (lowercase)
            {
                VC_ConfigurePasswordPolicyDLG.LowercaseCharactersCK.Check();
            }
            else
            {
                VC_ConfigurePasswordPolicyDLG.LowercaseCharactersCK.Uncheck();
            }
            //set uppercase
            if (uppercase)
            {
                VC_ConfigurePasswordPolicyDLG.UppercaseCharactersCK.Check();
            }
            else
            {
                VC_ConfigurePasswordPolicyDLG.UppercaseCharactersCK.Uncheck();
            }
            //set number
            if (number)
            {
                VC_ConfigurePasswordPolicyDLG.NumbersCK.Check();
            }
            else
            {
                VC_ConfigurePasswordPolicyDLG.NumbersCK.Uncheck();
            }
            //set special characters
            if (special)
            {
                VC_ConfigurePasswordPolicyDLG.SpecialCharactersCK.Check();
            }
            else
            {
                VC_ConfigurePasswordPolicyDLG.SpecialCharactersCK.Uncheck();
            }
            VC_ConfigurePasswordPolicyDLG.OKPB.Click();
            VM_GlobalSettingsDLG VM_GlobalSettingsDLG = new VM_GlobalSettingsDLG();
            VM_GlobalSettingsDLG.ClosePB.Click();
        }

        public void disenablePolicy(bool restartVaultPro = true)
        {
            string disenablePolicy = VaultProFunctions.tempFolder + "disenablePolicy.txt";
            if (!File.Exists(disenablePolicy))
            {
                VM_GlobalSettingsDLG VM_GlobalSettingsDLG = new VM_GlobalSettingsDLG();
                VM_GlobalSettingsDLG.Invoke();
                VM_GlobalSettingsDLG_pagelist VM_GlobalSettingsDLG_pagelist = new VM_GlobalSettingsDLG_pagelist();
                VM_GlobalSettingsDLG_pagelist.PageListPG.Select(0);
                VM_GlobalSettingsDLG.EnforcePasswordPolicyCK.Uncheck();
                VM_GlobalSettingsDLG.ClosePB.Click();
                if (restartVaultPro)
                {
                    VaultPro VaultPro = new VaultPro();
                    VaultPro.Restart();
                }
            }
            File.Create(disenablePolicy).Close();
        }
    }
}
