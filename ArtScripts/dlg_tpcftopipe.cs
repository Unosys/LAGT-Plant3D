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
    public partial class dlg_tpcftopipe : PCFINSelectFileDLG
    {

        public dlg_tpcftopipe() // add the constructor name as filename for each dialog
        {
            //also used for:
            //dlg_tpcftopipe_err
            //dlg_pcftopipe_map

            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_tpcftopipe",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-8306585E-EEF0-4E61-846C-98D21FFBB3B5",
                    "GUID-1DC49440-66A8-4328-AF9B-E1EB9D95F9CE",
                    "GUID-C71B84F2-DA8E-4CD2-B1FB-B93C9E4DAAF9",
				//Add the GUID here
				},
                FYRelease.FY16
            );
        }

        public override void Invoke()
        {
            base.Invoke();
            base.FileNameCB.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PCF\\SampleIsoPreview.pcf");
            base.OpenPB.Click();
            PCFINListDLG PCFINListDLG = new PCFINListDLG();
            PCFINListDLG.PushButton2PB.Click();
            PCFINSelectFileDLG PCFINSelectFileDLG = new PCFINSelectFileDLG();
            PCFINSelectFileDLG.FileNameCB.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PCF\\L123.pcf");
            PCFINSelectFileDLG.OpenPB.Click();
            PCFINListDLG.PushButton2PB.Click();
            PCFINSelectFileDLG.FileNameCB.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PCF\\L528.pcf");
            PCFINSelectFileDLG.OpenPB.Click();
            PCFINListDLG.PipeSettingsPB.Click();
            PCFINSettingsDLG PCFINSettingsDLG = new PCFINSettingsDLG();
            PCFINSettingsDLG.PCFINPL.Select(1);
            PCFINSettingsDLG.OKPB.Click();

           
        }

        public override void Capture(string SaveLocation)
        {
            PCFINListDLG PCFINListDLG = new PCFINListDLG();
            Thread.Sleep(1000);
            PCFINListDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

            PCFINListDLG.PipeSettingsPB.Click();
            PCFINSettingsDLG PCFINSettingsDLG = new PCFINSettingsDLG();
            PCFINSettingsDLG.PCFINPL.Select(27);
            //PCFINSettingsDLG.PCFINPL.TypeKeys("<Up 12><Enter>");
            PCFINSettingsDLG.CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension);
            PCFINSettingsDLG.PCFINPL.PressMouse(MouseButton.Left,20,20);
            PCFINSettingsDLG.PCFINPL.PressMouse(MouseButton.Left,20,20);
            Thread.Sleep(1000);
            PCFINSettingsDLG.CaptureBitmap(SaveLocation + this.Information.Items[2].ToString() + ArtEngineConstants.BitmapExtension);

        }

        public override void Dismiss()
        {
            PCFINSettingsDLG PCFINSettingsDLG = new PCFINSettingsDLG();
            PCFINSettingsDLG.Dismiss();
            //PCFINListDLG PCFINListDLG = new PCFINListDLG();
            //PCFINListDLG.Dismiss();
        }
    }
}
