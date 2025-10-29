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
    public partial class SynchronizeUpDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "~ActiveApp/[DialogBox]" + AcMainWin.cBabel(23165,16,"Synchronize Up");
		}

		public override void Invoke()
		{
			OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
			OpenProjectFromVaultDLG.Invoke();
            OpenProjectFromVaultDLG.VaultLocationLV.Select("Temp2");
            OpenProjectFromVaultDLG.OpenPB.Click();
            Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc");
			Drawing.Current.TypeE("_PLANTPIPEADD");
			Drawing.Current.TypeE("20");
			Drawing.Current.TypeE("100");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("_PLANTSYNCHRONIZETOVAULT");
			System.Threading.Thread.Sleep(5000);
			SynchronizeProjectToServerDLG SynchronizeProjectToServerDLG = new SynchronizeProjectToServerDLG ();
			SynchronizeProjectToServerDLG.SetActive();
            SynchronizeProjectToServerDLG.SaveAndCheckInPB.Click();
			System.Threading.Thread.Sleep(5000);
			SynchronizeUpDLG SynchronizeUpDLG = new SynchronizeUpDLG();
			SynchronizeUpDLG.SetActive();
		}

		public override void Dismiss()
		{
			SynchronizeUpDLG SynchronizeUpDLG = new SynchronizeUpDLG();
            if (SynchronizeUpDLG.Exists)
            {
                SynchronizeUpDLG.Close();
            }			
            Plant3DFunctions.SetToDefault();
		}
    }
}
