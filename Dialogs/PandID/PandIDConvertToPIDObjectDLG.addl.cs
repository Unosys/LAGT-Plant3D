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
    public partial class PandIDConvertToPIDObjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$ClassBrowserDlg";
		}

        public override void Invoke()
        {
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDFunctions.CreateDrawing();
            Drawing.Current.TypeE("_MODEL");
            Drawing.Current.TypeE("_ZOOM");
            Drawing.Current.TypeE("_EXTENTS");
            Drawing.Current.TypeE("_line");
            Drawing.Current.TypeE("10,16");
            Drawing.Current.TypeE("10,6");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_PIDCONVERT");
            Drawing.Current.TypeE("_last");
            Drawing.Current.TypeE("");
        }

		public override void Dismiss()
		{
            this.Close();
            PandIDFunctions.DeleteDrawing();
		}
    }
}
