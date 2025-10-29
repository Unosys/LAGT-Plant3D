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
    public partial class VC_AddRolesDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$UserRolesDialog";

            this.AdministratorCK.Tag = this.AdministratorCK.Tag.Replace("Administrator", VaultProFunctions.GetAdministratorLocal());
            //this.ProjectAdministratorCK.Tag = this.ProjectAdministratorCK.Tag.Replace("Project Administrator", VaultProFunctions.GetLocString("ProjectAdministrator"));
            //this.SecurityAdministratorCK.Tag = this.SecurityAdministratorCK.Tag.Replace("Security Administrator", VaultProFunctions.GetLocString("SecurityAdministrator"));
            //this.ItemReviewerCK.Tag = this.ItemReviewerCK.Tag.Replace("Item Reviewer", VaultProFunctions.GetLocString("ItemReviewer"));
            this.ProjectAdministratorCK.Tag = this.ProjectAdministratorCK.Tag.Replace("Project Administrator", Plant3DMainWin.cBabel(40, 1, "Project Administrator"));
            switch(LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "CHT":
                    this.SecurityAdministratorCK.Tag = this.SecurityAdministratorCK.Tag.Replace("Security Administrator", VaultProFunctions.GetLocString("SecurityAdministrator"));
                    break;
                default:
                    this.SecurityAdministratorCK.Tag = this.SecurityAdministratorCK.Tag.Replace("Security Administrator", Plant3DMainWin.cBabel(40, 2, "Security Administrator"));
                    break;
            }
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "PTB":
                    this.ItemReviewerCK.Tag = this.ItemReviewerCK.Tag.Replace("Item Reviewer", VaultProFunctions.GetLocString("ItemReviewer"));
                    break;
                default:
                    this.ItemReviewerCK.Tag = this.ItemReviewerCK.Tag.Replace("Item Reviewer", Plant3DMainWin.cBabel(40, 3, "Item Reviewer"));
                    break;
            }
        }

        public void Invoke()
		{
			VC_NewUserDLG VC_NewUserDLG = new VC_NewUserDLG();
			VC_NewUserDLG.Invoke();
            VC_NewUserDLG.RolesPB.Click();
		}

		public void Dismiss()
		{
			VC_AddRolesDLG VC_AddRolesDLG = Current<VC_AddRolesDLG>();
			VC_AddRolesDLG.CancelPB.Click();
			VC_NewUserDLG VC_NewUserDLG = new VC_NewUserDLG();
			VC_NewUserDLG.Dismiss();
		}
    }
}
