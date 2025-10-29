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
    public partial class ProjectSetupOrthoTitleBlockAndDisplay : Plant3DMainWin
    {
        private List<string> steps;

        public ProjectSetupOrthoTitleBlockAndDisplay() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "ProjectSetupOrthoTitleBlockAndDisplay",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-99E95A25-404F-4A3D-B086-7911B4D2B480"
				//Add the GUID here
				},
                FYRelease.FY16,
                false
            );
            this.steps = new List<string> {
                "1. Navigate to Path 'c:\\AutoCAD Plant 3D Osaka Content' ",
                "2. click on 'OK Button'",
            };
        }

        public override void Invoke()
        {
            //Desktop.Current.TypeE("_PROJECTSETUP");
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.Invoke();
            Current<ProjectSetupProjectDetailsDLG>().M_treeView.TypeKeys("<HOME><LEFT-UP>");
            Current<ProjectSetupProjectDetailsDLG>().OrthoDWGSettingsTVI.TypeKeys("<Add><Down>");
            ProjectSetupTitleBlockandDisplayDLG ProjectSetupTitleBlockandDisplayDLG = new ProjectSetupTitleBlockandDisplayDLG();
            ProjectSetupTitleBlockandDisplayDLG.SetActive();
        }

        public override void Capture(string SaveLocation)
        {
            Thread.Sleep(500);
            Current<ProjectSetupTitleBlockandDisplayDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

            
        }

        public override void Dismiss()
        {
            Current<ProjectSetupTitleBlockandDisplayDLG>().CancelPB.Click();
          
        }
    }
}
