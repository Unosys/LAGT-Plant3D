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
    public partial class UndoCheckOutProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            //Tag = "[DialogBox]" + AcMainWin.cBabel(23073, 35, "Undo Check Out");
            Tag = "[Window]$Window_1";//Undo Check Out - Plant 3D Drawings
        }

        public override void Invoke()
        {
            CollaborationCheckInDLG CollaborationCheckInDLG = new CollaborationCheckInDLG();
            CollaborationCheckInDLG.Invoke();
            CollaborationCheckInDLG.OKPB.Click();
            System.Threading.Thread.Sleep(25000);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 7, "0,2,1");//10 in list Check Out..
            System.Threading.Thread.Sleep(3000);
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2,1");//open
            System.Threading.Thread.Sleep(4000);
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "DEU":
                    Drawing.Current.TypeE("_line");
                    Drawing.Current.TypeE("8.1642,12.4773");
                    Drawing.Current.TypeE("25.8701,16.1424");
                    Drawing.Current.TypeE("");
                    break;
                case "JPN":
                    Drawing.Current.TypeE("_line");
                    Drawing.Current.TypeE("8.1642,12.4773");
                    Drawing.Current.TypeE("25.8701,16.1424");
                    Drawing.Current.TypeE("");
                    break;
                default:
                    Drawing.Current.TypeE("_PLANTPIPEADD");
                    System.Threading.Thread.Sleep(3000);
                    Drawing.Current.TypeE("20");
                    Drawing.Current.TypeE("100");
                    Drawing.Current.TypeE("");
                    break;
            }
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 6, "0,2");//Undo Check Out
            System.Threading.Thread.Sleep(3000);
            this.Size(800, 360);
            this.SetActive();
        }


        public override void Dismiss()
        {
            this.CancelPB.Click();
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.TypeE("_Close");
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            System.Threading.Thread.Sleep(3000);
            Plant3DFunctions.DeleteClaudDrawing("P3D");
            Plant3DFunctions.SetToDefault();
            Plant3D appwnd = new Plant3D();
            //appwnd.Exit1();

        }
    }
}
