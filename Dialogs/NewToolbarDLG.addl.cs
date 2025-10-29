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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class NewToolbarDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            //Tag = "[Pane]New Toolbar";
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "JPN":
                    Tag = "[Pane]*" + AcMainWin.cBabel(461, 4, "Tool") + "*";
                    break;
                case "DEU":
                    Tag = "[Pane]Neuer Werkzeugkasten";// + AcMainWin.cBabel(149, 1, "New Toolbar");
                    break;
                //case "RUS":
                //    Tag = "";
                //    break;
                case "CHS":
                    Tag = "[Pane]*" + AcMainWin.cBabel(461, 4, "Tool") + "*";
                    break;
                //case "FRA":
                //    Tag = "";
                //    break;
                //case "CHT":
                //    Tag = "";
                //    break;
                //case "KOR":
                //    Tag = "";
                //    break;
                
                default:
                    Tag = "[Pane]*" + AcMainWin.cBabel(461, 4, "Tool") + "*";
                    break;
            }

        }

        public void Invoke()
		{
			CustomizationDLG CustomizationDLG = new CustomizationDLG();
			CustomizationDLG.Invoke();
			CustomizationDLG.NewPB.Click();
            System.Threading.Thread.Sleep(2000);

        }

		public  void Dismiss()
		{
			this.CancelPB.Click();
			CustomizationDLG CustomizationDLG = new CustomizationDLG();
			CustomizationDLG.Dismiss();
		}
    }
}
