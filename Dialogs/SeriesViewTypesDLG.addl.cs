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
    public partial class SeriesViewTypesDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$ViewTypesForm";
		}

		public  void Invoke()
		{
			SeriesCollectionEditorPointsDLG SeriesCollectionEditorPointsDLG = new SeriesCollectionEditorPointsDLG();
			SeriesCollectionEditorPointsDLG.Invoke();
			System.Threading.Thread.Sleep(2000);
			SeriesCollectionEditorPointsDLG.AddPB.Click();
			SeriesViewTypesDLG SeriesViewTypesDLG = new SeriesViewTypesDLG();
			
			SeriesViewTypesDLG.SetActive();
		}

		public  void Dismiss()
		{
			SeriesViewTypesDLG SeriesViewTypesDLG = new SeriesViewTypesDLG();
			SeriesViewTypesDLG.SetActive();
			SeriesViewTypesDLG.TypeKeys("<Alt-F4>");
			SeriesCollectionEditorPointsDLG SeriesCollectionEditorPointsDLG = new SeriesCollectionEditorPointsDLG();
			SeriesCollectionEditorPointsDLG.SetActive();
			SeriesCollectionEditorPointsDLG.Dismiss();
		}
		public void Move(int xPos, int yPos)
		{

			SeriesViewTypesDLG SeriesViewTypesDLG = new SeriesViewTypesDLG();

			
			System.Threading.Thread.Sleep(1000);

			RECT r = SeriesViewTypesDLG.GetRect(true);
			if (r.xPos < (xPos - 30) || r.yPos < (yPos - 30) || r.xPos > (xPos + 30) || r.yPos > (yPos + 30))
			{
				Desktop Desktop = new GUIHarness.Desktop();
				Desktop.Click(MouseButton.Right, r.xPos+10, r.yPos+5);
				Desktop.TypeKeys("<Down 2><Enter>");
				Desktop.TypeKeys("<Right><Down>");
				Desktop.Click(MouseButton.Left, r.xPos, r.yPos-200);
			}

		}

	}
}
