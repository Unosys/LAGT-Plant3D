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
    public partial class VC_UserAndGroupManagementDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$AccessManagementDialog";

            this.NewPB.Tag = this.NewPB.Tag.Replace("New", Plant3DFunctions.GetLocString("New").Replace("...", "*"));
        }

        public void Invoke()
        {
            VM_GlobalSettingsDLG VM_GlobalSettingsDLG = new VM_GlobalSettingsDLG();
            VM_GlobalSettingsDLG.Invoke();
            VM_GlobalSettingsDLG.SetActive();
            //VM_GlobalSettingsDLG_pagelist VM_GlobalSettingsDLG_pagelist = new VM_GlobalSettingsDLG_pagelist();
            //VM_GlobalSettingsDLG_pagelist.PageListPG.Select(0);
            VM_GlobalSettingsDLG.ManageAccessPB.Click();
            System.Threading.Thread.Sleep(3000);
            this.SetActive();

            try
            {
                this.Move(10, 10);
            }
            catch
            { }
            this.SetActive();
        }

        public void Dismiss()
        {
            this.ClosePB.Click();
            VM_GlobalSettingsDLG VM_GlobalSettingsDLG = new VM_GlobalSettingsDLG();
            VM_GlobalSettingsDLG.Dismiss();
        }
    }
}
