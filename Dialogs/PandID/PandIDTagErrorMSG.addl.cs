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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using ProductTestSuite.CommonFiles;
using System.IO;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDTagErrorMSG : AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[DialogBox]" + AcMainWin.cBabel(517, 16, "Error");
        }

        public override void Invoke()
        {
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Invoke();
            Drawing.Current.TypeE("_toolpalettesclose");
            Drawing.Current.TypeE("_SDI");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("_FILEDIA");
            Drawing.Current.TypeE("1");
            PandIDPROJECTMANAGERDLG.SetActive();
            PandIDProjManUndocked pROJECTMANAGERDLG = new PandIDProjManUndocked();
            pROJECTMANAGERDLG.SetActive();
            Window wTreeView = pROJECTMANAGERDLG.TreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1");
            PandIDSelectDrawingsToCopyToProDLG PandIDSelectDrawingsToCopyToProDLG = new PandIDSelectDrawingsToCopyToProDLG();
            PandIDSelectDrawingsToCopyToProDLG.SetActive();
            PandIDSelectDrawingsToCopyToProDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\TestTag.dwg");
            PandIDSelectDrawingsToCopyToProDLG.OpenPB.Click();
            PandIDPlant3DProjectSomeFilesDLG PandIDPlant3DProjectSomeFilesDLG = new PandIDPlant3DProjectSomeFilesDLG();
            if (PandIDPlant3DProjectSomeFilesDLG.Exists)
            {
                PandIDPlant3DProjectSomeFilesDLG.SetActive();
                PandIDPlant3DProjectSomeFilesDLG.M_btnOk.Click();
            }


            pROJECTMANAGERDLG.SetActive();
            wTreeView = pROJECTMANAGERDLG.TreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");
            System.Threading.Thread.Sleep(5000);
            //Drawing.Current.TypeE("_ZOOM");
            //System.Threading.Thread.Sleep(1000);
            //Drawing.Current.TypeE("_E");
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_ASSIGNTAG");
            Drawing.Current.TypeE("10,10");
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.TypeKeys("<Enter>");
            PandIDAssignTagDLG PandIDAssignTagDLG = new PandIDAssignTagDLG();
            System.Threading.Thread.Sleep(2000);
            PandIDAssignTagDLG.TypeKeys("002");
            PandIDAssignTagDLG.AssignPB.Click();
            //    PandIDAssignTagDLG.AssignPB.Click();
            //Drawing.Current.TypeE("_ProjectManager");
            //PandIDFunctions.CreateDrawing();
            //Drawing.Current.TypeE("_ProjectManager");
            //Drawing.Current.TypeE("_ToolPalettes");
            //Drawing.Current.TypeE("_ProjectManagerClose");
            //Drawing.Current.TypeE("_Model");
            //Drawing.Current.TypeE("_zoom");
            //Drawing.Current.TypeE("_e");
            //PandIDToolPalettesDLG PandIDToolPalettesDLG = new PandIDToolPalettesDLG();
            ////PandIDToolPalettesDLG.Click(MouseButton.Left, 10, 150);//Equipment
            ////PandIDToolPalettesDLG.Click(MouseButton.Left, 100, 110);
            //Desktop Desktop = new Desktop();
            //ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\Expand.bmp");
            //Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            //if ( LAGT.CommonFiles.Product.Variables.Language == "DEU"||LAGT.CommonFiles.Product.Variables.Language == "FRA"||LAGT.CommonFiles.Product.Variables.Language == "KOR"|| LAGT.CommonFiles.Product.Variables.Language == "JPN"||LAGT.CommonFiles.Product.Variables.Language == "RUS"||LAGT.CommonFiles.Product.Variables.Language == "CHS")
            //{
            //    Desktop.TypeKeys("<Down 6><Enter>");//Equipment
            //}
            //else
            //{
            //    Desktop.TypeKeys("<Down 22><Enter>");//Equipment
            //}

            //    System.Threading.Thread.Sleep(2000);


            //    ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\ToolPalette_Item_tab1.bmp");//ToolPalette_Item_tab1.bmp
            //    Desktop.DoubleClick(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            //    System.Threading.Thread.Sleep(2000);
            //    Drawing.Current.TypeE("13,13");
            //    PandIDAssignTagDLG PandIDAssignTagDLG = new PandIDAssignTagDLG();
            //    if (PandIDAssignTagDLG.Exists)
            //    {
            //        PandIDAssignTagDLG.TypeKeys("001");

            //        PandIDAssignTagDLG.AssignPB.Click();
            //        System.Threading.Thread.Sleep(2000);
            //    }
            //if (!this.Exists)
            //{
            //    Drawing.Current.TypeKeys("<Esc 3>");
            //    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\ToolPalette_Item_tab1.bmp");//ToolPalette_Item_tab6.bmp
            //    Desktop.DoubleClick(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            //    System.Threading.Thread.Sleep(3000);
            //    Drawing.Current.TypeE("13,13");
            //    PandIDAssignTagDLG.TypeKeys("001");

            //    PandIDAssignTagDLG.AssignPB.Click();
            //}




        }

        public override void Dismiss()
        {
            this.Close();
            PandIDAssignTagDLG PandIDAssignTagDLG = new PandIDAssignTagDLG();
            PandIDAssignTagDLG.CancelPB.Click();
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_Close");
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_TOOLPALETTESCLOSE");
            Drawing.Current.TypeE("_ProjectManager");
            PandIDFunctions.DeleteDrawing();
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Dismiss();
        }
    }
}
