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
    public partial class DB_Proj_Setup_Shared_Plant_Content : Plant3DMainWin
    {
        private List<string> steps;

        public DB_Proj_Setup_Shared_Plant_Content() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "DB_Proj_Setup_Shared_Plant_Content",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-ED2BCFEA-073C-4B38-A38F-F41AA73BEF23"
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
            Desktop.Current.TypeE("_projectsetup");
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = Current<ProjectSetupProjectDetailsDLG>();
            ProjectSetupProjectDetailsDLG.SetActive();
            //ProjectSetupProjectDetailsDLG.M_treeView.Select("Shared Plant Content");
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(23073, 26, "Shared Plant Content"));
        }

        public override void Capture(string SaveLocation)
        {
            Current<ProjectSetupSharedPlantContentDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);            
           
        }

        public override void Dismiss()
        {

            Current<ProjectSetupSharedPlantContentDLG>().CancelPB.Click();
                 
        }
    }
}
