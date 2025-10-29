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
    public partial class UnrecognizedCharactersInLengthDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			//switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
			//{
			//	case "JPN":
			//		Tag = Plant3DFunctions.GetLocString("UnrecognizedCharactersInLengthDLG");
			//		break;

			//	default:
			//		Tag = "[MainWin]" + AcMainWin.cBabel(518, 10, "Invalid Entry") /*AcMainWin.cBabel(23035, 11, "Unrecognized Characters in Length")*/;
			//		break;
			//}
			Tag = "[MainWin]" + AcMainWin.cBabel(518, 10, "Invalid Entry") + "|" + Plant3DFunctions.GetLocString("UnrecognizedCharactersInLengthDLG");


		}

		public override void Invoke()
		{
			IsometricDWGSettingsIsoStyleSetupDLG IsometricDWGSettingsIsoStyleSetupDLG = new IsometricDWGSettingsIsoStyleSetupDLG();
			IsometricDWGSettingsIsoStyleSetupDLG.Invoke();
            if (!IsometricDWGSettingsIsoStyleSetupDLG.PlaceFieldWeldsAtCK.IsChecked)
			{
                IsometricDWGSettingsIsoStyleSetupDLG.PlaceFieldWeldsAtCK.Check();
			}
            IsometricDWGSettingsIsoStyleSetupDLG.MaximumPipeLengthTF.SetText("Len%");
            IsometricDWGSettingsIsoStyleSetupDLG.MaximumPipeLengthTF.TypeKeys("<Enter>");
		}

		public override void Dismiss()
		{
			UnrecognizedCharactersInLengthDLG UnrecognizedCharactersInLengthDLG = new UnrecognizedCharactersInLengthDLG();
			UnrecognizedCharactersInLengthDLG.SetActive();
            //UnrecognizedCharactersInLengthDLG.TypeKeys("<Alt-F4>");
            UnrecognizedCharactersInLengthDLG.ClosePB.Click();
            System.Threading.Thread.Sleep(1000);
            IsometricDWGSettingsIsoStyleSetupDLG IsometricDWGSettingsIsoStyleSetupDLG = new IsometricDWGSettingsIsoStyleSetupDLG();

            IsometricDWGSettingsIsoStyleSetupDLG.MaximumPipeLengthTF.SetText("0");            
            //IsometricDWGSettingsIsoStyleSetupDLG.TypeKeys("<Alt-F4>");
            IsometricDWGSettingsIsoStyleSetupDLG.CancelPB.Click();
            if (UnrecognizedCharactersInLengthDLG.Exists)
            {
                UnrecognizedCharactersInLengthDLG.TypeKeys("<Alt-F4>");
            }
		}
    }
}
