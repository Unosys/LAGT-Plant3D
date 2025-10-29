// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2017 by Autodesk, Inc.
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
    public partial class PlantProjectBackupFinishDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        partial void OnInitialize()
        {
            Tag = "[Window]$PrjBackUpDlog";
        }


        public override void Invoke()
        {
            PlantProjectBackupDLG PlantProjectBackupDLG = new PlantProjectBackupDLG();
            PlantProjectBackupDLG.Invoke();
            PlantProjectBackupDLG.BackupProjectPB.Click();
            System.Threading.Thread.Sleep(4000);
            this.Size(700, 650);
        }

        public override void Dismiss()
        {
            this.Close2PB.Click();
            Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.SetToDefault(); 
        }
    }
}
