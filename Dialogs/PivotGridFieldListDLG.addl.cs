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
    public partial class PivotGridFieldListDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            //Tag = "DevExpress.XtraPivotGrid.Customization.CustomizationForm|#2";
            Tag = "[Pane]PivotGrid Field List|#2";

        }

		public  void Invoke()
		{
            PropertyEditorLayoutGridPreviewDLG PropertyEditorLayoutGridPreviewDLG = new PropertyEditorLayoutGridPreviewDLG();
            PropertyEditorLayoutGridPreviewDLG.Invoke();

            PropertyEditorLayoutGridPreviewDLG.ShowFieldsselectorPB.Click();
			PivotGridFieldListDLG PivotGridFieldListDLG = new PivotGridFieldListDLG();
			PivotGridFieldListDLG.SetActive();
		}

		public  void Dismiss()
		{
			PivotGridFieldListDLG PivotGridFieldListDLG = new PivotGridFieldListDLG();
			PivotGridFieldListDLG.TypeKeys("<Alt-F4>");
            PropertyEditorLayoutGridPreviewDLG PropertyEditorLayoutGridPreviewDLG = new PropertyEditorLayoutGridPreviewDLG();
            if (PropertyEditorLayoutGridPreviewDLG.Exists)
            {
                PropertyEditorLayoutGridPreviewDLG.SetActive();
                PropertyEditorLayoutGridPreviewDLG.Dismiss();
            }
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();

            if (ReportDesignerApplicationDLG.Exists)
            {
                ReportDesignerApplicationDLG.SetActive();
                ReportDesignerApplicationDLG.Dismiss();
            }
            

        }
    }
}
