using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Diagnostics;

using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.Dialogs.General;
using Autodesk.GUIHarness.AutoCAD;
using LAGT.CommonFiles;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using Microsoft.Win32;
using Autodesk.GUIHarness.Plant3d.Core;
using static System.Windows.Forms.AxHost;

namespace Autodesk.GUIHarness.Plant3D
{
    public class Plant3DMainWin : AcMainWin
    {
        public static String sDefaultProjPath = null;
        public Plant3DMainWin()
        {
            //Change .reg file used.
            RegBaseDir = LAGT.CommonFiles.Product.Variables.ProductName;
            RegFile = LAGT.CommonFiles.Product.Variables.ProductName + ".reg";
            Args = "/product PLNT3D";
            Project = "Plant3D";
        }

        static bool flag = false;


        public static string PcName
        {
            get
            {
                return Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", "") as string;
            }
        }

        /// <summary>
        /// Initializes support path variables, command line variables, starts Autocad Mechanical.
        /// </summary>
        /// <param name="bLeaveStartupWizardOpen">true to leave the StartupWizard open.  Default is false.(bool Optional)</param>
        public override void Initialize(bool bLeaveStartupWizardOpen = false)
        {

            //// kill existing processes
            //Start("taskkill /f /im acad.exe");
            //Start("taskkill /f /im AutoCADPlant3DCatalogBuilder.exe");
            //Start("taskkill /f /im Senddmp.exe"); //Make sure there is not any other CER instance running
            //Start("taskkill /f /im SpecsAndCatalogsEditor.exe"); //Make sure there is not any other Plant3D Spec Editor instance running
            //Start("taskkill /f /im PnPReportCreator.exe");//Make sure there is not any other Plant Report Creator instance running
            //Start("taskkill /f /im AdAppMgrSvc.exe"); //Make sure there is not any other Autodesk Application Manager instance running
            //Start("taskkill /f /im AcWebBrowser.exe"); //Make sure there is not any other Spec Editor component instance running
            ErrorReport ErrorReport = new ErrorReport();
            if (ErrorReport.Exists)
            {
                ErrorReport.Dismiss();
                System.Threading.Thread.Sleep(5000);
            }
            string ErrorReport1 = "cer_dialog";
            Process[] prc3 = Process.GetProcesses();
            foreach (Process pr in prc3)
            {
                //Console.WriteLine(pr.ProcessName);
                if (ErrorReport1 == pr.ProcessName)
                {
                    pr.Kill();
                    System.Threading.Thread.Sleep(3000);
                }
            }
            ////Kill CatalogBuilder---------------------------------
            string CatalogBuilder = "AutoCADPlant3DCatalogBuilder";
            Process[] CatalogBuilderprc = Process.GetProcesses();
            foreach (Process pr in CatalogBuilderprc)
            {
                if (CatalogBuilder == pr.ProcessName)
                {
                    pr.Kill();
                    System.Threading.Thread.Sleep(3000);
                }
            }
            ////Kill StyleEditor----------------------------
            System.Threading.Thread.Sleep(2000);
            IsoStyleEditorDLG IsoStyleEditorDLG = new IsoStyleEditorDLG();
            if (IsoStyleEditorDLG.WaitExists(500))
            {
                Process[] procArr2 = Process.GetProcessesByName("PnPIsoConfigEditor");
                if (procArr2.Length > 0)
                {
                    foreach (Process proc2 in procArr2)
                    {
                        proc2.Kill();

                    }
                }
            }
            ////kill SpecEditor-----------------------------------
            System.Threading.Thread.Sleep(5000);
            string SpecEditor = "SpecsAndCatalogsEditor";
            Process[] prc1 = Process.GetProcesses();
            foreach (Process pr1 in prc1)
            {
                if (SpecEditor == pr1.ProcessName)
                {
                    pr1.Kill();
                    System.Threading.Thread.Sleep(3000);
                }
            }
            ////Kill  Report Creator-------------------------------
            System.Threading.Thread.Sleep(5000);
            string reportCreator = "PnPReportCreator";
            Process[] prc = Process.GetProcesses();
            foreach (Process pr in prc)
            {
                if (reportCreator == pr.ProcessName)
                {
                    pr.Kill();
                    System.Threading.Thread.Sleep(3000);
                }
            }

            if (Exists)
            {
                Exit();
            }
            if (bLeaveStartupWizardOpen)
                return;

            // Let's try to define reasonable support paths if they're not already defined

            string sSupportPath = "";

            if (Product.Variables.ProductLocation != "")
            {
                sSupportPath = Product.Variables.ProductLocation;
            }
            else if (OverrideSupportPath != null)
            {
                sSupportPath = OverrideSupportPath;
            }
            else
            {
                // New support paths needed by Plant3D
                string sNewSupportPaths = Path.Combine(LocalRootFolder, "Support") + ";" +
                                          Path.Combine(RoamableRootFolder, "Support");

                sSupportPath = Dialogs.Plant3D.Path + ";" +
                               Path.Combine(Dialogs.Plant3D.Path, "support") + ";" +
                               sNewSupportPaths + ";" +
                               Path.Combine(Dialogs.Plant3D.Path, "fonts") + ";" +
                               Path.Combine(Dialogs.Plant3D.Path, "drv") + ";" +
                               Path.Combine(Dialogs.Plant3D.Path, "help") + ";" +
                               Path.Combine(Dialogs.Plant3D.Path, "Express");
            }

            string sStartCmd;
            if (File.Exists(Path.Combine(Dialogs.Plant3D.Path, "launchacad.exe")))
            {
                sStartCmd = Path.Combine(Dialogs.Plant3D.Path, "launchacad.exe");
            }
            else
            {
                sStartCmd = CmdLine;
                // Add some quotes for spaces in path
                //if (sStartCmd[0] != '\"')
                //    sStartCmd = "\"" + sStartCmd;
                //if (sStartCmd[sStartCmd.Length - 1] != '\"')
                //    sStartCmd += "\"";

                if (sSupportPath[0] != '\"')
                    sSupportPath = "\"" + sSupportPath;
                if (sSupportPath[sSupportPath.Length - 1] != '\"')
                    sSupportPath += "\"";
            }


            Environment.CurrentDirectory = Dialogs.Plant3D.Path;

            //string templateFilePath = GetFullTemplatePath(mAcadTemplateFile.Name, true);
            //if (!File.Exists(templateFilePath))
            //    mAcadTemplateFile.CopyTo(templateFilePath);

            Start(sStartCmd, Args + " /nologo", bLeaveStartupWizardOpen);
            //Start(sStartCmd, Args + " /s " + sSupportPath + " /nologo", bLeaveStartupWizardOpen);
            //Start(sStartCmd, Args + " /s " + @"C:\Users\Public\Documents\Autodesk\AutoCAD Mechanical 2015\Acadm\Gef\Gdb", bLeaveStartupWizardOpen);
            if (!File.Exists("c:\\Temp\\MakeCommandLineDock.txt"))
            {
                Autodesk.GUIHarness.AutoCAD.Dialogs.CmdWnd CmdWnd = new Autodesk.GUIHarness.AutoCAD.Dialogs.CmdWnd();
                if (!CmdWnd.IsDocked)
                {
                    //CmdWnd.Dock();
                    MakeCLIDocked();
                }

                File.Create("c:\\Temp\\MakeCommandLineDock.txt");
            }
            if (bLeaveStartupWizardOpen)
                return;
            var appwnd = Harness.Current.AppWnd;
            if (!appwnd.Exists)
            {
                Initialize();
            }
            //Plant Collaboration config setting FY25
            string initializecheck = "C:\\temp\\";
            string sPath = LAGT.CommonFiles.Product.Variables.ProductLocation + "PLNT3D\\PnpCloudConfig.json";
            if (!File.Exists(initializecheck + "PlantCollaborationconfig.txt"))
            {
                if (File.Exists(sPath))
                {

                    File.Copy(LAGT.CommonFiles.Product.Variables.TestFilesDir + "Plant Collaboration config\\PnpCloudConfig.json", sPath, true);
                }
                File.Create(initializecheck + "PlantCollaborationconfig.txt").Close();
                //login with user : locvend2_3@npisimulation.com  PW: PasswordL2

            }
            //if (Plant3dConstants.testbranch == "VaultAddin")
            //{
            //    VaultInitialize();
            //    LogInDLG LogInDLG = new LogInDLG();
            //    if (LogInDLG.Exists)
            //    {
            //        LogInDLG.SetActive();
            //        LogInDLG.UserNameTF.ClearText();
            //        LogInDLG.UserNameTF.SetText(Plant3DFunctions.GetLocString("Administrator"));
            //        LogInDLG.OKPANE.Click();
            //        System.Threading.Thread.Sleep(20000);
            //    }

            //    while (!Drawing.Current.ReadyForNextCommand())
            //    {
            //        System.Threading.Thread.Sleep(10000);
            //    }
            //    if (!File.Exists("C:\\temp\\CreateVaultProject.txt"))
            //    {
            //        Plant3DFunctions.CreateVaultProject("TestVault");
            //        File.Create("C:\\temp\\CreateVaultProject.txt").Close();
            //    }
            //}
            if (Plant3dConstants.testbranch == "VaultAddin")
            {
                VaultInitialize();
                if (!appwnd.Exists)
                {
                    Initialize();
                }
                VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
                if (VaultLogInDLG.Exists)
                {

                    VaultLogInDLG.UserNameTextBox.ClearText();
                    VaultLogInDLG.UserNameTextBox.SetText(Plant3DFunctions.GetLocString("Administrator"));
                    VaultLogInDLG.OK.Click();
                    System.Threading.Thread.Sleep(10000);
                }
                LogInDLG LogInDLG = new LogInDLG();
                if (LogInDLG.Exists)
                {
                    LogInDLG.SetActive();
                    LogInDLG.UserNameTF.ClearText();
                    LogInDLG.UserNameTF.SetText(Plant3DFunctions.GetLocString("Administrator"));
                    LogInDLG.OKPANE.Click();
                    System.Threading.Thread.Sleep(10000);
                }
                VaultProjectError VaultProjectError = new VaultProjectError();
                ProjectRefreshFromVaultMSG ProjectRefreshFromVaultMSG = new ProjectRefreshFromVaultMSG();

                if (VaultProjectError.Exists)
                {
                    VaultProjectError.ClosePB.Click();
                }
                System.Threading.Thread.Sleep(3000);
                if (ProjectRefreshFromVaultMSG.Exists)
                {
                    ProjectRefreshFromVaultMSG.OKPB.Click();
                }
                System.Threading.Thread.Sleep(8000);
                while (!Drawing.Current.ReadyForNextCommand())
                {
                    System.Threading.Thread.Sleep(10000);
                }
                if (!File.Exists("C:\\temp\\CreateVaultProject.txt"))
                {
                    Plant3DFunctions.CreateVaultProject("TestVault");
                    File.Create("C:\\temp\\CreateVaultProject.txt").Close();
                }
            }
            var curDwg = Drawing.Current;
            System.Threading.Thread.Sleep(3000);
            if (curDwg == null) //AutoCAD started with no drawing
                Drawing.New(false);

            curDwg.Ready(10);
            curDwg.TypeE("(Command \"_-INPUTSEARCHOPTIONS\" \"_C\" \"_N\" \"_R\" \"_N\" \"_S\" \"_N\" \"_T\" \"_N\" \"_M\" \"_N\" \"\")");
            curDwg.Type("<ESC 5>");
            curDwg.TypeE("_.ToolPalettesClose"); //This is a command so we can't set it in the AutoCAD.reg. ESW states are stored in the profile.
            curDwg.TypeE("_.LayerClose");
            curDwg.TypeE("_.RibbonClose");
            curDwg.TypeE("_.PropertiesClose");
            curDwg.TypeE("_.Startup 0");
            curDwg.TypeE("_.Startmode 0");
            curDwg.TypeE("_filedia 0");

            var PROJECTMANAGERDLG = new Dialogs.PROJECTMANAGERDLG();
            var ProjManUndocked = new Dialogs.ProjManUndocked();
            PROJECTMANAGERDLG.Invoke();
            PROJECTMANAGERDLG.Undock();
            ProjManUndocked.SetSize();
            ProjManUndocked.SetPosition();

            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + AcadRoot + "\\" + AcadNumber, "DefaultProject", "") as string;
            sDefaultProjPath = sProjectPath;
            string sProjectName = sProjectPath + "Project.xml";
            curDwg.Ready(10);
            curDwg.TypeE("_openproject");
            curDwg.TypeE(sProjectName);

