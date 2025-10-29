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
using System.Diagnostics;
using System.IO;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReadOnlyDrawingErrorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$frmReadonlyDwgError";
		}

		public void Invoke()
		{
			string sPath = null;

            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\Temp.dwg";
            string sPathBak = new AcMainWin().RoamableRootFolder + @"DefaultProject\Plant_3D_Models\Temp.bak";

            if (File.Exists(sPath))
            {
                Process.Start("cmd.exe", "/c attrib " + "-R \"" + sPath + "\"");
                //PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
                File.Delete(sPath);
                File.Delete(sPathBak);
            }

            Plant3DFunctions.CreateDrawing("P3D",null, "Temp", "no");
			Drawing.Current.TypeE("_close");
			Desktop Desktop = new Desktop();
			Desktop.TypeKeys("<Tab><Enter>");
            System.Threading.Thread.Sleep(5000);
            Process.Start("cmd.exe", "/c attrib " + "+R \"" + sPath + "\"");
            //Process.Start("Attrib +R &apos;C:\\Users\\Administrator.W7EN1ENUx64-VM7\\AppData\\Roaming\\Autodesk\\Autodesk AutoCAD Plant 3D 2016\\R20.1\\enu\\DefaultProject\\Plant_3D_Models\\Temp.dwg&apos;");
            //Process.Start("Attrib +R &apos;"+sPath+"&apos;");
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.SetActive();
//			PROJECTMANAGERDLG.TreeViewTV.SetFocus();
//			PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            Window wTreeView = ProjManUndocked.TreeViewTV;
			Plant3DFunctions.ExpandTreeP3D(wTreeView,3,"0,2,1");//remove 4for FY24
			RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
			RemoveDrawingsFromProjectDLG.TypeKeys("<enter>");
			System.Threading.Thread.Sleep(1000);
		}

		public void Dismiss()
		{
			ReadOnlyDrawingErrorDLG ReadOnlyDrawingErrorDLG = new ReadOnlyDrawingErrorDLG();
			ReadOnlyDrawingErrorDLG.BtnOK.Click();
            //int iProd;
			string sPath;
            //string sProd;
            //if (LAGT.CommonFiles.Product.Variables.ProductName == "AutoCAD Plant 3D")
            //{
            //        iProd = 2;
            //        sProd = "P3D";
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\Temp.dwg";
            string sPathBak = new AcMainWin().RoamableRootFolder + @"DefaultProject\Plant_3D_Models\Temp.bak";

            //}
            //else
            //{
            //        iProd = 1;
            //        sProd = "PID";
            //        sPath = AcMainWin.RoamableRootFolder+"DefaultProject\\PID_DWG\\Temp.dwg";
            //}
            Process.Start("cmd.exe", "/c attrib " + "-R \"" + sPath + "\"");

            Plant3DFunctions.DeleteDrawing("P3D");
            File.Delete(sPath);
            File.Delete(sPathBak);
        }
    }
}
