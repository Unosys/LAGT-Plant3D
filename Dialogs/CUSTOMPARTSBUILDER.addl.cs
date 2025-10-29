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
using ProductTestSuite.CommonFiles;
using System.Threading;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CUSTOMPARTSBUILDER : CustomWin
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[CustomWin]$59420";
        }

        public void Invoke()
        {
            Plant3DFunctions.CreateDrawing("P3D");
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_PLANTCUSTOMPARTS");


        }

        public void Dismiss()
        {
            Drawing.Current.TypeE("_PLANTCUSTOMPARTS");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            Plant3DFunctions.DeleteDrawing("P3D");
        }
        public void SetActive()
        {
            if (this.Exists)
            {
                this.Click(MouseButton.Left, 10, 80);
            }
            else
                this.Invoke();
        }
        public void Close()
        {
            if (this.Exists)
            {
                // Pass a co-ordinate location to the Dialog (not to the desktop) to hit the close button
                // Since the dialog is recognized this click will work no matter where the dialog is located on the screen
                //this.SetActive ();
                //this.Undock();
                // ToolspaceDLG.Toolspace.Toolsspace.Click (1, -10, 7)
                //System.Threading.Thread.Sleep (500);
                Drawing.Current.SetActive();
                Drawing.Current.TypeE("_PLANTCUSTOMPARTS");
            }
        }
        public void Undock()
        {
            CUSTOMPARTSBUILDER CUSTOMPARTSBUILDER = new CUSTOMPARTSBUILDER();
            CUSTOMPARTSBUILDER.SetActive();
            System.Threading.Thread.Sleep(100);
            //RECT rPos = PROJECTMANAGERDLG.GetRect();
            //AdResultLog.Current.Log(rPos);
            CUSTOMPARTSBUILDER.Click(MouseButton.Left, 100,5);
            System.Threading.Thread.Sleep(100);
            if (CUSTOMPARTSBUILDER.PushButton2PB.Exists)
            {
                CUSTOMPARTSBUILDER.DoubleClick(MouseButton.Left, 100, 5);
                AdResultLog.Current.Log("undocking");
            }
            else
            {
                AdResultLog.Current.Log("already undocked");
            }
        }
        //public void MoveOutOfMainWin()
        //{
        //    RECT rPos2 = this.GetRect();
        //    this.PressMouse(MouseButton.Left, rPos2.xPos + 5, (rPos2.yPos + rPos2.ySize) / 2);
        //    this.MoveMouse(750, 300);
        //    this.ReleaseMouse(MouseButton.Left, 750, 300);
        //    // sleep(1)

        //}
    }
}
