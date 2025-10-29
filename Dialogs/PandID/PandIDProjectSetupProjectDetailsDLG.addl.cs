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
    public partial class PandIDProjectSetupProjectDetailsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
            Drawing.Current.SetSysVar("SDI", 0);
            Drawing.Current.TypeE("_ProjectSetup");
            System.Threading.Thread.Sleep(10000);
            if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
            {
                System.Threading.Thread.Sleep(40000);
            }

            //this.M_treeView.Select(AcMainWin.cBabel(23165, 8, "Project Details"));
            System.Threading.Thread.Sleep(5000);
            this.ProjectDetailsTVI.Click();
            try { this.Move(50, 50); } catch { }
            this.SetActive();
        }

        public override void Dismiss()
        {
            this.SetActive();
            this.CancelPB.Click();
            System.Threading.Thread.Sleep(3000);
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Dismiss();
            Drawing.Current.SetSysVar("SDI", 0);
        }
    }
}
