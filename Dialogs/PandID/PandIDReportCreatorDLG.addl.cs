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
using System.Diagnostics;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDReportCreatorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "MainForm";
		}

		public override void Invoke()
		{
			PandIDReportCreatorDLG PandIDReportCreatorDLG = new PandIDReportCreatorDLG();
            string sPath = Autodesk.GUIHarness.AutoCAD.Dialogs.AutoCAD.Path + "PNID\\PnPReportCreator.exe";
			if (PandIDReportCreatorDLG.Exists)
			{
                Process.Start(sPath);
			}
			//int rOldOpt = Agent.GetOption(OPT_WINDOW_TIMEOUT)
			//Agent.SetOption(AgentOptions.OPT_WINDOW_TIMEOUT, 10);
			//derived::Start(this derived::Start(this = Current<derived::Start(this>();
			//derived::Start(this.sStartup);
			//Agent.SetOption(AgentOptions.OPT_WINDOW_TIMEOUT, roldopt);
			PandIDReportCreatorDLG.SetActive();
		}

		public override void Dismiss()
		{
            //try
            //{
            //}
			PandIDReportCreatorDLG PandIDReportCreatorDLG = Current<PandIDReportCreatorDLG>();
			if (PandIDReportCreatorDLG.Exists)
            {
                PandIDReportCreatorDLG.SetActive();
                PandIDReportCreatorDLG.Close();
            }
			//except except = Current<except>();
            //except;
            //window wActive = Desktop.GetActive()
            //wActive == AppWnd wActive == AppWnd = new wActive == AppWnd();
            //if (wActive == AppWnd)
            //{
            //    Drawing.Current.TypeKeys("<Esc 2>");
            //}
            //else
            //{
            //    list of Window lwClose list of window lwClose = Current<list of window lwClose>();
            //    list of Window lwClose;
            //    Window wToClose window wToClose = Current<window wToClose>();
            //    Window wToClose;
            //    Plant3D AppWnd = Current<Plant3D>();
            //    AppWnd.GetCloseWindows();
            //    for each wToClose in lwClose for each wToClose in lwClose = Current<for each wToClose in lwClose>();
            //    for each wToClose in lwClose;
			//}
			//wToClose wToClose = Current<wToClose>();
            //wToClose.Close();
            //string sPath = "Taskkill /f /im PnPReportCreator.exe";
            if (PandIDReportCreatorDLG.Exists)
            {
                //Sys_Execute("Taskkill /f /im PnPReportCreator.exe");
                Process.Start("Taskkill /f /im PnPReportCreator.exe");
            }
		}
    }
}
