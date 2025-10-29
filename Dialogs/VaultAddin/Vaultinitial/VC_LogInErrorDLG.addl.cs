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

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class VC_LogInErrorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$CommonMessageBox";
		}

		public void Invoke()
		{
			VC_LogInDLG VC_LogInDLG = new VC_LogInDLG();
            VC_LogInDLG.Invoke();
            VC_LogInDLG.LoginTypePL.Select(2);
            VC_LogInDLG.OKPB.Click();
            if (!this.WaitExists(20000))
            {
                System.Threading.Thread.Sleep(20000);
            }
		}

		public void Dismiss()
		{
			VC_LogInErrorDLG VC_LogInErrorDLG = Current<VC_LogInErrorDLG>();
            VC_LogInErrorDLG.ClosePB.Click();
            VC_LogInDLG VC_LogInDLG = new VC_LogInDLG();
            VC_LogInDLG.LoginTypePL.Select(1);
            VC_LogInDLG.Dismiss();
		}
    }
}
