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
    public partial class PandIDDuplicateDefinitionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[DialogBox]" + AcMainWin.cBabel(21003,1,"Duplicate Definition");
		}

		public override void Invoke()
		{
            PandIDProjectSetupPandIDClassDefinitionDLG PandIDProjectSetupPandIDClassDefinitionDLG = new PandIDProjectSetupPandIDClassDefinitionDLG();
            PandIDProjectSetupPandIDClassDefinitionDLG.Invoke();
            string sIndex;
            switch (Product.Variables.Language)
            {
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
            // PandIDFunctions.treeViewExpand(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers"));
            // PandIDFunctions.treeViewExpand(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers"));
            //PandIDFunctions.treeViewSelect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers") + "/" + "#2");
            // //RECT rect = PandIDFunctions.treeViewGetItemRect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers") + "/" + "#2");

            //RECT rect = PandIDFunctions.treeViewGetItemRect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment"));
            //RECT rect = PandIDFunctions.treeViewGetItemRect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21051, 3, "Equipment") );
            RECT rect = PandIDFunctions.treeViewGetItemRect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21051, 3, "Equipment"));
            PandIDProjectSetupEndConnectionDLG.M_treeView.Click(MouseButton.Right, rect.xPos + rect.xSize / 2, rect.yPos + rect.ySize / 2);
            PandIDProjectSetupEndConnectionDLG.M_treeView.TypeKeys("<Down 1><Enter>");
            System.Threading.Thread.Sleep(3000);
            PandIDCreateClassDLG PandIDCreateClassDLG = new PandIDCreateClassDLG();
            PandIDCreateClassDLG.M_textBoxName.SetText("test");
            PandIDCreateClassDLG.M_btnOk.Click();

            PandIDProjectSetupEndConnectionDLG.M_treeView.Click(MouseButton.Right, rect.xPos + rect.xSize / 2, rect.yPos + rect.ySize / 2);
            PandIDProjectSetupEndConnectionDLG.M_treeView.TypeKeys("<Down 1><Enter>");

            System.Threading.Thread.Sleep(3000);
            PandIDCreateClassDLG.M_textBoxName.SetText("test");
            PandIDCreateClassDLG.M_btnOk.Click();
		}

        public override void Dismiss()
        {
            this.OK.Click();
            PandIDCreateClassDLG PandIDCreateClassDLG = new PandIDCreateClassDLG();
            PandIDCreateClassDLG.M_btnCancel.Click();
            string sIndex;
            switch (Product.Variables.Language)
            {
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
            PandIDProjectSetupEndConnectionDLG PandIDProjectSetupEndConnectionDLG = Current<PandIDProjectSetupEndConnectionDLG>();
            //RECT rect = PandIDFunctions.treeViewGetItemRect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/test");
            RECT rect = PandIDFunctions.treeViewGetItemRect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21051, 3, "Equipment") + "/test");

            //RECT rect = PandIDFunctions.treeViewGetItemRect(PandIDProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/test");
            PandIDProjectSetupEndConnectionDLG.M_treeView.Click(MouseButton.Right, rect.xPos + rect.xSize / 2, rect.yPos + rect.ySize / 2);
            PandIDProjectSetupEndConnectionDLG.M_treeView.TypeKeys("<Down 3><Enter>");
            PandIDConfirmDeleteDLG PandIDConfirmDeleteDLG = new PandIDConfirmDeleteDLG();
            PandIDConfirmDeleteDLG.YesPB.Click();
            PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
            PandIDProjectSetupProjectDetailsDLG.Dismiss();
        }
    }
}
