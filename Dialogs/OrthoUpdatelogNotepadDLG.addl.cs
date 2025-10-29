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
using ProductTestSuite.CommonFiles;
using System.Diagnostics;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class OrthoUpdatelogNotepadDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[MainWin]OrthoUpdate*";
        }

        public override void Invoke()
        {
            var Plant3DOrthoGenerationDLG_Successfully = new Plant3DOrthoGenerationDLG_Successfully();
            Plant3DOrthoGenerationDLG_Successfully.Invoke();
            System.Threading.Thread.Sleep(25000);
            int j = 0;
            while (j <= 30)
            {
                if (Plant3DOrthoGenerationDLG_Successfully.LogFileLINK.IsEnabled)
                {
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(5000);
                }
                j++;
            }
            Plant3DOrthoGenerationDLG_Successfully.LogFileLINK.Click();
            this.SetSize();
            this.Move(10,10);
            this.SetActive();
           
        }

        public override void Dismiss()
        {
            this.SetActive();
            this.TypeKeys("<Alt-F4>");
            var Plant3DOrthoGenerationDLG_Successfully = new Plant3DOrthoGenerationDLG_Successfully();
            Plant3DOrthoGenerationDLG_Successfully.Dismiss();
        }
        public void SetSize()
        {
            var OrthoUpdatelogNotepadDLG = new OrthoUpdatelogNotepadDLG();
            RECT r = OrthoUpdatelogNotepadDLG.GetRect(true);
            if (r.xSize != 400 && r.ySize != 600)
            {
                OrthoUpdatelogNotepadDLG.Click(MouseButton.Right, 10, 10);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + 800, r.yPos + 600);
            }
        }
        public void Move(int xRestSize, int yRestSize)
        {
            var OrthoUpdatelogNotepadDLG = new OrthoUpdatelogNotepadDLG();
            RECT r = OrthoUpdatelogNotepadDLG.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                Desktop.Current.PressMouse(MouseButton.Left, r.xPos + 5, r.yPos + 5);
                Desktop.Current.ReleaseMouse(MouseButton.Left, xRestSize, yRestSize);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
