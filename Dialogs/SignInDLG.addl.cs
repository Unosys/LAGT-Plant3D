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
    public partial class SignInDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            //Tag = "[Window]"+ AcMainWin.cBabel(533, 8, "Sign in");//Tag = "[Pane]" + AcMainWin.cBabel(533, 8, "Sign in") + "|" + "Sign in";
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
                    Tag = "[Window]" + AcMainWin.cBabel(533, 8, "Sign in");
                    break;

                default:
                    Tag = "[Window]" + AcMainWin.cBabel(533, 8, "Sign in");//Tag = "[Pane]" + AcMainWin.cBabel(533, 8, "Sign in") + "|" + "Sign in";
                    break;

            }
        }

		public override void Invoke()
		{
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            
            AppWnd.PushButton2PB.Click();
            AppWnd.TypeKeys("<Down 1><Enter>");//Select Sign in
        }

		public override void Dismiss()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();


            //if (ReportDesignerApplicationDLG.RestorePB.Exists)
            //{
            //    ReportDesignerApplicationDLG.RestorePB.Click();
            //}
            ReportDesignerApplicationDLG.ClosePB.Click();

            //ReportDesignerApplicationDLG.TypeKeys("<Alt-F4>");
            System.Threading.Thread.Sleep(2000);
            //Desktop Desktop = new Desktop();
            //Desktop.TypeKeys("<Tab><Enter>");
          
            System.Threading.Thread.Sleep(2000);
            ReportLayoutModifiedSaveChangesDLG ReportLayoutModifiedSaveChangesDLG = new ReportLayoutModifiedSaveChangesDLG();
            if (ReportLayoutModifiedSaveChangesDLG.Exists)
            {
                ReportLayoutModifiedSaveChangesDLG.NoPB.Click();
            }
			ReportConfigurationDLG ReportConfigurationDLG = new ReportConfigurationDLG();
			ReportConfigurationDLG.Dismiss();
		}
    }
}
