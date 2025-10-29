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
    public partial class PandIDProjectsPIDDWGDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[DialogBox]" + AcMainWin.cBabel(21037,2, "Projects - P&ID DWG")+ "|*P*ID*";
		}

        public override void Invoke()
        {
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDPROJECTMANAGERDLG.SetActive();
            Window wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            //PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,4");
            wTreeView.TypeKeys("<Esc><home><Add>");
            //RECT rTree = PandIDPROJECTMANAGERDLG.TreeViewTV.GetRect();
            //if (LAGT.CommonFiles.Product.Variables.Language == "RUS" || LAGT.CommonFiles.Product.Variables.Language == "CHS")
            //{
            //    wTreeView.Click(MouseButton.Right, 5, 85);//Related Files
            //}
            //else
            //{
            //    wTreeView.Click(MouseButton.Right, 5, 85);//Related Files
            //}
            RECT rTree = PandIDPROJECTMANAGERDLG.RelatedFilesTVI.GetRect();
            wTreeView.Click(MouseButton.Right, 5, rTree.yPos+5);//Related Files
            System.Threading.Thread.Sleep(1000);
            wTreeView.TypeKeys("<down 3><Enter>");
            System.Threading.Thread.Sleep(1000);
            PandIDSelectFilesToCopyToProject PandIDSelectFilesToCopyToProject = new PandIDSelectFilesToCopyToProject();
            PandIDSelectFilesToCopyToProject.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\PIDEditBlock.Dwg");
            PandIDSelectFilesToCopyToProject.OpenPB.Click();

        }

		public override void Dismiss()
		{
            this.Close();
		}
    }
}
