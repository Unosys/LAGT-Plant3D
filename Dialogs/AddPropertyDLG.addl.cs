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
using Autodesk.GUIHarness.AutoCAD;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class AddPropertyDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$AddPropertyDlg";
		}

		public  void Invoke()
		{
            ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
            ProjectSetupPandIDClassDefinitionDLG.Invoke();
            ProjectSetupPandIDClassDefinitionDLG.M_btnAddProperty.Click();
            ////switch gsProductName switch gsProductName = new switch gsProductName();
            //if (LAGT.CommonFiles.Product.Variables.ProductName == "AutoCAD P and ID")
            //{
            //    DataManagerConfigurationDLG DataManagerConfigurationDLG = new DataManagerConfigurationDLG();
            //    DataManagerConfigurationDLG.Invoke();
            //    ProjectSetupEndConnectionDLG ProjectSetupEndConnectionDLG = new ProjectSetupEndConnectionDLG();
            //    ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030,1,"P&ID DWG Settings")+"/"+AcMainWin.cBabel(21013,1,"P&ID Class Definitions"));
            //    ProjectSetupEndConnectionDLG.M_treeView.TypeKeys("<right>");
            //    Plant3D AppWnd = new Plant3D();
            //    switch (LAGT.CommonFiles.Product.Variables.Language)
            //    {
            //        case "LANG_JAPANESE":
            //            ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030,1,"P&ID DWG Settings")+"/"+AcMainWin.cBabel(21013,1,"P&ID Class Definitions")+"/#1/#4");
            //            break;
            //        case "LANG_RUSSIAN":
            //            ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030,1,"P&ID DWG Settings")+"/"+AcMainWin.cBabel(21013,1,"P&ID Class Definitions")+"/#3/#4");
            //            break;
            //        default:
            //            ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030,1,"P&ID DWG Settings")+"/"+AcMainWin.cBabel(21013,1,"P&ID Class Definitions")+"/#1/#1");
            //            ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
            //            //ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
            //            ProjectSetupPandIDClassDefinitionDLG.M_btnAddProperty.Click();
            //            break;
            //    }
            //}
            //else //P3D
            //{
            //    Plant3DFunctions.InvokeCentrifugalBlower();
            //    ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
            //    ProjectSetupPandIDClassDefinitionDLG.M_btnAddProperty.Click();  
            //}
          }
		public  void Dismiss()
		{
			AddPropertyDLG AddPropertyDLG = new AddPropertyDLG();
			AddPropertyDLG.M_btnCancel.Click();
			ProjectSetupPathsDLG ProjectSetupPathsDLG = new ProjectSetupPathsDLG();
			ProjectSetupPathsDLG.Dismiss();
		}
    }
}
