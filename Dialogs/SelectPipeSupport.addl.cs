// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2014 by Autodesk, Inc.
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
using Autodesk.GUIHarness.Core;
using Microsoft.Win32;
using ProductTestSuite.CommonFiles;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SelectPipeSupport : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Window]$ShapeBrowserWindow";
;
        }
        public override void Invoke()
        {
            Plant3DFunctions.CopyDrawing("Pipesupport\\pipesupport.dwg");
            Drawing.Current.TypeE("_ZOOM");
            Drawing.Current.TypeE("_E");
            Drawing.Current.TypeE("_SELECT");
            Drawing.Current.TypeE("_ALL");
            Drawing.Current.TypeE("");
            Desktop Desktop = new Desktop();
            //Desktop.Click(MouseButton.Left, 379, 394);
            System.Threading.Thread.Sleep(2000);
            //Desktop.Click(MouseButton.Left, 379, 394);
            //SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Drop.bmp");
            //Desktop.Click(MouseButton.Left, SAM.iXCenter, SAM.iYCenter);
            Desktop.Click(MouseButton.Left, 377, 393);
            Desktop.Current.TypeKeys("<Up><Enter>");
            //// #if automation running can't invoke ,invoke it manually refer the steps.
            ////Click the placed pipe support, the little triangle icon display, click on it.
            ////Move mouse on menu items select Custom support.

            System.Threading.Thread.Sleep(2000);
            this.SetActive();
        }
        public override void Dismiss()
        {
            this.CancelPB.Click();
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(2000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.DeleteDrawing("P3D");
        }

    }
}
