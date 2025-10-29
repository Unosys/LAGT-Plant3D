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
using Autodesk.GUIHarness.Plant3d.Core;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CatalogPropertyEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$PropertyEditor"; 
		}

		public override void Invoke()
		{
			SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
			SpecUtilityOpenCatDLG.Invoke();
			//SpecUtilityOpenCatDLG.TypeKeys("C:\\AutoCAD Plant 3D 2025 Content\\CPak ASME\\ASME Pipes and Fittings Catalog.pcat");
            SpecUtilityOpenCatDLG.TypeKeys(Plant3dConstants.Contentpath +"\\CPak ASME\\ASME Pipes and Fittings Catalog.pcat");
           
            System.Threading.Thread.Sleep(2000);
			SpecUtilityOpenCatDLG.Open.Click();
			System.Threading.Thread.Sleep(10000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.CatalogEditor.Click();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.SetActive();
			System.Threading.Thread.Sleep(1000);
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.PropertyEditorPB.Click();
			System.Threading.Thread.Sleep(1000);
			CatalogPropertyEditorDLG CatalogPropertyEditorDLG = new CatalogPropertyEditorDLG();
			CatalogPropertyEditorDLG.SetActive();
			this.Size(1000,480);
		}

		public override void Dismiss()
		{
			CatalogPropertyEditorDLG CatalogPropertyEditorDLG = new CatalogPropertyEditorDLG();
			CatalogPropertyEditorDLG.SetActive();
			CatalogPropertyEditorDLG.CancelPB.Click();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.Dismiss();

		}
    }
}
