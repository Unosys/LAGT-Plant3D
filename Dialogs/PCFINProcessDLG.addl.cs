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
using LAGT.CommonFiles.Extensions.CaptureBitmaps; 
using System.Runtime.CompilerServices;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PCFINProcessDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            
            Tag = "$Window_1";
        }

        public override void Invoke()
        {
            PCFINSelectFileDLG PCFINSelectFileDLG = new PCFINSelectFileDLG();
            PCFINSelectFileDLG.Invoke();
            PCFINSelectFileDLG.FileNameCB.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir);
            PCFINSelectFileDLG.OpenPB.Click();
            PCFINSelectFileDLG.ListViewLV.Click(MouseButton.Left, 20, 40);
            System.Threading.Thread.Sleep(2000);
            PCFINSelectFileDLG.ListViewLV.TypeKeys("10");
            PCFINSelectFileDLG.ListViewLV.TypeKeys("<Shift-Down 2>");
            PCFINSelectFileDLG.OpenPB.Click();           
            PCFINListDLG PCFINListDLG = Current<PCFINListDLG>();
            PCFINListDLG.CreatePipingPB.Click();
        
        }
        public override void Capture(string SaveLocation)
        {

            RECT item = base.GetRect(true);
            this.CaptureDelimitedArea(SaveLocation + this.Information.Items[0].ToString() + ".bmp",
    item.xPos,
    item.yPos,
    item.xSize,
    item.ySize
                );
           
        }
        public override void Dismiss()
        {

            PCFINProcessDLG PCFINProcessDLG = Current<PCFINProcessDLG>();
            PCFINProcessDLG.ClosePB.Click();
        }
    }
}
