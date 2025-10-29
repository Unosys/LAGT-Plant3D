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
    public partial class PandIDLineGroupTagAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "#1|[DialogBox]" + AcMainWin.cBabel(21025, 1, "Tag Already assigned")+"|"+ AcMainWin.cBabel(23044, 1, "Tag Already assigned");
		}

        public override void Invoke()
        {
            PandIDFunctions.CreateDrawingWithAnObject();
            Drawing.Current.TypeE("ASSIGNTAG");
            Drawing.Current.TypeE("200,600");
            Drawing.Current.TypeE("");
            PandIDAssignTagDLG PandIDAssignTagDLG = new PandIDAssignTagDLG();
            PandIDAssignTagDLG.TypeKeys("<tab 7><down><tab><down><tab><down><tab>");
            //int i = 1;
            Random Random = new Random();
            int i = Random.Next(1, 100);
            string j = i.ToString();
            PandIDAssignTagDLG.TypeKeys(j);//3
            PandIDAssignTagDLG.AssignPB.Click();
            System.Threading.Thread.Sleep(2000);
            PandIDTagInUse PandIDTagInUse = new PandIDTagInUse();
            if (PandIDTagInUse.Exists) {
                PandIDTagInUse.OKPB.Click();
            }



                PandIDFunctions.CreateDrawingWithAnObject(null,null,"2");
                Drawing.Current.TypeE("ASSIGNTAG");
                Drawing.Current.TypeE("200,600");
                Drawing.Current.TypeE("");
                PandIDAssignTagDLG.SetActive();
                PandIDAssignTagDLG.TypeKeys("<tab 7><down><tab><down><tab><down><tab>");
               
                PandIDAssignTagDLG.TypeKeys(j);
                PandIDAssignTagDLG.AssignPB.Click();
                if (PandIDTagInUse.Exists)
                {
                    PandIDTagInUse.OKPB.Click();
                }
            
        }

		public override void Dismiss()
		{
            this.OKPB.Click();
            PandIDAssignTagDLG PandIDAssignTagDLG = new PandIDAssignTagDLG();
            PandIDAssignTagDLG.CancelPB.Click();
            PandIDFunctions.DeleteDrawing();
            PandIDFunctions.DeleteDrawing();
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Dismiss();
		}
    }
}
