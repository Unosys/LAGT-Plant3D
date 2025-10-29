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
    public partial class OpenRTFDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
					Tag = Plant3DFunctions.GetLocString("OpenImageDLG") + "|" + AcMainWin.cBabel(250, 14, "Open");

					break;

                default:
                    Tag = "[DialogBox]" + AcMainWin.cBabel(250, 14, "Open");
                    break;

            }
        }

		public override void Invoke()
		{
			RichTextTasksDLG RichTextTasksDLG = new RichTextTasksDLG();
			RichTextTasksDLG.Invoke();
            Desktop Desktop = new Desktop();
			
			switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
			{
				case "DEU":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\LoadFile\\DEU_LoadFile.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 10, SAM.iYCoord + 10);
                    break;
                case "JPN":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\LoadFile\\JPN_LoadFile.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 10, SAM.iYCoord + 10);
                    break;
                case "RUS":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\LoadFile\\RUS_LoadFile.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 10, SAM.iYCoord + 10);
                    break;
                case "FRA":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\LoadFile\\FRA_LoadFile.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 10, SAM.iYCoord + 10);
                    break;
                case "CHS":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\LoadFile\\CHS_LoadFile.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 10, SAM.iYCoord + 10);
                    break;
                case "KOR":
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\LoadFile\\KOR_LoadFile.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 10, SAM.iYCoord + 10);
                    break;
                default:
                    
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\LoadFile\\LoadFile.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 10, SAM.iYCoord + 10);
                    break;

			}
		}

		public override void Dismiss()
		{
			OpenRTFDLG OpenRTFDLG = new OpenRTFDLG();
			OpenRTFDLG.SetActive();
			OpenRTFDLG.TypeKeys("<Alt-F4>");
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
