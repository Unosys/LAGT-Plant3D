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
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using System.Diagnostics;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReadOnlyDWGError : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23050, 2, "AutoCAD Alert");
		}

		public override void Invoke()
		{
			string sPath;
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\TempAlert.dwg";

            Plant3DFunctions.CreateDrawing("P3D", null, "TempAlert", "no");
			Drawing.Current.TypeE("_close");
			Desktop Desktop = new Desktop();
			Desktop.TypeKeys("<Tab><Enter>");
			//Sys_Execute("Attrib +R {chr(34)}{sPath}{chr(34)}") Sys_Execute("Attrib +R {chr(34)}{sPath}{chr(34)}") = new Sys_Execute("Attrib +R {chr(34)}{sPath}{chr(34)}")();
            System.Threading.Thread.Sleep(5000);
            Process.Start("cmd.exe", "/c attrib " + "+R \"" + sPath + "\"");
            //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            //PROJECTMANAGERDLG.SetActive();
            //PROJECTMANAGERDLG.TreeViewTV.SetFocus();
            //PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.SetActive();
            Window wTreeView = ProjManUndocked.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2,1");
			//Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			//Plant3DFunctions.//ExpandTreeP3D(wTreeView,1,"1,iProd,1");
			ReadOnlyDWGError ReadOnlyDWGError = new ReadOnlyDWGError();
			ReadOnlyDWGError.SetActive();
		}

		public override void Dismiss()
		{
			ReadOnlyDWGError ReadOnlyDWGError = new ReadOnlyDWGError();
			ReadOnlyDWGError.No.Click();
			//int iProd;
			string sPath;
            //string sProd;
            //if (LAGT.CommonFiles.Product.Variables.ProductName == "AutoCAD Plant 3D")
            //{
            //    iProd = 2;
            //    sProd = "P3D";
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\TempAlert.dwg";
            //}
            //else
            //{
            //    iProd = 1;
            //    sProd = "PID";
            //    sPath = AcMainWin.RoamableRootFolder + "DefaultProject\\PID_DWG\\TempAlert.dwg";
            //}
            Process.Start("cmd.exe", "/c attrib " + "-R \"" + sPath + "\"");
            Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
