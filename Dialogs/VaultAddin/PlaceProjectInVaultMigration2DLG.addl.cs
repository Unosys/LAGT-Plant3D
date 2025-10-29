// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PlaceProjectInVaultMigration2DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
		}

		public override void Invoke()
		{
			ProjectSetupWizardDLG ProjectSetupWizardDLG = new ProjectSetupWizardDLG();
			ProjectSetupWizardDLG.Invoke();
			ProjectSetupWizardDLG.M_editName.SetText("Project2013_Limit_user");
			ProjectSetupWizardDLG.M_buttonNext.Click();
			ProjectSetupWizardSpecifyUnitSettingsDLG ProjectSetupWizardSpecifyUnitSettingsDLG = Current<ProjectSetupWizardSpecifyUnitSettingsDLG>();
			ProjectSetupWizardSpecifyUnitSettingsDLG.M_buttonNext.Click();
			ProjectSetupWizardSpecifyPIDSettingsDLG ProjectSetupWizardSpecifyPIDSettingsDLG = Current<ProjectSetupWizardSpecifyPIDSettingsDLG>();
			ProjectSetupWizardSpecifyPIDSettingsDLG.M_buttonNext.Click();
			ProjectSetupWizardSpecifyPlant3DDLG ProjectSetupWizardSpecifyPlant3DDLG = Current<ProjectSetupWizardSpecifyPlant3DDLG>();
			ProjectSetupWizardSpecifyPlant3DDLG.M_buttonNext.Click();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = Current<ProjectSetupWizardSpecifyDatabaseSettingsDLG>();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_buttonNext.Click();
			ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = Current<ProjectSetupWizardFinishDLG>();
			ProjectSetupWizardFinishDLG.M_buttonFinish.Click();
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
			while(!PROJECTMANAGERDLG.Exists);
            {
                System.Threading.Thread.Sleep(5000);
            }
			
            Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc");
			Drawing.Current.TypeE("_PLANTPROJECTTOVAULT");
			VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
			if (VaultLogInDLG.Exists)
			{
				VaultLogInDLG.SetActive();
				VaultLogInDLG.UserNameTextBox.SetText("Administrator");
				VaultLogInDLG.OK.Click();
			}
			PlaceProjectInVaultMigration2DLG PlaceProjectInVaultMigration2DLG = Current<PlaceProjectInVaultMigration2DLG>();
			PlaceProjectInVaultMigration2DLG.SetActive();
		}

		public override void Dismiss()
		{
			PlaceProjectInVaultMigration2DLG PlaceProjectInVaultMigration2DLG = Current<PlaceProjectInVaultMigration2DLG>();
			PlaceProjectInVaultMigration2DLG.Yes.Click();
			Plant3DFunctions.SetToDefault();
		}
    }
}
