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
using Microsoft.Win32;
using System;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectCompareOrthoCubeLibraryDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Window]$Window_1";

        }

        public override void Invoke()
        {
            ///////Default project vs Sample project
            String DefaultProject = Plant3DMainWin.sDefaultProjPath + "Project.xml";

            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "SampleProject", "") as string;
            string SampleProject = sProjectPath + "Project.xml";
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.Invoke();
            ProjManUndocked.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Up 2><Enter>");
            System.Threading.Thread.Sleep(1000);
            ProjectCompareDLG ProjectCompareDLG = new ProjectCompareDLG();
            ProjectCompareDLG.ChooseAProjectToPB.Click();
            System.Threading.Thread.Sleep(1000);
            /////////Plant3D project compare with Default Project/////////////////////
            ProjectCompareOpenDLG ProjectCompareOpenDLG = new ProjectCompareOpenDLG();
            ProjectCompareOpenDLG.FileNameCB.SetText(SampleProject);
            System.Threading.Thread.Sleep(1000);
            ProjectCompareOpenDLG.OpenPB.Click();
            this.TreeViewTV.Select(AcMainWin.cBabel(23069, 15, "OrthoCube Library"));
            System.Threading.Thread.Sleep(1000);
            this.Area1JoggedqryLBI.Click(MouseButton.Left, 1, 1);
            System.Threading.Thread.Sleep(1000);

        }

        public override void Dismiss()
        {
            this.Close2PB.Click();

        }
    }
}
