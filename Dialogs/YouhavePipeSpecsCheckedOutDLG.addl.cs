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
    public partial class YouhavePipeSpecsCheckedOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[DialogBox]" + AcMainWin.cBabel(23073,33,"You Have Pipe Specs Checked Out");
        }

        public override void Invoke()
        {
            Plant3DFunctions.OpenCollaborationProject("AutoFY24");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.PipeSpecsTVI.Select();
            ProjManUndocked.PipeSpecsTVI.TypeKeys("<Right><Down>");
            System.Threading.Thread.Sleep(9000);
            RECT rtree = ProjManUndocked.TreeViewTV.GetRect();
            if (LAGT.CommonFiles.Product.Variables.Language == "RUS")
            {
                ProjManUndocked.TreeViewTV.Click(MouseButton.Right, rtree.xPos + 5, rtree.ySize - 20);
            }
            else {
                ProjManUndocked.TreeViewTV.Click(MouseButton.Right, rtree.xPos + 5, rtree.ySize - 23);
            }
            Desktop.Current.TypeKeys("<Down 6><Enter>");//checkout
            System.Threading.Thread.Sleep(9000);
            Desktop.Current.TypeKeys("<Alt><Home>");
            Window wTreeview = ProjManUndocked.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeview, 1, "0");
            System.Threading.Thread.Sleep(3000);
            this.SetActive();
        }


        public override void Dismiss()
        {
            this.CheckInAnyPipeSpecsPB.Click();
            String projectname = Plant3DMainWin.sDefaultProjPath + "Project.xml";
            Drawing.Current.TypeE("Filedia 0");
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(projectname);
            System.Threading.Thread.Sleep(3000);
            //Plant3DFunctions.SetToDefault();
            Plant3D appwnd = new Plant3D();
            //appwnd.Exit1();
        }
    }
}
