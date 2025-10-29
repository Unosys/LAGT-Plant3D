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
    public partial class PlantProjectBackupProcessDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        partial void OnInitialize()
        {
            Tag = "[Window]$Window_1";
        }


        public override void Invoke()
        {
            Plant3DFunctions.CreateProj();            
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            for (int i = 2; i <= 10; i++)
            {
                ProjManUndocked.Plant3DDrawingsTVI.Click(MouseButton.Right);
                Desktop.Current.TypeKeys("<Down 3><Enter>");
                SelectDrawingsToCopyToProDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir +"PP" +i+ "equipment.dwg");
                SelectDrawingsToCopyToProDLG.Open.Click();
                System.Threading.Thread.Sleep(4000);
                   
            }
            for (int i = 2; i <= 10; i++)
            {
                ProjManUndocked.PIDDrawingsTVI.Click(MouseButton.Right);
                Desktop.Current.TypeKeys("<Down 3><Enter>");
                SelectDrawingsToCopyToProDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PP" + i + "equipment.dwg");
                SelectDrawingsToCopyToProDLG.Open.Click();
                System.Threading.Thread.Sleep(4000);

            }

            ProjManUndocked.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Up 3><Enter>");
            PlantProjectBackupDLG PlantProjectBackupDLG = new PlantProjectBackupDLG();
            PlantProjectBackupDLG.BackupProjectPB.Click();
        }

        public override void Dismiss()
        {
            //Current<PlantProjectBackupProcessDLG>().CancelPB.Click();
            System.Threading.Thread.Sleep(4000);
            if (this.Exists) {
                System.Threading.Thread.Sleep(6000);
            }
            
            Plant3DFunctions.SetToDefault();
        }
    }
}
