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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DOrthoGenerationDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$OrthoUpdateDlg";

        }

		public override void Invoke()
        {
            string sProjectName = Product.Variables.TestFilesDir+ "OrthoNewUI\\Project.xml";
            Plant3DFunctions.OpenProject(sProjectName);
            string sPath = Product.Variables.TestFilesDir + "OrthoNewUI\\Plant 3D Models\\P3D-001.dwg";
            string sPath1 = Product.Variables.TestFilesDir + "OrthoNewUI\\Plant 3D Models\\P3D-001AAA.dwg";
            FileInfo file = new FileInfo(sPath);
            if (File.Exists(sPath) && !File.Exists(sPath1))
            {
                
                file.CopyTo(sPath1);
                File.Delete(sPath);
            }
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            Plant3DFunctions.ExpandTreeOrtho(PROJECTMANAGERDLG.TreeViewTV, 2, "0,1,1");
            //Plant3DFunctions.RightClickTreeP3D(PROJECTMANAGERDLG.TreeViewTV, "2", "", false, 1, 1, 1);
            System.Threading.Thread.Sleep(8000);

            this.SetActive();
            this.Size(750, 640);
           

        }
        public override void Dismiss()
        {
            this.ClosePB.Click();
            string sPath = Product.Variables.TestFilesDir + "OrthoNewUI\\Plant 3D Models\\P3D-001.dwg";
            string sPath1 = Product.Variables.TestFilesDir + "OrthoNewUI\\Plant 3D Models\\P3D-001AAA.dwg";
            FileInfo file = new FileInfo(sPath1);
            if (File.Exists(sPath1) && !File.Exists(sPath))
            {

                file.CopyTo(sPath);
                File.Delete(sPath1);
            }
            Plant3DFunctions.SetToDefault();

           
        }
    }
}
