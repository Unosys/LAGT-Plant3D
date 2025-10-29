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
using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ProjectSetupforCollaboration : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$EditProjectSettingsDlg";
        }

        public override void Invoke()
        {
            Plant3DFunctions.OpenCollaborationProject("AutoFY24");
            Drawing.Current.TypeE("_PROJECTSETUP");
            System.Threading.Thread.Sleep(3000);
            ProjectSettingsCheckOut ProjectSettingsCheckOut = new ProjectSettingsCheckOut();
            if (ProjectSettingsCheckOut.Exists) {
                ProjectSettingsCheckOut.SetActive();
                ProjectSettingsCheckOut.OpenReadonlyPB.Click();
            }
            var ProjectSettingsLockedMSG = new ProjectSettingsLockedMSG();
            if (ProjectSettingsLockedMSG.Exists)
            {
                ProjectSettingsLockedMSG.SetActive();
                ProjectSettingsLockedMSG.YesPB.Click();
            }
            System.Threading.Thread.Sleep(8000);
            this.SetActive();
        }

        public override void Dismiss()
        {
            this.CancelPB.Click();
            System.Threading.Thread.Sleep(5000);           
            Plant3DFunctions.SetToDefault();
            //String projectname = Plant3DMainWin.sDefaultProjPath + "Project.xml";
            //Drawing.Current.TypeE("Filedia 0");
            //Drawing.Current.TypeE("_openproject");
            //Drawing.Current.TypeE(projectname);
            //System.Threading.Thread.Sleep(3000);
            ////Plant3DFunctions.SetToDefault();
            //Plant3D appwnd = new Plant3D();
            ////appwnd.Exit1();
        }
    }
}
