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
    public partial class ProjectSetupProjectDetailsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$EditProjectSettingsDlg";
           
        }

        public override void Invoke()
        {
            Drawing.Current.SetSysVar("SDI", 0);
           
            Drawing.Current.TypeE("_ProjectSetup");
           
			if (LAGT.CommonFiles.Product.Variables.Language == "CHS") {
			 System.Threading.Thread.Sleep(40000);
			}
			 System.Threading.Thread.Sleep(9000);
            try
            {
                this.Move(5, 5);
            }
            catch
            {
            }
            this.Size(1200,950);
            //Plant3DFunctions.treeViewSelect(this.M_treeView, AcMainWin.cBabel(23165, 8, "Project Details"));
            this.ProjectDetailsTVI.Click();
            System.Threading.Thread.Sleep(8000);

        }

        public override void Dismiss()
        {
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.SetActive();
            ProjectSetupProjectDetailsDLG.CancelPB.Click();
          
        }
        //public  void Move()
        //{
        //    ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
          
        //    RECT r = ProjectSetupProjectDetailsDLG.GetRect(true);
        //    if (r.xSize != xRestSize && r.ySize != yRestSize)
        //    {
        //        ProjectSetupProjectDetailsDLG.Click(MouseButton.Right, 8, 70);
        //        Desktop.Current.TypeKeys("<Down 2><Enter>", 500);
        //        Desktop.Current.TypeKeys("<Right><Down>");
        //        Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
        //    }

        //}

    }
}
