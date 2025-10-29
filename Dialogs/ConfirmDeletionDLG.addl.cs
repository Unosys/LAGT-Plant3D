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
    public partial class ConfirmDeletionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            
            Tag = "[DialogBox]" + AcMainWin.cBabel(426, 34, "Confirm Delete") + "|*" + AcMainWin.cBabel(23062, 7, "Confirm ") + "*|"+ AcMainWin.cBabel(21067, 1, "Confirm Deletion");

        }

		public override void Invoke()
		{

            AddJointDLG AddJointDLG = new AddJointDLG();
            P3DSelectClassPropertyDLG P3DSelectClassPropertyDLG = new P3DSelectClassPropertyDLG();
            P3DSelectClassPropertyDLG.Invoke();
            P3DSelectClassPropertyDLG.M_button_ok.Click();
            AddJointDLG.DeletePB.Click();



        }

		public override void Dismiss()
		{
            ConfirmDeletionDLG ConfirmDeletionDLG=new ConfirmDeletionDLG();
            ConfirmDeletionDLG.YesPB.Click();
            AddJointDLG AddJointDLG = new AddJointDLG();
            AddJointDLG.Dismiss();



        }
    }
}
