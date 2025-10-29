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
    public partial class CreateNewComponentDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$ComponentEditorDlg|Create New Component|#1";
		}

		public override void Invoke()
		{
			//SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
			//SpecUtilityOpenCatDLG.Invoke();
			//SpecUtilityOpenCatDLG.SetActive();
   //         SpecUtilityOpenCatDLG.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "CustomParts Metric Catalog.pcat");
			//SpecUtilityOpenCatDLG.Open.Click();
			//System.Threading.Thread.Sleep(20000);
   //         SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			//RECT Rrect = SpecEditorDLG.GetRect();
			//Desktop Desktop = new Desktop();
			//Desktop.Click(MouseButton.Left,(Rrect.xPos + Rrect.xSize - 70),(Rrect.yPos + 65));
			var AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.Invoke();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.CreateComponentPB.Click();
			var CreateNewComponentDLG1 = new CreateNewComponentDLG1();
			CreateNewComponentDLG1.SetActive();
            //CreateNewComponentDLG1.Move(1,1);
            //CreateNewComponentDLG1.SetActive();
		}

		public override void Dismiss()
		{
			var CreateNewComponentDLG1 = new CreateNewComponentDLG1();
			CreateNewComponentDLG1.SetActive();
            CreateNewComponentDLG1.CancelPB.Click();
            var AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
            AutoCADPlantDSpecEditorxCatalogEditortabDLG.Dismiss();
        }
    }
}
