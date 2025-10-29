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
    public partial class CADWorxToPlantDMappingClassMappingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$SpecMigration_EditMapping";
		}

		public override void Invoke()
		{
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Invoke();
			SpecEditorDLG.SetActive();
            SpecEditorDLG.FileMI.Pick();
            SpecEditorDLG.Convert.Pick();
            SpecEditorDLG.MigrateSettings.Pick();
            SpecEditorDLG.CADWorxSetting.Pick();
			System.Threading.Thread.Sleep(10000);
			CADWorxToPlantDMappingClassMappingDLG CADWorxToPlantDMappingClassMappingDLG = new CADWorxToPlantDMappingClassMappingDLG();
			try { this.Move(10, 10); } catch { }
			
			this.Size(900,500);
			this.SetActive();
		}

		public override void Dismiss()
		{
			CADWorxToPlantDMappingClassMappingDLG CADWorxToPlantDMappingClassMappingDLG = new CADWorxToPlantDMappingClassMappingDLG();
			CADWorxToPlantDMappingClassMappingDLG.SetActive();
			CADWorxToPlantDMappingClassMappingDLG.CancelPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Dismiss();
		}
    }
}
