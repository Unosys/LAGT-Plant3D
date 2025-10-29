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
    public partial class PandIDNetworkPathNotFoundDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "~ActiveApp/[DialogBox]" + AcMainWin.cBabel(21065,1,"Network Path Not Found");
		}

		public override void Invoke()
		{
			Drawing.Current.SetSysVar("Filedia", 0);
			string sProjectName = "{FRAMEWKDIR}Test Files\\PandID\\NetworkPath\\Project.xml";
			Drawing.Current.TypeE("_OPENPROJECT");
			Drawing.Current.TypeE(sProjectName);
			System.Threading.Thread.Sleep(50000);
			PandIDNetworkPathNotFoundDLG PandIDNetworkPathNotFoundDLG = Current<PandIDNetworkPathNotFoundDLG>();
			PandIDNetworkPathNotFoundDLG.SetActive();
			PandIDNetworkPathNotFoundDLG.TypeKeys("<Tab 3><Enter>");
		}

		public override void Dismiss()
		{
			PandIDNetworkPathNotFoundDLG PandIDNetworkPathNotFoundDLG = Current<PandIDNetworkPathNotFoundDLG>();
			PandIDNetworkPathNotFoundDLG.SetActive();
			PandIDNetworkPathNotFoundDLG.TypeKeys("<Tab 2><Enter>");
			string sProjectName = "{AppWnd.GetDefaultProjPath()}Project.xml";
			Drawing.Current.TypeE("_openproject");
			Drawing.Current.TypeE(sProjectName);
			System.Threading.Thread.Sleep(10000);
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("1");
			Drawing.Current.SetSysVar("Filedia", 1);
		}
    }
}
