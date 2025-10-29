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
    public partial class FileSetToReadOnlyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "AutoCAD Plant 3D";
		}

		public override void Invoke()
		{



            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            string sPath;
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\ABC.dwg";
            FileInfo file = new FileInfo(sPath);
            if (!File.Exists(sPath))
            {
                File.Copy(LAGT.CommonFiles.Product.Variables.TestFilesDir + "ABC.dwg", sPath);
            }
            Desktop Desktop = new Desktop();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Process.Start("cmd.exe", "/c attrib " + "+R \"" + sPath + "\"");
            //Process.Start("Attrib +R " + sPath);
			//Process.Start("Attrib +R "+sPath+".dwg"); 
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2");
            //Plant3DFunctions.ExpandTreeP3D(wTreeView,1,"1,2");
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
            try
			{
				if (NewDWGDLG.M_tb_filename.Exists)
				{
					NewDWGDLG.M_tb_filename.SetText("ABC.dwg");
				}
			}
			catch
			{
			}
			try
			{
                if (NewDWGDLG.M_tb_filename.Exists)
				{
                    NewDWGDLG.M_tb_filename.SetText("ABC.dwg");
				}
			}
			catch
			{
				NewDWGDLG.TypeKeys("<Shift-Tab 3>ABC.dwg");
			}
            NewDWGDLG.BtnOK.Click();
			Desktop.TypeKeys("<Enter>");
			FileSetToReadOnlyDLG FileSetToReadOnlyDLG = new FileSetToReadOnlyDLG();
			FileSetToReadOnlyDLG.SetActive();
		}

		public override void Dismiss()
		{
			FileSetToReadOnlyDLG FileSetToReadOnlyDLG = new FileSetToReadOnlyDLG();
			FileSetToReadOnlyDLG.OK.Click();
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.BtnCancel.Click();
            string sPath;
            //string sProd;
            //int iProd;
            //switch (LAGT.CommonFiles.Product.Variables.ProductName)
            //{
            //    case "AutoCAD Plant 3D":
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\ABC.dwg";
            //        break;
            //    case "AutoCAD P and ID":
            //        sPath = AcMainWin.RoamableRootFolder + "DefaultProject\\PID_DWG\\ABC.dwg";
            //        break;
            //}
            Process.Start("cmd.exe", "/c attrib " + "-R \"" + sPath + "\"");
            //Plant3DFunctions.DeleteDrawing("P3D");
            //Process.Start("Attrib +R " + sPath);
            //Process.Start("Attrib +R " + sPath + ".dwg");
		}
    }
}
