// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
    public partial class Plant3DProjectDrawingsContainExternalReferencesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2017";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[DialogBox]" + AcMainWin.cBabel(23031,14, "Plant 3D Project - Drawing(s) Contain External References").Replace("*","-").Replace("/", "*");
        }

        public override void Invoke()
        {
            //Plant3DFunctions.CopyDrawing("a.dwg");
            ProjManUndocked projectmanagerDLG = new ProjManUndocked();
            projectmanagerDLG.SetActive();
            Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,2");
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir+"" + "a.dwg");
            SelectDrawingsToCopyToProDLG.Open.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public override void Dismiss()
        {
            Plant3DProjectDrawingsContainExternalReferencesDLG Plant3DProjectDrawingsContainExternalReferencesDLG = new Plant3DProjectDrawingsContainExternalReferencesDLG();
            Plant3DProjectDrawingsContainExternalReferencesDLG.Cancel.Click();
            PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            PROJECTMANAGERDLG.Dismiss();
        }
    }
}
