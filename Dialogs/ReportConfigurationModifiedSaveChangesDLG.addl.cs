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
    public partial class ReportConfigurationModifiedSaveChangesDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$MessageForm";
		}

		public void Invoke()
		{
			NewReportConfigurationDLG NewReportConfigurationDLG = new NewReportConfigurationDLG();
			NewReportConfigurationDLG.Invoke();
			NewReportConfigurationDLG.M_blankReportRadioBtn.Click();
			NewReportConfigurationDLG.M_okBtn.Click();
			ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();
			ReportConfigurationDLG.M_editQryBtn.Click();
			QueryConfigurationDLG QueryConfigurationDLG = new QueryConfigurationDLG();
			QueryConfigurationDLG.SetActive();
            QueryConfigurationDLG.MaximizePB.Click();
            QueryConfigurationDLG.CancelPB.Click();
            System.Threading.Thread.Sleep(2000);
            ReportConfigurationDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            RECT r = ReportConfigurationDLG.ReportConfigurationCB.GetRect(true);
            ReportConfigurationDLG.ReportConfigurationCB.DoubleClick(MouseButton.Left,r.xPos+r.xSize-5,5);
            System.Threading.Thread.Sleep(2000);
            if (!this.Exists) {
				Desktop.Current.Click(MouseButton.Left, r.xPos + r.xSize - 5, r.yPos+5);

            }
			//ReportConfigurationDLG.M_repConfigCmbBox.Click();
			//System.Threading.Thread.Sleep(2000);
			//ReportConfigurationDLG.DropDownButtonPB.Click();
			
			this.SetActive();
        }

		public void Dismiss()
		{
			ReportConfigurationModifiedSaveChangesDLG ReportConfigurationModifiedSaveChangesDLG = new ReportConfigurationModifiedSaveChangesDLG();
			ReportConfigurationModifiedSaveChangesDLG.M_noBtn.Click();
			System.Threading.Thread.Sleep(3000);
			ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();
			ReportConfigurationDLG.SetActive();
			ReportConfigurationDLG.TypeKeys("<Esc>");
			ReportConfigurationDLG.Dismiss();
			System.Threading.Thread.Sleep(1000);
		}
    }
}
