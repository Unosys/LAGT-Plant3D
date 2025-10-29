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
    public partial class CreateAnAdjacentViewDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$Window_1";
		}

        public override void Invoke()
        {
            ProjManUndocked projectmanagerDLG = new ProjManUndocked();         
            //projectmanagerDLG.Invoke();
		    projectmanagerDLG.SetActive();
            Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,2");
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir+"SampleDrawing.dwg");
		    SelectDrawingsToCopyToProDLG.Open.Click();
            AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
            if (AutoCADPlant3DMigrationDLG.WaitExists(2000))
            {
                AutoCADPlant3DMigrationDLG.BackupTheDrawingBeforeCK.Uncheck();
                Desktop.Current.TypeKeys("<enter>"); //close migration
            }
            projectmanagerDLG.SetTab(2);
            Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.OrthoTreeViewTV, 4, "0,1");
            System.Threading.Thread.Sleep(1000);
    //        Window WTreeView = projectmanagerDLG.TreeViewTV;
    //        RECT wWind = WTreeView.GetRect();
    //        if (LAGT.CommonFiles.Product.Variables.Language == "RUS")
    //        {
    //            WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 70);
    //        }
			 //else if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
    //        {
    //            WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 70);//75
    //        }
    //        else
    //        {
    //            WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 85);
    //        }
                
    //        Desktop.Current.TypeKeys("<Down 3><Enter>");


            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir+"OrthoViewPort.dwg");
            SelectDrawingsToCopyToProDLG.Open.Click();
            if (AutoCADPlant3DMigrationDLG.WaitExists(2000))
            {
                AutoCADPlant3DMigrationDLG.BackupTheDrawingBeforeCK.Uncheck();
                Desktop.Current.TypeKeys("<enter>"); //close migration
            }
            Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
            if (Plant3DProjectSomeFilesDLG.WaitExists(2000))
            {
                Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            }
            var ProjectDataMerged = new ProjectDataMerged();
            if (ProjectDataMerged.WaitExists(2000))
            {
                ProjectDataMerged.OKPB.Click();
            }
            System.Threading.Thread.Sleep(2000);
            Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.OrthoTreeViewTV, 4, "0,1,1");//Unamed View->Edit View
            System.Threading.Thread.Sleep(6000);
            Drawing.Current.TypeE("_Ai_Selall");
            Drawing.Current.TypeE("_PLANTORTHOADJACENT");
            Drawing.Current.TypeE("_last");
            System.Threading.Thread.Sleep(2000);
            if (!this.Exists) {
                Drawing.Current.TypeKeys("<Esc 2>");
                Drawing.Current.TypeE("_Close");
                System.Threading.Thread.Sleep(2000);
                PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
                if (PandIDWarningAutoCADDLG.Exists)
                {
                    PandIDWarningAutoCADDLG.No.Click();
                }
                Drawing.Current.TypeE("_Ai_Selall");
                Drawing.Current.TypeE("_PLANTORTHOADJACENT");
                Drawing.Current.TypeE("_last");
            }
            CreateAnAdjacentViewDLG CreateAnAdjacentViewDLG = new CreateAnAdjacentViewDLG();
            CreateAnAdjacentViewDLG.SetActive();
        }

		public override void Dismiss()
		{
			CreateAnAdjacentViewDLG CreateAnAdjacentViewDLG = new CreateAnAdjacentViewDLG();
			CreateAnAdjacentViewDLG.SetActive();
			CreateAnAdjacentViewDLG.Cancel.Click();// .TypeKeys("<TAB 2><ENTER>");
    		Plant3DFunctions.DeleteOrthoDrawing();
            Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
