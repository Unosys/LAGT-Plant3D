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
	public partial class SpecUtilityCatalogPartsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
	{
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
		///// <summary>
		///// OnInitialize() is used to contain additional initialization code
		///// Uncomment the code block below to use it
		///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$Window_1";
		}

		public override void Invoke()
		{
			SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
			SpecUtilityOpenCatDLG.Invoke();
			SpecUtilityOpenCatDLG.SetActive();
			SpecUtilityOpenCatDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "CustomParts Metric Catalog.pcat");
			SpecUtilityOpenCatDLG.Open.Click();
			System.Threading.Thread.Sleep(10000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			RECT Rrect = SpecEditorDLG.GetRect();
			Desktop Desktop = new Desktop();
			Desktop.Click(MouseButton.Left, (Rrect.xPos + Rrect.xSize - 70), (Rrect.yPos + 65));
			//SpecEditorDLG.CatalogEditor.Click();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			//AutoCADPlantDSpecEditorxCatalogEditortabDLG.PopUpButton2.Click();
			SpecUtilityCatalogPartsDLG SpecUtilityCatalogPartsDLG = new SpecUtilityCatalogPartsDLG();

            this.Move(50,50);
            this.SetSize(1000,800);
			this.SetActive();
		}

		public override void Dismiss()
		{
			SpecUtilityCatalogPartsDLG SpecUtilityCatalogPartsDLG = new SpecUtilityCatalogPartsDLG();
			SpecUtilityCatalogPartsDLG.SetActive();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();
			//SpecEditorDLG.CloseAll.Pick();
			SpecEditorDLG.Dismiss();
		}
		
        void Move(int xRestSize, int yRestSize)
        {
            SpecUtilityCatalogPartsDLG SpecUtilityCatalogPartsDLG = new SpecUtilityCatalogPartsDLG();
            RECT r = SpecUtilityCatalogPartsDLG.GetRect(true);
            SpecUtilityCatalogPartsDLG.Click(MouseButton.Right, 5, 5);
            Desktop.Current.TypeKeys("<Down 2><Enter>", 250);
            if (r.xPos != xRestSize && r.yPos != yRestSize)
            {
                Desktop.Current.PressMouse(MouseButton.Left, r.xPos + 5, r.yPos + 1);
                Desktop.Current.ReleaseMouse(MouseButton.Left, xRestSize, yRestSize);
                System.Threading.Thread.Sleep(1000);
            }

        }

        void SetSize(int xSize, int ySize)
        {
            SpecUtilityCatalogPartsDLG SpecUtilityCatalogPartsDLG = new SpecUtilityCatalogPartsDLG();
            RECT r = SpecUtilityCatalogPartsDLG.GetRect(true);
            SpecUtilityCatalogPartsDLG.Click(MouseButton.Right, 5, 5);
            Desktop.Current.TypeKeys("<Down 3><Enter><Right><Down>", 250);
            if (r.xSize < (xSize - 10) || r.ySize < (ySize - 10))
            {
                Desktop.Current.Click(MouseButton.Left, r.xPos + xSize + 5, r.yPos + ySize + 5);
            }

        }
    }
}
