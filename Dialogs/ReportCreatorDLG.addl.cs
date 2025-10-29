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
using System.Diagnostics;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReportCreatorDLG : Autodesk.GUIHarness.MainWin
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[MainWin]$MainForm";
        }

        public void Invoke()
        {
            string Plant3DProgessName = "acad";
            Process[] prc = Process.GetProcesses();
            foreach (Process pr in prc)
            {
                string a = pr.ProcessName;
                if (Plant3DProgessName == pr.ProcessName)
                {
                    pr.Kill();
                    System.Threading.Thread.Sleep(3000);
                }
            }
            ////////////////////
            string sPath = LAGT.CommonFiles.Product.Variables.ProductLocation;
            if (!sPath.EndsWith("\\"))
                sPath += "\\";
            sPath += "PLNT3D\\PnPReportCreator.exe";
            ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
            if (ReportCreatorDLG.Exists)
            {

                //Process.Start("Taskkill /f /im PnPReportCreator.exe");
                Process[] procArr = Process.GetProcessesByName("PnPReportCreator"); //ReportCreator
                if (procArr.Length > 0)
                {
                    foreach (Process proc in procArr)
                    {
                        proc.Kill();
                        //Console.WriteLine(proc + "killed\n");
                    }

                }
            }
           
            Process.Start(sPath);
            System.Threading.Thread.Sleep(5000);

            var SettingsDLG= new SettingsDLG();
            if (SettingsDLG.Exists) {
                SettingsDLG.M_cancelBtn.Click();
                System.Threading.Thread.Sleep(1000);
            }
            ReportCreatorDLG.SetActive();
        }

        public void Dismiss()
        {
            System.Threading.Thread.Sleep(5000);
            ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
            if (ReportCreatorDLG.Exists)
            {
                ReportCreatorDLG.SetActive();
                ReportCreatorDLG.Close1PB.Click();
            }
            System.Threading.Thread.Sleep(2000);
            if (ReportCreatorDLG.Exists)
            {
                ReportCreatorDLG.SetActive();
                ReportCreatorDLG.Close2PB.Click();
            }

        }
        public void Invoke1()//don't close ACAD
        {
           
            string sPath = LAGT.CommonFiles.Product.Variables.ProductLocation;
            if (!sPath.EndsWith("\\"))
                sPath += "\\";
            sPath += "PLNT3D\\PnPReportCreator.exe";
            ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
            if (ReportCreatorDLG.Exists)
            {

                //Process.Start("Taskkill /f /im PnPReportCreator.exe");
                Process[] procArr = Process.GetProcessesByName("PnPReportCreator"); //ReportCreator
                if (procArr.Length > 0)
                {
                    foreach (Process proc in procArr)
                    {
                        proc.Kill();
                        //Console.WriteLine(proc + "killed\n");
                    }

                }
            }

            Process.Start(sPath);
            ReportCreatorDLG.SetActive();
        }
    }
}
