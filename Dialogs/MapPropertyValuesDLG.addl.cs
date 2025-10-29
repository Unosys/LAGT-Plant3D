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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class MapPropertyValuesDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$PnPMapPropertyValuesDlg";
		}

		public  void Invoke()
		{
			NewExportandImportSettingsDLG NewExportandImportSettingsDLG = new NewExportandImportSettingsDLG();
			NewExportandImportSettingsDLG.Invoke();
			NewExportandImportSettingsDLG.M_tbName.SetText("temp");
            RECT rTPRect = NewExportandImportSettingsDLG.M_dataGridView.GetRect();
            NewExportandImportSettingsDLG.DoubleClick(MouseButton.Left, rTPRect.xPos + 300, rTPRect.yPos - 60);
            NewExportandImportSettingsDLG.M_treeView.Select("*" +"Engineering Items" +"*");
			NewExportandImportSettingsDLG.M_treeView.Select(0);
            NewExportandImportSettingsDLG.M_treeView.TypeKeys("<Space>");
            NewExportandImportSettingsDLG.M_dataGridView.Click(MouseButton.Left, 310, 35); //Check manually with addlspy
			System.Threading.Thread.Sleep(1000);
			NewExportandImportSettingsDLG.Elipses.Click();
		}

		public  void Dismiss()
		{
			MapPropertyValuesDLG MapPropertyValuesDLG = new MapPropertyValuesDLG();
            MapPropertyValuesDLG.TypeKeys("<Esc>");
			NewExportandImportSettingsDLG NewExportandImportSettingsDLG = new NewExportandImportSettingsDLG();
			NewExportandImportSettingsDLG.SetActive();
			NewExportandImportSettingsDLG.M_btnOK.Click();
			ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
			ProjectSetupProjectDetailsDLG.Dismiss();
		}
    }
}
