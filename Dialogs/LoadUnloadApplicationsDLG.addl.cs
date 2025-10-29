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
using LAGT.CommonFiles;
using Microsoft.Win32;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class LoadUnloadApplicationsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(131, 1, "Load?Unload Applications");
		}

		public override void Invoke()
		{
			Drawing.Current.TypeE("_appload");
		}

		public override void Dismiss()
		{
			this.ClosePB.Click();
            
        }
        public  void Reload()
        {
            Autodesk.GUIHarness.AutoCAD.AcMainWin AcMainWin = new Autodesk.GUIHarness.AutoCAD.AcMainWin();
            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + AcMainWin.AcadRoot + "\\" + AcMainWin.AcadNumber, "SupportFolderLang", "") as string;           
            string sProjectName = sProjectPath + "acad"+ Product.Variables.ReleaseYear+"doc.lsp";//acad2026doc.lsp

            Drawing.Current.TypeE("_APPLOAD");
            System.Threading.Thread.Sleep(1000);
            LoadUnloadApplicationsDLG LoadUnloadApplicationsDLG = new LoadUnloadApplicationsDLG();
            LoadUnloadApplicationsDLG.FileNameCB.SetText(sProjectName);
            LoadUnloadApplicationsDLG.LoadPB.Click();
            System.Threading.Thread.Sleep(1000);
            LoadUnloadApplicationsDLG.ClosePB.Click();
        }
    }
}
