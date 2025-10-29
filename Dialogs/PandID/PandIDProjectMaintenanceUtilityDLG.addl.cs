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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using System.Diagnostics;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDProjectMaintenanceUtilityDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[MainWin]$ProjectMaintenanceDlg";
		}

		public override void Invoke()
		{
			PandIDProjectMaintenanceUtilityDLG PandIDProjectMaintenanceUtilityDLG = new PandIDProjectMaintenanceUtilityDLG();
			if (PandIDProjectMaintenanceUtilityDLG.Exists)
			{
				Process.Start("Taskkill /f /im PnPProjectMaintenance.exe");
			}
            //string sPath1 = Autodesk.GUIHarness.AutoCAD.Dialogs.AutoCAD.Path + "\\PLNT3D\\PnPProjectMaintenance.exe";

            //string sPath = Autodesk.GUIHarness.AutoCAD.Dialogs.AutoCAD.Path + "PLNT3D\\PnPProjectMaintenance.exe";
            //if (LAGT.CommonFiles.Product.Variables.Language == "FRA" || LAGT.CommonFiles.Product.Variables.Language == "KOR")
            //{
            //    Process.Start(sPath1);
            //}
            //else
            //{
            //    Process.Start(sPath);
            //}

            string sPath = LAGT.CommonFiles.Product.Variables.ProductLocation;
            if (!sPath.EndsWith("\\"))
                sPath += "\\";
            sPath += "PLNT3D\\PnPProjectMaintenance.exe";
            Process.Start(sPath);

            PandIDProjectMaintenanceUtilityDLG.SetActive();
		}

		public override void Dismiss()
		{
			PandIDProjectMaintenanceUtilityDLG PandIDProjectMaintenanceUtilityDLG = Current<PandIDProjectMaintenanceUtilityDLG>();
			PandIDProjectMaintenanceUtilityDLG.SetActive();
			PandIDProjectMaintenanceUtilityDLG.Close();
		}
    }
}
