// $Header: //streams/main/TD/UIAutomation/Harness/ACADHarness/Dialogs/PandIDFieldDLG.addl.cs#2 $ 
// $Change: 383451 $ $DateTime: 2013/09/17 00:51:53 $ $Author: liusi $
//
// (C) Copyright 2013 by Autodesk, Inc.
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
    public partial class PandIDFieldDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
 	  public string FeatureType = "Dialog";
      public string releaseVer = "2016"; 
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// <summary>
		partial void OnInitialize()
		{
           // Tag="~ActiveApp/[DialogBox]Field";
			//Tag = "../[DialogBox]" + AcMainWin.cBabel(425,1,"Field")  ;
            Tag = "[DialogBox]" + AcMainWin.cBabel(425,1,"Field")  ;
		}
        public override void Invoke()
        {
            Drawing.Current.TypeE("_FIELD");
        }

        public override void Dismiss()
        {
            this.CancelPB.SetFocus();
            this.CancelPB.Click();
        }
    }
}
