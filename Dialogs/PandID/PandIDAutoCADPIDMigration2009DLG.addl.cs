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
    public partial class PandIDAutoCADPIDMigration2009DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$frmProjectMigration1|[Pane]$frmProjectMigration3|[Pane]$frmProjectMigration4";
		}

		public void Invoke()
		{
			PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
			PandIDPROJECTMANAGERDLG.Invoke();
			CmdWnd CmdWnd = Current<CmdWnd>();
			CmdWnd.Click(MouseButton.Left,100,10);
			Drawing.Current.TypeE("Filedia 0");
            string sProjectName = LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\NetworkPath\\Project.xml";
			Drawing.Current.TypeE("_OPENPROJECT");
			Drawing.Current.TypeE(sProjectName);
		}

		public void Dismiss()
		{
            this.CancelPB.Click();
            //System.Threading.Thread.Sleep(1000);
            //Desktop.Current.TypeKeys("<Enter>");
            //PandIDProjectMigrationCannotContinueDLG PandIDProjectMigrationCannotContinueDLG = new PandIDProjectMigrationCannotContinueDLG();
            //PandIDProjectMigrationCannotContinueDLG.Close();
            MigrationCancelTaskDLG MigrationCancelTaskDLG = new MigrationCancelTaskDLG();
            if (MigrationCancelTaskDLG.Exists)
            {
                MigrationCancelTaskDLG.Dismiss();
                System.Threading.Thread.Sleep(10000);
            }
           
            Drawing.Current.SetSysVar("Filedia", 1);
		}
    }
}
