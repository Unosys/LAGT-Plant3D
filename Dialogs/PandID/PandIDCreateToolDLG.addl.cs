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
using LAGT.CommonFiles;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDCreateToolDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]" + AcMainWin.cBabel(21000, 1, "Create Tool");
		}

		public override void Invoke()
		{
			PandIDProjectSetupPandIDClassDefinitionDLG PandIDProjectSetupPandIDClassDefinitionDLG = new PandIDProjectSetupPandIDClassDefinitionDLG();
			PandIDProjectSetupPandIDClassDefinitionDLG.Invoke();
			string sIndex;
			switch (Product.Variables.Language){
                case "Kor":
			        sIndex = "#3";
                    break;
                case "Deu":
			        sIndex = "#4";
                    break;
                case "Rus":
			        sIndex = "#3";
                    break;
                case "Chs":
			        sIndex = "#2";
                    break;
    			default:
                    sIndex = "#1";
                    break;
            }
            System.Threading.Thread.Sleep(3000);
            PandIDProjectSetupEndConnectionDLG PandIDProjectSetupEndConnectionDLG = Current<PandIDProjectSetupEndConnectionDLG>();
            //PandIDFunctions.treeViewSelect(PandIDProjectSetupEndConnectionDLG.M_treeView,AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21000, 2, "Equipment") + "/" + AcMainWin.cBabel(21000, 3, "Blowers") + "/" + AcMainWin.cBabel(21000, 4, "Centrifugal Blower"));
            //PandIDFunctions.treeViewExpand(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers"));
            //if (LAGT.CommonFiles.Product.Variables.Language == "JPN")
            //{
            //    PandIDFunctions.treeViewSelect(PandIDProjectSetupEndConnectionDLG.M_treeView,  AcMainWin.cBabel(21100, 6, "Blowers") + "/" + "#1");

            //}
            //else if ( LAGT.CommonFiles.Product.Variables.Language == "RUS")
            //    {
            //        PandIDFunctions.treeViewSelect(PandIDProjectSetupEndConnectionDLG.M_treeView, "Вентиляторы" + "/" + "#1");

            //    }
            //else if (LAGT.CommonFiles.Product.Variables.Language == "DEU")
            //{
            //    PandIDFunctions.treeViewSelect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21100, 6, "Blowers") + "/" + "#4");//AcMainWin.cBabel(21100, 6, "Blowers") + "/" + "#4");//Gebläse

            //}
            //else
            //{
            //    //PandIDFunctions.treeViewSelect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers") + "/" + "#2");

            //    PandIDFunctions.treeViewSelect(PandIDProjectSetupEndConnectionDLG.M_treeView,  AcMainWin.cBabel(21100, 6, "Blowers") + "/" + AcMainWin.cBabel(21000, 4, "Centrifugal Blower")+"/"+AcMainWin.cBabel(21000, 4, "Centrifugal Blower"));
            //}
            PandIDFunctions.treeViewSelect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21100, 6, "Blowers") + "/" + AcMainWin.cBabel(21000, 4, "Centrifugal Blower"));
            PandIDProjectSetupPandIDClassDefinitionDLG.M_btnAdd2TP.Click();
		}

		public override void Dismiss()
		{
			PandIDCreateToolDLG PandIDCreateToolDLG = Current<PandIDCreateToolDLG>();
			PandIDCreateToolDLG.OK.Click();
            PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
            PandIDProjectSetupProjectDetailsDLG.Dismiss();
		}
    }
}
