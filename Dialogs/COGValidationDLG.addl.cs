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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class COGValidationDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$CenterOfGravityValidationDlg";
		}

		public void Invoke()
		{
            //ProjManUndocked projectmanagerDLG = new ProjManUndocked();
            //projectmanagerDLG.SetActive();
            //Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,2");
            //SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            //SelectDrawingsToCopyToProDLG.SetActive();
            //SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir+"COGValidation.dwg");
            //SelectDrawingsToCopyToProDLG.Open.Click();
            //AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
            //if (AutoCADPlant3DMigrationDLG.WaitExists(2000))
            //{
            //    AutoCADPlant3DMigrationDLG.BackupTheDrawingBeforeCK.Uncheck();
            //    Desktop.Current.TypeKeys("<enter>"); //close migration
            //}
            //Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 1, "0,2,1");
            Plant3DFunctions.CopyDrawing("COGValidation.dwg");
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_PLANTSELECTIVECOGSWITCH 1");
            Drawing.Current.TypeE("_PLANTCOGVALIDATIONSWITCH _ON");
			//Drawing.Current.TypeE("_ON");
			Drawing.Current.TypeKeys("<Esc>");
            ////////////////////////updated for FY23//
            LoadUnloadApplicationsDLG LoadUnloadApplicationsDLG = new LoadUnloadApplicationsDLG();
            LoadUnloadApplicationsDLG.Reload();
            //////////////////
            Drawing.Current.TypeE("_AI_SELALL");
            System.Threading.Thread.Sleep(2000);
			COGValidationDLG COGValidationDLG = new COGValidationDLG();
			if (COGValidationDLG.WaitExists(5000))
            {
                COGValidationDLG.SetActive();
            }
		}

		public void Dismiss()
		{
			COGValidationDLG COGValidationDLG = new COGValidationDLG();
			COGValidationDLG.SetActive();
            COGValidationDLG.ClosePB.Click();
            Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeE("_PLANTCOGVALIDATIONSWITCH");
			Drawing.Current.TypeE("_OFF");
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
