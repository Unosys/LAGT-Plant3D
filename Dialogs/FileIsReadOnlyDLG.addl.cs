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
    public partial class FileIsReadOnlyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23050,9,"File is Read-only");
		}

		public override void Invoke()
		{
            string sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\Temp.dwg";

            Plant3DFunctions.CreateDrawing("P3D",null, "Temp","no");
            Drawing.Current.TypeE("_close");
			Desktop Desktop = new Desktop();
			Desktop.TypeKeys("<Tab><Enter>");
            System.Threading.Thread.Sleep(5000);
            Process.Start("cmd.exe", "/c attrib " + "+R \"" + sPath + "\"");
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.SetActive();
            Window wTreeView = ProjManUndocked.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,2,1");//  
            
			System.Threading.Thread.Sleep(500);
			FileIsReadOnlyDLG FileIsReadOnlyDLG = new FileIsReadOnlyDLG();
			FileIsReadOnlyDLG.SetActive();
		}

		public override void Dismiss()
		{
			FileIsReadOnlyDLG FileIsReadOnlyDLG = new FileIsReadOnlyDLG();
			FileIsReadOnlyDLG.OK.Click();

            string sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\Temp.dwg";
            //string sPathBak = new AcMainWin().RoamableRootFolder + @"DefaultProject\Plant_3D_Models\Temp.bak";
            //if (File.Exists(sPath))
            //{
            //    //PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
            //    File.Delete(sPath);

            //}
            //if (File.Exists(sPathBak))
            //{
            //    File.Delete(sPathBak);

            //}
            Process.Start("cmd.exe", "/c attrib " + "-R \"" + sPath + "\"");
            Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
