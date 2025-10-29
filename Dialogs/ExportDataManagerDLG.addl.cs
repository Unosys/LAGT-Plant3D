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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ExportDataManagerDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$PnPExportDataDlg";
		}

		public void Invoke()
		{
           
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDFunctions.CreateDrawing("PID");
            Drawing.Current.TypeE("_erase");
            Drawing.Current.TypeE("_all");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_SLINE");
            Drawing.Current.TypeE("14,16");
            Drawing.Current.TypeE("14,7");
            Drawing.Current.TypeE("");
            PandIDPROJECTMANAGERDLG.Dismiss();
            Drawing.Current.TypeE("_DATAMANAGER");
            DataManagerDLG PandIDDataManagerDLG = new DataManagerDLG();
            RECT rect = PandIDDataManagerDLG.TreeViewTV.GetRect(true);
            PandIDDataManagerDLG.Click(MouseButton.Right, rect.xPos + 2, rect.yPos + 1);
            System.Threading.Thread.Sleep(100);
            PandIDDataManagerDLG.TreeViewTV.TypeKeys("<Down 2><Enter>");
            PandIDDataManagerDLG.ExportPB.Click();
            if (!PandIDDataManagerDLG.Exists)
            {
                ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Export.bmp");
                Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            }
        }

		public void Dismiss()
		{
            ExportDataManagerDLG ExportDataManagerDLG = new ExportDataManagerDLG();
            ExportDataManagerDLG.SetActive();
            ExportDataManagerDLG.Cancel.Click();
            Drawing.Current.TypeE("DATAMANAGERCLOSE");
            Drawing.Current.TypeE("_projectmanager");
            PandIDFunctions.DeleteDrawing();
		}
    }
}
