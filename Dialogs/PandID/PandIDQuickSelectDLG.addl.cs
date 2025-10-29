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
    public partial class PandIDQuickSelectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            
            Tag = "~ActiveApp/[DialogBox]" + AcMainWin.cBabel(174, 1, "Quick Select");
        }

        public override void Invoke()
        {
            Plant3DFunctions.OpenSampleProject();
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");

            PROJECTMANAGERDLG.SetActive();
            Plant3DFunctions.ExpandTreeP3D(PROJECTMANAGERDLG.TreeViewTV, 1, "0,1,1");
            System.Threading.Thread.Sleep(8000);
            DrawingCheckerDLG DrawingCheckerDLG = new DrawingCheckerDLG();
            if (DrawingCheckerDLG.Exists)
            {
                DrawingCheckerDLG.Close();
            }
            Drawing.Current.TypeE("_qselect");
            System.Threading.Thread.Sleep(3000);
            

        }

        public override void Dismiss()
		{
            this.CancelPB.Click();
            Drawing.Current.TypeE("_CLOSE");
            System.Threading.Thread.Sleep(2000);
            Plant3DFunctions.SetToDefault();
        }
    }
}
