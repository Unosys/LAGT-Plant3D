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
    public partial class CreateQuickIsoDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            //Tag = "$QuickIsoCreate";
            Tag = "[Pane]$QuickIsoCreate";
		}

		public override void Invoke()
		{
            Plant3DFunctions.CreateDrawing("P3D",null, null, null);
		    Drawing.Current.TypeE ("_Erase");
		    Drawing.Current.TypeE ("_All");
		    Drawing.Current.TypeE ("");
		    Drawing.Current.TypeE("_PLANTPIPEADD");
		    Drawing.Current.TypeE("50,60");
		    Drawing.Current.TypeE("50,30");
		    Drawing.Current.TypeE("");
		    Drawing.Current.TypeE("_ZOOM");
		    Drawing.Current.TypeE("_EXTENTS");
		    Drawing.Current.TypeE("_PLANTQUICKISO");
		    Drawing.Current.TypeE("50,40");
            Drawing.Current.TypeE("");
		}

		public override void Dismiss()
		{
            CreateQuickIsoDLG CreateQuickIsoDLG = new CreateQuickIsoDLG();
            CreateQuickIsoDLG.SetActive();
            CreateQuickIsoDLG.Button_Cancel.Click();
			Drawing.Current.TypeE("_Close");
			System.Threading.Thread.Sleep(1000);
			SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
			if (SaveChangesMSG.WaitExists(2000))
			{
				SaveChangesMSG.NoPB.Click();

			}
			ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
			
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
