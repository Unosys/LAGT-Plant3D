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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CollaborationCheckInDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$frmVaultCheckin";
        }

        public override void Invoke()
        {
            Plant3DFunctions.OpenCollaborationProject("AutoFY24");//Auto_ENU_03
            Random rand = new Random();
            //String number = "Draw" + (rand.Next(2,9));
            //Plant3DFunctions.CreateVaultDrawing("P3D","no",number);
            Plant3DFunctions.CreateDrawing("P3D");
            Drawing.Current.TypeE("_PlantCheckIn");
            System.Threading.Thread.Sleep(5000);
            this.SetActive();
        }


        public override void Dismiss()
        {
           this.ClosePB.Click();
            Drawing.Current.TypeE("_Close");
            Plant3DFunctions.DeleteClaudDrawing("P3D");
            System.Threading.Thread.Sleep(4000);
            Plant3DFunctions.SetToDefault();
            System.Threading.Thread.Sleep(3000);
            //Plant3D appwnd = new Plant3D();
            //appwnd.Exit1();

        }
    }
}
