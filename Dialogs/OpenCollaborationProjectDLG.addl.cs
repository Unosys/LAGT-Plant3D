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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class OpenCollaborationProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
            // Pre: Follow C:\LAGT\Plant3D\TestFiles\Plant Collaboration config\Collaboration project Setting.txt login to simulation Account first
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            try
            {
                //PROJECTMANAGERDLG.CurrentProjectPL.Select(AcMainWin.cBabel(23073, 34, "Open Collaboration Project"));
                PROJECTMANAGERDLG.OpenPB.Click();
                PROJECTMANAGERDLG.OpenPB.TypeKeys("<Home><Down><Enter>");
            }
            catch
            {
              System.Threading.Thread.Sleep(4000);
            }
            System.Threading.Thread.Sleep(15000);
            this.SetActive();
        }


        public override void Dismiss()
        {
            this.ClosePB.Click();
            Plant3DFunctions.SetToDefault();
            //Plant3D appwnd = new Plant3D();
            //appwnd.Exit1();
        }
    }
}
 