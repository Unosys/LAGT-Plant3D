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
    public partial class PandIDProjManUndocked : CustomWin
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>

        partial void OnInitialize()
        {
            Tag = "PROJECTMANAGER";
        }

        public void Invoke()
        {
            Drawing.Current.TypeE("_ProjectManager");
        }

        public void Dismiss()
        {
            //PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = Current<PandIDPROJECTMANAGERDLG>();
            //PandIDPROJECTMANAGERDLG.SetActive();
            //RECT rPaletteWnd = PandIDPROJECTMANAGERDLG.GetRect(true);
            //PandIDPROJECTMANAGERDLG.Click(MouseButton.Left, rPaletteWnd.xSize - 10, 79);
            Drawing.Current.TypeE("_ProjectManagerClose");
        }
        public void SetActive()
        {
            if (this.Exists)
            {
                //this.Click(MouseButton.Left, 10, 80);
                this.Click(MouseButton.Left, 100, 400);
            }
            else
                this.Invoke();
        }
        public void SetTab(int iTab)
        {
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(1000);
            RECT rRect = PandIDPROJECTMANAGERDLG.PROJECTMANAGER1WIN.GetRect();
            //ResultLog.Current.Log(rRect);
            switch (iTab)
            {
                case 1:
                    {
                        PandIDPROJECTMANAGERDLG.Click(MouseButton.Left, rRect.xSize +10, rRect.yPos +50); //1st tab
                        break;
                    }
                case 2:
                    {
                        PandIDPROJECTMANAGERDLG.Click(MouseButton.Left, rRect.xSize +10, rRect.yPos + 200); //2nd tab
                        break;
                    }
                case 3:
                    {
                        PandIDPROJECTMANAGERDLG.Click(MouseButton.Left, rRect.xSize +10, rRect.yPos + 300); //3rd tab
                        break;
                    }
            }
            System.Threading.Thread.Sleep(1000);
        }
        public void SetPosition()
        {
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = Current<PandIDProjManUndocked>();
            //PandIDPROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(100);
            //move aside
            PandIDPROJECTMANAGERDLG.PressMouse(MouseButton.Left, 5, 100);
            Desktop.Current.ReleaseMouse(MouseButton.Left, 700, 100);
            System.Threading.Thread.Sleep(100);
            //resize
            RECT rWin = PandIDPROJECTMANAGERDLG.GetRect();
            PandIDPROJECTMANAGERDLG.PressMouse(MouseButton.Left, 100, rWin.yPos);
            System.Threading.Thread.Sleep(100);
            Desktop.Current.ReleaseMouse(MouseButton.Left, 100, 10);
            System.Threading.Thread.Sleep(100);
            PandIDPROJECTMANAGERDLG.PressMouse(MouseButton.Left, 100, rWin.ySize);
            System.Threading.Thread.Sleep(100);
            Desktop.Current.ReleaseMouse(MouseButton.Left, 100, 650);
            System.Threading.Thread.Sleep(100);
            //resize treeview
            //rWin = PandIDPROJECTMANAGERDLG.TreeViewTV.GetRect();
            //PandIDPROJECTMANAGERDLG.TreeViewTV.PressMouse(MouseButton.Left, 50, rWin.ySize);
            //System.Threading.Thread.Sleep(100);
            //PandIDPROJECTMANAGERDLG.TreeViewTV.PressMouse(MouseButton.Left, 50, 300);
            //System.Threading.Thread.Sleep(100);
        }
    }
}
