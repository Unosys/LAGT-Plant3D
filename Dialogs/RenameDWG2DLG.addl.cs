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
    public partial class RenameDWG2DLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$frmRenameDrawing";
		}
        public void Invoke()
        {
            Plant3DFunctions.CreateDrawing ("P3D","no","Test");
            Drawing.Current.TypeE("SDI 0");
		    Drawing.Current.TypeE("_PROJECTSETUP");
            System.Threading.Thread.Sleep(10000);
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.SetActive();
            ProjectSetupProjectDetailsDLG.FileNameFormatTVI.Click();
            ProjectSetupProjectDetailsDLG.FNAddPB.Click();
            System.Threading.Thread.Sleep(3000);
            ProjectSetupProjectDetailsDLG.M_tb_name.SetText("TEST");
		    ProjectSetupProjectDetailsDLG.OKPB.Click ();
            Drawing.Current.TypeE("_Close");
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            if (WarningAutoCADDLG.WaitExists(2))
            {
                WarningAutoCADDLG.No.Click();
            }
            Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
		    PROJECTMANAGERDLG.SetActive ();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView,4,"0,2,1");//5 in list
            RenameDWG2DLG RenameDWG2DLG = new RenameDWG2DLG();
            RenameDWG2DLG.SetActive();
        }
		public void Dismiss()
		{
			RenameDWG2DLG RenameDWG2DLG = new RenameDWG2DLG();
			RenameDWG2DLG.SetActive();
			RenameDWG2DLG.BtnCancel.Click();
            Drawing.Current.TypeE("SDI 0");
            Drawing.Current.TypeE("_PROJECTSETUP");
            System.Threading.Thread.Sleep(5000);
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.SetActive();
            ProjectSetupProjectDetailsDLG.FileNameFormatTVI.Click();
            ProjectSetupProjectDetailsDLG.FNDeletePB.Click();
            ProjectSetupProjectDetailsDLG.OKPB.Click();
            Plant3DFunctions.DeleteAllDrawings();
		}
    }
}
