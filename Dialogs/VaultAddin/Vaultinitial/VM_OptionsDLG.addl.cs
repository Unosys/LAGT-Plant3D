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
using LAGT.CommonFiles;
using Autodesk.GUIHarness.Plant3D.Dialogs;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class VM_OptionsDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$OptionsForm";
		}

        public void Invoke()
        {
            VaultPro AppWnd = new VaultPro();
            switch (Product.Variables.Language.ToUpper())
            {
                case "HUN":
                    VaultProFunctions.Pick(AppWnd, "tools");
                    Desktop.Current.TypeKeys("<Up 2><Enter>", 250);
                    break;
                default:
                    VaultProFunctions.Pick(AppWnd, "tools", "options");
                    break;
            }
            System.Threading.Thread.Sleep(2000);

            try
            {
                this.Move(5, 5);
            }
            catch
            { }
        }

		public void Dismiss()
		{
			VM_OptionsDLG VM_OptionsDLG = Current<VM_OptionsDLG>();
            VM_OptionsDLG.CancelPB.Click();
		}
    }
}
