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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class LinetypeManagerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = AcMainWin.cBabel(124, 1, "Linetype Manager");
        }
        public override void Invoke()
        {
            
            string sPath = LAGT.CommonFiles.Product.Variables.ProductLocation + "PLNT3D\\en-US\\ISA_projSymbolStyle.dwg".Replace("en-US", Plant3DFunctions.GetLangCode());
            Drawing.Current.TypeE("_SDI");
            Drawing.Current.TypeE("1");
            Drawing.Current.Open(sPath);
            System.Threading.Thread.Sleep(8000);
            Drawing.Current.TypeE("_LINETYPE");
            this.SetActive();

        }
        public override void Dismiss()
        {
            this.CancelPB.Click();
            //Drawing.Current.TypeE("_SDI 0");
            //Drawing.Current.TypeE("_Close");
            //System.Threading.Thread.Sleep(2000);
            //SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            //if (SaveChangesMSG.Exists)
            //{
            //    SaveChangesMSG.NoPB.Click();

            //}
            //Plant3D appwnd = new Plant3D();
            //appwnd.Exit();
            Plant3DFunctions.CloseDrawing();
        }

    }
}
