// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2017 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class OpenfromVaultErrorDLG : Window//Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        //partial void OnInitialize()
        // {
        // }
        partial void OnInitialize()
        {
            //Tag = "[DialogBox]#1";
            Tag = "[Window]$Window_1";
        }

        public /*override*/ void Invoke()
        {
            ProjectCompareDLG ProjectCompareDLG = new ProjectCompareDLG();
            ProjectCompareDLG.Invoke();
            //ProjectCompareDLG.UpdatePartOfYourPL.Click();//open from Vault
            //ProjectCompareDLG.TypeKeys("<Down><Enter>");
            //ProjectCompareDLG.UpdatePartOfYourPL.Select(2);
            RECT r = ProjectCompareDLG.LearnHowToCreatePL.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r.xPos + r.xSize - 10, r.yPos + 5);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.MoveMouse(r.xPos + r.xSize - 10, r.yPos + r.ySize + 60);
            System.Threading.Thread.Sleep(500);
            Desktop.Current.Click(MouseButton.Left, r.xPos + r.xSize - 10, r.yPos + r.ySize + 60);
            System.Threading.Thread.Sleep(1000);

        }

        public /*override*/ void Dismiss()
        {
            //this.TypeKeys("<Alt-F4>");
            ProjectCompareDLG ProjectCompareDLG = new ProjectCompareDLG();

            if (ProjectCompareDLG.Exists)
            {
                ProjectCompareDLG.Dismiss();
            }
            //Plant3DFunctions.DeleteAllDrawings();
            //Plant3DFunctions.SetToDefault();
        }
    }
}
