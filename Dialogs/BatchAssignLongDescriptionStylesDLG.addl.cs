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
    public partial class BatchAssignLongDescriptionStylesDLG : Window
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Window]$LongDescriptionBatchWindow";
		}

		public void Invoke()
		{
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.Invoke();
			SpecEditorDLG.SetActive();
            SpecEditorDLG.SpecsMI.Pick();
			SpecEditorDLG.BatchAssignLDStyles.Pick();
            //System.Threading.Thread.Sleep(5000);
			BatchAssignLongDescriptionStylesDLG BatchAssignLongDescriptionStylesDLG = new BatchAssignLongDescriptionStylesDLG();
			BatchAssignLongDescriptionStylesDLG.SetActive();
			BatchAssignLongDescriptionStylesDLG.SetSize(100,100);
		}

		public void Dismiss()
		{
			BatchAssignLongDescriptionStylesDLG BatchAssignLongDescriptionStylesDLG = new BatchAssignLongDescriptionStylesDLG();
			BatchAssignLongDescriptionStylesDLG.SetActive();
            BatchAssignLongDescriptionStylesDLG.Cancel2PB.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();
			SpecEditorDLG.Dismiss();
		}
		public void SetSize(int xRestSize, int yRestSize)
		{
			
			RECT r = this.GetRect(true);
			if (r.xSize != xRestSize && r.ySize != yRestSize)
			{
				this.Click(MouseButton.Right, 8, 8);
				Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
				Desktop.Current.TypeKeys("<Right><Down>");
				Desktop.Current.Click(MouseButton.Left, r.xPos+r.xSize + xRestSize, r.yPos+r.ySize + yRestSize);
			}
		}
	}
}
