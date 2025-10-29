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
    public partial class AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG : Autodesk.GUIHarness.MainWin
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
        {
			Tag = "$Window";

        }

		public void Invoke()
		{
			AutoCADPlant3DCatalogBuilderApplicationDLG AutoCADPlant3DCatalogBuilderApplicationDLG = new AutoCADPlant3DCatalogBuilderApplicationDLG();
			AutoCADPlant3DCatalogBuilderApplicationDLG.Invoke();
			AutoCADPlant3DCatalogBuilderApplicationDLG.SetActive();
            AutoCADPlant3DCatalogBuilderApplicationDLG.FittingsBtn.Click(MouseButton.Left, 10, 10);
            AutoCADPlant3DCatalogBuilderApplicationDLG.CrossST.Click();
			AutoCADPlant3DCatalogBuilderApplicationDLG.IdNewFamily.Click();
			AutoCADPlant3DCatalogBuilderApplicationDLG.RadioButton1.Select();
		}

		public void Dismiss()
		{
			AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG = new AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG();
            AutoCADPlant3DCatalogBuildTaskDLG AutoCADPlant3DCatalogBuildTaskDLG = new AutoCADPlant3DCatalogBuildTaskDLG();
            if (AutoCADPlant3DCatalogBuildTaskDLG.Exists)
            {
                AutoCADPlant3DCatalogBuildTaskDLG.SetActive();
                AutoCADPlant3DCatalogBuildTaskDLG.No.Click();
            }
            AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG.SetActive();
			AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG.TypeKeys("<Alt-F4>");
			if (AutoCADPlant3DCatalogBuildTaskDLG.Exists)
			{
				AutoCADPlant3DCatalogBuildTaskDLG.SetActive();
				AutoCADPlant3DCatalogBuildTaskDLG.No.Click();
			}
		}
    }
}
