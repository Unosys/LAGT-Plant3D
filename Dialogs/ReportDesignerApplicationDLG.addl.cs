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
using System.IO;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReportDesignerApplicationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$XRDesignFormExBase";
        }

        public override void Invoke()
        {
            ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();
            ReportConfigurationDLG.Invoke();
            ReportConfigurationDLG.M_editReportLayoutBtn.Click();
            System.Threading.Thread.Sleep(10000);
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            int i = 0;
            while (!ReportDesignerApplicationDLG.Exists)
            {
                System.Threading.Thread.Sleep(10000);
                if (ReportDesignerApplicationDLG.Exists)
                {
                    break;
                }
                if (i > 5)
                {
                    break;
                }
                i++;
            }

            Desktop Desktop = new Desktop();
            Desktop.TypeKeys("<Tab><Enter>");
            System.Threading.Thread.Sleep(2000);
            //ReportDesignerApplicationDLG.NoPB.Click();
            if (ReportDesignerApplicationDLG.Exists)
            {
                System.Threading.Thread.Sleep(2000);
                ReportDesignerApplicationDLG.Maximize();
                ReportDesignerApplicationDLG.SetActive();
            }
            System.Threading.Thread.Sleep(5000);
            if (!File.Exists("C:\\temp\\CloseWindow.txt"))
            {
                ReportDesignerApplicationDLG.SetWorkspace();
                File.Create("C:\\temp\\CloseWindow.txt").Close();
            }

            ReportDesignerApplicationDLG.SetActive();
        }

        public override void Dismiss()
        {
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportLayoutModifiedSaveChangesDLG ReportLayoutModifiedSaveChangesDLG = new ReportLayoutModifiedSaveChangesDLG();
            ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();

            ReportDesignerApplicationDLG.SetActive();


            //if (ReportDesignerApplicationDLG.RestorePB.Exists)
            //{
            //    ReportDesignerApplicationDLG.RestorePB.Click();
            //}
            ReportDesignerApplicationDLG.ClosePB.Click();

            //ReportDesignerApplicationDLG.TypeKeys("<Alt-F4>");
            System.Threading.Thread.Sleep(2000);
            //Desktop Desktop = new Desktop();
            //Desktop.TypeKeys("<Tab><Enter>");

            System.Threading.Thread.Sleep(5000);
            if (ReportLayoutModifiedSaveChangesDLG.Exists)
            {
                ReportLayoutModifiedSaveChangesDLG.ClosePB.Click();
            }

            ReportConfigurationDLG.Dismiss();
        }
        public void SetWorkspace()
        {

            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportDesignerApplicationDLG.RibbonTabsPG.Select(3);//View tab
            System.Threading.Thread.Sleep(2000);
            ReportDesignerApplicationDLG.WindowsMI.Click();
            System.Threading.Thread.Sleep(1000);
            ReportDesignerApplicationDLG.TypeKeys("<Down><Space>");
            System.Threading.Thread.Sleep(3000);
            ReportDesignerApplicationDLG.WindowsMI.Click();
            ReportDesignerApplicationDLG.TypeKeys("<Down 2><Space>");
            System.Threading.Thread.Sleep(3000);
            ReportDesignerApplicationDLG.WindowsMI.Click();
            System.Threading.Thread.Sleep(3000);
            ReportDesignerApplicationDLG.TypeKeys("<Down 3><Space>");
            System.Threading.Thread.Sleep(2000);
            ReportDesignerApplicationDLG.WindowsMI.Click();
            ReportDesignerApplicationDLG.TypeKeys("<Down 4><Space>");
            System.Threading.Thread.Sleep(3000);
            ReportDesignerApplicationDLG.WindowsMI.Click();
            ReportDesignerApplicationDLG.TypeKeys("<Down 5><Space>");
            System.Threading.Thread.Sleep(3000);
            ReportDesignerApplicationDLG.WindowsMI.Click();
            ReportDesignerApplicationDLG.TypeKeys("<Down 6><Space>");
        }
    }
}
