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
    public partial class PlantProjectBackupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        //partial void OnInitialize()
        // {
        // }
        partial void OnInitialize()
        {
            Tag = "[Window]$PrjBackUpDlog";
        }

        public override void Invoke()
        {
            Plant3DFunctions.CreateProj();
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            ProjManUndocked.Plant3DDrawingsTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Down 3><Enter>");      
            SelectDrawingsToCopyToProDLG.FileName.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PP2equipment.dwg");
            SelectDrawingsToCopyToProDLG.Open.Click();
            System.Threading.Thread.Sleep(4000);
            ProjManUndocked.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Up 3><Enter>");
            this.Size(700,650);
 
        }

        public override void Dismiss()
        {
           this.ClosePB.Click();
            Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.SetToDefault();
        }
    }
}
