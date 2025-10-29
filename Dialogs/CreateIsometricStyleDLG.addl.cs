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
using System;
using Autodesk.GUIHarness;
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CreateIsometricStyleDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$Window_1";
		}

		public override void Invoke()
		{
			CreateIsoStyleDLG CreateIsoStyleDLG = new CreateIsoStyleDLG();
			CreateIsoStyleDLG.Invoke();
            CreateIsoStyleDLG.NewStyleName2RB.Click();
            CreateIsoStyleDLG.SpoolFormatCK.Uncheck();
            string Title = DateTime.Now.ToString();
            AdResultLog.Current.Log(Title);
            Title = Title.Replace(":", "_").Replace("/", "_");
            //AdResultLog.Current.Log(Title);
            CreateIsoStyleDLG.NewStyleNameTF.SetText(Title);
            //System.Threading.Thread.Sleep(5000);
            CreateIsoStyleDLG.CreatePB.Click();
			this.SetActive();
		}

		public override void Dismiss()
		{
			this.Btn_Cancel.Click();
			CreateIsoStyleDLG CreateIsoStyleDLG = new CreateIsoStyleDLG();
			if (CreateIsoStyleDLG.Exists)
			{
				CreateIsoStyleDLG.Dismiss();
			}
			ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
			if (ProjectSetupPlant3DDWG.Exists)
			{
				ProjectSetupPlant3DDWG.Dismiss();
			}
		}
    }
}
