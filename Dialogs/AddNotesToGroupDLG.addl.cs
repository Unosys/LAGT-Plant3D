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
using System.Drawing;
using System.Windows.Forms;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class AddNotesToGroupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Window]$AddNotesToGroupWindow|" + AcMainWin.cBabel(23053, 40, "Add Notes To Group");
		}

		public override void Invoke()
		{
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.OpenSpec(LAGT.CommonFiles.Product.Variables.TestFilesDir+"CS150 Flanged.pspx");
            SpecEditorDLG.SpecSheetListView.Select(2);//Bolt Set
            //SpecEditorDLG.AddNotesToGroupButton.Click();	          
            RECT Bolt = SpecEditorDLG.BoltSetRow3LVI.GetRect();
            SpecEditorDLG.BoltSetRow3LVI.DoubleClick(MouseButton.Right, 50, 13);
            System.Threading.Thread.Sleep(2000);
            Desktop.Current.TypeKeys("<Down 3><Enter>");//add notes
            System.Threading.Thread.Sleep(2000);
            //if (this.Exists!) {
            //    Desktop.Current.Click(MouseButton.Right, Bolt.xPos+100, Bolt.yPos+13);
            //    System.Threading.Thread.Sleep(1500);
            //    Desktop.Current.TypeKeys("<Down 3><Enter>", 250);
            //}
            this.SetActive();
		}
        

        public override void Dismiss()
		{
            this.CancelPB.Click();
            System.Threading.Thread.Sleep(3000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();
            SpecEditorDLG.FileMI.Pick();
            SpecEditorDLG.CloseAll.Click();
			SpecEditorDLG.Dismiss();
		}
    }
}
