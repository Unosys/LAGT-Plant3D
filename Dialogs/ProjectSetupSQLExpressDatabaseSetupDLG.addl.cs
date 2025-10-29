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
using Microsoft.Win32;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectSetupSQLExpressDatabaseSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$EditProjectSettingsDlg";
		}

		public override void Invoke()
		{
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("0");
            string sPCName = Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", "") as string;
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.Invoke();
            //Agent.SetOption(AgentOptions.OPT_VERIFY_RESPONDING, false);
            //Agent.SetOption(AgentOptions.OPT_VERIFY_ACTIVE, false);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_radioSQLServer.Click();
			System.Threading.Thread.Sleep(5000);
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboAuthent.Select("#1");
			ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_buttonNext.Click();
			ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = new ProjectSetupWizardFinishDLG();
			ProjectSetupWizardFinishDLG.M_buttonFinish.Click();
			System.Threading.Thread.Sleep(20000);
			Drawing.Current.TypeE("_projectsetup");
			System.Threading.Thread.Sleep(10000);
			ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
			ProjectSetupProjectDetailsDLG.SetActive();
			ProjectSetupProjectDetailsDLG.M_treeView.Select("*/"+AcMainWin.cBabel(23043,1,"Database Setup"));
            //Agent.SetOption(AgentOptions.OPT_VERIFY_RESPONDING, true);
            //Agent.SetOption(AgentOptions.OPT_VERIFY_ACTIVE, true);
		}

		public override void Dismiss()
		{
			this.CancelPB.Click();
            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new Plant3DMainWin().AcadRoot + "\\" + new Plant3DMainWin().AcadNumber, "DefaultProject", "") as string;
            string sProjectName = sProjectPath + "Project.xml";
			Drawing.Current.TypeE("_FILEDIA 0");
			Drawing.Current.TypeE("_openproject");
			Drawing.Current.TypeE(sProjectName);
			System.Threading.Thread.Sleep(10000);
			Drawing.Current.TypeE("_FILEDIA 1");
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("1");
		}
    }
}
