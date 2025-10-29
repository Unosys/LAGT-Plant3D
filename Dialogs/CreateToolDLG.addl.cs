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
    public partial class CreateToolDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(21000, 1, "Create Tool");
		}

		public override void Invoke()
		{
			ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
			ProjectSetupPandIDClassDefinitionDLG.Invoke();
			string sIndex="Engineering Items";
            //switch (LAGT.CommonFiles.Product.Variables.Language){
            //    case "Deu":
            //        sIndex = "#4";
            //        break;
            //    case "Chs":
            //        sIndex = "#2";
            //        break;
            //    case "Kor":
            //        sIndex = "#3";
            //        break;
            //    case "Rus":
            //        sIndex = "#3";
            //        break;
            //    default:
            //        sIndex = "#1";
            //        break;
            //}
			ProjectSetupEndConnectionDLG ProjectSetupEndConnectionDLG = new ProjectSetupEndConnectionDLG();
			ProjectSetupEndConnectionDLG.M_treeView.TypeKeys("<right>");
            ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21000, 2, "Equipment"));
			ProjectSetupEndConnectionDLG.M_treeView.TypeKeys("<right>");
            ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21000, 2, "Equipment") + "/" + AcMainWin.cBabel(21000, 3, "Blowers"));
			ProjectSetupEndConnectionDLG.M_treeView.TypeKeys("<right>");
            ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21000, 2, "Equipment") + "/" + AcMainWin.cBabel(21000, 3, "Blowers") + "/" + AcMainWin.cBabel(21000, 4, "Centrifugal Blower"));
			ProjectSetupEndConnectionDLG.M_treeView.TypeKeys("<right 2>");
			ProjectSetupPandIDClassDefinitionDLG.M_btnAdd2TP.Click();
		}

		public override void Dismiss()
		{
			CreateToolDLG CreateToolDLG = new CreateToolDLG();
			CreateToolDLG.OK.Click();
			ProjectSetupPathsDLG ProjectSetupPathsDLG = new ProjectSetupPathsDLG();
			ProjectSetupPathsDLG.Dismiss();
		}
    }
}
