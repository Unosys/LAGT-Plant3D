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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDAutoCADPIDMigrationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$frmDrawingMigration1";
		}

		public override void Invoke()
		{
			PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
			PandIDPROJECTMANAGERDLG.Invoke();
            //PandIDFunctions.CreateDrawing();
            PandIDPROJECTMANAGERDLG.SetActive();
			//PandIDPROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            //window wTreeView = PandIDPROJECTMANAGERDLG.M_treeView //use TreeView expand method...
            //ExpandTreePID(wTreeView,3,1,1);
            PandIDProjManUndocked pROJECTMANAGERDLG = new PandIDProjManUndocked();
            Window wTreeView = pROJECTMANAGERDLG.TreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1");
			PandIDSelectDrawingsToCopyToProDLG PandIDSelectDrawingsToCopyToProDLG = new PandIDSelectDrawingsToCopyToProDLG();
			PandIDSelectDrawingsToCopyToProDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir+ "PandID\\PIDEditBlock.dwg");
			PandIDSelectDrawingsToCopyToProDLG.OpenPB.Click();
		}

		public override void Dismiss()
		{
			PandIDAutoCADPIDMigrationDLG PandIDAutoCADPIDMigrationDLG = new PandIDAutoCADPIDMigrationDLG();
			PandIDAutoCADPIDMigrationDLG.SetActive();
			PandIDAutoCADPIDMigrationDLG.BtnCancel.Click();
			PandIDMigrationCancelTaskDLG PandIDMigrationCancelTaskDLG = new PandIDMigrationCancelTaskDLG();
			PandIDMigrationCancelTaskDLG.SetActive();
			PandIDMigrationCancelTaskDLG.Dismiss();
		}
    }
}
