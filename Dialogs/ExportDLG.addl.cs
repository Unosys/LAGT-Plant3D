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
using ProductTestSuite.CommonFiles;
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ExportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
		///// <summary>
		///// OnInitialize() is used to contain additional initialization code
		///// Uncomment the code block below to use it
		///// </summary>
		partial void OnInitialize()
		{
			switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
			{
				case "JPN":
				case "CHS":
				case "FRA":
				case "DEU":
					Tag = Plant3DFunctions.GetLocString("ExportDLG");				
					break;

				default:
					Tag = AcMainWin.cBabel(21066, 7, "Export");
					break;
			}
			
		}

		public void Invoke()
		{
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Invoke();
			System.Threading.Thread.Sleep(8000);
			PreviewDLG.TypeKeys("<Alt>");
			PreviewDLG.TypeKeys("<Down 4>");
			PreviewDLG.TypeKeys("<Right>");
			PreviewDLG.TypeKeys("<Enter>");
			System.Threading.Thread.Sleep(3000);
			PreviewPDFExportOptionsDLG PreviewPDFExportOptionsDLG = new PreviewPDFExportOptionsDLG();
			PreviewPDFExportOptionsDLG.OKPB.Click();
			System.Threading.Thread.Sleep(1000);
			SaveAsPDFDocumentDLG SaveAsPDFDocumentDLG = new SaveAsPDFDocumentDLG();
			SaveAsPDFDocumentDLG.Save.Click();
			System.Threading.Thread.Sleep(1000);
			Desktop Desktop = new Desktop();
            Desktop.TypeKeys("<Tab><Enter>");
            SaveAsFileAlreadyExistsDLG SaveAsFileAlreadyExistsDLG = new SaveAsFileAlreadyExistsDLG();
            if (SaveAsFileAlreadyExistsDLG.Exists)
            {
                SaveAsFileAlreadyExistsDLG.SetActive();
                SaveAsFileAlreadyExistsDLG.Yes.Click();
            }
	
		}

		public void Dismiss()
		{
			ExportDLG ExportDLG = new ExportDLG();
			ExportDLG.SetActive();
			ExportDLG.TypeKeys("<Tab><Enter>");
			PreviewDLG PreviewDLG = new PreviewDLG();
			PreviewDLG.Dismiss();
		}
    }
}
