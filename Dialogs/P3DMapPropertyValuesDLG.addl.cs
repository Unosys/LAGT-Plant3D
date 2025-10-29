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
    public partial class P3DMapPropertyValuesDLG :Pane
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
			Plant3DNewExportImportSettingDLG Plant3DNewExportImportSettingDLG = new Plant3DNewExportImportSettingDLG();
			Plant3DNewExportImportSettingDLG.Invoke();
			Plant3DNewExportImportSettingDLG.M_tbName.SetText("temp");
            RECT rTPRect = Plant3DNewExportImportSettingDLG.M_dataGridView.GetRect();
			Plant3DNewExportImportSettingDLG.DoubleClick(MouseButton.Left, rTPRect.xPos + 300, rTPRect.yPos -60);
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "DEU":

                Plant3DNewExportImportSettingDLG.M_treeView.Select(AcMainWin.cBabel(23073, 16, "Piping and Equipment"));
                    break;
                //case "RUS":

                
                //    break;
                default:
                    Plant3DNewExportImportSettingDLG.M_treeView.Select("*"+AcMainWin.cBabel(21051,2,"Piping")+"*");

                    break;

            }
                      
            Plant3DNewExportImportSettingDLG.M_treeView.TypeKeys("<Space>");
            System.Threading.Thread.Sleep(1000);
            Plant3DNewExportImportSettingDLG.TypeKeys("<Tab 6><Enter>");          
            P3DMapPropertyValuesDLG P3DMapPropertyValuesDLG = new P3DMapPropertyValuesDLG();            
            if (!P3DMapPropertyValuesDLG.Exists)
            {
                RECT r = Plant3DNewExportImportSettingDLG.VerSB.GetRect(true);
                Plant3DNewExportImportSettingDLG.Click(MouseButton.Left,r.xPos-50,r.yPos+50);
                System.Threading.Thread.Sleep(1000);
                Plant3DNewExportImportSettingDLG.TypeKeys("<Enter>");
            }
           
		}

		public  void Dismiss()
		{
			P3DMapPropertyValuesDLG P3DMapPropertyValuesDLG = new P3DMapPropertyValuesDLG();
			P3DMapPropertyValuesDLG.M_btCancel.Click();
			Plant3DNewExportImportSettingDLG Plant3DNewExportImportSettingDLG = new Plant3DNewExportImportSettingDLG();
			Plant3DNewExportImportSettingDLG.M_btnOK.Click();
			ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
			ProjectSetupPlant3DDWG.Dismiss();
		}
    }
}
