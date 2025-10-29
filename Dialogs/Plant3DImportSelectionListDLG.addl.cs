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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DImportSelectionListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "Plant 3D*" + AcMainWin.cBabel(2, 9, "Import") + "*"+ "|Plant 3D*" + AcMainWin.cBabel(545, 17, "Select")+"*";
        }

		public override void Invoke()
		{
            string sPath = "C:\\temp\\Project Reports.xlsx";
            if (File.Exists(sPath)) {
                File.Delete(sPath);
            }
            var PandIDSelectionListPropertyDLG = new PandIDSelectionListPropertyDLG();
            var ExportToDLG = new ExportToDLG();
            var ImportData = new ImportData();
            ExportToDLG.Invoke();
            ExportToDLG.FileNameCB.ClearText();
            ExportToDLG.FileNameCB.SetText(@"C:\temp\Project Reports.xlsx");
            ExportToDLG.SavePB.Click();
            var ExportDataDLG = new ExportDataDLG();
            ExportDataDLG.OKPB.Click();
            System.Threading.Thread.Sleep(2000);
            PandIDSelectionListPropertyDLG.SetActive();
            PandIDSelectionListPropertyDLG.ImportPB.Click();
            System.Threading.Thread.Sleep(6000);
            ImportData.SetActive();
            ImportData.FileNameCB.SetText(@"C:\temp\Project Reports.xlsx");
            System.Threading.Thread.Sleep(2000);
            ImportData.OpenPB.Click();
        }

		public override void Dismiss()
		{
            this.CancelPB.Click();
            var PandIDSelectionListPropertyDLG = new PandIDSelectionListPropertyDLG();
            PandIDSelectionListPropertyDLG.Dismiss();

        }
    }
}
