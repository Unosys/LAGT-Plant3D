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
using System.IO;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReplaceExistingFilesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			//Tag = "[DialogBox]Replace Existing Files";
            Tag = "*"+AcMainWin.cBabel(312, 1, "Replace")+"*|"+ "*" + AcMainWin.cBabel(21, 6, "File").Replace("* ", "*") + "*";

        }

        public override void Invoke()
        {
            string sPath = "C:\\temp\\Project Reports1.xlsx";
            if (!File.Exists(sPath))
            {
                File.Create(sPath);
            }
            var PandIDSelectionListPropertyDLG = new PandIDSelectionListPropertyDLG();
            var ExportToDLG = new ExportToDLG();
            var ExportDataDLG = new ExportDataDLG();
            ExportDataDLG.Invoke();
            ExportDataDLG.EnterFileNameAndTF.ClearText();
            ExportDataDLG.EnterFileNameAndTF.SetText(@"C:\temp\Project Reports1.xlsx");
            ExportDataDLG.OKPB.Click();
          
        }

        public override void Dismiss()
        {
            this.CancelPB.Click();
            var ExportDataDLG = new ExportDataDLG();
            ExportDataDLG.CancelPB.Click();
            var PandIDSelectionListPropertyDLG = new PandIDSelectionListPropertyDLG();
            PandIDSelectionListPropertyDLG.Dismiss();
            string sPath = "C:\\temp\\Project Reports1.xlsx";
            if (!File.Exists(sPath))
            {
                File.Delete(sPath);
            }

        }
    }
}
