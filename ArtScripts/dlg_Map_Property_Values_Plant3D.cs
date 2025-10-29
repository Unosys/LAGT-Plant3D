using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using OptionSet;
using LAGT.CommonFiles;
using LAGT.CommonFiles.Constants;
using LAGT.CommonFiles.Entities;
using LAGT.CommonFiles.Extensions.CaptureBitmaps;
using LAGT.CommonFiles.Extensions.Rectangle;
using Autodesk.GUIHarness.AutoCAD;
namespace Autodesk.GUIHarness.Plant3D.ArtScripts
{
    public partial class dlg_Map_Property_Values_Plant3D : Plant3DMainWin
    {
        private List<string> steps;

        public dlg_Map_Property_Values_Plant3D() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_Map_Property_Values_Plant3D",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-8502915B-4291-4BE7-8EDD-246916105D33"
				//Add the GUID here
				},
                FYRelease.FY16,
                false
            );
            this.steps = new List<string> {
                "1. Wait for the balloon notification to show on Status Bar",
                "2. Use SnagIt to Capture screen using 'PrtScn' button according to the source image",
            };
        }

        public override void Invoke()
        {
            //Plant3DNewExportImportSettingDLG Plant3DNewExportImportSettingDLG = new Plant3DNewExportImportSettingDLG();
            //Plant3DNewExportImportSettingDLG.Invoke();
            //Current<Plant3DNewExportImportSettingDLG>().M_treeView.Select(0);
            //Plant3DNewExportImportSettingDLG.M_treeView.TypeKeys("<Space>");
            //Plant3DNewExportImportSettingDLG.M_dataGridView.Click(MouseButton.Left, 310, 35); //Check manually with addlspy
            //System.Threading.Thread.Sleep(1000);
            //Plant3DNewExportImportSettingDLG.M_ValueMappingPB.Click();
            P3DMapPropertyValuesDLG P3DMapPropertyValuesDLG = new P3DMapPropertyValuesDLG();
            P3DMapPropertyValuesDLG.Invoke();
            P3DMapPropertyValuesDLG.SetActive();
        }

        public override void Capture(string SaveLocation)
        {
            //CollaborationRibbon CollaborationRibbon = new CollaborationRibbon();
            //Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            //RECT captureArea = AppWnd.Ribbon.GetRect(true);
            ////RECT ProjectPanel = CollaborationRibbon.ProjectPanel.GetRect(true);
            ////RECT FilePanel = CollaborationRibbon.FilePanel.GetRect(true);
            ////RECT button = IsosRibbon.ExportPanel.PCFExportPB.GetRect(true);
            //captureArea.xSize = captureArea.xSize / 2 - 100;
            //captureArea.yPos = captureArea.yPos + 20;
            //captureArea.ySize = captureArea.ySize - 20;
            ////captureArea.xSize = ProjectPanel.xSize + FilePanel.xSize;
            ////captureArea.yPos = captureArea.yPos + 30;
            ////captureArea.ySize = captureArea.ySize - 85;
            ////captureArea.xPos = captureArea.xPos + 100;
            ////captureArea.xSize = captureArea.xSize - 112;
            Current<P3DMapPropertyValuesDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

            
            //Current<AddEndcodeDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
            //LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            //Thread.Sleep(2000);
            //CaptureBitmaps.SaveSangIt(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        
        }

        public override void Dismiss()
        {
            Current<P3DMapPropertyValuesDLG>().Dismiss();

            
        }
    }
}
