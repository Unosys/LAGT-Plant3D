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
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CollaborationCheckOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$frmVaultGetCheckOut";
        }

        public override void Invoke()
        {
            
            CollaborationCheckInDLG CollaborationCheckInDLG = new CollaborationCheckInDLG();
            CollaborationCheckInDLG.Invoke();
            CollaborationCheckInDLG.OKPB.Click();
            System.Threading.Thread.Sleep(15000);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "0");//4 in listcheck out
            //CollaborationCheckOutDLG CollaborationCheckOutDLG = new CollaborationCheckOutDLG();
            //CollaborationCheckOutDLG.Plant3DDrawingsTVI.DoubleClick();
            //CollaborationCheckOutDLG.IsometricDrawingsTVI.DoubleClick();
            System.Threading.Thread.Sleep(3000);
            this.SetActive();
        }


        public override void Dismiss()
        {
            this.ClosePB.Click();
            Plant3DFunctions.DeleteClaudDrawing("P3D");
            Plant3DFunctions.SetToDefault();
            System.Threading.Thread.Sleep(3000);
            //Plant3D appwnd = new Plant3D();
            //appwnd.Exit1();

        }
    }
}
