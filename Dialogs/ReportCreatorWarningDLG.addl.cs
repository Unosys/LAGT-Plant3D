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
using Autodesk.GUIHarness.Core;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReportCreatorWarningDLG : Autodesk.GUIHarness.MainWin
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "$MainForm";
        }

        public void Invoke()
        {
           
            string slang = ESCGlobals.gsLangCode[(int)ESCGlobals.gBuildLang - 1].ToLower();
            string sPath = AllUsersFolder.Replace("enu", slang) + "ReportCreator\\ReportFiles\\3D Parts1.rcf";
            if (!File.Exists(sPath))
            {
                File.Copy(LAGT.CommonFiles.Product.Variables.TestFilesDir + "3D Parts1.rcf", sPath);
            }
            ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
            ReportCreatorDLG.Invoke();
            System.Threading.Thread.Sleep(2000);
            ReportCreatorDLG.M_projectCmbBox.TypeKeys("<F4><Down 2><Enter>");
            System.Threading.Thread.Sleep(5000);
            ReportCreatorDLG.M_repConfigCmbBox.TypeKeys("<F4><Down 4><Enter>");//3D Parts1
            ReportCreatorDLG.M_repConfigEditBtn.Click();
            System.Threading.Thread.Sleep(3000);

        }

        public void Dismiss()
        {

            ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
            ReportCreatorDLG.Dismiss();
            string slang = ESCGlobals.gsLangCode[(int)ESCGlobals.gBuildLang - 1].ToLower();
            string sPath = AllUsersFolder.Replace("enu", slang) + "ReportCreator\\ReportFiles\\3D Parts1.rcf";
            if (File.Exists(sPath))
            {
                File.Delete(sPath);
            }
        }
        public virtual string AllUsersFolder
        {
            get
            {
                return Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "AllUsersFolder", "") as string;
            }
        }
    }
}
