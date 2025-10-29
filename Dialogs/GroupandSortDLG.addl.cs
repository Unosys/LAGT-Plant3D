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
    public partial class GroupandSortDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$groupAndSortDockPanel1";

        }

		public  void Invoke()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Invoke();
			
			ReportDesignerApplicationDLG.TypeKeys("<Ctrl-n>");
			System.Threading.Thread.Sleep(2000);
			GroupandSortDLG GroupandSortDLG = new GroupandSortDLG();
            //if (!this.Exists)
            //{

                ReportDesignerApplicationDLG.RibbonTabsPG.Select(3);//View tab
                System.Threading.Thread.Sleep(2000);
                ReportDesignerApplicationDLG.WindowsMI.Click();
                System.Threading.Thread.Sleep(1000);
                ReportDesignerApplicationDLG.GroupAndSortPB.Click();
            //}
            this.SetSize();
        }

        public  void Dismiss()
		{
			GroupandSortDLG GroupandSortDLG = new GroupandSortDLG();
			GroupandSortDLG.SetActive();
            GroupandSortDLG.Close();
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
        public void SetSize()
        {
            RECT r = this.GetRect(true);
            Desktop.Current.PressMouse(MouseButton.Left, r.xPos+r.xSize/2, r.yPos+1);
            Desktop.Current.ReleaseMouse(MouseButton.Left, r.xPos + r.xSize / 2, r.yPos - 200);
            System.Threading.Thread.Sleep(1000);
            //Desktop.Current.BeginDragAt(MouseButton.Left, r.xPos + r.xSize / 2, r.yPos+1);
            //Desktop.Current.EndDragAt(r.xPos + r.xSize / 2, r.yPos-300);
            
            //Desktop.Current.ReleaseMouse(MouseButton.Left, r.xPos+300, r.yPos-300);
        }
        public void Close()
        {
            GroupandSortDLG GroupandSortDLG = new GroupandSortDLG();

            RECT r = GroupandSortDLG.GetRect(true);
            Desktop.Current.Click(MouseButton.Right, r.xPos + 5, r.yPos + 5);
            Desktop.Current.TypeKeys("<Up><Enter>");


        }

    }
}
