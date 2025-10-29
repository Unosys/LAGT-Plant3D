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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDInsertingItemsFromToolPaleDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$DragandDropInfoDlg";
		}

        public override void Invoke()
        {
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDFunctions.CreateDrawing();
            Drawing.Current.TypeE("_Model");
            Drawing.Current.TypeE("_zoom");
            Drawing.Current.TypeE("_e");
            Drawing.Current.TypeE("_ToolPalettes");//EXECUTETOOL
            System.Threading.Thread.Sleep(2000);
            PandIDToolPalettesDLG PandIDToolPalettesDLG = new PandIDToolPalettesDLG();

            Desktop Desktop = new Desktop();
            SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\Expand.bmp");
            Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            if (LAGT.CommonFiles.Product.Variables.Language == "KOR" || LAGT.CommonFiles.Product.Variables.Language == "FRA"|| LAGT.CommonFiles.Product.Variables.Language == "JPN"||LAGT.CommonFiles.Product.Variables.Language == "RUS"||LAGT.CommonFiles.Product.Variables.Language == "CHS"||LAGT.CommonFiles.Product.Variables.Language == "DEU")
            {
                Desktop.TypeKeys("<Down 24><Enter>");//Select Fittings or Valves tab
               

            }
            else
            {
                Desktop.TypeKeys("<Down 24><Enter>");//Select Fittings or Valves tab
            }

            System.Threading.Thread.Sleep(3000);
            SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\Tool01.bmp");
            Desktop.DragMouse(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2, 200, 300);
            System.Threading.Thread.Sleep(2000);
            //if (!this.Exists) {
            //    Drawing.Current.TypeKeys("<Esc 2>");
            //    System.Threading.Thread.Sleep(2000);
            //    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\Tool01.bmp");
            //    Desktop.DragMouse(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2, 200, 300);
            //}

        }

        public override void Dismiss()
        {
            this.Close1PB.Click();
            Drawing.Current.TypeE("_ToolPalettesclose");
            Drawing.Current.TypeE("_ProjectManager");
            PandIDFunctions.DeleteDrawing();
            //Drawing.Current.TypeE("_close");
            //System.Threading.Thread.Sleep(2000);
            //PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
            //if (PandIDWarningAutoCADDLG.Exists)
            //{
            //    PandIDWarningAutoCADDLG.No.Click();
            //}
        }
    }
}
