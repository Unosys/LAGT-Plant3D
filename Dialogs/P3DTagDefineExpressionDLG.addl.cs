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
    public partial class P3DTagDefineExpressionDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$DefineExpressionDlg";
		}

		public  void Invoke()
		{
			P3DTagFormatSetupDLG P3DTagFormatSetupDLG = new P3DTagFormatSetupDLG();
			P3DTagFormatSetupDLG.Invoke();
            System.Threading.Thread.Sleep(2000);
			P3DTagFormatSetupDLG.M_btnExpression.Click();
		}

		public  void Dismiss()
		{
			P3DTagDefineExpressionDLG P3DTagDefineExpressionDLG = new P3DTagDefineExpressionDLG();
			P3DTagDefineExpressionDLG.M_cancelButton.Click();
			P3DTagFormatSetupDLG P3DTagFormatSetupDLG = new P3DTagFormatSetupDLG();
			P3DTagFormatSetupDLG.Dismiss();
		}
    }
}
