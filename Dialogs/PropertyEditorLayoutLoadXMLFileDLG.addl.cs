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
using LAGT.CommonFiles;
using System.IO;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PropertyEditorLayoutLoadXMLFileDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$DesignerForm";// "$BaseDesignerForm";
		}

		public  void Invoke()
		{
			OpenFileDLG OpenFileDLG = new OpenFileDLG();
			OpenFileDLG.Invoke();
			OpenFileDLG.SetActive();
			System.Threading.Thread.Sleep(3000);
            OpenFileDLG.FileNameTextField.ClearText();
            System.Threading.Thread.Sleep(1000);

           
            string sPath = LAGT.CommonFiles.Product.Variables.ProductLocation;
            if (!sPath.EndsWith("\\"))
                sPath += "\\";
            sPath += "PLNT3D\\AdMigrator.xml";
            OpenFileDLG.FileNameTextField.SetText(sPath);

            OpenFileDLG.Open.Click();
			System.Threading.Thread.Sleep(1000);
			PropertyEditorLayoutLoadXMLFileDLG PropertyEditorLayoutLoadXMLFileDLG = new PropertyEditorLayoutLoadXMLFileDLG();
			PropertyEditorLayoutLoadXMLFileDLG.SetActive();
		}

		public  void Dismiss()
		{
			PropertyEditorLayoutLoadXMLFileDLG PropertyEditorLayoutLoadXMLFileDLG = new PropertyEditorLayoutLoadXMLFileDLG();
			PropertyEditorLayoutLoadXMLFileDLG.SetActive();
            PropertyEditorLayoutLoadXMLFileDLG.Close2PB.Click();// TypeKeys("<Alt-F4>");
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.SetActive();
			ReportDesignerApplicationDLG.Dismiss();
		}
    }
}
