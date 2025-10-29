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
using System;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDTagAlreadyAssignedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[DialogBox]" + AcMainWin.cBabel(23044,1,"Tag Already Assigned");
		}

        public override void Invoke()
        {
            Random rand = new Random();
            String number = rand.Next(1, 50).ToString();

            PandIDFunctions.CreateDrawingWithAnObject();
            Drawing.Current.TypeE("_ASSIGNTAG");
            Drawing.Current.TypeE("200,600");
            Drawing.Current.TypeE("");
            System.Threading.Thread.Sleep(3000);
            PandIDAssignTagDLG PandIDAssignTagDLG = new PandIDAssignTagDLG();
            if (!PandIDAssignTagDLG.Exists)
            {
                Drawing.Current.TypeE("_ASSIGNTAG");
                Drawing.Current.TypeE("200,600");
                Drawing.Current.TypeE("");
                System.Threading.Thread.Sleep(3000);
            }
            PandIDAssignTagDLG.SetActive();

            PandIDAssignTagDLG.TypeKeys("<tab 7><down><tab><down><tab><down><tab>");
            PandIDAssignTagDLG.TypeKeys(number);//3
            PandIDAssignTagDLG.AssignPB.Click();
            Drawing.Current.TypeE("_SLINE");
            Drawing.Current.TypeE("100,500");
            Drawing.Current.TypeE("100,700");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_ZOOM");
            Drawing.Current.TypeE("_EXTENTS");
            Drawing.Current.TypeE("_ASSIGNTAG");
            Drawing.Current.TypeE("100,600");
            Drawing.Current.TypeE("");
            System.Threading.Thread.Sleep(3000);
            if (!PandIDAssignTagDLG.Exists)
            {
                Drawing.Current.TypeE("_ASSIGNTAG");
                Drawing.Current.TypeE("100,600");
                Drawing.Current.TypeE("");
                System.Threading.Thread.Sleep(3000);
            }

            PandIDAssignTagDLG.TypeKeys("<tab 7><down><tab><down><tab><down><tab>");
            PandIDAssignTagDLG.TypeKeys(number);//3
            PandIDAssignTagDLG.AssignPB.Click();

        }

		public override void Dismiss()
		{
            this.Close();
            PandIDAssignTagDLG PandIDAssignTagDLG = new PandIDAssignTagDLG();
            PandIDAssignTagDLG.Dismiss();
		}
    }
}
