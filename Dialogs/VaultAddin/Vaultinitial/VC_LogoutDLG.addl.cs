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
    public partial class VC_LogoutDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$LogoutDialog";
        }

		public void Invoke()
		{
            //VC_ConfigurePasswordPolicyDLG VC_ConfigurePasswordPolicyDLG = new VC_ConfigurePasswordPolicyDLG();
            //VC_ConfigurePasswordPolicyDLG.disenablePolicy();
            VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
            VM_ProjectExplorerDLG.Invoke();
            VaultProFunctions.Pick(VM_ProjectExplorerDLG, "file", "logout");
            System.Threading.Thread.Sleep(1500);
		}

		public void Dismiss()
		{
            this.LogInPB.Click();
            VC_LogInDLG VC_LogInDLG = new VC_LogInDLG();
            VC_LogInDLG.Dismiss();
        }

        public void InvokeWithPasswordPolicy()
        {
            VC_ConfigurePasswordPolicyDLG VC_ConfigurePasswordPolicyDLG = new VC_ConfigurePasswordPolicyDLG();
            VC_ConfigurePasswordPolicyDLG.enablePolicy(true, true, true, true, true);

            VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
            VM_ProjectExplorerDLG.Invoke();
            VaultProFunctions.Pick(VM_ProjectExplorerDLG, "file", "logout");
            System.Threading.Thread.Sleep(1500);
        }
    }
}
