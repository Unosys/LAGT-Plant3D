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
    public partial class PandIDProjectSetupSQLExpressDatabaseSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$EditProjectSettingsDlg";
		}

		public override void Invoke()
		{
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("0");
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG = new PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG();
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.Invoke();
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_radioSQLServer.Click();
			System.Threading.Thread.Sleep(5000);
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboAuthent.Select("#1");
            PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboServer.SetText(Plant3DMainWin.PcName);
			PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_buttonNext.Click();
			PandIDProjectSetupWizardFinishDLG PandIDProjectSetupWizardFinishDLG = new PandIDProjectSetupWizardFinishDLG();
			PandIDProjectSetupWizardFinishDLG.M_buttonFinish.Click();
			System.Threading.Thread.Sleep(20000);
			Drawing.Current.TypeE("_projectsetup");
			System.Threading.Thread.Sleep(10000);
			PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
			PandIDProjectSetupProjectDetailsDLG.SetActive();
            PandIDFunctions.treeViewSelect(PandIDProjectSetupProjectDetailsDLG.TreeViewTV, AcMainWin.cBabel(23043, 1, "Database Setup"));
		}

		public override void Dismiss()
		{
            this.Close();
			Drawing.Current.TypeE("_FILEDIA 0");
			Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(Plant3DMainWin.sDefaultProjPath + "Project.xml");
			System.Threading.Thread.Sleep(10000);
			Drawing.Current.TypeE("_FILEDIA 1");
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("1");
		}
    }
}
