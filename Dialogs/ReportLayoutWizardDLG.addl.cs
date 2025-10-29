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
    public partial class ReportLayoutWizardDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$WizardView";
        }

		public  void Invoke()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Invoke();
			ReportDesignerApplicationDLG.TypeKeys("<Ctrl-w>");
			System.Threading.Thread.Sleep(3000);
			ReportWizardDLG ReportWizardDLG = new ReportWizardDLG();
            ReportWizardDLG.RightNode1TVI.Click();      // need to be checked manually with addlspy
			ReportWizardDLG.RightNode1TVI.TypeKeys("<Space>"); 
            ReportWizardDLG.NextPB.Click();
            ReportWizardDLG.AddPB.Click();
            ReportWizardDLG.NextPB.Click();
		}

		public  void Dismiss()
		{
			ReportLayoutWizardDLG ReportLayoutWizardDLG = new ReportLayoutWizardDLG();
			ReportLayoutWizardDLG.SetActive();
			ReportLayoutWizardDLG.Close();
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Dismiss();
		}
        public void Close()
        {
            ReportLayoutWizardDLG ReportLayoutWizardDLG = new ReportLayoutWizardDLG();

            RECT r = ReportLayoutWizardDLG.GetRect(true);
            Desktop.Current.Click(MouseButton.Right, r.xPos + 5, r.yPos + 5);
            Desktop.Current.TypeKeys("<Up><Enter>");


        }
    }
}
