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
    public partial class Collaboration_Options_db : CollaborationOptionsDLG
    {
        private List<string> steps;

        public Collaboration_Options_db() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "Collaboration_Options_db",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-D57CF7E2-79AD-49B8-A370-88114DDA70AE"
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
            base.Invoke();
            base.SetActive();
        }

        public override void Capture(string SaveLocation)
        {

            Current<CollaborationOptionsDLG>().SpecifyWorkingFolderForCK.Click();
            Thread.Sleep(1000);
            Current<CollaborationOptionsDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
                         
        }

        public override void Dismiss()
        {
            base.Dismiss();
            
        }
    }
}
