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
using System.Threading;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDPROJECTMANAGERDLG : AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
//            Tag = Plant3DMainWin.cBabel(21028, 1, "PROJECT MANAGER");
        }

        string sCurrent = "";
        
        public override string Tag
        {
            get
            {
                const string sDocked = "[CustomWin]PROJECTMANAGER*";
                const string ExtRefdocked = "[DialogBox]PROJECTMANAGER*";

                MainWin appWnd = Harness.Current.AppWnd;
                if (appWnd.Exists && appWnd.DialogBox("PROJECT MANAGER").Exists)
                {
                    sCurrent = ExtRefdocked;
                }
                else
                {
                    sCurrent = sDocked;
                }
                return sCurrent;
            }
        }

        public override void Invoke()
        {
            Drawing.Current.TypeE("_ProjectManager");           
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeE("_ProjectManagerClose");
        }

        public bool bIsDocked
        {
            get
            {
                if (Harness.Current.AppWnd.DialogBox("PROJECTMANAGER").WaitExists(2000))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        //-----------------------------------------------------------------
        // IsDocked: Function to indicate ExternalReferencesDLG is docked or not
        //-----------------------------------------------------------------
        public bool IsDocked()
        {
            return bIsDocked;
        }
        //------------------------------------------------------------------------
        // Dock: Dock ExternalReferencesDLG
        //------------------------------------------------------------------------
        public void Dock()
        {
            if (IsDocked() == false)
            {
                RECT rExtRefRect = GetRect(true);

                // Double click title bar which is always below the close X button.
                // Try clicking on the left side, it title bar is there it will dock it if not
                // continue
                Desktop.Current.DoubleClick(MouseButton.Left, rExtRefRect.xPos + 10, rExtRefRect.yPos + 40);

                // If its still not docked the title bar may be on the right so double click
                // the right side of the cmd window to dock it
                if (IsDocked() == false)
                {
                    Desktop.Current.DoubleClick(MouseButton.Left, rExtRefRect.xPos + rExtRefRect.xSize - 10, rExtRefRect.yPos + 40);
                }
            }
        }
        //------------------------------------------------------------------------
        // Undock: Undock ExternalReferencesDLG
        //------------------------------------------------------------------------
        public bool Undock()
        {
            if (IsDocked())
            {
                RECT rExtRefRect = GetRect(true);

                // Double click bar on left size of cmd window to undock it
                Desktop.Current.DoubleClick(MouseButton.Left, rExtRefRect.xPos + 5, rExtRefRect.yPos + 5);

                return true;
            }

            return false;
        }
        //-----------------------------------------------------------------
        // SetActive:
        //-----------------------------------------------------------------
        public override void SetActive()
        {
            RECT rExtRefRect;
            RECT rExtRefRect2;

            if (IsDocked()) // if ExternalReferencesDLG is docked then no need to do a SetActive
            {
                return;
            }

            rExtRefRect = this.GetRect(true);
            rExtRefRect2 = this.GetRect(false);
            if (!this.IsActive)
            {
                if (this.IsDocked())
                {
                    Desktop.Current.MoveMouse(rExtRefRect.xPos + 5, rExtRefRect.yPos + 5);
                    Desktop.Current.Click(MouseButton.Left, rExtRefRect.xPos + 5, rExtRefRect.yPos + 5);
                }
                else
                {
                    Desktop.Current.MoveMouse(rExtRefRect.xPos + 10, rExtRefRect.yPos + 40);
                    Desktop.Current.Click(MouseButton.Left, rExtRefRect.xPos + 10, rExtRefRect.yPos + 40);
                }

            }
            Thread.Sleep(500);
            this.MoveMouse(rExtRefRect2.xSize / 2, rExtRefRect2.ySize / 2);
        }

        public void MoveOutOfMainWin()
        { 
            //RECT rPos2 = Drawing.Current.GetRect();
            RECT rPos2 = GetRect(true);
		    Desktop.Current.PressMouse(MouseButton.Left,rPos2.xPos+5,(rPos2.yPos+rPos2.ySize)/2);
		    Desktop.Current.MoveMouse(750,300);
            Desktop.Current.ReleaseMouse(MouseButton.Left, 750, 300);
        }

       

    }
}
