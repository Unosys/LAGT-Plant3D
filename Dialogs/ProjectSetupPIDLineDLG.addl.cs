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
    public partial class ProjectSetupPIDLineDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$EditProjectSettingsDlg";
		}

		public  void Invoke()
		{
			ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
			ProjectSetupPandIDClassDefinitionDLG.Invoke();
			ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + "Инженерные элементы");
                    ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right>");
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + "Инженерные элементы" + "/" + "Линии");
                    //ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 3, "Lines"));
                    System.Threading.Thread.Sleep(3000);
                    ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right><Down>");

                    break;
                case "DEU":
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + "Technische Elemente");
                    ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right>");
                    //ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + "Technische Elemente" + "/" + "Leitungen");
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 3, "Lines"));
                    ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right>");
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 3, "Lines") + "/" + AcMainWin.cBabel(21100, 4, "Pipe Line Segments"));
                    System.Threading.Thread.Sleep(3000);
                    //ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right><Down>");
                    break;
                case "JPN":
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items"));
                    ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right>");
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 3, "Lines"));
                    //ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 3, "Lines"));
                    System.Threading.Thread.Sleep(3000);
                    ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right>");
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 3, "Lines") + "/" + AcMainWin.cBabel(21100, 4, "Pipe Line Segments"));

                    break;
                default:
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items"));
                    ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right>");
                    ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 3, "Lines"));
                    //ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21100, 3, "Lines"));
                    System.Threading.Thread.Sleep(3000);
                    ProjectSetupProjectDetailsDLG.M_treeView.TypeKeys("<right><Down>");
                    break;

            }
           
           
		}

		public  void Dismiss()
		{
			ProjectSetupPIDLineDLG ProjectSetupPIDLineDLG = new ProjectSetupPIDLineDLG();
			ProjectSetupPIDLineDLG.M_btnCancel.Click();
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Dismiss();
		}
    }
}
