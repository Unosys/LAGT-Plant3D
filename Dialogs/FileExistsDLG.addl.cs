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
using System.IO;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class FileExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23037, 3, "File Exists");
		}

		public override void Invoke()
        {
            string sPath;
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\ABC.dwg";
            FileInfo file = new FileInfo(sPath);
            if (!file.Exists)
            {
                File.Create(sPath);
            }

            //         Plant3DFunctions.CreateDrawing("P3D",null,"ABC");
            //Drawing.Current.TypeE("SDI 0");
            //Drawing.Current.TypeE("_Close");
            //WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            //if (WarningAutoCADDLG.Exists)
            //{
            //	WarningAutoCADDLG.No.Click();
            //}
            //Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            ////PROJECTMANAGERDLG.SetActive();
            //Plant3DFunctions.DeleteDrawing("P3D");
            Drawing.Current.TypeE("_New ");
			Drawing.Current.TypeE("SDI 0");
			PROJECTMANAGERDLG.Invoke();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2");
			NewDWGDLG NewDWGDLG = new NewDWGDLG();
			NewDWGDLG.M_tb_filename.SetText("ABC");
			NewDWGDLG.BtnOK.Click();
		}

		public override void Dismiss()
		{
			FileExistsDLG FileExistsDLG = new FileExistsDLG();
			FileExistsDLG.SetActive();
			FileExistsDLG.TypeKeys("<Tab 2><Enter>");
			Drawing.Current.TypeE("SDI 1");
            string sPath;
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\Plant_3D_Models\\ABC.dwg";
            FileInfo file = new FileInfo(sPath);
            if (!file.Exists)
            {
                file.Delete();
            }
            
        }
    }
}
