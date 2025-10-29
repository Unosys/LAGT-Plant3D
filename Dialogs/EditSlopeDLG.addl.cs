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
    public partial class EditSlopeDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$PipeSlopeToolDlg";
		}

		public void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
            Plant3DFunctions.CreateDrawing("P3D", null, null, null);
			Drawing.Current.SetSysVar("DYNMODE", -3);
			Drawing.Current.TypeE("_PlantPipeAdd");
			Drawing.Current.TypeE("1000,1000");
			Drawing.Current.TypeE("1500");
			Drawing.Current.TypeE("");
			Drawing.Current.SetSysVar("DYNMODE", 0);
			Drawing.Current.TypeE("_PLANTPIPESLOPE");
			Drawing.Current.TypeE("_last");
		}

		public void Dismiss()
		{
			EditSlopeDLG EditSlopeDLG = new EditSlopeDLG();
			EditSlopeDLG.M_bt_Cancel.Click();
			Drawing.Current.TypeE("_ProjectManager");
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
