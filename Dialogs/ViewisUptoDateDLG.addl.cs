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
    public partial class ViewisUptoDateDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = Plant3DFunctions.GetLocString("ViewisUptoDateDLG");
        }
        public override void Invoke()
        {

            Plant3DFunctions.OpenSampleProject();
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);                      
            Plant3DFunctions.ExpandTreeOrtho(PROJECTMANAGERDLG.TreeViewTV, 4, "0,1,1");
            System.Threading.Thread.Sleep(8000);
            Drawing.Current.TypeE("_PLANTORTHOUPDATE");
            Drawing.Current.TypeE("_ALL");
            System.Threading.Thread.Sleep(10000);
            Plant3DOrthoGenerationDLG Plant3DOrthoGenerationDLG = new Plant3DOrthoGenerationDLG();
            if (Plant3DOrthoGenerationDLG.Exists) {
                System.Threading.Thread.Sleep(10000);
            }
            Drawing.Current.TypeE("_PLANTORTHOUPDATE");
            Drawing.Current.TypeE("_ALL");
            System.Threading.Thread.Sleep(3000);
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
            Plant3DFunctions.SetToDefault();
        }

    }
}
