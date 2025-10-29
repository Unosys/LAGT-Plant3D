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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDMapPropertyValuesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$PnPMapPropertyValuesDlg";
		}

		public override void Invoke()
		{
            PandIDNewExportandImportSettingsDLG PandIDNewExportandImportSettingsDLG = new PandIDNewExportandImportSettingsDLG();
			PandIDNewExportandImportSettingsDLG.Invoke();
			PandIDNewExportandImportSettingsDLG.M_tbName.SetText("temp");
            System.Threading.Thread.Sleep(100);
            //PandIDNewExportandImportSettingsDLG.M_treeView.Select("/#1");
            //         PandIDNewExportandImportSettingsDLG.M_treeView.TypeKeys("<Space>");
            PandIDNewExportandImportSettingsDLG.EngineeringItemsTVI.Click();
            PandIDNewExportandImportSettingsDLG.TypeKeys("<Space>");
            System.Threading.Thread.Sleep(100);
            Desktop.Current.TypeKeys("<Tab 6><Enter>");
            System.Threading.Thread.Sleep(1000);
            
            
            //if (!PandIDNewExportandImportSettingsDLG.PushButtonPB.Exists) {
            //    RECT rect = PandIDNewExportandImportSettingsDLG.M_dataGridView.GetRect();
            //    PandIDNewExportandImportSettingsDLG.Click(MouseButton.Left, rect.xPos + rect.xSize - 30, rect.yPos + 20);
            //    System.Threading.Thread.Sleep(1000);
            //}
            //    PandIDNewExportandImportSettingsDLG.PushButtonPB.Click();
		}

		public override void Dismiss()
		{
			PandIDMapPropertyValuesDLG PandIDMapPropertyValuesDLG = Current<PandIDMapPropertyValuesDLG>();
			PandIDMapPropertyValuesDLG.Close();
			PandIDNewExportandImportSettingsDLG PandIDNewExportandImportSettingsDLG = Current<PandIDNewExportandImportSettingsDLG>();
            PandIDNewExportandImportSettingsDLG.Close();
			PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
			PandIDProjectSetupProjectDetailsDLG.Dismiss();
		}
    }
}
