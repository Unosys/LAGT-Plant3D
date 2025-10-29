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
    public partial class DataFilterCollectionEditorAddDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$DataFilterCollectionForm";
		}

		public  void Invoke()
		{
			DataFilterCollectionEditorDLG DataFilterCollectionEditorDLG = new DataFilterCollectionEditorDLG();
			DataFilterCollectionEditorDLG.Invoke();
			System.Threading.Thread.Sleep(200);
            DataFilterCollectionEditorDLG.AddPB.Click();
			System.Threading.Thread.Sleep(500);
			DataFilterCollectionEditorAddDLG DataFilterCollectionEditorAddDLG = new DataFilterCollectionEditorAddDLG();
			DataFilterCollectionEditorAddDLG.SetActive();
		}

		public  void Dismiss()
		{
			DataFilterCollectionEditorAddDLG DataFilterCollectionEditorAddDLG = new DataFilterCollectionEditorAddDLG();
			DataFilterCollectionEditorAddDLG.SetActive();
			DataFilterCollectionEditorAddDLG.TypeKeys("<Alt-F4>");
            ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            ChartWizardChartDLG.SetActive();
            ChartWizardChartDLG.ClosePB.Click();// TypeKeys("<Alt-F4>");
            System.Threading.Thread.Sleep(500);
            Desktop Desktop = new Desktop();
            Desktop.TypeKeys("<Tab><Enter>");
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportDesignerApplicationDLG.SetActive();
            ReportDesignerApplicationDLG.Dismiss();
        }
    }
}
