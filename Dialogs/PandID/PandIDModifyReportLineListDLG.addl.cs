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
using ProductTestSuite.CommonFiles;
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDModifyReportLineListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]*"+AcMainWin.cBabel(21032,2,"Modify Report")+"*";
		}

		public override void Invoke()
		{
			PandIDProjectSetupProjectReportsDLG PandIDProjectSetupProjectReportsDLG = new PandIDProjectSetupProjectReportsDLG();
			PandIDProjectSetupProjectReportsDLG.Invoke();
			PandIDProjectSetupProjectReportsDLG.M_listBox.Select(0);
			PandIDProjectSetupProjectReportsDLG.M_btnModify.Click();
			this.Size(620,490);

		}

		public override void Dismiss()
		{
            this.M_btnCancel.Click();
			PandIDProjectSetupProjectReportsDLG PandIDProjectSetupProjectReportsDLG = new PandIDProjectSetupProjectReportsDLG();
			PandIDProjectSetupProjectReportsDLG.Dismiss();
		}
    }
}
