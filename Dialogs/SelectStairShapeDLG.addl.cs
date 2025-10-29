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
    public partial class SelectStairShapeDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
                
                case "KOR":
                    Tag = "*"+AcMainWin.cBabel(23020, 1, "Stair Shape") + "*|계단 쉐이프 선택";
                    break;
                //case "ITA":
                //    Tag = "";
                //    break;
                //case "ESP":
                //    Tag = "";
                //    break;
                //case "CSY":
                //    Tag = "";
                //    break;
                default:
                    Tag = "[DialogBox]" + AcMainWin.cBabel(23046, 8, "Select") + AcMainWin.cBabel(23020, 1, "Stair Shape") + "*|*Select Stair Shape*|*" + AcMainWin.cBabel(23020, 1, "Stair Shape") + "*";

                    break;
            }
        }

		public override void Invoke()
		{
			StairSettingsDLG StairSettingsDLG = new StairSettingsDLG();
			StairSettingsDLG.Invoke();
            System.Threading.Thread.Sleep(4000);
			StairSettingsDLG.StairShape.Click();
		}

		public override void Dismiss()
		{
			SelectStairShapeDLG SelectStairShapeDLG = new SelectStairShapeDLG();
			SelectStairShapeDLG.Cancel.Click();
			StairSettingsDLG StairSettingsDLG = new StairSettingsDLG();
			StairSettingsDLG.Dismiss();
		}
    }
}
