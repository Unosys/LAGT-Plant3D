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
    public partial class ReadOnlyFileDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$DwgOfflineReadOnly";
		}

		public  void Invoke()
		{
            string sPath1;
            string sPath2;
            sPath1 = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\ABCdwg";

            sPath2 = @"C:\Users\Administrator\Documents\TestA\Plant 3D Models\ABC.dwg";

            FileInfo file1 = new FileInfo(sPath1);
            if (file1.Exists)
            {
                file1.Delete();
            }
            Plant3DFunctions.CreateProj("TestA");
            System.Threading.Thread.Sleep(3000);
            PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            try
            {
                PROJECTMANAGERDLG.CurrentProjectPL.Select("TestA");
            }
            catch
            {
                System.Threading.Thread.Sleep(4000);
            }
            Plant3DFunctions.CreateDrawing("P3D", null, "ABC", "no");
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_close");
            Desktop Desktop = new Desktop();
            Desktop.TypeKeys("<Tab><Enter>");
            System.Threading.Thread.Sleep(1000);
            PROJECTMANAGERDLG.CurrentProjectPL.Select(AcMainWin.cBabel(23039, 2, "Default Project"));
            //PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039, 2, "Default Project"));
            System.Threading.Thread.Sleep(3000);
            Plant3DFunctions.CreateDrawing("P3D", null, "ABC", "no");
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_close");
            
            Desktop.TypeKeys("<Tab><Enter>");

            System.Threading.Thread.Sleep(1000);

            Process.Start("cmd.exe", "/c attrib " + "+R \"" + sPath1 + "\"");
            System.Threading.Thread.Sleep(2000);
            FileInfo file2 = new FileInfo(sPath2);
            if (file2.Exists)
            {
                //file2.Delete();
                File.Replace(sPath1, sPath2, "ABCO");


            }
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.CurrentProjectPL.Select("TestA");
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2,1");
            System.Threading.Thread.Sleep(2000);
            Desktop.TypeKeys("<Enter>");

            Desktop.TypeKeys("<Enter>");
            Desktop.TypeKeys("<Enter>");


        }

		public  void Dismiss()
		{
			ReadOnlyFileDLG ReadOnlyFileDLG = new ReadOnlyFileDLG();
			ReadOnlyFileDLG.OKPB.Click();

            string sPath;
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\ABC.dwg";
            Process.Start("cmd.exe", "/c attrib " + "-R \"" + sPath + "\"");
            Plant3DFunctions.DeleteDrawing("P3D");
        }
    }
}
