using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Autodesk.GUIHarness.Core;
using OptionSet;
using ProductTestSuite.CommonFiles;
using LAGT.CommonFiles;

namespace Autodesk.GUIHarness.Core.Plant3D
{
    public class Plant3DLib : ScrtiptLib
    {
        
        public override void DefaultScriptEnter()
        {
            // Check setup paths
            if (!((LAGT.CommonFiles.Core.Variables.WorkingDir[LAGT.CommonFiles.Core.Variables.WorkingDir.Length - 1]).Equals('\\'))) { AdResultLog.Current.Print("ESC_Setup.inc: gsScriptDir variable must end with a backslash"); Environment.Exit(-1); }
            //if (Product.Variables.RegressBaseDir == "") Product.Variables.RegressBaseDir = LAGT.CommonFiles.Core.Variables.ResultsDir.Replace("/", "\\");
            //if (Product.Variables.RegressMode && (!((Product.Variables.RegressBaseDir[Product.Variables.RegressBaseDir.Length - 1].Equals('\\'))))) { AdResultLog.Current.Print("ESC_Setup.inc: gsRegressBaseDir variable must end with a backslash"); Environment.Exit(-1); }
            if (!Directory.Exists(LAGT.CommonFiles.Core.Variables.FrameworkDir)) { AdResultLog.Current.Print("C# compiler constants: Harness.FRAMEWKDIR is not valid"); Environment.Exit(-1); }
            if (!Directory.Exists(LAGT.CommonFiles.Core.Variables.ResultsDir)) { AdResultLog.Current.Print("C# compiler constants: TESTRESDIR is not valid"); Environment.Exit(-1); }
            if (!Directory.Exists(LAGT.CommonFiles.Core.Variables.WorkingDir)) { AdResultLog.Current.Print("ESC_Setup.inc: gsScriptDir variable is not valid"); Environment.Exit(-1); }
            //if (Product.Variables.RegressMode && !Directory.Exists(Product.Variables.RegressBaseDir)) { AdResultLog.Current.Print("ESC_Setup.inc: gsRegressBaseDir variable is not valid"); Environment.Exit(-1); }
            
            // To be moved to ACMMainWin class.
            //// Language of the build and OS       
            //ESCGlobals.gBuildLang = ESC_Tools.ConvertLangCode(AppWnd.Language);
            //ESCGlobals.gOSLang = ESC_Tools.ConvertLangCode(OS.sLanguage);

            // Results folder
            //string CurrentTestName = Assembly.GetEntryAssembly().FullName.Split(',')[0];
            //ESCGlobals.gsResultDir = LAGT.CommonFiles.Core.Variables.ResultsDir + "\\" + Product.Variables.ProductCode + "\\" + ESCGlobals.gsLangCode[(int)ESCGlobals.gBuildLang - 1] + "\\" + Product.Variables.BuildNumber + "\\" + ESC_Tools.Get_OS_Version() + "\\" + AutomationTests.Variables.AutomationType + "\\";/*CurrentTestName.Split('.')[0];*/
            //if (Product.Variables.RegressLanguage == 0) Product.Variables.RegressLanguage = ESCGlobals.gBuildLang;
            //Line below is not requested anymore testing is covered under datavalidation when the system populate the variable.
            if (string.IsNullOrEmpty(Product.Variables.RegressVersion)) { AdResultLog.Current.Print("RegressPlatfrom value must not be emtpy"); Environment.Exit(-1); }
            //ESCGlobals.gsRegressDir = Product.Variables.RegressBaseDir + Product.Variables.RegressProductCode + "\\" + Product.Variables.RegressLanguage + Product.Variables.RegressVersion + "\\" + Product.Variables.RegressPlatform + "\\" + AutomationTests.Variables.AutomationType + "\\";/*CurrentTestName.Split('.')[0];*/
            if (Product.Variables.RegressMode && !Directory.Exists(AutomationTests.Variables.AutomationRegressDir)) { AdResultLog.Current.Print("Regress folder " + AutomationTests.Variables.AutomationRegressDir + " not valid"); Environment.Exit(-1); }

            ESC_Tools.Create_Folder(AutomationTests.Variables.AutomationResultsDir);
            Directory.CreateDirectory("C:\\Temp");

            ESC_Tools.BackupFile(LAGT.CommonFiles.Core.Variables.ResultsDir + "\\" + AutomationTests.Variables.AutomationType + ".res");

            //SetKeyboardUSINT();
            //Harness.ScriptEnter();
        }
    }
}
