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
    public partial class MigrationCancelTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "~ActiveApp/[DialogBox]" + AcMainWin.cBabel(14,101,"Cancel");
		}

		public override void Invoke()
		{
			//STRING sProductInstalledPath, sTemp,sProjectName STRING sProductInstalledPath, sTemp,sProjectName = new STRING sProductInstalledPath, sTemp,sProjectName();
			string sProductInstalledPath, sTemp,sProjectName;
			sProjectName = "S:\\Test Files\\Plant3D\\Project 1\\Project.xml";
			Drawing.Current.SetSysVar("Filedia", 0);
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			Drawing.Current.TypeE("OPENPROJECT");
			Drawing.Current.TypeE(sProjectName);
			System.Threading.Thread.Sleep(15000);
			AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
			if (AutoCADPlant3DMigrationDLG.Exists)
			{
				AutoCADPlant3DMigrationDLG.SetActive();
				AutoCADPlant3DMigrationDLG.BtnCancel.Click();
			}
		}

		public override void Dismiss()
		{
			MigrationCancelTaskDLG MigrationCancelTaskDLG = new MigrationCancelTaskDLG();
			MigrationCancelTaskDLG.SetActive();
			MigrationCancelTaskDLG.TypeKeys("<Enter>");
		}
    }
}