            Thread.Sleep(1000);

            ///////////////////////add in FY 2020 for default setting  Unnamed Profile 
            //FileInfo UnnamedProfile = new FileInfo(Path.Combine(new AcMainWin().CustomSupportPath, "Support", "Profiles", "Unnamed Profile", "profile.aws"));
            string UnnamedProfilepath = Path.Combine(new AcMainWin().CustomSupportPath, "Support", "Profiles", "Unnamed Profile");
            if (!Directory.Exists(UnnamedProfilepath))
            {

                Directory.CreateDirectory(UnnamedProfilepath);
            }

            Plant3DFunctions.DeleteAllDrawings();

            //prjManagerDlg.Dismiss();

            if (bLeaveStartupWizardOpen)
                return;

            curDwg.Ready(30);

            if (curDwg.Ready())
            {
                curDwg.TypeE("_TOOLPALETTESCLOSE");
                curDwg.TypeE("_SHEETSETHIDE");
                curDwg.TypeE("_.DrawingRecoveryHide");
            }

            //Drawing.Current.Ready();
        }
        public override void ArtInitialization()
        {
            //Set right color theme.
            //Autodesk.GUIHarness.AutoCAD.classes.ArtFunctions.PreSettingProductColor(Drawing.Current, 0);

            //Add other required per-settings here.


        }
        //public static string AcadNumber
        //{
        //    get
        //    {
        //        //TODO find this value automatically
        //        return "ACAD-F017:409";
        //        //return "ACAD-F017:804";
        //    }
        //}

