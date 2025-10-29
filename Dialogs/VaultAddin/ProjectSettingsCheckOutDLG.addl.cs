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
    public partial class ProjectSettingsCheckOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[MainWin]" + AcMainWin.cBabel(23165,14,"Project Settings Check Out");
		}

		public override void Invoke()
		{
            Plant3DFunctions.OpenVaultProject("TestVault");
            Drawing.Current.TypeE("PROJECTSETUP");
            ////ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
            ////PROJECTMANAGERDLG.SetActive();
            ////Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            ////Plant3DFunctions.ExpandTreeP3D(wTreeView, 0, "0,0,0");
            ////wTreeView.TypeKeys("<Down 10><Enter>");
            System.Threading.Thread.Sleep(3000);
            ProjectSettingsCheckOutDLG ProjectSettingsCheckOutDLG = new ProjectSettingsCheckOutDLG();
            ProjectSettingsCheckOutDLG.SetActive();

		}

		public override void Dismiss()
		{
            ProjectSettingsCheckOutDLG ProjectSettingsCheckOutDLG = new ProjectSettingsCheckOutDLG();
            ProjectSettingsCheckOutDLG.SetActive();
            ProjectSettingsCheckOutDLG.Close();
			Plant3DFunctions.SetToDefault(); 
		}
    }
}
