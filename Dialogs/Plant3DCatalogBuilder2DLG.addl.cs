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
    public partial class Plant3DCatalogBuilder2DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "TAG_IS_OPEN_AGENT" + "|" + AcMainWin.cBabel(23068, 9, "Welcome to the Autodesk AutoCAD Plant 3D Catalog Builder");
		}

		public override void Invoke()
		{
			Plant3DCatalogBuilderDLG Plant3DCatalogBuilderDLG = new Plant3DCatalogBuilderDLG();
			Plant3DCatalogBuilderDLG.Invoke();
			Plant3DCatalogBuilderDLG.Chevron.Click();
			Plant3DCatalogBuilder2DLG Plant3DCatalogBuilder2DLG = new Plant3DCatalogBuilder2DLG();
			Plant3DCatalogBuilder2DLG.SetActive();
		}

		public override void Dismiss()
		{
			Plant3DCatalogBuilder2DLG Plant3DCatalogBuilder2DLG = new Plant3DCatalogBuilder2DLG();
			Plant3DCatalogBuilder2DLG.SetActive();
			Plant3DCatalogBuilder2DLG.TypeKeys("<Alt-F4>");
		}
    }
}
