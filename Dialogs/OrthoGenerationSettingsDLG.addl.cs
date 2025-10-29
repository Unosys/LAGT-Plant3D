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
    public partial class OrthoGenerationSettingsDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$OrthoGenerationSettingsDlg";
		}

		public void Invoke()
		{
            ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = new ProjectSetupTitleBlockandDisplayDLG();
            ProjectSetupTitleBlockandDisplayDLG.Invoke();
            ProjectSetupTitleBlockandDisplayDLG.BtnSetupBlk.Click();
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_PLANTORTHOTEMPLATESETTINGS");
            
		}

		public void Dismiss()
		{
            OrthoGenerationSettingsDLG OrthoGenerationSettingsDLG = new OrthoGenerationSettingsDLG();
            OrthoGenerationSettingsDLG.BtnCancel.Click ();
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_close");
            System.Threading.Thread.Sleep(10000);
            ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = new ProjectSetupTitleBlockandDisplayDLG();
            ProjectSetupTitleBlockandDisplayDLG.SetActive();
            ProjectSetupTitleBlockandDisplayDLG.Dismiss();
		}
    }
}
