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
using System;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ReportCreatorSelectDrawingErrorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$ExceptionMessageForm";
		}

		public void Invoke()
		{
			Plant3DFunctions.CreateDrawing("P3D", "no", "Temp{RandInt(2,9)}");
			ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
			ReportCreatorDLG.Invoke1();
			ReportCreatorDLG.SetActive();
            System.Threading.Thread.Sleep(1000);
            //ReportCreatorDLG.M_projectCmbBox.TypeKeys("<F4><Down 2><Enter>");
            //ReportCreatorDLG.M_projectCmbBox.TypeKeys("<F4><Down 2><Enter>");//default project
            ReportCreatorDLG.M_projectCmbBox.TypeKeys("<Home>");
            String DefaultProject = Plant3DMainWin.sDefaultProjPath + "Project.xml";
            OpenReportCreatorProjectDLG OpenReportCreatorProjectDLG = new OpenReportCreatorProjectDLG();
            OpenReportCreatorProjectDLG.FileNameCB.SetText(DefaultProject);
            OpenReportCreatorProjectDLG.OpenPB.Click();
            System.Threading.Thread.Sleep(1000);

            ReportCreatorDLG.SetActive();
            System.Threading.Thread.Sleep(1000);
            ReportCreatorDLG.M_repConfigCmbBox.TypeKeys("<F4><Down 2><Enter>");
            ReportCreatorDLG.M_repConfigCmbBox.TypeKeys("<F4><Down 2><Enter>");
            ReportCreatorDLG.SetActive();
			ReportCreatorDLG.M_drawingDataRadioBtn.Click();
            ReportCreatorDLG.SetActive();
			ReportCreatorDLG.M_previewBtn.Click();
			ReportCreatorSelectDrawingErrorDLG ReportCreatorSelectDrawingErrorDLG = new ReportCreatorSelectDrawingErrorDLG();
			ReportCreatorSelectDrawingErrorDLG.M_detailsBtn.Click();
		}

		public void Dismiss()
		{
			ReportCreatorSelectDrawingErrorDLG ReportCreatorSelectDrawingErrorDLG = new ReportCreatorSelectDrawingErrorDLG();
			ReportCreatorSelectDrawingErrorDLG.SetActive();
			ReportCreatorSelectDrawingErrorDLG.ClosePB.Click();
			ReportCreatorDLG ReportCreatorDLG = new ReportCreatorDLG();
			ReportCreatorDLG.Dismiss();
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
