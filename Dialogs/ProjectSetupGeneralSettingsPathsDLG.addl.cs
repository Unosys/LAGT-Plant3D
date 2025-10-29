// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
    public partial class ProjectSetupGeneralSettingsPathsDLG : Pane
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2017";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "$EditProjectSettingsDlg";
        }
        public void Invoke()
        {
            Drawing.Current.SetSysVar("SDI", 0);
            Drawing.Current.TypeE("_ProjectSetup");
            System.Threading.Thread.Sleep(6000);
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.SetActive();
            ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<Home><Down 4>");//path
            //ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21014, 1, "Paths"));
            //this.SetSize(1200,730);
        }

        public void Dismiss()
        {
            ProjectSetupGeneralSettingsPathsDLG ProjectSetupGeneralSettingsPathsDLG = new ProjectSetupGeneralSettingsPathsDLG();
            ProjectSetupGeneralSettingsPathsDLG.CancelPB.Click();
           
        }
        public void SetSize(int xRestSize, int yRestSize)
        {
            
            RECT r = this.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                this.Click(MouseButton.Right, 8, 70);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
    }
}
