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
using Autodesk.GUIHarness.Plant3d.Core;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CatalogPropertiesGeneralPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$Window_1|" + AcMainWin.cBabel(23053, 37, "Catalog Properties");
		}

		public override void Invoke()
		{
			//AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			//AutoCADPlantDSpecEditorxCatalogEditortabDLG.Invoke();
			//AutoCADPlantDSpecEditorxCatalogEditortabDLG.SetActive();
			//         //AutoCADPlantDSpecEditorxCatalogEditortabDLG.PopUpButton.PopupSelect(1,1,"");
			//         AutoCADPlantDSpecEditorxCatalogEditortabDLG.PopUpButton.Click();
			
			SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
			SpecUtilityOpenCatDLG.Invoke();
			//SpecUtilityOpenCatDLG.TypeKeys("C:\\AutoCAD Plant 3D 2025 Content\\CPak ASME\\ASME Valves Catalog.pcat");
            SpecUtilityOpenCatDLG.TypeKeys(Plant3dConstants.Contentpath + "\\CPak ASME\\ASME Valves Catalog.pcat");

            System.Threading.Thread.Sleep(2000);
			SpecUtilityOpenCatDLG.Open.Click();
			System.Threading.Thread.Sleep(10000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.CatalogEditor.Click();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.SetActive();
			System.Threading.Thread.Sleep(1000);
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.PopUpButton.Click();
			System.Threading.Thread.Sleep(1000);
			CatalogPropertiesGeneralPropertiesDLG CatalogPropertiesGeneralPropertiesDLG = new CatalogPropertiesGeneralPropertiesDLG();
          
			CatalogPropertiesGeneralPropertiesDLG.Move(50,50);
			System.Threading.Thread.Sleep(1000);
			CatalogPropertiesGeneralPropertiesDLG.SetSize(1230,690);
			CatalogPropertiesGeneralPropertiesDLG.SetActive();
		}

		public override void Dismiss()
		{
			CatalogPropertiesGeneralPropertiesDLG CatalogPropertiesGeneralPropertiesDLG = new CatalogPropertiesGeneralPropertiesDLG();
			CatalogPropertiesGeneralPropertiesDLG.SetActive();
			CatalogPropertiesGeneralPropertiesDLG.Close();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.Dismiss();
		}
		public void Move(int xRestSize, int yRestSize)
		{
			CatalogPropertiesGeneralPropertiesDLG CatalogPropertiesGeneralPropertiesDLG = new CatalogPropertiesGeneralPropertiesDLG();

			RECT r = CatalogPropertiesGeneralPropertiesDLG.GetRect(true);
			if (r.xSize != xRestSize && r.ySize != yRestSize)
			{
				Desktop.Current.PressMouse(MouseButton.Left, r.xPos + 5, r.yPos + 1);
				Desktop.Current.ReleaseMouse(MouseButton.Left, xRestSize, yRestSize);
				System.Threading.Thread.Sleep(1000);
			}
		}
		public void SetSize(int xRestSize, int yRestSize)
		{
			CatalogPropertiesGeneralPropertiesDLG CatalogPropertiesGeneralPropertiesDLG = new CatalogPropertiesGeneralPropertiesDLG();

			RECT r = CatalogPropertiesGeneralPropertiesDLG.GetRect(true);
			if (r.xSize != xRestSize && r.ySize != yRestSize)
			{
				CatalogPropertiesGeneralPropertiesDLG.Click(MouseButton.Right, 8, 70);
				Desktop.Current.TypeKeys("<Down 2><Enter>", 500);
				Desktop.Current.TypeKeys("<Right><Down>");
				Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
			}
		}
	}
}
