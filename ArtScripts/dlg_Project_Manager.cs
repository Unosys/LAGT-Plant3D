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
    public partial class dlg_Project_Manager : Plant3DMainWin
    {
        private List<string> steps;

        public dlg_Project_Manager() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_Project_Manager",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-C6F84AFE-336F-4C9F-9834-80388D8DCB42"
				//Add the GUID here
				},
                FYRelease.FY16,
                true
            );
            this.steps = new List<string> {
                "1. click on preview in Preview Pane like search icon(2nd option) ",
                "2. click on 'Ok' button",
            };
        }

        public override void Invoke()
        {
            Desktop.Current.TypeE("_projectmanager");
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("1");
            Current<PROJECTMANAGERDLG>().SetActive();

        }

        public override void Capture(string SaveLocation)
        {

            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            Thread.Sleep(1000);
            Current<PROJECTMANAGERDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
            
        }

        public override void Dismiss()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.Size(653, 635);
            Drawing.Current.TypeE("COLORTHEME");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("TOOLTIPS");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("_RIBBONCLOSE");
            Drawing.Current.TypeE("MENUBAR");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            Drawing.Current.TypeE("_TOOLPALETTES");

            
        }
    }
}
