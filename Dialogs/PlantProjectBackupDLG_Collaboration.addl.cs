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
    public partial class PlantProjectBackupDLG_Collaboration : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
            Plant3DFunctions.OpenCollaborationProject("SampleProject_Auto");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            Plant3DFunctions.ExpandTreeP3D(PROJECTMANAGERDLG.TreeViewTV, 12, "0");
            System.Threading.Thread.Sleep(8000);

            this.SetActive();
            this.Size(750, 640);


        }
        public override void Dismiss()
        {
            this.ClosePB.Click();
            System.Threading.Thread.Sleep(8000);
            Plant3DFunctions.SetToDefault();


        }
    }
}
