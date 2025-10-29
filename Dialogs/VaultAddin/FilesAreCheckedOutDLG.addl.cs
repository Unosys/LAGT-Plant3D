// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
    public partial class FilesAreCheckedOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]" + AcMainWin.cBabel(23165, 4, "Files Are Checked Out|#1");
		}

		public override void Invoke()
		{
            CheckInDLG CheckInDLG = new CheckInDLG();
            CheckInDLG.Invoke();
            CheckInDLG.SetActive();
            CheckInDLG.OK.Click();
            System.Threading.Thread.Sleep(10000);
            CheckOutDLG CheckOutDLG = new CheckOutDLG();
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 0, "0,2,1");
            wTreeView.TypeKeys("<Down 8><Right><Down 2><Enter>");
            System.Threading.Thread.Sleep(3000);
            CheckOutDLG.SetActive();
            CheckOutDLG.StaticText1ST.DoubleClick();
            CheckOutDLG.OK.Click();
            System.Threading.Thread.Sleep(10000);
          //PROJECTMANAGERDLG.SetActive();
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 0, "0,0,0");
            wTreeView.TypeKeys("<Down 3><Right><Down 5><Enter>");
            System.Threading.Thread.Sleep(3000);
            FilesAreCheckedOutDLG FilesAreCheckedOutDLG = new FilesAreCheckedOutDLG();
            FilesAreCheckedOutDLG.SetActive();
		}

		public override void Dismiss()
		{
            FilesAreCheckedOutDLG FilesAreCheckedOutDLG = new FilesAreCheckedOutDLG();
            FilesAreCheckedOutDLG.SetActive();
            FilesAreCheckedOutDLG.OK.Click();
            Plant3DFunctions.DeleteVaultDrawing("P3D");
            System.Threading.Thread.Sleep(3000);
            Plant3DFunctions.SetToDefault();
		}
    }
}
