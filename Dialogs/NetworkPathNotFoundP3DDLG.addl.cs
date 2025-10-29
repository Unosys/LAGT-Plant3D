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
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Microsoft.Win32;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class NetworkPathNotFoundP3DDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "#1";
		}

		public override void Invoke()
		{
			Drawing.Current.SetSysVar("Filedia", 0);
            string sProjectName = LAGT.CommonFiles.Product.Variables.TestFilesDir+"NetworkPath1\\Project.xml";
            Drawing.Current.TypeE("_OPENPROJECT");
			Drawing.Current.TypeE(sProjectName);
            //System.Threading.Thread.Sleep(20000);
            //NetworkPathNotFoundP3DDLG NetworkPathNotFoundP3DDLG = new NetworkPathNotFoundP3DDLG();
            //NetworkPathNotFoundP3DDLG.SetActive();
            //NetworkPathNotFoundP3DDLG.ShowDetailsPB.Click();
		}

		public override void Dismiss()
		{
			NetworkPathNotFoundP3DDLG NetworkPathNotFoundP3DDLG = new NetworkPathNotFoundP3DDLG();
			NetworkPathNotFoundP3DDLG.SetActive();
            NetworkPathNotFoundP3DDLG.OKPB.Click();

            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "DefaultProject", "") as string;
            string sProjectName = sProjectPath + "Project.xml";
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
            System.Threading.Thread.Sleep(15000);
		}
    }
}
