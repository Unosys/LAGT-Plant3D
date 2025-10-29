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
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectSetupWizardVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			//Tag = "$CreateProjectWizard";
            Tag = "[Pane]$CreateProjectWizard";
		}

		public override void Invoke()
		{
            var r = new Random();
            Drawing.Current.TypeE("_PLANTVAULTLOGOUT");
            System.Threading.Thread.Sleep(5000);
            VaultLogOutDLG VaultLogOutDLG = new VaultLogOutDLG();
            if (VaultLogOutDLG.Exists)
            {
                VaultLogOutDLG.ClosePB.Click();
            }
            int prjn = 1;
            Drawing.Current.TypeE("_Newproject");
			ProjectSetupWizardVaultDLG ProjectSetupWizardVaultDLG = new ProjectSetupWizardVaultDLG();
			//ProjectSetupWizardVaultDLG.M_editName.SetText("a"+r.Next()+"b");
            ProjectSetupWizardVaultDLG.M_editName.SetText("VaultProject"+r.Next() + prjn);
            //ErrorDLG ErrorDLG = new ErrorDLG();
            //if (ErrorDLG.WaitExists(5000))
            //{
            //    ErrorDLG.OK.Click();
            //    prjn++;
            //    //ProjectSetupWizardVaultDLG.M_editName.SetText("a" + r.Next() + "b");
            //    ProjectSetupWizardVaultDLG.M_editName.SetText("Project" + prjn);
            //}
            System.Threading.Thread.Sleep(2000);
            try
            {
			    ProjectSetupWizardVaultDLG.M_checkBoxVaultPrj.Check();
            }
            catch
            {
                ProjectSetupWizardVaultDLG.M_checkBoxVaultPrj.Click();
            }
			VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            VaultLogInDLG.UserNameTextBox.SetText(Plant3DFunctions.GetLocString("Administrator"));
            VaultLogInDLG.OK.Click();
			System.Threading.Thread.Sleep(30000);
            while (!ProjectSetupWizardVaultDLG.M_buttonNext.IsActive)
            {
                System.Threading.Thread.Sleep(15000);
            }
            SelectedSpecCannotbeUsedDLG SelectedSpecCannotbeUsedDLG = new SelectedSpecCannotbeUsedDLG();
			if (SelectedSpecCannotbeUsedDLG.Exists)
			{
				SelectedSpecCannotbeUsedDLG.Close();
			}
		}

		public override void Dismiss()
		{
			ProjectSetupWizardVaultDLG ProjectSetupWizardVaultDLG = new ProjectSetupWizardVaultDLG();
            ProjectSetupWizardVaultDLG.Cancel.Click();
            System.Threading.Thread.Sleep(2000);
            ProjectSetupWizardPageMSG ProjectSetupWizardPageMSG = new ProjectSetupWizardPageMSG();
			if (ProjectSetupWizardPageMSG.WaitExists(3000))
			{
				ProjectSetupWizardPageMSG.Yes.Click();
              
			}
		}
    }
}
