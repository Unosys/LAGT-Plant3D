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
    public partial class OpenFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "*"+AcMainWin.cBabel(250, 14, "Open")+"*" + "|*" + AcMainWin.cBabel(275, 6, "Open")+"*";
		}

		public override void Invoke()
		{
			PropertyEditorLayoutGridPreviewDLG PropertyEditorLayoutGridPreviewDLG = new PropertyEditorLayoutGridPreviewDLG();
			PropertyEditorLayoutGridPreviewDLG.Invoke();
			PropertyEditorLayoutGridPreviewDLG.SetActive();
            PropertyEditorLayoutGridPreviewDLG.PageListPG.Select(1);
            System.Threading.Thread.Sleep(1000);
            RECT Tab2 = PropertyEditorLayoutGridPreviewDLG.PnlTabPANE.GetRect();
            PropertyEditorLayoutGridPreviewDLG.PnlTabPANE.Click(MouseButton.Left, 50, 50);//Tab 2

            if (!this.Exists)
            {
                PropertyEditorLayoutGridPreviewDLG.LoadXMLFilePB.SetFocus();
                PropertyEditorLayoutGridPreviewDLG.LoadXMLFilePB.Click();//Load XML File
            }
            OpenFileDLG OpenFileDLG = new OpenFileDLG();
			OpenFileDLG.SetActive();
		}

		public override void Dismiss()
		{
			OpenFileDLG OpenFileDLG = new OpenFileDLG();
			OpenFileDLG.SetActive();
			OpenFileDLG.TypeKeys("<Alt-F4>");
			PropertyEditorFieldsDLG PropertyEditorFieldsDLG = new PropertyEditorFieldsDLG();
			PropertyEditorFieldsDLG.SetActive();
			PropertyEditorFieldsDLG.Dismiss();
		}
    }
}
