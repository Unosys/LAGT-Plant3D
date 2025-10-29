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
    public partial class MapTitleBlockAttributesDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$IsometricMapTBAttributesDlg";
		}

		public  void Invoke()
		{
			InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributesDLG();
			InsertTitleBlockAttributesDLG.Invoke();
			InsertTitleBlockAttributesDLG.SetActive();
			//InsertTitleBlockAttributesDLG.PageListPG.Click(MouseButton.Left,10,10);
            RECT r11 = InsertTitleBlockAttributesDLG.AddAttributesPANE.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r11.xPos + 5, r11.yPos - 5);
            InsertTitleBlockAttributesDLG.MapAttributesPB.Click();
		}

		public  void Dismiss()
        {
            this.TypeKeys("<Alt-F4>");
            InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributesDLG();
            InsertTitleBlockAttributesDLG.Dismiss();
            
		}
    }
}
