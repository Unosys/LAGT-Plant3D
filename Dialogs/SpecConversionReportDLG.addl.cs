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
    public partial class SpecConversionReportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$SpecMigrationErrorReportWindow";
		}

		public override void Invoke()
		{
			SpecandCatalogsConversionCompleteDLG SpecandCatalogsConversionCompleteDLG = new SpecandCatalogsConversionCompleteDLG();
			SpecandCatalogsConversionCompleteDLG.Invoke();
            SpecandCatalogsConversionCompleteDLG.ViewTheConversionReportST.Click(MouseButton.Left,10,10);
			System.Threading.Thread.Sleep(2000);
            SpecConversionReportDLG SpecConversionReportDLG = new SpecConversionReportDLG();
			while (!SpecConversionReportDLG.Exists);
			System.Threading.Thread.Sleep(1000);
			SpecConversionReportDLG = new SpecConversionReportDLG();
			SpecConversionReportDLG.SetActive();
		}

		public override void Dismiss()
		{
			SpecConversionReportDLG SpecConversionReportDLG = new SpecConversionReportDLG();
			SpecConversionReportDLG.SetActive();
            SpecConversionReportDLG.Close2PB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Dismiss();
		}
    }
}
