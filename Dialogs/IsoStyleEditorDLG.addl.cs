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
    public partial class IsoStyleEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[MainWin]$Window_1"+"|" + AcMainWin.cBabel(23165, 30, "Iso Style Editor")+"*C*";
            //Tag = "[MainWin]Iso Style Editor*";//
        }

        public override void Invoke()
        {
            ProjectSetupIsoThemesDLG ProjectSetupIsoThemesDLG = new ProjectSetupIsoThemesDLG();
            ProjectSetupIsoThemesDLG.Invoke();
            ProjectSetupIsoThemesDLG.XMLPB.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public override void Dismiss()
        {
            IsoStyleEditorDLG IsoStyleEditorDLG = new IsoStyleEditorDLG();
            IsoStyleEditorDLG.ClosePB.Click();
            IsoStyleEditorSaveDLG IsoStyleEditorSaveDLG = new IsoStyleEditorSaveDLG();
            
            if (IsoStyleEditorSaveDLG.Exists) {
                IsoStyleEditorSaveDLG.Dismiss();
            }
            ProjectSetupIsoThemesDLG ProjectSetupIsoThemesDLG = new ProjectSetupIsoThemesDLG();
            ProjectSetupIsoThemesDLG.Dismiss();

        }
        public partial class MenuItem : Control
        {
            //partial void OnInitialize()
            //{
            //}
            public void Pick()
            {
                this.Click(MouseButton.Left, 1, 1);
            }
        }
    }
}