        public void Start(string sStartCmd, string sArgs, bool bLeaveStartupDLGOpen = false, bool bLeaveAuthWizardOpen = false)
        {
            // Enable CLIPROMPTFORMAT for the command line support - this Required for GetCmdLine() to work
            Environment.SetEnvironmentVariable("CLIPROMPTFORMAT", "PLAIN"); // MEP17-184 - cannot be removed as AGT is not (yet) able to retrieve options if they are clickable objects
            using (Agent.SetOption(AgentOptions.OPT_WINDOW_TIMEOUT, STARTUP_WAIT))
            {
                //base.Start(sStartCmd, "", sArgs);
                base.Start(sStartCmd, "", Args + " /nologo");
            }
            System.Threading.Thread.Sleep(5000);
            ///////////////FY25////////////////////
            var LinceseGetStartedDLG = new Dialogs.LinceseGetStartedDLG();
            if (LinceseGetStartedDLG.Exists)
            {
                LinceseGetStartedDLG.lincese();
                System.Threading.Thread.Sleep(25000);
            }

            ////////////////////////////
            //New status dialog that appears and dismisses automatically. Just wait for it.
            //var verifyingLicenseDLG = new VerifyingLicenseDLG();
            // New Authcode is invalid message appears when the authcode in the CFG file is no
            // longer valid. You need to press OK to get the AuthorizationWizardBeginDLG dialog
            var configurationFileHasAuthCodeInvalidMSG = new ConfigurationFileHasAuthCodeInvalidMSG();
            var startupDLG = new StartupDLG();
            var appWnd = Harness.Current.AppWnd;

            if (!appWnd.WaitExists((int)Agent.GetOption(AgentOptions.OPT_APPREADY_TIMEOUT)))
            {
                throw new UIException(ExceptionType.CantStartApp, "AutoCAD Start Failure");
            }
            try
            {
                PrivacySettingsDLG PrivacySettingsDLG = new PrivacySettingsDLG();
                if (PrivacySettingsDLG.Exists)
                {
                    PrivacySettingsDLG.OKPB.Click();
                }
            }
            catch
            {
            }
            if (Plant3dConstants.testbranch == "VaultAddin")
            {
                LogInDLG LogInDLG = new LogInDLG();
                if (LogInDLG.Exists)
                {
                    LogInDLG.SetActive();
                    LogInDLG.UserNameTF.ClearText();
                    LogInDLG.UserNameTF.SetText(Plant3DFunctions.GetLocString("Administrator"));
                    LogInDLG.OKPANE.Click();
                    System.Threading.Thread.Sleep(10000);
                }

                while (!Drawing.Current.ReadyForNextCommand())
                {
                    System.Threading.Thread.Sleep(10000);
                }
                //if (!File.Exists("C:\\temp\\CreateVaultProject.txt"))
                //{
                //    Plant3DFunctions.CreateVaultProject("TestVault");
                //    File.Create("C:\\temp\\CreateVaultProject.txt").Close();
                //}
            }
            //Wait Plant3D Active
            int j = 0;
            while (j <= 30)
            {
                if (appWnd.IsEnabled)
                {
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(5000);
                }
                j++;
            }
            //var timer = 0;
            //while (true)
            //{
            //    try
            //    {
            //        var curDwg = Drawing.Current;
            //        if (curDwg != null)
            //        {
            //            curDwg.SetActive();
            //            break;
            //        }
            //    }
            //    catch (UIException)
            //    {
            //    }
            //    System.Threading.Thread.Sleep(5000);
            //    if (timer++ > 5)
            //        break;
            //}
            var curDwg = Drawing.Current;
            if (curDwg != null)
            {
                curDwg.SetActive();
            }
            appWnd.SetActive();
            if (curDwg == null)
                Drawing.New();

            new Talisman().Load();
            System.Threading.Thread.Sleep(2000);
            if ((int)Drawing.Current.GetSysVar("RIBBONSTATE") != 0)
                Drawing.Current.TypeE("_.RIBBONCLOSE");  //This is a command so we can't set it in the AutoCAD.reg. ESW states are stored in the profile.        
            Drawing.Current.TypeE("_ProjectManagerClose");
        }
        public void Restart()
        {
            Dialogs.Plant3D appwnd = new Dialogs.Plant3D();
            appwnd.Exit();

            System.Threading.Thread.Sleep(5000);
            string autoloaderProgessName = "Launch acad";
            Process[] prc = Process.GetProcesses();
            foreach (Process pr in prc)
            {
                if (autoloaderProgessName == pr.ProcessName)
                {
                    pr.Kill();
                    System.Threading.Thread.Sleep(3000);
                }
            }

            appwnd.Initialize();
        }
        public void Exit1()
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

        }
        public override void Exit()
        {
            //var curDwg = Drawing.Current;
            //try
            //{
            //    if (curDwg != null)
            //    {
            //        if (curDwg.Exists && curDwg.IsActive)
            //        {
            //            curDwg.TypeKeys("<Esc 5>");
            //            if (curDwg.GetSysVarI("SDI") != 1)
            //                CloseAllDrawings();
            //            Close();
            //            Thread.Sleep(2000);
            //            // TypeKeys("<Alt-F4>");
            //            if (Exists)
            //            {
            //                base.Exit();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        base.Exit();					
            //    }

            //    Thread.Sleep(2000);
            //    if (Exists)
            //    {
            //        Exit1();
            //    }
            //}
            //catch (UIException)
            //{
            //    string autoloaderProgessName = "acad";
            //    Process[] prc = Process.GetProcesses();
            //    foreach (Process pr in prc)
            //    {
            //        if (autoloaderProgessName == pr.ProcessName)
            //        {
            //            pr.Kill();
            //            System.Threading.Thread.Sleep(3000);
            //        }
            //    }
            //}
            if (Exists)
            {
                Exit1();
            }
            if (Exists)
            {
                Exit1();
            }
        }
        private void MakeCLIDocked()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd_Plant3D = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();

            AppWnd_Plant3D.TypeKeys("_quit");
            Exit();

            try
            {
                string profilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Autodesk\\";
                List<string> awsfiles = Directory.GetFiles(profilesPath, "Profile.aws", SearchOption.AllDirectories).ToList<string>();
                foreach (var awsFile in awsfiles)
                {
                    string originalContent = File.ReadAllText(awsFile);
                    string newContent = null;
                    if (originalContent.Contains("<CLI Dock=\""))
                    {
                        if (originalContent.Contains("<CLI Dock=\"AnchoredBottom\""))
                        {
                            newContent = originalContent.Replace("<CLI Dock=\"AnchoredBottom\"", "<CLI Dock=\"DockedInESW\"");
                        }
                        else if (originalContent.Contains("<CLI Dock =\"Floating\""))
                        {
                            newContent = originalContent.Replace("<CLI Dock=\"Floating\"", "<CLI Dock=\"DockedInESW\"");
                        }
                    }
                    else continue;
                    if (newContent != null)
                    {
                        File.Move(awsFile, awsFile + ".bak" + DateTime.Now.ToString("yyyyMMddHHmmss"));
                        File.WriteAllText(awsFile, newContent);
                    }
                }
            }
            catch (IOException e)
            {
                throw new Exception("Error occured at making CommandLine docked", e);
            }

        }

        public void VaultInitialize()
        {
            Thread.Sleep(2000);
            string initializecheck = "C:\\temp\\";
            DirectoryInfo dInfo = new DirectoryInfo(initializecheck);
            if (!dInfo.Exists)
            {
                dInfo.Create();
            }

            if (!File.Exists(initializecheck + "VaultInitializeFinished.txt"))
            {
                if (Exists)
                {
                    Exit();
                }
                VaultProInitialize.CreatedVault();
                if (!File.Exists(initializecheck + "InitializeVaultPro.txt"))
                {
                    VaultProInitialize.InitializeVault();
                    File.Create(initializecheck + "InitializeVaultPro.txt").Close();
                }
                File.Create(initializecheck + "VaultInitializeFinished.txt").Close();
            }


        }
        public void StartVault(string cmdLine = null)
        {
            int i = 0;
            int timeout = 180;

            if (!Exists)
            {
                if (cmdLine != null)
                    base.Start(cmdLine, null, null);
                else
                    base.Start(CmdLine, null, null);

                //Log in and select "Project Explorer"
                VC_LogInDLG VC_LogInDLG = new VC_LogInDLG();
                if (VC_LogInDLG.WaitExists())
                {
                    VaultProFunctions.LoginWithUserAndDataBase("admin", "vault");
                }

                VC_PrivacySettingsDLG VC_PrivacySettingsDLG = new VC_PrivacySettingsDLG();
                if (VC_PrivacySettingsDLG.WaitExists(2500))
                {
                    VC_PrivacySettingsDLG.OKPB.Click();
                }

                while (!Exists && (i++ < timeout)) // give at least 30 seconds to come up
                    Thread.Sleep(1000);

                if (!Harness.Current.AppWnd.WaitExists((int)Agent.GetOption(AgentOptions.OPT_APPREADY_TIMEOUT)))
                {
                    throw new UIException(ExceptionType.CantStartApp, "Vault product Start Failure");
                }
            }

            try
            {
                SetActive();
            }
            catch
            {
                throw new UIException(ExceptionType.AppNotResponding, "Vault Main window is not active or not responding");
            }

            try
            {
                Move(0, 0);
            }
            catch
            {
            }
            finally
            {
                Size(1100, 800);
                //VaultProCheckClientSatue.CheckVaultSatue();
                Thread.Sleep(2000);
            }

            string markcase = VaultProFunctions.tempFolder + "VM_ShareViewIAMPublishDLG.txt";
            if (File.Exists(markcase))
            {
                File.Delete(markcase);
            }
        }
        internal static string sProjectPath()
        {
            throw new NotImplementedException();
        }


    }
}
