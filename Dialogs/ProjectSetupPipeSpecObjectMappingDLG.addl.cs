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
    public partial class ProjectSetupPipeSpecObjectMappingDLG : Pane
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
            ProjectSetupPipeSpecsInPIDDLG ProjectSetupPipeSpecsInPIDDLG = new ProjectSetupPipeSpecsInPIDDLG();
            ProjectSetupPipeSpecsInPIDDLG.Invoke();
            ProjectSetupPipeSpecsInPIDDLG.SetActive();
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(23073, 22, "Pipe Specs in P&ID"));
            ProjectSetupProjectDetailsDLG.M_treeView.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(23073, 22, "Pipe Specs in P&ID"));
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030,1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(23073, 22, "Pipe Specs in P&ID") + "/" + AcMainWin.cBabel(23073,23, "Pipe Spec Object Mapping"));
            ProjectSetupProjectDetailsDLG.PipeSpecObjectMappingTVI.Click();
        }

        public void Dismiss()
        {
            ProjectSetupPipeSpecObjectMappingDLG ProjectSetupPipeSpecObjectMappingDLG = new ProjectSetupPipeSpecObjectMappingDLG();
            ProjectSetupPipeSpecObjectMappingDLG.CancelPB.Click();

        }
        public void SelectTab(int i = 1)
        {

            RECT r = this.ObjectMappingPANE.GetRect(true);
            Desktop.Current.DoubleClick(MouseButton.Left, r.xPos + 10, r.yPos - 10);
            if (i != 1)
            {
                Desktop.Current.TypeKeys("<Right " + (i - 1).ToString() + ">");
            }
        }
    }
}
