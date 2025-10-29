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
    public partial class VaultPro : Plant3DMainWin
    {
        public new const string Name = "Autodesk Vault Professional";
        public static readonly string Path = Product.Variables.ProductLocation;
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[MainWin]Autodesk Vault Professional*|$ExplorerForm";

            this.PropertiesPANE.Tag = this.PropertiesPANE.Tag.Replace("Properties", Plant3DFunctions.GetLocString("Properties"));
            this.SharedViewsPANE.Tag = this.SharedViewsPANE.Tag.Replace("Shared Views", Plant3DFunctions.GetLocString("SharedViews"));

            this.AboutAutodeskVaultProfessionalPB.Tag = this.AboutAutodeskVaultProfessionalPB.Tag.Replace(
                "About Autodesk Vault Professional", Plant3DFunctions.GetLocString("AboutAutodeskVaultProfessional").Replace("&", ""));
        }

        public override void Invoke()
        {
            
        }

        public override void Dismiss()
        {
        }
    }
}
