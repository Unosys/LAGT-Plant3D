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
    public partial class OrthoGenerationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Window]$Window_1|#1";


        }

        public override void Invoke()
		{
			Plant3DFunctions.OpenSampleProject();
			ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
			PROJECTMANAGERDLG.SetActive();
			System.Threading.Thread.Sleep(2000);
			PROJECTMANAGERDLG.SetTab(2);
			Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			//Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");

			PROJECTMANAGERDLG.SetActive();
			Plant3DFunctions.ExpandTreeP3D(PROJECTMANAGERDLG.TreeViewTV, 4, "0,1");
			System.Threading.Thread.Sleep(2000);
			Drawing.Current.TypeE("_PLANTORTHOSINGLELINEDISPLAY");
			Drawing.Current.TypeE("1");
			Drawing.Current.TypeE("_ZOOM");
			Drawing.Current.TypeE("_ALL");
			Drawing.Current.TypeE("_PLANTORTHOSINGLELINEPIPING");
			System.Threading.Thread.Sleep(1000);
			Drawing.Current.TypeE("1.217,13.269");
			System.Threading.Thread.Sleep(1000);
			Drawing.Current.TypeE("_Allpiping");
			System.Threading.Thread.Sleep(1000);
			Drawing.Current.TypeE("_Update");
		}

        public override void Dismiss()
		{
			OrthoGenerationDLG OrthoGenerationDLG = new OrthoGenerationDLG();
			for (int i = 0; i < 3; i++)
			{
				if (OrthoGenerationDLG.WaitExists(5000))
				{
					System.Threading.Thread.Sleep(10000);
				}
			}
			Drawing.Current.TypeKeys("<ESC>");
			System.Threading.Thread.Sleep(1000);
			Drawing.Current.TypeE("_Close");
			Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();

			if (SaveChangesMSG.WaitExists(2000))
			{
				SaveChangesMSG.NoPB.Click();

			}
			Plant3DFunctions.SetToDefault();
		}
    }
}
