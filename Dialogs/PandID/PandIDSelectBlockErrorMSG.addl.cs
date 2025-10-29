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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDSelectBlockErrorMSG : AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[DialogBox]" + AcMainWin.cBabel(517, 16, "Error");
        }

        public override void Invoke()
        {
            PandIDSelectBlockPandIDDLG PandIDSelectBlockPandIDDLG = new PandIDSelectBlockPandIDDLG();
            PandIDSelectBlockPandIDDLG.Invoke();
            PandIDSelectBlockPandIDDLG.M_btnOk.Click();
            if (!this.Exists)
            {
                PandIDNewEndConnectionDLG PandIDNewEndConnectionDLG = new PandIDNewEndConnectionDLG();
                PandIDNewEndConnectionDLG.M_textBoxName.SetText("aaa");
                PandIDNewEndConnectionDLG.M_btnOk.Click();
                PandIDProjectSetupEndConnectionDLG PandIDProjectSetupEndConnectionDLG = new PandIDProjectSetupEndConnectionDLG();
                PandIDProjectSetupEndConnectionDLG.M_btnAddBlock.Click();
                PandIDNewEndConnectionDLG.M_btnBrowse.Click();
                PandIDSelectBlockDrawingDLG PandIDSelectBlockDrawingDLG = new PandIDSelectBlockDrawingDLG();
                PandIDSelectBlockDrawingDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\projSymbolStyle.dwg");
                PandIDSelectBlockDrawingDLG.OpenPB.Click();
                PandIDSelectBlockPandIDDLG.M_btnOk.Click();
            }

        }

        public override void Dismiss()
        {
            this.No.Click();
            PandIDSelectBlockPandIDDLG PandIDSelectBlockPandIDDLG = new PandIDSelectBlockPandIDDLG();
            PandIDSelectBlockPandIDDLG.Dismiss();
        }
    }
}
