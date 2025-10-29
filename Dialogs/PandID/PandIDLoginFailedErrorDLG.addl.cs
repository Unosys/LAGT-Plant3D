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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDLoginFailedErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]#1";
		}
        public string GetsPCName
        {
            get
            {
                return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", "") as string;
            }
        }

		public override void Invoke()
		{
            PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG = new PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG();
            PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.Invoke();
            PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_radioSQLServer.Click();
            System.Threading.Thread.Sleep(5000);
            string sPCName = GetsPCName;
            PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboServer.SetText(sPCName);
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboAuthent.Select(AcMainWin.cBabel(23042,5,"SQL Server Authentication"));
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_tbUsrName.SetText("User1");
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_tbPwd.SetText("PQR");
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_btnTestConnection.Click();
		}

		public override void Dismiss()
		{
            this.Close();
            PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG = Current<PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG>();
            PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_buttonCancel.Click();
            ProjectSetupWizardPageMSG ProjectSetupWizardPageMSG = new ProjectSetupWizardPageMSG();//related to plant 3d, check manually
            if (ProjectSetupWizardPageMSG.Exists)
            {
                ProjectSetupWizardPageMSG.Yes.Click();
            }
		}
    }
}
