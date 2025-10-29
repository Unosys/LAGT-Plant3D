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
    public partial class DrawingDoesNotBelongToTheCurrentProject : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23050, 3, "Drawing does Not Belong to the Current Project");
		}

		public override void Invoke()
		{
			Drawing.Current.SetSysVar("SDI", 0);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
			PROJECTMANAGERDLG.Invoke();
			PROJECTMANAGERDLG.SetActive();
            Plant3DFunctions.CreateDrawing("P3D", null, "NewDWG");
            Drawing.Current.TypeE("_Close");
            Desktop.Current.TypeKeys("<Tab><Enter>");
			System.Threading.Thread.Sleep(1000);

            int iCount = 1;
            ProjectSetupWizardDLG ProjectSetupWizardDLG = new ProjectSetupWizardDLG();
            ProjectSetupWizardDLG.Invoke();
            ProjectSetupWizardDLG.SetActive();
            ProjectSetupWizardDLG.M_editName.SetText("NewPrjt" + iCount);
            ProjectSetupWizardDLG.M_editProjDir.SetText("c:\\Temp\\");
            ProjectSetupWizardDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(1000);
            ProjWizError ProjWizError = new ProjWizError();
            while (ProjWizError.Exists)
            {
                ProjWizError.OK.Click();
                iCount++;
                ProjectSetupWizardDLG.M_editName.SetText("NewPrjt" + iCount);
                ProjectSetupWizardDLG.M_buttonNext.Click();
            }
            ProjectSetupWizardSpecifyUnitSettingsDLG ProjectSetupWizardSpecifyUnitSettingsDLG = new ProjectSetupWizardSpecifyUnitSettingsDLG();
            ProjectSetupWizardSpecifyUnitSettingsDLG.SetActive();
            ProjectSetupWizardSpecifyUnitSettingsDLG.M_buttonNext.Click();
            ProjectSetupWizardSpecifyPIDSettingsDLG ProjectSetupWizardSpecifyPIDSettingsDLG = new ProjectSetupWizardSpecifyPIDSettingsDLG();
            ProjectSetupWizardSpecifyPIDSettingsDLG.SetActive();
            ProjectSetupWizardSpecifyPIDSettingsDLG.M_buttonNext.Click();
            ProjectSetupWizardSpecifyPlant3DDLG ProjectSetupWizardSpecifyPlant3DDLG = new ProjectSetupWizardSpecifyPlant3DDLG();
            ProjectSetupWizardSpecifyPlant3DDLG.SetActive();
            ProjectSetupWizardSpecifyPlant3DDLG.M_buttonNext.Click();
            ProjectSetupWizardSpecifyDatabaseSettingsDLG ProjectSetupWizardSpecifyDatabaseSettingsDLG = new ProjectSetupWizardSpecifyDatabaseSettingsDLG();
            ProjectSetupWizardSpecifyDatabaseSettingsDLG.SetActive();
            ProjectSetupWizardSpecifyDatabaseSettingsDLG.M_buttonNext.Click();
            ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = new ProjectSetupWizardFinishDLG();
            ProjectSetupWizardFinishDLG.SetActive();
            ProjectSetupWizardFinishDLG.M_buttonFinish.Click();
            System.Threading.Thread.Sleep(25000);
			SelectFilePIDDLG SelectFilePIDDLG = new SelectFilePIDDLG();
			SelectFilePIDDLG.Invoke();
            string sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\NewDWG.dwg";
            SelectFilePIDDLG.FileName.SetText(sPath);
            //System.Threading.Thread.Sleep(1000);
			SelectFilePIDDLG.Open.Click();
			if (SelectFilePIDDLG.Exists)
			{
				SelectFilePIDDLG.Open.Click();
			}
			System.Threading.Thread.Sleep(1000);
			DrawingDoesNotBelongToTheCurrentProject DrawingDoesNotBelongToTheCurrentProject = new DrawingDoesNotBelongToTheCurrentProject();
			DrawingDoesNotBelongToTheCurrentProject.SetActive();
		}

		public override void Dismiss()
		{
			DrawingDoesNotBelongToTheCurrentProject DrawingDoesNotBelongToTheCurrentProject = new DrawingDoesNotBelongToTheCurrentProject();
			DrawingDoesNotBelongToTheCurrentProject.TypeKeys("<Alt-F4>");
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_Close");
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.SetToDefault();
            Plant3DFunctions.DeleteDrawing("P3D");
        }
    }
}
