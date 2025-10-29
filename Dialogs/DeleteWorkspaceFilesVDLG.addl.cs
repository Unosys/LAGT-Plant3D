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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class DeleteWorkspaceFilesVDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            //Tag = "[DialogBox]" + Plant3DMainWin.cBabel(xxx, x, "Delete Workspace Files");
        }

        public override void Invoke()
        {
            Plant3DFunctions.CreateNewVaultProject();
            Plant3DMainWin Plant3DMainWin = new Plant3DMainWin();
            Plant3DMainWin.SetActive();
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            Plant3DFunctions.CreateDrawing("P3D",null,null,null);
            System.Threading.Thread.Sleep(2000);
            //project - vault - delete workspace files
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DMainWin.SetActive();
            PROJECTMANAGERDLG.SetActive();
            wTreeView.Click(MouseButton.Right, 1, 1); //set active
            wTreeView.TypeKeys("<Esc><home>");
            RECT rTree = wTreeView.GetRect();
            wTreeView.Click(MouseButton.Right, 5, rTree.ySize - 20);
            System.Threading.Thread.Sleep(1000);
            wTreeView.TypeKeys("<down 3><right><down 4>");
            wTreeView.TypeKeys("<enter>");
            System.Threading.Thread.Sleep(1000);
        }

        public override void Dismiss()
        {
            DeleteWorkspaceFilesVDLG DeleteWorkspaceFilesVDLG = new DeleteWorkspaceFilesVDLG();
            DeleteWorkspaceFilesVDLG.SetActive();
            DeleteWorkspaceFilesVDLG.CancelPB.Click();
        }
    }
}
