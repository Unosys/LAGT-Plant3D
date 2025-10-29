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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDProjectDataMergedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
			//PandIDPROJECTMANAGERDLG.Exists;
			PandIDPROJECTMANAGERDLG.SetActive();
			TreeView wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;
            //FunctionsPID FunctionsPID = new FunctionsPID();
            PandIDFunctions.ExpandTreeP3D(wTreeView,3,"1,2");
			PandIDSelectDrawingsToCopyToProDLG PandIDSelectDrawingsToCopyToProDLG = Current<PandIDSelectDrawingsToCopyToProDLG>();
			PandIDSelectDrawingsToCopyToProDLG.SetActive();
			PandIDSelectDrawingsToCopyToProDLG.FileNameCB.SetText(Path.Combine(Harness.ToolsDir, "Test Files","PandID","SampleDrawing.dwg"));
			PandIDSelectDrawingsToCopyToProDLG.OpenPB.Click();
			//this.Exists;
            //PandIDPlant3DProjectSomeFilesDLG PandIDPlant3DProjectSomeFilesDLG = new PandIDPlant3DProjectSomeFilesDLG(); //related to plant 3d, check manually
            //if (PandIDPlant3DProjectSomeFilesDLG.Exists)
            //{
            //    PandIDPlant3DProjectSomeFilesDLG.SetActive();
            //    PandIDPlant3DProjectSomeFilesDLG.M_btnOk.Click();
            //}
		}

		public override void Dismiss()
		{
			PandIDProjectDataMergedDLG PandIDProjectDataMergedDLG = Current<PandIDProjectDataMergedDLG>();
			PandIDProjectDataMergedDLG.SetActive();
			PandIDProjectDataMergedDLG.MigratePB.Click();
            //FunctionsPID FunctionsPID = new FunctionsPID();
            PandIDFunctions.DeleteDrawing("P3D");
		}
    }
}
