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
    public partial class PlantFittingAddDLG : Window
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$Window_1";
		}

		public  void Invoke()
		{
            //Drawing.Current.SetSysVar("SDI", 0);
            //PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            //PROJECTMANAGERDLG.Invoke();
            //PROJECTMANAGERDLG.SetActive();
            ////PROJECTMANAGERDLG.PROJECTMANAGER.PROJECTMANAGER.SourceFiles.PrjMgrMainTab.CurrentProject1.SystemWindowsFormsSplitterP1.M_collapsiblePanelTreeView.M_treeView.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            ////window wTreeView1 = PROJECTMANAGERDLG.PROJECTMANAGER.PROJECTMANAGER.SourceFiles.PrjMgrMainTab.CurrentProject1.SystemWindowsFormsSplitterP1.M_collapsiblePanelTreeView.M_treeView;
            ////ExpandTree(wTreeView1,1,1,2) //ExpandTree(wTreeView1,1,1,2) = new //ExpandTree(wTreeView1,1,1,2)();
            ////ExpandTree(wTreeView1,1,1,2);
            //NewDWGDLG NewDWGDLG = new NewDWGDLG();
            //NewDWGDLG.M_tb_filename.SetText("plant1.dwg");
            //NewDWGDLG.BtnOK.Click();
            //System.Threading.Thread.Sleep(2000);
            //Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Plant3DFunctions.CreateDrawing("P3D");
			Drawing.Current.TypeE("_RIBBONCLOSE");
			Drawing.Current.TypeE("_PLANTFITTINGADD");
			System.Threading.Thread.Sleep(3000);
			PlantFittingAddDLG PlantFittingAddDLG = new PlantFittingAddDLG();
			PlantFittingAddDLG.SetActive();
		}

		public  void Dismiss()
		{
			PlantFittingAddDLG PlantFittingAddDLG = new PlantFittingAddDLG();
			PlantFittingAddDLG.TypeKeys("<Alt-F4>");
            Plant3DFunctions.DeleteDrawing("P3D");
        }
    }
}
