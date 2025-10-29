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
    public partial class CustomizeResetDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()

        {
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
                    Tag = /*"~ActiveApp/[DialogBox]" + */AcMainWin.cBabel(4750, 175, "Customize");
                    break;
                case "CHS":
                case "JPN":
                case "KOR":
                case "FRA":
                case "DEU":
                    Tag = /*"~ActiveApp/[DialogBox]" +*/ AcMainWin.cBabel(74, 1, "Customize");
                    break;
                default:
                    Tag =AcMainWin.cBabel(74, 1, "Customize") + "|" + AcMainWin.cBabel(21066, 6, "Customize");
                    break;

            }
           
		}

		public void Invoke()
		{
			CustomizationDLG CustomizationDLG = new CustomizationDLG();
			CustomizationDLG.Invoke();
			CustomizationDLG.ResetPB.Click();
            System.Threading.Thread.Sleep(3000);
            CustomizeResetDLG CustomizeResetDLG = new CustomizeResetDLG();
            CustomizeResetDLG.SetActive();
		}

		public void Dismiss()
		{
			
            CustomizeResetDLG CustomizeResetDLG = new CustomizeResetDLG();
            CustomizeResetDLG.CancelPB.Click();
			CustomizationDLG CustomizationDLG = new CustomizationDLG();
			CustomizationDLG.Dismiss();
		}
    }
}
