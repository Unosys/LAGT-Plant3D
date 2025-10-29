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
    public partial class BoltStandardAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23053,59,"Bolt Standard Already Exists");
		}

		public override void Invoke()
		{
			SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
			SpecUtilityOpenCatDLG.Invoke();
			SpecUtilityOpenCatDLG.TypeKeys("C:\\AutoCAD Plant 3D Osaka Content\\CPak ASME\\ASME Pipes and Fittings Catalog.pcat");
			System.Threading.Thread.Sleep(5000);
			SpecUtilityOpenCatDLG.Open.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			//SpecEditorDLG.CatalogEditor.Click();
            //SpecEditorDLG.Catalogs.EditBoltLengthMapping.Select(); //NEED TO CHECK THE CORRECT CONTROL.....
			BoltLengthMappingDLG BoltLengthMappingDLG = new BoltLengthMappingDLG();
			BoltLengthMappingDLG.AddBoltStandardPB.Click();
			AddBoltStandardDLG AddBoltStandardDLG = new AddBoltStandardDLG();
			AddBoltStandardDLG.SetActive();
			AddBoltStandardDLG.TbBoltCompatibleStd.SetText("Test");
			AddBoltStandardDLG.CbUnit.Select("#1");
            //AddBoltStandardDLG.DataGridCell.TypeKeys("10");  //Using Table AGT control, get the cells..
            //AddBoltStandardDLG.DataGridCell2.TypeKeys("1");
            //AddBoltStandardDLG.DataGridCell3.TypeKeys("10");
            //AddBoltStandardDLG.DataGridCell4.TypeKeys("1");
            //AddBoltStandardDLG.TypeKeys("<Tab>");
			AddBoltStandardDLG.TbBoltCompatibleStd.SetText("Test");
			AddBoltStandardDLG.CbUnit.Select("#1");
			AddBoltStandardDLG.OK.Click();
			BoltLengthMappingDLG.AddBoltStandardPB.Click();
			AddBoltStandardDLG.TbBoltCompatibleStd.SetText("Test");
			AddBoltStandardDLG.CbUnit.Select("#1");
            //AddBoltStandardDLG.DataGridCell.TypeKeys("10");
            //AddBoltStandardDLG.DataGridCell2.TypeKeys("1");
            //AddBoltStandardDLG.DataGridCell3.TypeKeys("10");
            //AddBoltStandardDLG.DataGridCell4.TypeKeys("1");
			AddBoltStandardDLG.TypeKeys("<Tab>");
			AddBoltStandardDLG.TbBoltCompatibleStd.SetText("Test");
			AddBoltStandardDLG.CbUnit.Select("#1");
			AddBoltStandardDLG.OK.Click();
		}

		public override void Dismiss()
		{
			BoltStandardAlreadyExistsDLG BoltStandardAlreadyExistsDLG = new BoltStandardAlreadyExistsDLG();
			BoltStandardAlreadyExistsDLG.SetActive();
			BoltStandardAlreadyExistsDLG.Close();
			AddBoltStandardDLG AddBoltStandardDLG = new AddBoltStandardDLG();
			AddBoltStandardDLG.SetActive();
			AddBoltStandardDLG.ClosePB.Click();
			BoltLengthMappingDLG BoltLengthMappingDLG = new BoltLengthMappingDLG();
			BoltLengthMappingDLG.Dismiss();
		}
    }
}
