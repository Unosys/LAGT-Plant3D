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
using Autodesk.GUIHarness.Plant3D.Dialogs;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class VM_GlobalSettingsDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$AdminToolForm";

             
        }

        public override void Invoke()
		{
            VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
            VM_ProjectExplorerDLG.Invoke();

            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "ITA":
                case "ESP":
                    VaultProFunctions.Pick(VM_ProjectExplorerDLG, "tools", "administration");
                    Desktop.Current.TypeKeys("<Down><Enter>");
                    break;
                default:
                    VaultProFunctions.Pick(VM_ProjectExplorerDLG, "tools", "administration", "globalsettings");
                    break;
            }
            try 
            {
                this.Move(0,0);
            }
            catch
            { 
            }
            System.Threading.Thread.Sleep(2000);
		}

		public override void Dismiss()
		{
            this.ClosePB.Click();
		}
    }
}
