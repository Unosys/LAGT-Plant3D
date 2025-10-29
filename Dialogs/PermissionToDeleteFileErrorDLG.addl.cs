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
using Microsoft.Win32;
using System.Diagnostics;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PermissionToDeleteFileErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$MessageForm";
		}

		public override void Invoke()
		{
			//string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new Plant3DMainWin().AcadRoot + "\\" + new Plant3DMainWin().AcadNumber, "DefaultProject", "") as string;
            string sProjectPath = Plant3DMainWin.sDefaultProjPath;
            string sFilePath = sProjectPath + "ReportCreator\\ReportFiles\\Drawinglist.rcf";
			ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
			ReportCreatorDLG.Invoke();
			ReportCreatorDLG.M_projectCmbBox.TypeKeys("<F4><Down 2><Enter>");
			System.Threading.Thread.Sleep(5000);
			ReportCreatorDLG.M_repConfigCmbBox.TypeKeys("<F4><Down 3><Enter>");
			//Sys_Execute("Attrib +R {chr(34)}{sFilePath}{chr(34)}") Sys_Execute("Attrib +R {chr(34)}{sFilePath}{chr(34)}") = new Sys_Execute("Attrib +R {chr(34)}{sFilePath}{chr(34)}")();
		//	Process.Start("Attrib +R " + sFilePath);
            //ShowManualSteps(PermissionToDeleteFileErrorDLG) ShowManualSteps(PermissionToDeleteFileErrorDLG) = new ShowManualSteps(PermissionToDeleteFileErrorDLG)();
            //ShowManualSteps(PermissionToDeleteFileErrorDLG);
			ReportCreatorDLG.SetActive();
			ReportCreatorDLG.M_repConfigEditBtn.Click();
			ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();
			ReportConfigurationDLG.SetActive();
            ReportConfigurationDLG.M_oneReportDwgRadioBtn.Select();
            ReportConfigurationDLG.M_oneReportRadioBtn.Select();
            ReportConfigurationDLG.M_oneReportDwgRadioBtn.Select();
			ReportConfigurationDLG.M_deleteBtn.Click();
			ReportCreatorConfirmDeleteDLG ReportCreatorConfirmDeleteDLG = new ReportCreatorConfirmDeleteDLG();
			ReportCreatorConfirmDeleteDLG.SetActive();
			ReportCreatorConfirmDeleteDLG.M_yesBtn.Click();
			PermissionToDeleteFileErrorDLG PermissionToDeleteFileErrorDLG = new PermissionToDeleteFileErrorDLG();
			PermissionToDeleteFileErrorDLG.SetActive();
		}

		public override void Dismiss()
		{
			PermissionToDeleteFileErrorDLG PermissionToDeleteFileErrorDLG = new PermissionToDeleteFileErrorDLG();
			PermissionToDeleteFileErrorDLG.M_okBtn.Click();
            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new Plant3DMainWin().AcadRoot + "\\" + new Plant3DMainWin().AcadNumber, "DefaultProject", "") as string;
            string sFilePath = sProjectPath + "ReportCreator\\ReportFiles\\3D Parts.rcf";
			//Sys_Execute("Attrib -R {chr(34)}{sFilePath}{chr(34)}") Sys_Execute("Attrib -R {chr(34)}{sFilePath}{chr(34)}") = new Sys_Execute("Attrib -R {chr(34)}{sFilePath}{chr(34)}")();
			Process.Start("Attrib -R " + sFilePath);
			ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();
			ReportConfigurationDLG.Dismiss();
		}
    }
}
