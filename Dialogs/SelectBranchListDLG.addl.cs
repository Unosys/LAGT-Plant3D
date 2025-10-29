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
    public partial class SelectBranchListDLG : Window
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Window]Select Branch List|$MultiBranchSelWindow";
		}

		public void Invoke()
		{

            var AutoCADPlantDSpecEditorxBranchEditortabDLG = new AutoCADPlantDSpecEditorxBranchEditortabDLG();
            AutoCADPlantDSpecEditorxBranchEditortabDLG.Invoke();
            
            var SpecEditorDLG = new SpecEditorDLG();
            System.Threading.Thread.Sleep(5000);
            RECT Rrect = SpecEditorDLG.GetRect();
            Desktop Desktop = new Desktop();
            AutoCADPlantDSpecEditorxBranchEditortabDLG.TextField1TF.DoubleClick(MouseButton.Left,5,5);
            SelectBranchListDLG SelectBranchListDLG = new SelectBranchListDLG();
            if (!SelectBranchListDLG.Exists)
            {
                Desktop.Click(MouseButton.Right, Rrect.xPos + 300, Rrect.yPos + 400);
                Desktop.TypeKeys("<Up><Enter>");
            }
            System.Threading.Thread.Sleep(10000);
            this.SetActive();
		}

		public void Dismiss()
		{
			var SelectBranchListDLG = new SelectBranchListDLG();
			SelectBranchListDLG.SetActive();
			SelectBranchListDLG.CancelPB.Click();
            var AutoCADPlantDSpecEditorxBranchEditortabDLG = new AutoCADPlantDSpecEditorxBranchEditortabDLG();
            AutoCADPlantDSpecEditorxBranchEditortabDLG.Dismiss();
        }
    }
}
