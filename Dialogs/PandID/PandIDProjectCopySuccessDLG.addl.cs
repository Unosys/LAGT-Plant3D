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
    public partial class PandIDProjectCopySuccessDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[DialogBox]" + AcMainWin.cBabel(23032,8,"Project Copy Success");
		}

		public override void Invoke()
		{
            string projectName = PandIDFunctions.CreateProj();
            PandIDPMUConvertProjectToSQLExpressDLG PandIDPMUConvertProjectToSQLExpressDLG = new PandIDPMUConvertProjectToSQLExpressDLG();
            PandIDPMUConvertProjectToSQLExpressDLG.Invoke();
            PandIDPMUConvertProjectToSQLExpressDLG.ConvertBrowseBtn.Click();
            PandIDOpenReportCreatorProjectDLG PandIDOpenReportCreatorProjectDLG = Current<PandIDOpenReportCreatorProjectDLG>();
            PandIDOpenReportCreatorProjectDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + projectName + "\\" + "Project.xml");
            PandIDOpenReportCreatorProjectDLG.OpenPB.Click();
            PandIDPMUConvertProjectToSQLExpressDLG.ServerListCombboxTextField.SetText(Plant3DMainWin.PcName);
            PandIDPMUConvertProjectToSQLExpressDLG.DoBtn.Click();
            System.Threading.Thread.Sleep(30000);
            PandIDProjectConversionSuccessDLG PandIDProjectConversionSuccessDLG = new PandIDProjectConversionSuccessDLG();
            PandIDProjectConversionSuccessDLG.Dismiss();
            PandIDPMUCopyProjectDatabaseDLG PandIDPMUCopyProjectDatabaseDLG = new PandIDPMUCopyProjectDatabaseDLG();
            PandIDPMUCopyProjectDatabaseDLG.Invoke();
            PandIDPMUCopyProjectDatabaseDLG.CopyBrowseBtn.Click();
            PandIDOpenReportCreatorProjectDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + projectName + "\\" + "Project.xml");
            PandIDOpenReportCreatorProjectDLG.OpenPB.Click();
            PandIDPMUCopyProjectDatabaseDLG.ServerListCombboxTextField.SetText(Plant3DMainWin.PcName);
            PandIDPMUCopyProjectDatabaseDLG.DbPrefixTxt.TypeKeys("<end>a");
            PandIDPMUCopyProjectDatabaseDLG.DoBtn.Click();
            System.Threading.Thread.Sleep(10000);
		}

		public override void Dismiss()
		{
            this.Close();
			PandIDPMUCopyProjectDatabaseDLG PandIDPMUCopyProjectDatabaseDLG = Current<PandIDPMUCopyProjectDatabaseDLG>();
            PandIDPMUCopyProjectDatabaseDLG.Dismiss();
		}
    }
}
