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
using System;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DProjectCompareDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
            Tag = "[Window]$Window_1";
        }

        public override void Invoke()
        {
            Random random = new Random();
            string sPname = "ProjectCompare_0" + (random.Next(1, 1000));
            Plant3DFunctions.CreateProj(sPname);////new two plant3D project.
            Plant3DFunctions.CreateProj(sPname+"1");
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.Invoke();
            ProjManUndocked.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Up 2><Enter>");
            System.Threading.Thread.Sleep(1000);
            ProjectCompareDLG ProjectCompareDLG = new ProjectCompareDLG();
            ProjectCompareDLG.ChooseAProjectToPB.Click();
            System.Threading.Thread.Sleep(1000);
            /////////Plant3D project compare with Plant3D project/////////////////////
            ProjectCompareOpenDLG ProjectCompareOpenDLG = new ProjectCompareOpenDLG();
            //String sProjectname = Plant3DMainWin.sDefaultProjPath + "Project.xml";
            String sProjectname = "C:\\Users\\Administrator\\Documents\\"+ sPname + "\\Project.xml";
            ProjectCompareOpenDLG.FileNameCB.SetText(sProjectname);
            System.Threading.Thread.Sleep(1000);
            ProjectCompareOpenDLG.OpenPB.Click();
            this.Size(1200,690);
        }

        public override void Dismiss()
        {
            Current<Plant3DProjectCompareDLG>().Close2PB.Click();
            Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.SetToDefault();
        }
    }
}
