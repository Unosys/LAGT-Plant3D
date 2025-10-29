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
    public partial class dlg_Select_Block_Drawing : Plant3DMainWin
    {
        private List<string> steps;

        public dlg_Select_Block_Drawing() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_Select_Block_Drawing",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-F9D696F1-BAC6-45AF-9AEF-77425FDAA3F0"
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
            //Desktop.Current.TypeE("_PROJECTMANAGER");
            ProjectSetupEndConnectionDLG ProjectSetupEndConnectionDLG = new ProjectSetupEndConnectionDLG();
            ProjectSetupEndConnectionDLG.Invoke();
            Current<ProjectSetupEndConnectionDLG>().M_btnAddBlock.Click();
            Current<NewEndConnectionDLG>().M_btnBrowse.Click();
            Current<SelectBlockDrawingDLG>().SetActive();
            Current<SelectBlockDrawingDLG>().FileNameCB.Click();
            Current<SelectBlockDrawingDLG>().FileNameCB.TypeKeys("C:\\AutoCAD Plant 3D Osaka Content<ENTER>");
            Current<SelectBlockDrawingDLG>().FileNameCB.TypeKeys("<CTRL-A><DELETE>");

        }

        public override void Capture(string SaveLocation)
        {
            //LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            //Thread.Sleep(1000);
            Current<SelectBlockDrawingDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

            //LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            //Thread.Sleep(2000);
            //CaptureBitmaps.SaveSangIt(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        
        }

        public override void Dismiss()
        {
            Current<SelectBlockDrawingDLG>().Cancel.Click();
            Current<NewEndConnectionDLG>().M_btnCancel.Click();
            Current<ProjectSetupEndConnectionDLG>().CancelPB.Click();
        }
    }
}
