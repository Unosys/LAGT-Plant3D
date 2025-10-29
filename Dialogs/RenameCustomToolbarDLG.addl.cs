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
    public partial class RenameCustomToolbarDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            //Tag = "[Pane]|#1"; // "DevExpress.XtraBars.Customization.BarForm";
            // Tag="[Pane]Rename Toolbar|#1";//"[Pane]#2";
            //Tag = "[Pane]Renommer la barre d'outils|#2";
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "JPN":
                    Tag = "[Pane]*" + AcMainWin.cBabel(461, 4, "Tool") + "*";
                    break;
                //case "DEU":
                //    Tag = "";
                //    break;
                //case "DEU":
                //    Tag = "";
                //    break;
                case "RUS":
                    Tag = "*"+AcMainWin.cBabel(461, 4, "Tool")+"*";
                    break;
                //case "CHS":
                //    Tag = "";
                //    break;
                case "FRA":
                    Tag = "[Pane]Renommer la barre d'outils|#2";
                    break;
                //case "CHT":
                //    Tag = "";
                //    break;
                //case "PTB":
                //    Tag = "";
                //    break;
                //case "PLK":
                //    Tag = "";
                //    break;
                //case "KOR":
                //    Tag = "";
                //    break;
                //case "ITA":
                //    Tag = "";
                //    break;
                //case "ESP":
                //    Tag = "";
                //    break;
                //case "CSY":
                //    Tag = "";
                    //break;
                default:
                    Tag = "[Pane]*" + AcMainWin.cBabel(461, 4, "Tool") + "*";
                    break;
            }
        

    }

		public void Invoke()
		{
            NewCustomToolbarDLG NewCustomToolbarDLG = new NewCustomToolbarDLG();
			NewCustomToolbarDLG.Invoke();
			NewCustomToolbarDLG.SetActive();
			NewCustomToolbarDLG.BtNBDlgOk.Click();
			CustomizationDLG CustomizationDLG = new CustomizationDLG();
			CustomizationDLG.SetActive();
			CustomizationDLG.RenamePB.Click();
			RenameCustomToolbarDLG RenameCustomToolbarDLG = new RenameCustomToolbarDLG();
			RenameCustomToolbarDLG.SetActive();
		}

		public void Dismiss()
		{
			RenameCustomToolbarDLG RenameCustomToolbarDLG = new RenameCustomToolbarDLG();
			RenameCustomToolbarDLG.BtNBDlgCancel.Click();
			CustomizationDLG CustomizationDLG = new CustomizationDLG();
			CustomizationDLG.Dismiss();
		}
    }
}
