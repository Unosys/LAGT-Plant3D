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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PCFINListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
            PCFINSelectFileDLG PCFINSelectFileDLG = new PCFINSelectFileDLG();
            PCFINSelectFileDLG.Invoke();
            PCFINSelectFileDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "1001.pcf");
            System.Threading.Thread.Sleep(200);
            PCFINSelectFileDLG.OpenPB.Click();
            //PCFINSelectFileDLG.ListViewLV.Click(MouseButton.Left, 20, 40);
            //PCFINSelectFileDLG.ListViewLV.TypeKeys("10");
            //PCFINSelectFileDLG.ListViewLV.TypeKeys("<Shift-Down 2>");
            //PCFINSelectFileDLG.OpenPB.Click();
            System.Threading.Thread.Sleep(2000);

        }

        public override void Dismiss()
        {
            PCFINListDLG PCFINListDLG = Current<PCFINListDLG>();
            PCFINListDLG.CancelPB.Click();
        }
    }
}
