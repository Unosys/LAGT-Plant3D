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
    public partial class LoginFailedErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23070,5,"Project Setup Wizard(Page 5 of 6)");
		}

		public override void Invoke()
		{
			//string sPCName = SYS_GetRegistryValue(HKEY_LOCAL_MACHINE,'SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName','ComputerName')
			//print(sPCName) print(sPCName) = new print(sPCName)();
			//print(sPCName);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Invoke();
			//Agent.SetOption(AgentOptions.OPT_VERIFY_RESPONDING, false);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_radioSQLServer.Click();
			System.Threading.Thread.Sleep(5000);
			System.Threading.Thread.Sleep(1000);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboAuthent.Select(AcMainWin.cBabel(23042,5,"SQL Server Authentication"));
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_tbUsrName.SetText("User1");
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_tbPwd.SetText("PQR");
			//print(1) print(1) = new print(1)();
			//print(1);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_btnTestConnection.Click();
			//Agent.SetOption(AgentOptions.OPT_VERIFY_RESPONDING, true);
			System.Threading.Thread.Sleep(2000);
		}

		public override void Dismiss()
		{
			LoginFailedErrorDLG LoginFailedErrorDLG = new LoginFailedErrorDLG();
			LoginFailedErrorDLG.SetActive();
			LoginFailedErrorDLG.OK.Click();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Dismiss();
		}
    }
}
