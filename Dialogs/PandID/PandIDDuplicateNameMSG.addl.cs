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
    public partial class PandIDDuplicateNameMSG : AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = AcMainWin.cBabel(21010, 3, "Duplicate Name");
        }

        public override void Invoke()
        {
            PandIDNewEndConnectionDLG PandIDNewEndConnectionDLG = new PandIDNewEndConnectionDLG();
            PandIDNewEndConnectionDLG.Invoke();
            PandIDNewEndConnectionDLG.M_textBoxName.SetText("ED1");
            PandIDNewEndConnectionDLG.M_btnBrowse.Click();
            PandIDSelectBlockDrawingDLG PandIDSelectBlockDrawingDLG = new PandIDSelectBlockDrawingDLG();
            PandIDSelectBlockDrawingDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\projSymbolStyle.dwg");
            PandIDSelectBlockDrawingDLG.OpenPB.Click();
            PandIDSelectBlockPandIDDLG PandIDSelectBlockPandIDDLG = new PandIDSelectBlockPandIDDLG();
            PandIDSelectBlockPandIDDLG.M_btnOk.Click();
            PandIDSelectBlockErrorMSG PandIDSelectBlockErrorMSG = new PandIDSelectBlockErrorMSG();
            if (PandIDSelectBlockErrorMSG.Exists)
            {
                PandIDSelectBlockErrorMSG.Yes.Click();
            }
            PandIDNewEndConnectionDLG.M_btnOk.Click();
            PandIDProjectSetupEndConnectionDLG PandIDProjectSetupEndConnectionDLG = new PandIDProjectSetupEndConnectionDLG();
            if (!this.Exists)
            {
                PandIDProjectSetupEndConnectionDLG.M_btnAddBlock.Click();
                PandIDNewEndConnectionDLG.M_textBoxName.SetText("ED1");
                PandIDNewEndConnectionDLG.M_btnOk.Click();
            }

        }

        public override void Dismiss()
        {
            this.Close();
            PandIDNewEndConnectionDLG PandIDNewEndConnectionDLG = new PandIDNewEndConnectionDLG();
            PandIDNewEndConnectionDLG.Dismiss();
        }
    }
}
