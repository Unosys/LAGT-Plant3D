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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class AutoCADPIDFileOpenForEditingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "AutoCAD P&ID";
		}

		public override void Invoke()
		{
			string sPath = "{AppWnd.sRoamableRootFolder}DefaultProject\\PID_DWG\\ABC.dwg";
			string sPath1 = "{AppWnd.sRoamableRootFolder}DefaultProject\\PID_DWG\\ABC.bak";
			if (File.Exists(sPath))
			{
				//Sys_Execute("Attrib -R {chr(34)}{sPath}{chr(34)}") Sys_Execute("Attrib -R {chr(34)}{sPath}{chr(34)}") = new Sys_Execute("Attrib -R {chr(34)}{sPath}{chr(34)}")();
				Process.Start("Attrib -R {chr(34)}{sPath}{chr(34)}");
				//SYS_RemoveFile(sPath) SYS_RemoveFile(sPath) = new SYS_RemoveFile(sPath)();
				File.Delete(sPath);
			}
			if (File.Exists(sPath1))
			{
				//Sys_Execute("Attrib -R {chr(34)}{sPath1}{chr(34)}") Sys_Execute("Attrib -R {chr(34)}{sPath1}{chr(34)}") = new Sys_Execute("Attrib -R {chr(34)}{sPath1}{chr(34)}")();
				Process.Start("Attrib -R {chr(34)}{sPath1}{chr(34)}");
				//SYS_RemoveFile(sPath1) SYS_RemoveFile(sPath1) = new SYS_RemoveFile(sPath1)();
				File.Delete(sPath1);
			}
			//DeleteAllDrawings() DeleteAllDrawings() = new DeleteAllDrawings()();
			Plant3DFunctions.DeleteAllDrawings();
			Drawing.Current.TypeE("SDI 0");
			Plant3DFunctions.CreateDrawing("PID",null,"ABC", "");
			Plant3DFunctions.DeleteDrawing("PID");
			Drawing.Current.TypeE("SDI 0");
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			PROJECTMANAGERDLG.Undock();
			PROJECTMANAGERDLG.SetActive();
			PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
			//wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			//ExpandTreePID(wTreeView,1,1,1) //ExpandTreePID(wTreeView,1,1,1) = new //ExpandTreePID(wTreeView,1,1,1)();
			//ExpandTreePID(wTreeView,1,1,1);
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.M_tb_filename.SetText("ABC");
			NewDWGDLG.BtnOK.Click();
			WarningDLG WarningDLG = new WarningDLG();
			if (WarningDLG.Exists)
			{
				WarningDLG.OK.Click();
			}
			FileExistsDLG FileExistsDLG = new FileExistsDLG();
			if (FileExistsDLG.Exists)
			{
				FileExistsDLG.TypeKeys("<Enter>");
			}
			AutoCADPIDFileOpenForEditingDLG AutoCADPIDFileOpenForEditingDLG = new AutoCADPIDFileOpenForEditingDLG();
			AutoCADPIDFileOpenForEditingDLG.SetActive();
		}

		public override void Dismiss()
		{
			AutoCADPIDFileOpenForEditingDLG AutoCADPIDFileOpenForEditingDLG = new AutoCADPIDFileOpenForEditingDLG();
			AutoCADPIDFileOpenForEditingDLG.Close();
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.Dismiss();
		}
    }
}
