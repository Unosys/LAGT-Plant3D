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
    public partial class SelectLongDescriptionStyleFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23038, 1, "Select Long Description Style File");// "~ActiveApp/[DialogBox]*" + AcMainWin.cBabel(23038, 1, "Select Long Description Style File");
		}

		public override void Invoke()
		{
			TableSetupDLG TableSetupDLG = new TableSetupDLG();
			TableSetupDLG.Invoke();
            //TableSetupDLG.PageListPG.Select(1);
            RECT r12 = TableSetupDLG.TableLayoutPANE.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r12.xPos + 5, r12.yPos - 5);
            Desktop.Current.TypeKeys("<Right>");
            System.Threading.Thread.Sleep(2000);
            if (!TableSetupDLG.UseCustomDescriptionCK.IsChecked)
			{
                TableSetupDLG.UseCustomDescriptionCK.Check();
			}
			TableSetupDLG.M_selectIdsFileBtn.Click();
            System.Threading.Thread.Sleep(2000);
        }

		public override void Dismiss()
		{
			SelectLongDescriptionStyleFileDLG SelectLongDescriptionStyleFileDLG = new SelectLongDescriptionStyleFileDLG();
			SelectLongDescriptionStyleFileDLG.SetActive();
			SelectLongDescriptionStyleFileDLG.Cancel.Click();
			LightingLightingUnitsMsgDLG LightingLightingUnitsMsgDLG = new LightingLightingUnitsMsgDLG();
			if (LightingLightingUnitsMsgDLG.Exists)
			{
				LightingLightingUnitsMsgDLG.Dismiss();
			}
			TableSetupDLG TableSetupDLG = new TableSetupDLG();
			TableSetupDLG.Dismiss();
		}
    }
}
