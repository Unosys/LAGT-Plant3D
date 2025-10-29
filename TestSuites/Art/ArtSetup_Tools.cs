using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using OptionSet;
using Autodesk.GUIHarness;
using LAGT.CommonFiles;
using ProductTestSuite.CommonFiles;
using Autodesk.GUIHarness.Core.AutoCAD;
using ProductTestSuite.CommonFiles.TestSuite.GlobalDlgBox;
using System.Diagnostics;
using Autodesk.GUIHarness.AutoCAD;


namespace Autodesk.GUIHarness.Plant3D.TestSuites.Art
{
    // Class responsible to initalize variables needed for testing the application under test.
    public class Setup_Tools : ISetup_Tools
    {
        private WatchDog2 Watcher;

        public Setup_Tools() {

            Watcher = new WatchDog2();
            Watcher.TimedOut += Watcher_TimedOut;
        }

        /// <summary>
        /// Implement time out process.
        /// </summary>
        void Watcher_TimedOut()
        {
            //Delegate operational 
            Process proc = Process.Start("Taskkill", string.Format("/F /IM {0}", LAGT.CommonFiles.Product.Variables.EXEName));
            proc.WaitForExit();

            Watcher.Stop();

            //throw new TimeoutException("Timeout reached....");
            //AdResultLog.Current.LogErrorInfo(string.Format("Test timed out after iRecoverBatWaitTime = {0} seconds.", Watcher.TimeOutValue));
            ////ResLog.ExceptLog ()
            //AdResultLog.Current.ExceptLog(new Exception(""));

            //if (Harness.Current.AppWnd.Exists) Harness.Current.AppWnd.Exit();

            ////string sExeName = Harness.Current.AppWnd.CmdLine;
            //Type type = Harness.Current.AppWnd.GetType();
            //var wCurrentDialog = Activator.CreateInstance(type);
            //string sExeName = type.GetProperty("CmdLine", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic).ToString();

            //// Determination of testcase failed to be at DlgBox.cs code.
            //// Use LogError instead of LogFail here.
            //AdResultLog.Current.LogError(string.Format("Killing {0} in WatchdogClass.Watch(): Test Timed out so for good measure we are killing {0} process", Harness.Current.AppWnd.Project));

            //Process proc = Process.Start("Taskkill", string.Format("/F /IM {0}", sExeName));
            //proc.WaitForExit();
            //proc = Process.Start("Taskkill", "/F /IM senddmp.exe");
            //proc.WaitForExit();
            //proc = Process.Start("Taskkill", "/F /IM AcHelp.exe");

            //bool sTrueCoverage = Product.Variables.TrueCoverage;
            //if (sTrueCoverage)
            //{
            //    Process procTruC = Process.Start("Taskkill", "/F /IM NmStart.exe");
            //    procTruC.WaitForExit();
            //}
        

           
        }

        // Variable to hold the product harness for use of the event triggers,
        // since those in CoreHarness are set to private.
        // Essentially, most of the triggers has to be duplicated over to the product Harness.
        // Implemenation of RunLoop in CoreHarness & AGT Tool UI does not fit the requirements for localization;
        // 1. Manual selection of tests to run still needed, however automation is required in LOC.
        // Too much overheads involved tbh; below variable just to call the event triggers is too much overhead.
        // Harness.Current will simply be just to reference the variables only. Another big flaw - what's the point
        // to reference CoreHarness then??
        // Simply, the structure requirements of a CoreHarness for LOC is fundamentally different from that of 
        // AGT's CoreHarness......
        private Plant3DHarness prodHarness;

        public void ScriptEnter()
        {
            prodHarness.FireTestBeginEvent();
            Watcher.Start();
        }

        public void ScriptExit()
        {
            prodHarness.FireTestExitEvent();
            Watcher.Stop();
        }

        public void TestCaseEnter()
        {
            prodHarness.FireTestCaseEnterEvent();
            Watcher.Start();
        }

        public void TestCaseExit()
        {
            Watcher.Start();
        }

        /// <summary>
        /// Sets up the following files; Result-Logging, Error output file, Core Library, Babel, Product Harness, static list of dialogs to be tested.
        /// </summary>
        public void setHarnessLibrary()
        {
            // Initialize the product-specific ResultLogLOC class
            // and assign corresponding variables.
            
            AdResultLog.setErrorLogging(new AcResultLog());
            
            // Retrieves the static variable - Path for use in Library initialization
            OptionSets.appWndPath = Dialogs.Plant3D.Path;
            // Initialize the Core Library
            OptionSets.ESCLib = new ESC_AClib();
            // Initialize the Babel Engine
            getBabelEngine();
            Methods.setBabel();
            // Initialize the TypeTree. Note that this must be called AFTER the derived harness
            // is loaded but before it is instantiated. Hence it can't be moved to the static initializer.
            Harness.Initialize();
            // Initialize the product-specific Harness
            prodHarness = new Plant3DHarness();
            prodHarness.InitializeAppWnd();
            // Initialize the product-specific DlgBox files.
            InitArtAutoamtionFiles();
        }

        /// <summary>
        /// Initializes the BabelEngine.
        /// </summary>
        public void getBabelEngine()
        {
            // Hard-coded Name to by-pass AppWnd.Name since it is not yet instantiated.
            // Overhead involved
            // Ensuring this string value is the same value in the declared AppWnd.
            AcBabel.Name = LAGT.CommonFiles.Product.Variables.ProductName;
            OptionSets.BabelEngine = new AcBabel();
        }

        /// <summary>
        /// Set-up the product-specific dialog files to be tested.
        /// </summary>
        //public void InitDlgBoxFiles()
        //{
        //    //OptionSets.dlgSetup = new DlgBox_Setup();
        //    //OptionSets.dlgFilter = new DlgBox_FilteringLists();
        //    //OptionSets.dlgExceptions = new DlgBox_Exceptions();
        //}

        /// <summary>
        /// Set-up the product-specific dialog files to be tested.
        /// </summary>
        public void InitArtAutoamtionFiles()
        {
            ArtOptionSets.ArtAutomationSetup = new ArtAutomation_Setup();
            
        }
       
        public void GA()
        {
            Assembly testAssembly = Assembly.LoadFrom(LAGT.CommonFiles.Core.Variables.AssemblyDir + "\\" + Product.Variables.ProductName + ".dll");
            if (testAssembly == null)
                throw new Exception("Assembly not found. Check the Assembly path in Settings.");
            // Search through the Assembly to find the Setup_Tools class, instantiate it, setup Library files.
            Type SetupType = typeof(ISetup_Tools);
            foreach (Type stype in testAssembly.GetExportedTypes().Where(stype => stype.IsPublic && !stype.IsAbstract && SetupType.IsAssignableFrom(stype)))
            {
                Console.WriteLine(stype.Assembly);
                Console.WriteLine(stype.ToString());
                if (stype.FullName.ToString().ToLower().Contains(LAGT.CommonFiles.AutomationTests.Variables.AutomationType.ToLower()))
                {
                    try
                    {
                        object obj = Activator.CreateInstance(stype);
                        HarnessSetup_Tools.setupTools = obj as ISetup_Tools;
                        HarnessSetup_Tools.setupTools.setHarnessLibrary();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Exception thrown");
                    }
                }
            }
        }
    }
}
