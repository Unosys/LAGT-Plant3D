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
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CheckInDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$frmVaultCheckin";
        }

        public override void Invoke()
		{
            Plant3DFunctions.OpenVaultProject("TestVault");
            System.Threading.Thread.Sleep(30000);
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            //Plant3DFunctions.DeleteAllVaultDrawings();
            Random randNum = new Random();
            string number = "Draw" + (randNum.Next(2,9));
            Plant3DFunctions.CreateVaultDrawing("P3D", "no", number);
            System.Threading.Thread.Sleep(10000);
            PROJECTMANAGERDLG.SetActive();
            Window wTreeView= PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView,0,"0,2,1");
            //RECT rRect = wTreeView.GetRect();
            //string sTreePath = wTreeView.IsActive.ToString();
            //RECT rRect = wTreeView.GetRect(IsActive);
            //wTreeView.Click(MouseButton.Right,rRect.xPos+8, rRect.yPos+8);
            //wTreeView.TypeKeys("<Down 4><Enter>");//9 in list check in
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,2,1");
            System.Threading.Thread.Sleep(3000);
            CheckInDLG CheckInDLG = new CheckInDLG();
            CheckInDLG.SetActive();
		}

        public  void Dismiss()
        {
            this.ClosePB.Click();
            Drawing.Current.TypeE("_CLOSE");
            System.Threading.Thread.Sleep(2000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.DeleteVaultDrawing("P3D");
           Plant3DFunctions.SetToDefault();
        }
    }
}
