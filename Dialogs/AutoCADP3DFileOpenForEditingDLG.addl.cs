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
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using System.Diagnostics;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class AutoCADP3DFileOpenForEditingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
		}

		public override void Invoke()
		{
			Drawing.Current.SetSysVar("SDI", 0);
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
			//window //wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			////ExpandTreeP3D(wTreeView,1,1,1) //ExpandTreeP3D(wTreeView,1,1,1) = new //ExpandTreeP3D(wTreeView,1,1,1)();
			////ExpandTreeP3D(wTreeView,1,1,1);
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.M_tb_filename.SetText("ABC.dwg");
			NewDWGDLG.BtnOK.Click();
			System.Threading.Thread.Sleep(2000);
			Drawing.Current.TypeE("_close");
			Desktop Desktop = new Desktop();
			Desktop.TypeKeys("<Tab><Enter>");
			System.Threading.Thread.Sleep(1000);
			//ShowManualSteps(AutoCADP3DFileOpenForEditingDLG) ShowManualSteps(AutoCADP3DFileOpenForEditingDLG) = new ShowManualSteps(AutoCADP3DFileOpenForEditingDLG)();
			//ShowManualSteps(AutoCADP3DFileOpenForEditingDLG);
			AutoCADP3DFileOpenForEditingDLG AutoCADP3DFileOpenForEditingDLG = new AutoCADP3DFileOpenForEditingDLG();
			AutoCADP3DFileOpenForEditingDLG.SetActive();
		}

		public override void Dismiss()
		{
			AutoCADP3DFileOpenForEditingDLG AutoCADP3DFileOpenForEditingDLG = new AutoCADP3DFileOpenForEditingDLG();
			AutoCADP3DFileOpenForEditingDLG.OK.Click();
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.BtnCancel.Click();
			//SYS_Execute("Taskkill /F /IM acad SYS_Execute("Taskkill /F /IM acad = new SYS_Execute("Taskkill /F /IM acad();
			//SYS_Execute("Taskkill /F /IM acad.exe");
            Process.Start("taskkill", "/F /IM acad.exe");
		}
    }
}
