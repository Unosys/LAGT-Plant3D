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
    public partial class dlg_isothemesdefaulttheme : IsoThemesDLG
    {


        public dlg_isothemesdefaulttheme() // add the constructor name as filename for each dialog
        //used also for:
        //"dlg_isothemesoverridethemes",
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_isothemesdefaulttheme",  //Name define by persons who edit scripts , excel?
                new List<string> {
				"GUID-0F0B6036-DACF-4FE2-8EE1-A03F552FD8EE",
                "GUID-85E86D68-79E9-41A0-B3F2-02C0D334D61A",
				//Add the GUID here
				},
                FYRelease.FY15
            );
        }
        public override void Invoke()
        {
            base.Invoke();
            base.MoveMouse(50, 100);

        }

        public override void Capture(string SaveLocation)
        {
            Current<IsoThemesDLG>().CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);

            //base.OverrideThemesWIN.Click();
            //base.DropDownButton2PB.Click();
            base.TypeKeys("<Down 4><Enter>");
            base.MoveMouse(0, 50);
            Thread.Sleep(1000);
            IsoThemesDLG IsoThemesDLG = new IsoThemesDLG();
            IsoThemesDLG.CaptureBitmap(SaveLocation + this.Information.Items[1].ToString() + ArtEngineConstants.BitmapExtension);

        }

        public override void Dismiss()
        {
            base.Dismiss();
        }

    }
}
