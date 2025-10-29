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
    public partial class DeleteSettingMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23165, 32, "Delete Setting")+"|"+"*"+AcMainWin.cBabel(321, 126, "Delete") + "*";

        }

        public override void Invoke()
        {
            Plant3DNewExportImportSettingDLG Plant3DNewExportImportSettingDLG = new Plant3DNewExportImportSettingDLG();
            Plant3DNewExportImportSettingDLG.Invoke();
            Plant3DNewExportImportSettingDLG.M_tbName.SetText("TEST");
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "DEU":

                    Plant3DNewExportImportSettingDLG.M_treeView.Select(AcMainWin.cBabel(23073, 16, "Piping and Equipment"));
                    break;
                //case "RUS":

                //    Desktop.Click(MouseButton.Left, 370, 516);//Styles Sheet
                //    break;
                default:
                    Plant3DNewExportImportSettingDLG.M_treeView.Select("*" + AcMainWin.cBabel(21051, 2, "Piping") + "*");

                    break;

            }
            Plant3DNewExportImportSettingDLG.M_treeView.TypeKeys("<Space>");
            Plant3DNewExportImportSettingDLG.M_btnOK.Click();
            ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
            while (!ProjectSetupPlant3DDWG.Exists)
            {
                System.Threading.Thread.Sleep(1000);
            }
            ProjectSetupPlant3DDWG.SetActive();
            ProjectSetupP3DExportImportDLG ProjectSetupP3DExportImportDLG = new ProjectSetupP3DExportImportDLG();
            ProjectSetupP3DExportImportDLG.DeletePB.Click();
        }

        public override void Dismiss()
        {
            this.YesPB.Click();        
            ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
            ProjectSetupPlant3DDWG.Dismiss();
        }
    }
}
