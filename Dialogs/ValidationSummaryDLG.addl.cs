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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ValidationSummaryDLG : CustomWin
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            //Tag = "Validation Summary"; // "AfxWnd110u";
            Tag = "[CustomWin]";
		}

		public void Invoke()
		{
			Plant3DFunctions.DeleteAllDrawings();
            Plant3DFunctions.CreateDrawing("PANDID", "no", "Temp{RandInt(2,9)}");
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Dismiss();
			Drawing.Current.TypeE("_ToolpalettesClose");
			Drawing.Current.TypeE("_Sline");
			Drawing.Current.TypeE("50,50");
			Drawing.Current.TypeE("100,50");
			if (!Drawing.Current.ReadyForNextCommand())
			{
				Drawing.Current.TypeE("");
			}
			Drawing.Current.TypeE("_VALIDATE");
			ValidationSummaryDLG ValidationSummaryDLG = new ValidationSummaryDLG();
            //ValidationSummaryDLG.Undock(); //Check this method in ValidationSummaryDLG
			System.Threading.Thread.Sleep(5000);
		}

		public void Dismiss()
		{
			Drawing.Current.TypeE("_VALIDATESUMMARYCLOSE");
		}
    }
}
