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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDExportReportDataDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$ExportReportDataDlg";
		}

		public override void Invoke()
		{
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDFunctions.CreateDrawing();
            Drawing.Current.TypeE("_erase");
            Drawing.Current.TypeE("_all");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_SLINE");
            Drawing.Current.TypeE("14,16");
            Drawing.Current.TypeE("14,8");
            Drawing.Current.TypeE("");
            PandIDPROJECTMANAGERDLG.Dismiss();
            Drawing.Current.TypeE("_DATAMANAGER");
            System.Threading.Thread.Sleep(1000);
            //DataManagerDLG PandIDDataManagerDLG = new DataManagerDLG();
            //PandIDDataManagerDLG.M_dataModeCombo.TypeKeys("<End>");
            //RECT rect = PandIDDataManagerDLG.TreeViewTV.GetItemRect(0);
            //PandIDDataManagerDLG.TreeViewTV.Click(MouseButton.Right, rect.xPos + rect.xSize / 2, rect.yPos + rect.ySize / 2);
            //System.Threading.Thread.Sleep(100);
            //PandIDDataManagerDLG.TreeViewTV.TypeKeys("<Down 2><Enter>");
            DATAMANAGER DATAMANAGER = new DATAMANAGER();
            DATAMANAGER.PopupListPL.TypeKeys("<End>");
            RECT rect = DATAMANAGER.TreeViewTV.GetItemRect(0);
            DATAMANAGER.TreeViewTV.Click(MouseButton.Right, rect.xPos + rect.xSize / 2, rect.yPos + rect.ySize / 2);
            System.Threading.Thread.Sleep(100);
            DATAMANAGER.TreeViewTV.TypeKeys("<Down 2><Enter>");
        }

        public override void Dismiss()
		{
            this.Close();
            Drawing.Current.TypeE("DATAMANAGERCLOSE");
            Drawing.Current.TypeE("_ProjectManager");
            PandIDFunctions.DeleteDrawing();
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Dismiss();
		}
    }
}
