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
    public partial class FieldListDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$fieldListDockPanel1";//Field List
        }

		public  void Invoke()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Invoke();		
			ReportDesignerApplicationDLG.TypeKeys("<Ctrl-N>");
            //if (!this.Exists) {
                ReportDesignerApplicationDLG.RibbonTabsPG.Select(3);//View tab
                System.Threading.Thread.Sleep(2000);
                ReportDesignerApplicationDLG.WindowsMI.Click();
                System.Threading.Thread.Sleep(1000);
                ReportDesignerApplicationDLG.FieldListPB.Click();
            //}
           
            


        }

		public  void Dismiss()
        {
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();

            this.Close();

            ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
        }
        public void Close()
        {
            FieldListDLG FieldListDLG = new FieldListDLG();

            RECT r = FieldListDLG.GetRect(true);
            Desktop.Current.Click(MouseButton.Right, r.xPos + 5, r.yPos + 5);
            Desktop.Current.TypeKeys("<Up><Enter>");


        }
    }
}
