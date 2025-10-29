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
using Autodesk.GUIHarness.AutoCAD;
using Microsoft.Win32;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PasswordErrorP3DDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(517,16,"Error");
		}

		public override void Invoke()
		{
			//string sPCName = SYS_GetRegistryValue(HKEY_LOCAL_MACHINE,'SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName','ComputerName')
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Invoke();
			//Agent.SetOption(AgentOptions.OPT_VERIFY_RESPONDING, false);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_radioSQLServer.Click();
			System.Threading.Thread.Sleep(5000);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboAuthent.Select(AcMainWin.cBabel(23042,5,"SQL Server Authentication"));
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_tbUsrName.SetText("User1");
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_buttonNext.Click();
		}

		public override void Dismiss()
		{
			PasswordErrorP3DDLG PasswordErrorP3DDLG = new PasswordErrorP3DDLG();
			PasswordErrorP3DDLG.SetActive();
			PasswordErrorP3DDLG.OK.Click();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Dismiss();
		}
    }
}
