// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2015 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DIsoStyleEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>

        partial void OnInitialize()
        {
            Tag = "[DialogBox]" + AcMainWin.cBabel(23165, 29, "Plant 3D Iso Style Editor");//"[MainWin]Plant 3D Iso Style Editor"
        }
        public override void Invoke()
        {
            IsoStyleEditorSaveDLG IsoStyleEditorSaveDLG = new IsoStyleEditorSaveDLG();
            IsoStyleEditorSaveDLG.Invoke();
            IsoStyleEditorSaveDLG.SaveMyChangesST.Click();
            System.Threading.Thread.Sleep(1000);
            //IsoStyleEditorSave IsoStyleEditorSave = new IsoStyleEditorSave();
            //IsoStyleEditorSave.OKPB.Click();
            Desktop Desktop = new Desktop();
            Desktop.TypeKeys("<Enter>");
            System.Threading.Thread.Sleep(1000);
            ProjectSetupIsoThemesDLG ProjectSetupIsoThemesDLG = new ProjectSetupIsoThemesDLG();
            
            ProjectSetupIsoThemesDLG.XMLPB.Click();
            System.Threading.Thread.Sleep(1000);
        }

        public override void Dismiss()
        {
            this.DoNotOpenThePB.Click();
            
            ProjectSetupIsoThemesDLG ProjectSetupIsoThemesDLG = new ProjectSetupIsoThemesDLG();
            ProjectSetupIsoThemesDLG.Dismiss();
        }
    }
}
