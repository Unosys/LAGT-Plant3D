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
    public partial class dlg_add_endcode : AddEndcodeDLG
    {

        public dlg_add_endcode() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_add_endcode",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-B47EB802-DD39-4034-9AD3-D54F0065E4EA"
				//Add the GUID here
				},
                FYRelease.FY16
            );
        }

        public override void Invoke()
        {
            base.Invoke();
            base.SetActive();
            base.TxtboxEndcode.SetText("TC");
            base.TxtboxDesc.SetText("Triclover Joint");
            base.TypeKeys("<TAB>");
        }

        public override void Capture(string SaveLocation)
        {
            Current<AddEndcodeDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);
        }

        public override void Dismiss()
        {
            base.CancelPB.Click();
            ManageEndcodesDLG ManageEndcodesDLG = new ManageEndcodesDLG();
            if (ManageEndcodesDLG.Exists)
            {
                ManageEndcodesDLG.Dismiss();
            }
        }
    }
}
