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
    public partial class Plant3DExcelImportDLG_Collaboration1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Window]$Window_1";

        }

		public override void Invoke()
		{
			var Plant3DExcelImportDLG_Collaboration = new Plant3DExcelImportDLG_Collaboration();
			Plant3DExcelImportDLG_Collaboration.Invoke();
            Plant3DExcelImportDLG_Collaboration.UpdatePB.Click();
            System.Threading.Thread.Sleep(30000);
            this.SetActive();
        }

		public override void Dismiss()
        {
            this.ClosePB.Click();
            DATAMANAGER DATAMANAGER = new DATAMANAGER();
            DATAMANAGER.Dismiss();
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(8000);
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            if (WarningAutoCADDLG.Exists)
            {
                WarningAutoCADDLG.No.Click();
            }
            Plant3DFunctions.SetToDefault();
        }
    }
}
