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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
	public partial class SpecUtilityPartnameDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
	{
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
		///// <summary>
		///// OnInitialize() is used to contain additional initialization code
		///// Uncomment the code block below to use it
		///// </summary>
		partial void OnInitialize()
		{
			Tag = "$PreviewImageDialog";
		}

		public override void Invoke()
		{
			SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
			SpecUtilityOpenCatDLG.Invoke();
			SpecUtilityOpenCatDLG.SetActive();
			SpecUtilityOpenCatDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "CS150.pspx");
			SpecUtilityOpenCatDLG.Open.Click();
			System.Threading.Thread.Sleep(20000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.CatalogEditor.Click();
			RECT Rrect = SpecEditorDLG.GetRect();
			Desktop Desktop = new Desktop();
			Desktop.Click(MouseButton.Left, (Rrect.xPos + Rrect.xSize - 70), (Rrect.yPos + 65));
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.SetActive();
			System.Threading.Thread.Sleep(3000);

			//if (!AutoCADPlantDSpecEditorxCatalogEditortabDLG.SizePreivewImage.Exists)
			//{
                RECT r = AutoCADPlantDSpecEditorxCatalogEditortabDLG.SizePreivewImage.GetRect(true);
                Desktop.Current.PressMouse(MouseButton.Left, r.xPos + 2, r.yPos + r.ySize / 4);
                Desktop.Current.ReleaseMouse(MouseButton.Left, r.xPos + 2, r.yPos + r.ySize - r.ySize / 4);
                
            //}
            AutoCADPlantDSpecEditorxCatalogEditortabDLG.SizePreivewImage.SetFocus();
            AutoCADPlantDSpecEditorxCatalogEditortabDLG.SizePreivewImage.DoubleClick(MouseButton.Left, 5, 5);


            this.SetActive();
		
	
		
		}

		public override void Dismiss()
		{
			SpecUtilityPartnameDLG SpecUtilityPartnameDLG = new SpecUtilityPartnameDLG();
			SpecUtilityPartnameDLG.SetActive();
			SpecUtilityPartnameDLG.ClosePB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();
            SpecEditorDLG.FileMI.Pick();
            SpecEditorDLG.CloseAll.Pick();
			SpecEditorDLG.Dismiss();
		}
    }
}

