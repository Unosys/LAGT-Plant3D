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
    public partial class ProjectSynchronizedToVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "~ActiveApp/[DialogBox]" + AcMainWin.cBabel(23165,15,"Project Synchronized to Vault");
		}

		public override void Invoke()
		{
			Plant3DFunctions.OpenProjectFromVault() ;
			Plant3DFunctions.CreateVaultDrawing("P3D","no","abc");
			Drawing.Current.TypeE("_PLANTPIPEADD");
			Drawing.Current.TypeE("20");
			Drawing.Current.TypeE("100");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("");
			Plant3DFunctions.CreateVaultDrawing("P3D","no","abc1");
			Drawing.Current.TypeE("_PLANTPIPEADD");
			Drawing.Current.TypeE("20");
			Drawing.Current.TypeE("100");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("_PLANTSYNCHRONIZETOVAULT");
			System.Threading.Thread.Sleep(5000);
			SynchronizeProjectToServerDLG SynchronizeProjectToServerDLG = Current<SynchronizeProjectToServerDLG>();
			SynchronizeProjectToServerDLG.SetActive();
			SynchronizeProjectToServerDLG.TypeKeys("<Enter>");
			System.Threading.Thread.Sleep(5000);
			SynchronizeUpDLG SynchronizeUpDLG = Current<SynchronizeUpDLG>();
			SynchronizeUpDLG.SetActive();
			SynchronizeUpDLG.Yes.Click();
			System.Threading.Thread.Sleep(5000);
			ProjectSynchronizedToVaultDLG ProjectSynchronizedToVaultDLG = Current<ProjectSynchronizedToVaultDLG>();
			ProjectSynchronizedToVaultDLG.SetActive();
		}

		public override void Dismiss()
		{
			ProjectSynchronizedToVaultDLG ProjectSynchronizedToVaultDLG = Current<ProjectSynchronizedToVaultDLG>();
			ProjectSynchronizedToVaultDLG.SetActive();
			ProjectSynchronizedToVaultDLG.DirectUIHWND1.CtrlNotifySink2.OK.Click();
			Plant3DFunctions.SetToDefault();
		}

        // public partial class DirectUIHWND1Class : CustomWin
        // {
            //  partial void OnInitialize()
            // {
            // }
        // }

        // public partial class CtrlNotifySink1Class : CustomWin
        // {
            //  partial void OnInitialize()
            // {
            // }
        // }

        // public partial class CtrlNotifySink2Class : CustomWin
        // {
            //  partial void OnInitialize()
            // {
            // }
        // }
    }
}
