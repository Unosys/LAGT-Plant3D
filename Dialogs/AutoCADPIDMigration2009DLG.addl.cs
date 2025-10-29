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
    public partial class AutoCADPIDMigration2009DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$frmProjectMigration*";
		}

		public override void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			CmdWnd CmdWnd = new CmdWnd();
			CmdWnd.Click(MouseButton.Left,100,10);
			Drawing.Current.TypeE("Filedia 0");
			string sProjectName = "c:\\PandIDinstall\\PNID\\Project.xml";
			Drawing.Current.TypeE("_OPENPROJECT");
			Drawing.Current.TypeE(sProjectName);
			System.Threading.Thread.Sleep(5000);
		}

		public override void Dismiss()
		{
			AutoCADPIDMigration2009DLG AutoCADPIDMigration2009DLG = new AutoCADPIDMigration2009DLG();
			AutoCADPIDMigration2009DLG.Exit.Click();
			System.Threading.Thread.Sleep(5000);
			Drawing.Current.SetSysVar("Filedia", 1);
		}
    }
}
