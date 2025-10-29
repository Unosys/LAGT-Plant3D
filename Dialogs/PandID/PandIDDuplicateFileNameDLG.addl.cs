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
    public partial class PandIDDuplicateFileNameDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23037,1,"Duplicate File Name");
		}

		public override void Invoke()
		{
			Drawing.Current.TypeE("_PROJECTMANAGER");
			PandIDFunctions.CreateDrawing("PandID","no","Sample1");
			Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(2000);
            PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
			if (PandIDWarningAutoCADDLG.Exists)
			{
				PandIDWarningAutoCADDLG.No.Click();
			}
			PandIDFunctions.CreateDrawing("PandID","no","Sample2");
            System.Threading.Thread.Sleep(2000);
            DrawingChecker DrawingChecker = new DrawingChecker();
            if (DrawingChecker.Exists) {
                DrawingChecker.CancelPB.Click();
            }

            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(2000);
            if (PandIDWarningAutoCADDLG.Exists)
			{
				PandIDWarningAutoCADDLG.No.Click();
			}
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.SetActive();
            Window wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            PandIDFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");//5 in list
			PandIDRenameDWGDLG PandIDRenameDWGDLG = new PandIDRenameDWGDLG();
			PandIDRenameDWGDLG.SetActive();
			PandIDRenameDWGDLG.M_tb_filename.SetText("Sample2.dwg");
			PandIDRenameDWGDLG.BtnOK.Click();
		}

		public override void Dismiss()
		{
			PandIDDuplicateFileNameDLG PandIDDuplicateFileNameDLG =new PandIDDuplicateFileNameDLG();
			PandIDDuplicateFileNameDLG.SetActive();
			PandIDDuplicateFileNameDLG.NoPB.Click();
            PandIDFunctions.DeleteDrawing();
            PandIDFunctions.DeleteDrawing();
		}
    }
}
