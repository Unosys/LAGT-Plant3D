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

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PropertiesPallete : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[CustomWin]" + AcMainWin.cBabel(540, 13, "Properties");
        }

        public override void Invoke()
        {
            ProjManUndocked projectmanagerDLG = new ProjManUndocked();
            //projectmanagerDLG.Invoke();
            projectmanagerDLG.SetActive();
            Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,2");
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "TestPallete.dwg");
            SelectDrawingsToCopyToProDLG.Open.Click();
            AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
            if (AutoCADPlant3DMigrationDLG.WaitExists(2000))
            {
                AutoCADPlant3DMigrationDLG.BackupTheDrawingBeforeCK.Uncheck();
                Desktop.Current.TypeKeys("<enter>"); //close migration
            }
            projectmanagerDLG.SetActive();
            Window WTreeView = projectmanagerDLG.TreeViewTV;
            projectmanagerDLG.TreeViewTV.Select(AcMainWin.cBabel(23039, 2, "Default Project"));
            Plant3DFunctions.ExpandTreeP3D(WTreeView, 1, "0,1,1");


            //         PandIDPROJECTMANAGERDLG pROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            //         pROJECTMANAGERDLG.Invoke();
            //         Plant3DFunctions.CreateDrawing("P3D", null, null, null);


            //         Drawing.Current.TypeE("_Erase");
            //         Drawing.Current.TypeE("_All");
            //         Drawing.Current.TypeE("");

            //         Drawing.Current.TypeE("_ZOOM");
            //         Drawing.Current.TypeE("_EXTENTS");

            //         Drawing.Current.TypeE("_ToolPalettes");
            //         PandIDToolPalettesDLG toolPalettesDLG = Current<PandIDToolPalettesDLG>();          
            //         Desktop Desktop = new Desktop();
            //         SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\Expand.bmp");
            //         Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            //         System.Threading.Thread.Sleep(2000);
            //         if (LAGT.CommonFiles.Product.Variables.Language == "KOR" || LAGT.CommonFiles.Product.Variables.Language == "FRA" || LAGT.CommonFiles.Product.Variables.Language == "JPN" || LAGT.CommonFiles.Product.Variables.Language == "RUS" || LAGT.CommonFiles.Product.Variables.Language == "CHS" || LAGT.CommonFiles.Product.Variables.Language == "DEU")
            //         {
            //             Desktop.TypeKeys("<Down 1><Enter>");//Dynamic Pipe Spec
            //         }
            //         else
            //         {
            //             Desktop.TypeKeys("<Down 1><Enter>");//Dynamic Pipe Spec
            //         }

            //         System.Threading.Thread.Sleep(2000);

            //         SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SAMScreenshots\\Vaule_item_02.bmp");//select one item from Value
            //         Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            //         System.Threading.Thread.Sleep(2000);
            //         Drawing.Current.TypeE("100,100");
            //         Drawing.Current.TypeE("0"); 
            //         Drawing.Current.TypeE("<Enter>");
            //Drawing.Current.TypeE("<Esc 3>");
            //         Drawing.Current.TypeE("_ZOOM");
            //         Drawing.Current.TypeE("_EXTENTS");
            ////////////////////////updated for FY23//
            LoadUnloadApplicationsDLG LoadUnloadApplicationsDLG = new LoadUnloadApplicationsDLG();
            LoadUnloadApplicationsDLG.Reload();
            //////////////////
            Drawing.Current.TypeE("_ai_selall");
            Drawing.Current.TypeE("_Properties");
            this.Move(10,10);
            this.SetSize(500,1000);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeE("_PROPERTIESCLOSE");
            Plant3DFunctions.DeleteDrawing("P3D");
           
        }
        public void SetSize(int xRestSize, int yRestSize)
        {
            RECT r = this.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                this.Click(MouseButton.Right, 8, 70);
                Desktop.Current.TypeKeys("<Down 2><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
    }
}
