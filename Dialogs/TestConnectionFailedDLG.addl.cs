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
using System;
using Autodesk.GUIHarness.AutoCAD;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class TestConnectionFailedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23033,1,"Test Connection Failed");
		}

		public override void Invoke()
		{
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Invoke();
			//Agent.SetOption(AgentOptions.OPT_VERIFY_ACTIVE, false);
			Boolean _b = CoreSettings.VerifyActive;
			_b = false;
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_radioSQLServer.Click();
			System.Threading.Thread.Sleep(5000);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboServer.SetText("test");
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_btnTestConnection.Click();
			System.Threading.Thread.Sleep(10000);
			int i=2;
            TestConnectionFailedDLG TestConnectionFailedDLG = new TestConnectionFailedDLG();
            while (!TestConnectionFailedDLG.Exists)
            {
                ConnectionSucceededDLG ConnectionSucceededDLG = new ConnectionSucceededDLG();
                if (ConnectionSucceededDLG.Exists)
                {
                    ConnectionSucceededDLG.OK.Click();
                }
                ProjectSetupWizardSpecifyDatabaseSettingsDLG.SetActive();
                ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboServer.Select(i);
                ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_btnTestConnection.Click();
                i++;
            }
			//Agent.SetOption(AgentOptions.OPT_VERIFY_ACTIVE, true);
			_b = true;
		}

		public override void Dismiss()
		{
			TestConnectionFailedDLG TestConnectionFailedDLG = new TestConnectionFailedDLG();
			TestConnectionFailedDLG.OK.Click();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Dismiss();
		}
    }
}
