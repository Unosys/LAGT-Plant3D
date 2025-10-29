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
using System.Diagnostics;
using System;
using Microsoft.Win32;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ConnectionSucceededDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23033,2,"Connection Succeeded");
		}

		public string GetsPCName
        {
            get
                {
                    return Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", "")  as string;
                }
        }
        public override void Invoke()
		{
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Invoke();
            //Agent.SetOption(AgentOptions.OPT_VERIFY_RESPONDING, false);
            //Agent.SetOption(AgentOptions.OPT_VERIFY_ACTIVE, false);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_radioSQLServer.Click();
			System.Threading.Thread.Sleep(5000);
			//string sPCName = SYS_GetRegistryValue(HKEY_LOCAL_MACHINE,'SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName','ComputerName');
            string sPCName = GetsPCName;
            ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboServer.TypeKeys("{sPCName}");
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_btnTestConnection.Click();
            //Agent.SetOption(AgentOptions.OPT_VERIFY_RESPONDING, true);
            //Agent.SetOption(AgentOptions.OPT_VERIFY_ACTIVE, true);
            //Agent.SetOption(AgentOptions.OPT_VERIFY_ACTIVE, true);
		}

		public override void Dismiss()
		{
			ConnectionSucceededDLG ConnectionSucceededDLG = new ConnectionSucceededDLG();
			ConnectionSucceededDLG.OK.Click();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Dismiss();
		}
    }
}
