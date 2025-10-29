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
    public partial class RenameClassDLG : Autodesk.GUIHarness.Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$RenameObjectDefinitionDlg";
		}

		public  void Invoke()
		{
            ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
            ProjectSetupPandIDClassDefinitionDLG.Invoke();
            ProjectSetupEndConnectionDLG ProjectSetupEndConnectionDLG = new ProjectSetupEndConnectionDLG();
            //ProjectSetupEndConnectionDLG.M_treeView.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items"));
            //ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment"));
            //ProjectSetupEndConnectionDLG.M_treeView.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment"));
            //ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipement") + "/" + AcMainWin.cBabel(21100, 6, "Blowers"));
            //ProjectSetupEndConnectionDLG.M_treeView.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipement") + "/" + AcMainWin.cBabel(21100, 6, "Blowers"));
            //ProjectSetupEndConnectionDLG.M_treeView.Select(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipement") + "/" + AcMainWin.cBabel(21100, 6, "Blowers") + "/" + AcMainWin.cBabel(21100, 7, "Blower Axail"));
            //ProjectSetupEndConnectionDLG.M_treeView.Expand(AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipement") + "/" + AcMainWin.cBabel(21100, 6, "Blowers") + "/" + AcMainWin.cBabel(21100, 7, "Blower Axail"));
            System.Threading.Thread.Sleep(4000);
            Window wtreeview = ProjectSetupEndConnectionDLG.M_treeView;
            wtreeview.TypeKeys("<SHIFT-F10><Down 2><Enter>");
            RenameClassDLG RenameClassDLG = new RenameClassDLG();
            RenameClassDLG.SetActive();
            System.Threading.Thread.Sleep(8000);

		}

		public  void Dismiss()
		{
            this.TypeKeys("<Alt-F4>");
            ProjectSetupPathsDLG ProjectSetupPathsDLG=new ProjectSetupPathsDLG();
            ProjectSetupPathsDLG.Dismiss();
		}
    }
}
