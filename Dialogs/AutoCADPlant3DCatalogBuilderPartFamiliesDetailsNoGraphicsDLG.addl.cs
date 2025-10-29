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
    public partial class AutoCADPlant3DCatalogBuilderPartFamiliesDetailsNoGraphicsDLG : Autodesk.GUIHarness.MainWin
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			//Tag = "Autodesk AutoCAD Plant 3D Catalog Builder*";
			Tag = "[MainWin]Autodesk Catalog Builder for AutoCAD Plant 3D *|$Window";
		}

		public void Invoke()
		{
			AutoCADPlant3DCatalogBuilderApplicationDLG AutoCADPlant3DCatalogBuilderApplicationDLG = new AutoCADPlant3DCatalogBuilderApplicationDLG();
			AutoCADPlant3DCatalogBuilderApplicationDLG.Invoke();
			AutoCADPlant3DCatalogBuilderApplicationDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
			AutoCADPlant3DCatalogBuilderApplicationDLG.FastenersBtn.Click(MouseButton.Left, 10, 10);
            AutoCADPlant3DCatalogBuilderApplicationDLG.BoltSet1ST.Click();
			AutoCADPlant3DCatalogBuilderApplicationDLG.IdNewFamily.Click();
		}

		public void Dismiss()
		{
			AutoCADPlant3DCatalogBuilderPartFamiliesDetailsNoGraphicsDLG AutoCADPlant3DCatalogBuilderPartFamiliesDetailsNoGraphicsDLG = new AutoCADPlant3DCatalogBuilderPartFamiliesDetailsNoGraphicsDLG();
			AutoCADPlant3DCatalogBuilderPartFamiliesDetailsNoGraphicsDLG.SetActive();
			AutoCADPlant3DCatalogBuilderPartFamiliesDetailsNoGraphicsDLG.TypeKeys("<Alt-F4>");
			AutoCADPlant3DCatalogBuildTaskDLG AutoCADPlant3DCatalogBuildTaskDLG = new AutoCADPlant3DCatalogBuildTaskDLG();
			if (AutoCADPlant3DCatalogBuildTaskDLG.Exists)
			{
				AutoCADPlant3DCatalogBuildTaskDLG.SetActive();
				AutoCADPlant3DCatalogBuildTaskDLG.No.Click();
			}
		}
    }
}
