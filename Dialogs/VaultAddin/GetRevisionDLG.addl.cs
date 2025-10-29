// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
    public partial class GetRevisionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
		}

		public override void Invoke()
		{
			ReviseDLG ReviseDLG = new ReviseDLG();
			ReviseDLG.Invoke();
			ReviseDLG.SetActive();
            //ReviseDLG.M_RadioBtnPrimary.Select(0);
            //ReviseDLG.EnterCommentsTF.TypeKeys("Plant");
            ReviseDLG.OK.Click();
			Plant3DFunctions.CheckOutDrawing() ;
			Plant3DFunctions.CheckInDrawing();
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
			Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			Plant3DFunctions.ExpandTreeP3D(wTreeView,0,"1,2,1");
            RECT rRect = PROJECTMANAGERDLG.TreeViewTV.GetRect();
			wTreeView.Click(MouseButton.Right, rRect.xPos+8, rRect.yPos+8);
			wTreeView.TypeKeys("<Down 8><Right><Down 4><Enter>");
			System.Threading.Thread.Sleep(3000);
			GetRevisionDLG GetRevisionDLG = Current<GetRevisionDLG>();
			GetRevisionDLG.SetActive();
		}

		public override void Dismiss()
		{
			GetRevisionDLG GetRevisionDLG = Current<GetRevisionDLG>();
			GetRevisionDLG.SetActive();
			GetRevisionDLG.M_BtnCancel.Click();
			Plant3DFunctions.CheckOutDrawing();
			Plant3DFunctions.SetToDefault();
		}
    }
}
