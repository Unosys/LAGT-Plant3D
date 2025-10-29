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
    public partial class PlaceProjectInVaultMigration3DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
			ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = new ProjectSetupWizardFinishDLG();
			ProjectSetupWizardFinishDLG.Invoke();
			ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG = Current<ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG>();
			ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG.M_buttonNext.Click();
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
			while(!PROJECTMANAGERDLG.Exists);
			System.Threading.Thread.Sleep(5000);
			Plant3DFunctions.CreateVaultDrawing("P3D","no","abc");
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.DoubleClick(MouseButton.Left, 255, 74);
			Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //LIST OF STRING lsContents = wTreeView.GetContents();
            //PROJECTMANAGERDLG.TreeViewTV.Select(lsContents[5]);
			PROJECTMANAGERDLG.TreeViewTV.Click(MouseButton.Right, 75, 80);
			PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<Down 2> <Enter>");
			SelectFilesToLinkToProjecDLG SelectFilesToLinkToProjecDLG = Current<SelectFilesToLinkToProjecDLG>();
			SelectFilesToLinkToProjecDLG.SetActive();
			SelectFilesToLinkToProjecDLG.FileName.SetText("S:\\Test Suites\\GlobalDlgBox\\Plant3D\\Vault_Addin\\DlgBoxMatrix.xls");
			SelectFilesToLinkToProjecDLG.Open.Click();
			Drawing.Current.TypeE("_PLANTPROJECTTOVAULT");
			VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
			if (VaultLogInDLG.Exists)
			{
				VaultLogInDLG.SetActive();
				VaultLogInDLG.UserNameTextBox.SetText("Administrator");
				VaultLogInDLG.OK.Click();
			}
			PlaceProjectInVaultMigration3DLG PlaceProjectInVaultMigration3DLG = Current<PlaceProjectInVaultMigration3DLG>();
			PlaceProjectInVaultMigration3DLG.SetActive();
		}

		public override void Dismiss()
		{
			PlaceProjectInVaultMigration3DLG PlaceProjectInVaultMigration3DLG = Current<PlaceProjectInVaultMigration3DLG>();
			PlaceProjectInVaultMigration3DLG.TypeKeys("<Enter>");
            Plant3DFunctions.SetToDefault();
		}
    }
}
