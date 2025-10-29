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
using Autodesk.GUIHarness.Plant3d.Core;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SpecPropertyEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$PropertyEditor"; 
		}

		public override void Invoke()
		{
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			//SpecEditorDLG.OpenSpec(@"C:\AutoCAD Plant 3D 2025 Content\CPak AME\CS150 Flanged.pspx");
            SpecEditorDLG.OpenSpec(Plant3dConstants.Contentpath + "\\CPak AME\\CS150 Flanged.pspx");
            System.Threading.Thread.Sleep(10000);
			Desktop Desktop = new Desktop();
			SpecEditorDLG.SpecSheetListView.Select(1);

			//RECT Rrect = SpecEditorDLG.GetRect();
			//Desktop.Click(MouseButton.Left, (Rrect.xPos + Rrect.xSize - 70), (Rrect.yPos + 65));
			SpecEditorDLG.PropertyEditorPB.Click();
			System.Threading.Thread.Sleep(3000);
			SpecPropertyEditorDLG SpecPropertyEditorDLG = new SpecPropertyEditorDLG();
			SpecPropertyEditorDLG.SetActive();
            this.Size(1000, 480);


        }

		public override void Dismiss()
		{
			SpecPropertyEditorDLG SpecPropertyEditorDLG = new SpecPropertyEditorDLG();
			SpecPropertyEditorDLG.SetActive();
			SpecPropertyEditorDLG.CancelPB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();			
			SpecEditorDLG.Dismiss();


		}
	}
}
