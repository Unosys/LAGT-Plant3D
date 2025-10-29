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
    public partial class Del_Paths_Tree_Node : Plant3DMainWin
    {
        private List<string> steps;

        public Del_Paths_Tree_Node() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "Del_Paths_Tree_Node",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-A7060C37-0A75-4210-AA53-875C51A15E38"
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
            Desktop.Current.TypeE("_ProjectSetup");
            ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            ProjectSetupProjectDetailsDLG.M_treeView.Select(AcMainWin.cBabel(21014, 1, "Paths"));
        }

        public override void Capture(string SaveLocation)
        {
            Current<ProjectSetupPathsDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);            
           
        }

        public override void Dismiss()
        {
        
            Current<ProjectSetupPathsDLG>().CancelPB.Click();
                 
        }
    }
}
