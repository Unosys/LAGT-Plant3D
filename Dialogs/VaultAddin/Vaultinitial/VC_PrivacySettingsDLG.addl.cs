// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2021 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;

using LAGT.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class VC_PrivacySettingsDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[DialogBox]" + Plant3DFunctions.GetLocString("PrivacySettingsDLG");
        }

        public override void Invoke()
        {

            VaultPro VaultPro = new VaultPro();
            switch (Product.Variables.Language.ToUpper())
            {
                case "CSY":
                case "ITA":
                    VaultProFunctions.Pick(VaultPro, "actions");
                    System.Threading.Thread.Sleep(1000);
                    Desktop.Current.TypeKeys("<Right><Up 2><Enter>");
                    break;   
                default:
                    VaultProFunctions.Pick(VaultPro, "help");
                    Desktop.Current.TypeKeys("<Up 2><Enter>");
                    break;
            }
            System.Threading.Thread.Sleep(3000);
        }

        public override void Dismiss()
        {
            this.OKPB.Click();
        }
    }
}
