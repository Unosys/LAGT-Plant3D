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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PreviewSearchDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$PrintPreviewFormExBase";

        }

		public void Invoke()
		{
			ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
			ReportCreatorDLG.Invoke();
			ReportCreatorDLG.SetActive();
			ReportCreatorDLG.M_projectCmbBox.TypeKeys("<F4><Down 2><Enter>");
			ReportCreatorDLG.SetActive();
			ReportCreatorDLG.M_repConfigCmbBox.TypeKeys("<F4><Down 2><Enter>");
			ReportCreatorDLG.SetActive();
			ReportCreatorDLG.M_projectDataRadioBtn.Click();
			ReportCreatorDLG.SetActive();
			ReportCreatorDLG.M_dwgsTreeView.Select("/" + AcMainWin.cBabel(23031, 3, "Plant 3D Drawings"));
			ReportCreatorDLG.SetActive();
			ReportCreatorDLG.TypeKeys("<Space>");
			ReportCreatorDLG.M_previewBtn.Click();
			System.Threading.Thread.Sleep(30000);
			this.SearchPB.Click();
		}

		public void Dismiss()
		{
			this.SetActive();
			this.Close1PB.Click();
			this.Close2PB.Click();
			ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
			ReportCreatorDLG.Dismiss();
		}
	}
}
