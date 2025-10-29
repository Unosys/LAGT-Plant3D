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
using Autodesk.GUIHarness.AutoCAD.Dialogs;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectCompareDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {

        partial void OnInitialize()
        {
            Tag = "[Window]$Window_1";
        }

        public override void Invoke()
        {
            //Plant3DFunctions.CreateProj();
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.Invoke();
            System.Threading.Thread.Sleep(4000);
            ProjManUndocked.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Up 2><Enter>");
            System.Threading.Thread.Sleep(2000);
            //Drawing.Current.SetSysVar("SDI", 0);
            //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            //PROJECTMANAGERDLG.Invoke();
            //PROJECTMANAGERDLG.TreeViewTV.Click(MouseButton.Right, 70, 8);
            //PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<Up><Enter>");


        }

        public override void Dismiss()
        {
            Current<ProjectCompareDLG>().Close2PB.Click();
            //Plant3DFunctions.DeleteAllDrawings();
            //Plant3DFunctions.SetToDefault();
        }
    }
}
