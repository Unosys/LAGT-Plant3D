using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.Dialogs.General;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using OptionSet;
using LAGT.CommonFiles;
using LAGT.CommonFiles.Constants;
using LAGT.CommonFiles.Entities;
using LAGT.CommonFiles.Extensions.CaptureBitmaps;
using LAGT.CommonFiles.Extensions.Rectangle;
using Autodesk.GUIHarness.AutoCAD;
using Microsoft.Win32;

namespace Autodesk.GUIHarness.Plant3D.ArtScripts
{
    public partial class dlg_proj_setup_gen_set_proj_detail_general_props : ProjectSetupProjectDetailsDLG
    {


        public dlg_proj_setup_gen_set_proj_detail_general_props() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_proj_setup_gen_set_proj_detail_general_props",
                // used also for:
                //"dlg_proj_setup_gen_set_proj_detail_custom_props",
                //"db_proj_setup_proj_details_add", //Name define by persons who edit scripts , excel?
                new List<string> {
				"GUID-EDAE7506-4971-492B-A8AA-02D6EBEC691F",
                "GUID-CA0A3470-B897-4726-B258-88CB7408D467",
                //"GUID-D505F46A-9D1B-43F2-9D33-B9B425038E5C"
				//Add the GUID here
				},
                FYRelease.FY16
            );
        }
        public override void Invoke()
        {
            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "SampleProject", "") as string;

            string sProjectName = sProjectPath + "Project.xml";
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
            Thread.Sleep(1000);
            base.Invoke();
            //RECT rectangle = base.GetRect();
            //base.DragMouse(MouseButton.Left, rectangle.xSize - 2, rectangle.ySize - 2, 980, 780);
            Current<ProjectSetupProjectDetailsDLG>().Size(980, 780);
            //base.Size(980, 780);
            base.ProjectDescriptionTF.SetText("Sample PIP Project");
            base.TypeKeys("<TAB>");


        }

        public override void Capture(string SaveLocation)
        {
            //RECT Annotations = base.Pane5PANE.GetRect(true);
            //Thread.Sleep(2000);
            //CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, Annotations);

            RECT Props = base.GeneralPropertiesGB.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, Props);

            base.ProjectDataLBI.Click();
            base.TypeKeys("<Tab 2>");
            base.TypeKeys("111 McInnis Pkwy");
            base.TypeKeys("<Tab 2>");
            base.TypeKeys("San Rafael");
            base.TypeKeys("<Tab 2>");
            base.TypeKeys("CA");
            base.TypeKeys("<Tab 2>");
            base.TypeKeys("94903");
            RECT CustomProps = base.CustomPropertiesGB.GetRect(true);
            Thread.Sleep(2000);
            CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension, CustomProps);

            //ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
            //ProjectSetupProjectDetailsDLG.AddPB.Click();
            //AddCategoryDLG AddCategoryDLG = new AddCategoryDLG();
            //AddCategoryDLG.CaptureBitmap(SaveLocation + this.Information.Items[2].ToString() + ArtEngineConstants.BitmapExtension);

        }

        public override void Dismiss()
        {
            Current<ProjectSetupProjectDetailsDLG>().Size(939, 719);
            base.Dismiss();
            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "DefaultProject", "") as string;

            string sProjectName = sProjectPath + "Project.xml";
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
        }

    }
}
