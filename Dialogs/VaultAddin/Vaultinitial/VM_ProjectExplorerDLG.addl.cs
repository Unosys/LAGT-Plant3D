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
    public partial class VM_ProjectExplorerDLG : Plant3DMainWin
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[MainWin]Autodesk Vault Professional*|$ExplorerForm";

		}

		public override void Invoke()
		{
            VaultPro VaultPro = new VaultPro();
            if (!VaultPro.Exists)
            {
                VaultPro.VaultInitialize();
            }

            string vaultAndUser = VaultProFunctions.treeViewUAndD();
            switch (Product.Variables.ProductName)
            {
                case "VaultAddins":
                    vaultAndUser = "Vault - " + VaultProFunctions.GetAdministratorLocal();
                    break;
            }
            
            VaultPro.TreeViewTV.Expand(vaultAndUser);
            if (VaultPro.TreeViewTV.SelectedText != Plant3DFunctions.GetLocString("ProjectExplorer"))
            {
                VaultPro.TreeViewTV.Select(vaultAndUser + "/" + Plant3DFunctions.GetLocString("ProjectExplorer"));
                System.Threading.Thread.Sleep(2000);
                VaultPro.TreeViewTV.TypeKeys("<Down>");
                System.Threading.Thread.Sleep(2000);
                VM_AfterDeleteCustomObjectMSG VM_AfterDeleteCustomObjectMSG = new VM_AfterDeleteCustomObjectMSG();
                if (VM_AfterDeleteCustomObjectMSG.Exists)
                {
                    VM_AfterDeleteCustomObjectMSG.OKPB.Click();
                    System.Threading.Thread.Sleep(2000);
                }
                VaultPro.TreeViewTV.TypeKeys("<Up>");
                System.Threading.Thread.Sleep(2000);
            }
            this.FileListPANE.TypeKeys("<F5>");
            System.Threading.Thread.Sleep(12000);
         
        }

		public override void Dismiss()
		{
		}
    }
}
