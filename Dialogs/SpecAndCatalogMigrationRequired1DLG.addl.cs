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
    public partial class SpecAndCatalogMigrationRequired1DLG : Autodesk.GUIHarness.MainWin
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$UpgradeMigrationRequiredWindow";
		}

		public  void Invoke()
		{
			var SpecUtilityOpenSpecDLG = new SpecUtilityOpenSpecDLG();
			SpecUtilityOpenSpecDLG.Invoke();
			SpecUtilityOpenSpecDLG.SetActive();
			SpecUtilityOpenSpecDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir+"Hadrian_Specs\\1HC01.pspx");
			
			SpecUtilityOpenSpecDLG.Open.Click();
			System.Threading.Thread.Sleep(5000);
            var SpecAndCatalogMigrationRequireTaskDLG = new SpecAndCatalogMigrationRequireTaskDLG();
            SpecAndCatalogMigrationRequireTaskDLG.SetActive();
            SpecAndCatalogMigrationRequireTaskDLG.ShowDetailsPB.Click();
            
		}

		public  void Dismiss()
		{
			var SpecAndCatalogMigrationRequired1DLG = new SpecAndCatalogMigrationRequired1DLG();
			SpecAndCatalogMigrationRequired1DLG.SetActive();
            SpecAndCatalogMigrationRequired1DLG.Close1PB.Click();
			var SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Dismiss();
		}
    }
}
