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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SelectLDTFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23035, 1, "Select LDT File");
		}

		public override void Invoke()
		{
			InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributesDLG();
			InsertTitleBlockAttributesDLG.Invoke();
            InsertTitleBlockAttributesDLG.SetActive();
            //InsertTitleBlockAttributesDLG.PageListPG.Select(1);
            RECT r11 = InsertTitleBlockAttributesDLG.AddAttributesPANE.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r11.xPos + 5, r11.yPos - 5);
            Desktop.Current.TypeKeys("<Right>");
            System.Threading.Thread.Sleep(1000);
            InsertTitleBlockAttributesDLG.PushButtonPB.Click();
		}

		public override void Dismiss()
		{
			LightingLightingUnitsMsgDLG LightingLightingUnitsMsgDLG = new LightingLightingUnitsMsgDLG();
			if (LightingLightingUnitsMsgDLG.Exists)
			{
				LightingLightingUnitsMsgDLG.Dismiss();
			}
			SelectLDTFileDLG SelectLDTFileDLG = new SelectLDTFileDLG();
			SelectLDTFileDLG.SetActive();
			SelectLDTFileDLG.Cancel.Click();
            InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributesDLG();
            InsertTitleBlockAttributesDLG.Dismiss();
           
		}
    }
}
