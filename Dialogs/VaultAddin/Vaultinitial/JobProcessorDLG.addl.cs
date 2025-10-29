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
//using System.Management;
using System.Diagnostics;

using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class JobProcessorDLG : MainWin
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
            //if (closeclient)
            //{
            //    VaultPro VaultPro = new VaultPro();
            //    if (VaultPro.Exists)
            //    {
            //        VaultPro.Exit();
            //    }
            //}

            System.Threading.Thread.Sleep(1500);
            string autoloaderProgessName = "JobProcessor";
            Process[] prc = Process.GetProcesses();
            foreach (Process pr in prc)
            {
                if (autoloaderProgessName == pr.ProcessName)
                {
                    pr.Kill();
                    System.Threading.Thread.Sleep(3000);
                }
            }

            Process autoloaderProcess = new Process();
            autoloaderProcess.StartInfo.FileName = LAGT.CommonFiles.Product.Variables.ProductLocation + "JobProcessor.exe";
            autoloaderProcess.Start();

            for (int i = 0; i < 6; i++)
            {
                JobProcessor_FirstSettings JobProcessor_FirstSettings = new JobProcessor_FirstSettings();
                if (JobProcessor_FirstSettings.WaitExists(5000))
                {
                    JobProcessor_FirstSettings.UserNameTF.SetText(VaultProFunctions.GetAdministratorLocal());
                    JobProcessor_FirstSettings.ServerTF.SetText("localhost");
                    JobProcessor_FirstSettings.OKPB.Click();
                    System.Threading.Thread.Sleep(5000);
                    this.SetActive();
                    break;
                }
                else
                {
                    if (this.WaitExists(5000))
                    {
                        this.SetActive();
                        break;
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(5000);
                    }
                }
            }

            try
            {
                this.Move(0, 0);
            }
            catch
            {
            }
            
            if (!File.Exists(@"C:\temp\FirstJobProcessor.txt"))
            {
                System.Threading.Thread.Sleep(65000);
                File.Create(@"C:\temp\FirstJobProcessor.txt").Close();
            }
            else
            {
                System.Threading.Thread.Sleep(15000);
            }
        }

		public void Dismiss()
		{
            JobProcessorDLG JobProcessorDLG = new JobProcessorDLG();
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
                    JobProcessorDLG.TypeKeys("<Alt><Down><Up><Enter>", 250);
                    break;
                default:
                    VaultProFunctions.Pick(JobProcessorDLG, "filejb", "exitjb");
                    break;
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
