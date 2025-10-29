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
    public partial class P3DTagFormatSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$TagformatSetupDlg";
		}

		public  void Invoke()
		{
			ProjectSetupPlant3DClassDefinationDLG ProjectSetupPlant3DClassDefinationDLG = new ProjectSetupPlant3DClassDefinationDLG();
			ProjectSetupPlant3DClassDefinationDLG.Invoke();
			ProjectSetupPlant3DClassDefinationDLG.NewPB.Click();
			System.Threading.Thread.Sleep(2000);
            P3DTagFormatSetupDLG P3DTagFormatSetupDLG = new P3DTagFormatSetupDLG();

            P3DTagFormatSetupDLG.Size(593, 525);
            P3DTagFormatSetupDLG.SetActive();
		}

		public  void Dismiss()
		{
			P3DTagFormatSetupDLG P3DTagFormatSetupDLG = new P3DTagFormatSetupDLG();
			P3DTagFormatSetupDLG.M_btnCancel.Click();
			ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
			ProjectSetupPlant3DDWG.Dismiss();
		}
		public void SetSize( )
		{
			P3DTagFormatSetupDLG P3DTagFormatSetupDLG = new P3DTagFormatSetupDLG();
			RECT r = P3DTagFormatSetupDLG.GetRect(true);
			if (r.xSize!= 500 && r.ySize!= 500)
			{
                P3DTagFormatSetupDLG.Click(MouseButton.Right,10,5);
				Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
				Desktop.Current.TypeKeys("<Right><Down>");
				Desktop.Current.Click(MouseButton.Left, r.xPos +500, r.yPos+500);
			}
		}
	}
}
