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
    public partial class PandIDRenameFileFormatDWG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$frmRenameDrawing";
		}

		public override void Invoke()
		{
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDPROJECTMANAGERDLG.SetActive();
            PandIDFunctions.CreateDrawing("PANDID", "no");
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("0");
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(2000);
            PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
			if (PandIDWarningAutoCADDLG.Exists)
			{
				PandIDWarningAutoCADDLG.No.Click();
			}
			if (!Drawing.Current.Exists)
			{
				PandID AppWnd = Current<PandID>();
				AppWnd.TypeKeys("<Ctrl-N><Enter>");
			}
			PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
			PandIDProjectSetupProjectDetailsDLG.Invoke();
            PandIDFunctions.treeViewSelect(PandIDProjectSetupProjectDetailsDLG.TreeViewTV, AcMainWin.cBabel(23037, 2, "File Name Format"));
            PandIDProjectSetupProjectDetailsDLG.M_add.Click();
			PandIDProjectSetupProjectDetailsDLG.M_tb_name.SetText("TEST");
			PandIDProjectSetupProjectDetailsDLG.M_btnOk.Click();
			System.Threading.Thread.Sleep(10000);
			Drawing.Current.TypeE("_PROJECTMANAGER");
           
            Window wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            PandIDFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");//5 in list
		}

		public override void Dismiss()
		{
            this.Close();
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("1");
			PandIDFunctions.DeleteDrawing();
			PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
			PandIDProjectSetupProjectDetailsDLG.Invoke();
            PandIDFunctions.treeViewSelect(PandIDProjectSetupProjectDetailsDLG.TreeViewTV, AcMainWin.cBabel(23037, 2, "File Name Format"));
            if (PandIDProjectSetupProjectDetailsDLG.M_bt_delete.Exists)
            {
                PandIDProjectSetupProjectDetailsDLG.M_bt_delete.Click();
            }
			PandIDProjectSetupProjectDetailsDLG.M_btnOk.Click();
			System.Threading.Thread.Sleep(10000);
		}
    }
}
