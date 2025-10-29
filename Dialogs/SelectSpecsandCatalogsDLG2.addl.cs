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
    public partial class SelectSpecsandCatalogsDLG2 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23053, 9, "Select Specs and Catalogs");
		}

		public override void Invoke()
		{
			ConvertAutoPLANTSpecsAndCatalogsDLG ConvertAutoPLANTSpecsAndCatalogsDLG = new ConvertAutoPLANTSpecsAndCatalogsDLG();
			ConvertAutoPLANTSpecsAndCatalogsDLG.Invoke();
            ConvertAutoPLANTSpecsAndCatalogsDLG.SetActive();
            System.Threading.Thread.Sleep(1000);

            ConvertAutoPLANTSpecsAndCatalogsDLG.AddPB.Click();
			
		}

		public override void Dismiss()
		{
			SelectSpecsandCatalogsDLG2 SelectSpecsandCatalogsDLG2 = new SelectSpecsandCatalogsDLG2();
			SelectSpecsandCatalogsDLG2.SetActive();
			SelectSpecsandCatalogsDLG2.Cancel.Click();
			ConvertAutoPLANTSpecsAndCatalogsDLG ConvertAutoPLANTSpecsAndCatalogsDLG = new ConvertAutoPLANTSpecsAndCatalogsDLG();
			ConvertAutoPLANTSpecsAndCatalogsDLG.SetActive();
			ConvertAutoPLANTSpecsAndCatalogsDLG.Dismiss();
		}
    }
}
