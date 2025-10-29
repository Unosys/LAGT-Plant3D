using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using OptionSet;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.Core;
using ProductTestSuite.CommonFiles;
using ProductTestSuite.CommonFiles.TestSuite.GlobalDlgBox;
using Autodesk.GUIHarness.Core.Plant3D;
using LAGT.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.TestSuites.GlobalCmdOpt
{
    // Class responsible to initalize variables needed for testing the application under test.
    public class CmdSetup_Tools : ISetup_Tools
    {
        public CmdSetup_Tools() { }

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
        private AcadHarness prodHarness;

        public void ScriptEnter()
        {
            prodHarness.FireTestBeginEvent();
        }

        public void ScriptExit()
        {
            prodHarness.FireTestExitEvent();
        }

        public void TestCaseEnter()
        {
            prodHarness.FireTestCaseEnterEvent();
            if (!Product.Variables.Debug)
                WatchDog.Current.Watch();
        }

        public void TestCaseExit()
        {
            if (!Product.Variables.Debug)
                WatchDog.Current.Reset();
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
            OptionSets.appWndPath = LAGT.CommonFiles.Product.Variables.ProductLocation;
            // Initialize the Core Library
            OptionSets.ESCLib = new Plant3DLib();
            // Initialize the Babel Engine
            getBabelEngine();
            Methods.setBabel();
            // Initialize the TypeTree. Note that this must be called AFTER the derived harness
            // is loaded but before it is instantiated. Hence it can't be moved to the static initializer.
            Harness.Initialize();
            // Initialize the product-specific Harness
            prodHarness = new Plant3DHarness();
            prodHarness.InitializeAppWnd();
            // Initialize the product-specific CmdOpt files.
            InitCmdOptFiles();
        }

        /// <summary>
        /// Initializes the BabelEngine.
        /// </summary>
        public void getBabelEngine()
        {
            // Hard-coded Name to by-pass AppWnd.Name since it is not yet instantiated.
            // Overhead involved
            // Ensuring this string value is the same value in the declared AppWnd.
            AcBabel.Name = "AutoCAD";
            OptionSets.BabelEngine = new AcBabel();
        }

        /// <summary>
        /// Set-up the product-specific dialog files to be tested.
        /// </summary>
        public void InitCmdOptFiles()
        {
            OptionSets.cmdSetup = new CmdOpt_Setup();
        }
    }
}
