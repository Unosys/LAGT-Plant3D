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
    public partial class BranchTableSetupDLG : Autodesk.GUIHarness.Window
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Window]$BranchTableSetupWindow";
		}

		public  void Invoke()
		{
			
			var AutoCADPlantDSpecEditorxBranchEditortabDLG = new AutoCADPlantDSpecEditorxBranchEditortabDLG();
			AutoCADPlantDSpecEditorxBranchEditortabDLG.Invoke();
            AutoCADPlantDSpecEditorxBranchEditortabDLG.EditLegendPB.Click();
			System.Threading.Thread.Sleep(2000);
			var BranchTableSetupDLG = new BranchTableSetupDLG();
			BranchTableSetupDLG.SetActive();
			BranchTableSetupDLG.SetSize(1000,600);
		}

		public  void Dismiss()
		{
			this.SetActive();
			this.CancelPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
            SpecEditorDLG.FileMI.Pick();
            SpecEditorDLG.CloseAll.Pick();
            SpecEditorDLG.Dismiss();
        }
        public void SetSize(int xRestSize, int yRestSize)
        {
            BranchTableSetupDLG BranchTableSetupDLG = new BranchTableSetupDLG();
            RECT r = BranchTableSetupDLG.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                BranchTableSetupDLG.Click(MouseButton.Right, 8, 8);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
    }
}
