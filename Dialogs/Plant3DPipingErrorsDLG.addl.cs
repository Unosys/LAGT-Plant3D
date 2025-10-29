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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DPipingErrorsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$AcPp3dErrorDlg";
		}

		public override void Invoke()
		{
			ProjectSetupWizardDLG ProjectSetupWizardDLG = new ProjectSetupWizardDLG();
			ProjectSetupWizardDLG.Invoke();
            //ProjectSetupWizardDLG.M_wizardSetup.PageWelcome.EnterANameForThisProjectTF.SetText("New_Project"); //Check it manually using addl spy
            //ProjectSetupWizardDLG.M_wizardSetup.PageWelcome.SpecifyTheDirectoryWherePr1.SetText("C:\\temp");
			System.Threading.Thread.Sleep(200);
			ProjectSetupWizardDLG.M_buttonNext.Click();
			ProjectSetupWizardSpecifyUnitSettingsDLG ProjectSetupWizardSpecifyUnitSettingsDLG = new ProjectSetupWizardSpecifyUnitSettingsDLG();
            ProjectSetupWizardSpecifyUnitSettingsDLG.M_buttonNext.Click();
			ProjectSetupWizardSpecifyPIDSettingsDLG ProjectSetupWizardSpecifyPIDSettingsDLG = new ProjectSetupWizardSpecifyPIDSettingsDLG();
            ProjectSetupWizardSpecifyPIDSettingsDLG.M_buttonNext.Click();
			ProjectSetupWizardSpecifyPlant3DDLG ProjectSetupWizardSpecifyPlant3DDLG = new ProjectSetupWizardSpecifyPlant3DDLG();
            ProjectSetupWizardSpecifyPlant3DDLG.M_buttonNext.Click();
			ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
            ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_buttonNext.Click();
			ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = new ProjectSetupWizardFinishDLG();
			ProjectSetupWizardFinishDLG.M_buttonFinish.Click();
			System.Threading.Thread.Sleep(15000);
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.SetActive();
			//window wTreeView = PROJECTMANAGERDLG.PROJECTMANAGER.PROJECTMANAGER.SourceFiles.PrjMgrMainTab.CurrentProject1.SystemWindowsFormsSplitterP1.M_collapsiblePanelTreeView.M_treeView;
			//ExpandTree(wTreeView,3,1,2) //ExpandTree(wTreeView,3,1,2) = new //ExpandTree(wTreeView,3,1,2)();
			//ExpandTree(wTreeView,3,1,2);
			SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
			SelectDrawingsToCopyToProDLG.SetActive();
			SelectDrawingsToCopyToProDLG.FileName.SetText(Path.Combine(Harness.ToolsDir, "Test Files","Plant3D","FFE-5.dwg"));
			SelectDrawingsToCopyToProDLG.Open.Click();
			System.Threading.Thread.Sleep(5000);
			ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
			ProjectDataMergedDLG.SetActive();
			ProjectDataMergedDLG.BtnOk.Click();
			PROJECTMANAGERDLG.SetActive();
			//ExpandTree(wTreeView,1,1,2,1) //ExpandTree(wTreeView,1,1,2,1) = new //ExpandTree(wTreeView,1,1,2,1)();
			//ExpandTree(wTreeView,1,1,2,1);
			System.Threading.Thread.Sleep(2000);
			Drawing.Current.TypeE("_Select");
			Drawing.Current.TypeE("_all");
			Desktop Desktop = new Desktop();
			Desktop.TypeKeys("<Enter>");
			Drawing.Current.TypeE("_Properties");
			System.Threading.Thread.Sleep(1000);
			PropertiesPallete PropertiesPallete = new PropertiesPallete();
			PropertiesPallete.SetActive();
            //ShowManualSteps(Plant3DPipingErrorsDLG);    // manual steps commented
			Plant3DPipingErrorsDLG Plant3DPipingErrorsDLG = new Plant3DPipingErrorsDLG();
			Plant3DPipingErrorsDLG.SetActive();
		}

		public override void Dismiss()
		{
			Plant3DPipingErrorsDLG Plant3DPipingErrorsDLG = new Plant3DPipingErrorsDLG();
			Plant3DPipingErrorsDLG.ClosePB.Click();
			Desktop Desktop = new Desktop();
			Desktop.TypeKeys("<Alt-F4>");
		}
    }
}
