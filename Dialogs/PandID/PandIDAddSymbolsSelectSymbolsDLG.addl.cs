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
    public partial class PandIDAddSymbolsSelectSymbolsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$SelectSymbolDlg";
		}

		public override void Invoke()
		{
            PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
            PandIDProjectSetupProjectDetailsDLG.Invoke();
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings"));
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.TypeKeys("<right>");
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions"));

            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions"));
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.TypeKeys("<right>");
            System.Threading.Thread.Sleep(100);

            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items"));

            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items"));
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment"));
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment"));
            System.Threading.Thread.Sleep(100);
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers"));
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers"));

            System.Threading.Thread.Sleep(100);
            PandIDProjectSetupProjectDetailsDLG.TreeViewTV.TypeKeys("<Down 2>");
            PandIDProjectSetupPandIDClassDefinitionDLG PandIDProjectSetupPandIDClassDefinitionDLG = new PandIDProjectSetupPandIDClassDefinitionDLG();
            PandIDProjectSetupPandIDClassDefinitionDLG.M_btnAddStyle.Click();
			this.SetActive();
		}

		public override void Dismiss()
		{
			PandIDAddSymbolsSelectSymbolsDLG PandIDAddSymbolsSelectSymbolsDLG = Current<PandIDAddSymbolsSelectSymbolsDLG>();
			PandIDAddSymbolsSelectSymbolsDLG.SetActive();
			PandIDAddSymbolsSelectSymbolsDLG.Close();
            PandIDProjectSetupProjectDetailsDLG PandIDProjectSetupProjectDetailsDLG = new PandIDProjectSetupProjectDetailsDLG();
            PandIDProjectSetupProjectDetailsDLG.Dismiss();
		}
    }
}
