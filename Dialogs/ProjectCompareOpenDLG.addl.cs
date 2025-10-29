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
using Autodesk.GUIHarness.AutoCAD;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectCompareOpenDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
            Tag = "*" + AcMainWin.cBabel(250, 14, "Open") + "*" + "|*" + AcMainWin.cBabel(275, 6, "Open") + "*";
        }

        public override void Invoke()
        {
            ProjectCompareDLG ProjectCompareDLG = new ProjectCompareDLG();
            ProjectCompareDLG.Invoke();
            System.Threading.Thread.Sleep(1000);
            //ProjectCompareDLG.UpdatePartOfYourPL.Select(0);
            ProjectCompareDLG.ChooseAProjectToPB.Click();

        }

        public override void Dismiss()
        {
            Current<ProjectCompareOpenDLG>().CancelPB.Click();
            //Plant3DFunctions.DeleteAllDrawings();
            //Plant3DFunctions.SetToDefault();
        }
    }
}
