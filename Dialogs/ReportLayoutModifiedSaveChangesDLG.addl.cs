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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReportLayoutModifiedSaveChangesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox//Autodesk.GUIHarness.Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$MessageForm";//Autodesk Report Creator for AutoCAD Plant 3D 2025|
        }

		public override void Invoke()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Invoke();
			ReportDesignerApplicationDLG.TypeKeys("<Ctrl-n>");
			System.Threading.Thread.Sleep(3000);
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.TypeKeys("<Alt-F4>");
		}

		public override void Dismiss()
		{
			ReportLayoutModifiedSaveChangesDLG ReportLayoutModifiedSaveChangesDLG = new ReportLayoutModifiedSaveChangesDLG();
			ReportLayoutModifiedSaveChangesDLG.SetActive();
			ReportLayoutModifiedSaveChangesDLG.NoPB.Click();
			System.Threading.Thread.Sleep(2000);
			ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();
			ReportConfigurationDLG.Dismiss();
		}
    }
}
