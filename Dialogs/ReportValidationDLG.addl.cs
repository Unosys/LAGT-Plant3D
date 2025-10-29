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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReportValidationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23069, 1, "Report Validation");

        }

        public override void Invoke()
		{
			//Plant3DFunctions.CreateDrawing("P3D","no","Temp", "no");
   //         Drawing.Current.TypeE("_DYNMODE");
   //         Drawing.Current.TypeE("-3");
   //         Drawing.Current.TypeE("_PLANTPIPEADD");
   //         Drawing.Current.TypeE("1250,800");
   //         Drawing.Current.TypeE("1650,800");
			//Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeE("_PlantCreateReport");
            System.Threading.Thread.Sleep(3000);
			PlantCreateReportDLG PlantCreateReportDLG = new PlantCreateReportDLG();
			PlantCreateReportDLG.SetActive();
			PlantCreateReportDLG.PreviewPB.Click();
            System.Threading.Thread.Sleep(3000);
            ReportValidationDLG ReportValidationDLG = new ReportValidationDLG();
            ReportValidationDLG.SetActive();
        }

        public override void Dismiss()
		{
			ReportValidationDLG ReportValidationDLG = new ReportValidationDLG();
            ReportValidationDLG.CancelPB.Click();
			PlantCreateReportDLG PlantCreateReportDLG = new PlantCreateReportDLG();
            PlantCreateReportDLG.ClosePB.Click();
            //Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
