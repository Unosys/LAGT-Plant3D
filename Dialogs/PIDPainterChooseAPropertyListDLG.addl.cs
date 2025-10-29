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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PIDPainterChooseAPropertyListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2017";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$ChooseaPropertyListDlg";
        }

        public override void Invoke()
        {
            ProjectSetupPIDPainterSettingsDLG ProjectSetupPIDPainterSettingsDLG = new ProjectSetupPIDPainterSettingsDLG();
            ProjectSetupPIDPainterSettingsDLG.Invoke();
            ProjectSetupPIDPainterSettingsDLG.SetActive();
            ProjectSetupPIDPainterSettingsDLG.ServicePB.Click();
            this.SetSize(750, 470);
        }

        public override void Dismiss()
        {
            PIDPainterChooseAPropertyListDLG PIDPainterChooseAPropertyListDLG = new PIDPainterChooseAPropertyListDLG();
            PIDPainterChooseAPropertyListDLG.CancelPB.Click();
            ProjectSetupPIDPainterSettingsDLG ProjectSetupPIDPainterSettingsDLG = new ProjectSetupPIDPainterSettingsDLG();
            ProjectSetupPIDPainterSettingsDLG.Dismiss();

        }
        public void SetSize(int xRestSize, int yRestSize)
        {
            RECT r = this.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                this.Click(MouseButton.Right, 10, 10);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
    }
}