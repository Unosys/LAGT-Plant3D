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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectSetupWizardSpecifyDatabaseSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
            Tag = "[Pane]Project Setup Wizard (Page 5 of 6)|$CreateProjectWizard";
		}

		public override void Invoke()
		{
			ProjectSetupWizardSpecifyPlant3DDLG ProjectSetupWizardSpecifyPlant3DDLG = new ProjectSetupWizardSpecifyPlant3DDLG();
			ProjectSetupWizardSpecifyPlant3DDLG.Invoke();
			ProjectSetupWizardSpecifyPlant3DDLG.M_buttonNext.Click();
		}

		public override void Dismiss()
		{
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_buttonCancel.Click();
            //ProjectSetupWizardPageMSG ProjectSetupWizardPageMSG = new ProjectSetupWizardPageMSG();
            //if (ProjectSetupWizardPageMSG.Exists)
            //{
            //    ProjectSetupWizardPageMSG.Yes.Click();
            //}
            DialogBox Message = new DialogBox("[DialogBox]#1");
            if (Message.WaitExists(5000))
            {
                Message.TypeKeys("<Tab><Enter>");
            }
		}
    }
}
