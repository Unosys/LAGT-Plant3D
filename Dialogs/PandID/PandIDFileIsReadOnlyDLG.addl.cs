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
using static System.Windows.Forms.AxHost;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDFileIsReadOnlyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]" + AcMainWin.cBabel(23050, 9, "File is Read-only");
		}

		public override void Invoke()
		{
            string sPath = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\Temp.dwg";
            //string sPathBak = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\Temp.bak";
            string sProd = "PID";
            //if (File.Exists(sPath))
            //{
            //    PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
            //    File.Delete(sPath);
            //    File.Delete(sPathBak);
            //}
            //if (File.Exists(sPathBak))
            //{
            //    PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPathBak + System.Convert.ToChar(34));
               
            //    File.Delete(sPathBak);
            //}
            PandIDFunctions.CreateDrawing(sProd,null, "Temp");
            Drawing.Current.TypeE("_close");
            System.Threading.Thread.Sleep(2000);
            PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
            if (PandIDWarningAutoCADDLG.Exists)
            {
                PandIDWarningAutoCADDLG.No.Click();
            }
            //PandIDFunctions.RunCmd("Attrib +R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
            //string s = "Attrib +R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34);
            Process.Start("cmd.exe", "/c attrib " + "+R \"" + sPath + "\"");
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.SetActive();
            Window wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            PandIDFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");//5 in FY24
			System.Threading.Thread.Sleep(500);
		}

		public override void Dismiss()
		{
            this.Close();
            string sPath = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\Temp.dwg";
            //string sPathBak = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\Temp.bak";
            //PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
            //PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
            Process.Start("cmd.exe", "/c attrib " + "-R \"" + sPath + "\"");
            PandIDFunctions.DeleteDrawing();            
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.Dismiss();
		}
    }
}
