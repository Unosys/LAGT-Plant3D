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
    public partial class ProjectSetupPipeSpecObjectMappingDLG_Valves : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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

        public override  void Invoke()
        {
            var ProjectSetupPipeSpecObjectMappingDLG = new ProjectSetupPipeSpecObjectMappingDLG();
            ProjectSetupPipeSpecObjectMappingDLG.Invoke();
            ProjectSetupPipeSpecObjectMappingDLG.Window2WIN.Click(MouseButton.Left,2,2);
            this.SetActive();
        }

        public override void Dismiss()
        {
            var ProjectSetupPipeSpecObjectMappingDLG = new ProjectSetupPipeSpecObjectMappingDLG();
            ProjectSetupPipeSpecObjectMappingDLG.Dismiss();
        }
        public void SelectTab(int i = 1)
        {
            var ProjectSetupPipeSpecObjectMappingDLG = new ProjectSetupPipeSpecObjectMappingDLG();
            RECT r = ProjectSetupPipeSpecObjectMappingDLG.ObjectMappingPANE.GetRect(true);
            Desktop.Current.DoubleClick(MouseButton.Left, r.xPos + 10, r.yPos - 10);
            if (i != 1)
            {
                Desktop.Current.TypeKeys("<Right " + (i - 1).ToString() + ">");
            }
        }
    }
}
