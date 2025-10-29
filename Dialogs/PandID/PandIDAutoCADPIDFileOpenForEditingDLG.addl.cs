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
using System;
using System.Diagnostics;
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDAutoCADPIDFileOpenForEditingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]AutoCAD Plant 3D";
		}

        public override void Invoke()
        {
            string Title = DateTime.Now.ToString();
            Title = Title.Replace(":", "_").Replace("/", "_");
            //Drawing.Current.TypeE("SDI 0");
            Drawing.Current.SetSysVar("SDI", 0);
            PandIDFunctions.CreateDrawing("PID", null, Title);
            
            string sPath = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\"+ Title+".dwg";
            string sPathcopy = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\ABC\";
            if (!Directory.Exists(sPathcopy)) Directory.CreateDirectory(sPathcopy);
            // File
            File.Copy(sPath, sPathcopy + Path.GetFileName(sPath), true);

            System.Threading.Thread.Sleep(5000);
            PandIDFunctions.DeleteDrawing();
            //Drawing.Current.SetSysVar("SDI", 0);
            File.Copy(sPathcopy + Path.GetFileName(sPath),sPath, true);
            System.Threading.Thread.Sleep(3000);
            Drawing.Current.TypeE("_Open");
            Drawing.Current.TypeE(sPath);
            DrawingAlertDLG DrawingAlertDLG = new DrawingAlertDLG();
            if (DrawingAlertDLG.Exists)
            {
                DrawingAlertDLG.NoPB.Click();
            }
            System.Threading.Thread.Sleep(2000);
            //Drawing.Current.TypeE("SDI 0");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.Invoke();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1"); //use 
            PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
            PandIDNewDWGDLG.FileNameTF.SetText(Title);
            PandIDNewDWGDLG.OKPB.Click();
            PandIDWarningDLG PandIDWarningDLG = new PandIDWarningDLG();
            if (PandIDWarningDLG.Exists)
            {
                PandIDWarningDLG.OK.Click();
            }
            PandIDFileExistsDLG PandIDFileExistsDLG = new PandIDFileExistsDLG();
            if (PandIDFileExistsDLG.Exists)
            {
                PandIDFileExistsDLG.TypeKeys("<Enter>");
            }
        }

		public override void Dismiss()
		{
            this.Close();
			PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
			PandIDNewDWGDLG.Dismiss();
            Drawing.Current.TypeE("_Close");

        }
    }
}
