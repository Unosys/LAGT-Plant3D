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
using Autodesk.GUIHarness.Drivers.Interfaces;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SpecUtilitySaveChangesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]Save Changes|$TaskDialog_Enhanced";
;
		}

		public override void Invoke()
		{
			var CreateNewComponentDLG1 = new CreateNewComponentDLG1();
			CreateNewComponentDLG1.Invoke();
            CreateNewComponentDLG1.ListBoxLB.Select(0);
            CreateNewComponentDLG1.SizeFromPL.Select(1);
            CreateNewComponentDLG1.CreatePB.Click();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
			AutoCADPlantDSpecEditorxCatalogEditortabDLG.SetActive();
            AutoCADPlantDSpecEditorxCatalogEditortabDLG.MatchingPipeODTF.TypeKeys("<Ctrl-A><Delete>");
            Desktop Desktop = new Desktop();
            Desktop.Current.Click(MouseButton.Left, 986,418);
            AutoCADPlantDSpecEditorxCatalogEditortabDLG.TypeKeys("<Ctrl-A><Delete>");
            AutoCADPlantDSpecEditorxCatalogEditortabDLG.TypeKeys("10");
            AutoCADPlantDSpecEditorxCatalogEditortabDLG.SavePB.Click();
            System.Threading.Thread.Sleep(5000);
            this.SetActive();
		}

		public override void Dismiss()
		{
			this.SetActive();
			this.DiscardChangesToTheST.Click(MouseButton.Left,2,2);
            AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();
            AutoCADPlantDSpecEditorxCatalogEditortabDLG.Dismiss();
        }
    }
}
