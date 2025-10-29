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
using System.Threading.Tasks;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDEditAnnotationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$AnnotationDlg";
		}

        public override void Invoke()
        {
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDPROJECTMANAGERDLG.SetActive();
            Window wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1");
            System.Threading.Thread.Sleep(1000);
            PandIDSelectDrawingsToCopyToProDLG PandIDSelectDrawingsToCopyToProDLG = new PandIDSelectDrawingsToCopyToProDLG();
            PandIDSelectDrawingsToCopyToProDLG.SetActive();
            PandIDSelectDrawingsToCopyToProDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\EditAnnotation.dwg");
            PandIDSelectDrawingsToCopyToProDLG.OpenPB.Click();
            PandIDPlant3DProjectSomeFilesDLG PandIDPlant3DProjectSomeFilesDLG = new PandIDPlant3DProjectSomeFilesDLG();
            if (PandIDPlant3DProjectSomeFilesDLG.Exists)
            {
                PandIDPlant3DProjectSomeFilesDLG.SetActive();
                PandIDPlant3DProjectSomeFilesDLG.M_btnOk.Click();
            }
            PandIDProjectDataMergedDLG PandIDProjectDataMergedDLG = new PandIDProjectDataMergedDLG();
            if (PandIDProjectDataMergedDLG.Exists)
            {
                PandIDProjectDataMergedDLG.SetActive();
                PandIDProjectDataMergedDLG.BackupTheDrawingBeforeCK.Uncheck();
                PandIDProjectDataMergedDLG.MigratePB.Click();
                System.Threading.Thread.Sleep(1000);
            }
            Desktop Desktop = new Desktop();
            Desktop.TypeKeys("<Enter>");
            System.Threading.Thread.Sleep(1000);
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            if (ProjectDataMergedDLG.Exists) {
                ProjectDataMergedDLG.BtnOk.Click();
            }
            System.Threading.Thread.Sleep(1000);
            PandIDPROJECTMANAGERDLG.SetActive();
            wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");
            System.Threading.Thread.Sleep(5000);

            Drawing.Current.TypeE("PROJECTMANAGERCLOSE");
            ////////////////////////updated for FY23//
            LoadUnloadApplicationsDLG LoadUnloadApplicationsDLG = new LoadUnloadApplicationsDLG();
            LoadUnloadApplicationsDLG.Reload();
            //////////////////
            Drawing.Current.TypeE("_ai_selall");
            Drawing.Current.TypeE("_EDITANNOTATION");
            this.SetSize();
        }

        public override void Dismiss()
        {
            this.Close();
            Drawing.Current.TypeE("PROJECTMANAGER");
            PandIDFunctions.DeleteDrawing();
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Dismiss();
        }
        public void SetSize()
        {
           RECT r = this.GetRect(true);
            if (r.xSize != 800 && r.ySize != 400)
            {
                this.Click(MouseButton.Right, 10, 10);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + 800, r.yPos + 400);
            }
        }
    }
}
