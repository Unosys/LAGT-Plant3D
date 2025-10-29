// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
    public partial class RefreshLocalProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
		}

		public override void Invoke()
		{
			CheckInDLG CheckInDLG = new CheckInDLG();
			CheckInDLG.Invoke();
			CheckInDLG.SetActive();
			CheckInDLG.OK.Click();
			System.Threading.Thread.Sleep(5000);
			ProjectDataMergedVaultDLG ProjectDataMergedVaultDLG = Current<ProjectDataMergedVaultDLG>();
			ProjectDataMergedVaultDLG.SetActive();
			ProjectDataMergedVaultDLG.BtnOk.Click();
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("_PLANTPIPEADD");
			Drawing.Current.TypeE("20");
			Drawing.Current.TypeE("100");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("");
			Plant3DFunctions.CreateVaultDrawing("P3D","no","abc1");
			Drawing.Current.TypeE("_PLANTPIPEADD");
			Drawing.Current.TypeE("20");
			Drawing.Current.TypeE("100");
			Drawing.Current.TypeE("");
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
			Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			Plant3DFunctions.ExpandTreeP3D(wTreeView,8,"1,2,1");
			PROJECTMANAGERDLG.TreeViewTV.Click(MouseButton.Right, 29,7);
			PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<Down 10> <Enter>");
			System.Threading.Thread.Sleep(8000);
			ProjectSettingsCheckOutDLG ProjectSettingsCheckOutDLG = Current<ProjectSettingsCheckOutDLG>();
			ProjectSettingsCheckOutDLG.SetActive();
			ProjectSettingsCheckOutDLG.TypeKeys("<Enter>");
            ProjectSetupDLG ProjectSetupDLG = new ProjectSetupDLG();
			while (!ProjectSetupDLG.Exists)
            {
                System.Threading.Thread.Sleep(3000);
            }
			
			ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = Current<ProjectSetupProjectDetailsDLG>();
			ProjectSetupProjectDetailsDLG.SetActive();
            //ProjectSetupProjectDetailsDLG.M_treeView.Select("*"/AcMainWin.cBabel(23165,8,"Project Details"));
            //ProjectSetupProjectDetailsDLG.M_textBoxProjectDesc.SetText("Vault Project");
            //ProjectSetupProjectDetailsDLG.M_btnOk.Click();
			Window wTreeView2 = PROJECTMANAGERDLG.TreeViewTV;
			Plant3DFunctions.ExpandTreeP3D(wTreeView2,8,"1,2,1");
			PROJECTMANAGERDLG.TreeViewTV.Click(MouseButton.Right, 29,7);
			PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<Down 3><Right> <Down 1><Enter>");
			RefreshLocalProjectDLG RefreshLocalProjectDLG = Current<RefreshLocalProjectDLG>();
			RefreshLocalProjectDLG.SetActive();
		}

		public override void Dismiss()
		{
			RefreshLocalProjectDLG RefreshLocalProjectDLG = Current<RefreshLocalProjectDLG>();
			RefreshLocalProjectDLG.TypeKeys("<Enter>");
			System.Threading.Thread.Sleep(3000);
			ProjectRefreshedFromVaultDLG ProjectRefreshedFromVaultDLG = Current<ProjectRefreshedFromVaultDLG>();
			ProjectRefreshedFromVaultDLG.SetActive();
			System.Threading.Thread.Sleep(3000);
			ProjectRefreshedFromVaultDLG.TypeKeys("<Enter>");
			Plant3DFunctions.SetToDefault();
		}
    }
}
