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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDActuatorBrowserDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$ClassBrowserDlg";
		}

		public  void Invoke()
		{
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Invoke();
            Drawing.Current.TypeE("_toolpalettesclose");
            Drawing.Current.TypeE("SDI");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            PandIDPROJECTMANAGERDLG.SetActive();
            PandIDProjManUndocked pROJECTMANAGERDLG = new PandIDProjManUndocked();
            pROJECTMANAGERDLG.SetActive();
            Window wTreeView = pROJECTMANAGERDLG.TreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1");
            PandIDSelectDrawingsToCopyToProDLG PandIDSelectDrawingsToCopyToProDLG = new PandIDSelectDrawingsToCopyToProDLG();
            PandIDSelectDrawingsToCopyToProDLG.SetActive();
            PandIDSelectDrawingsToCopyToProDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\TestPID.dwg");
            PandIDSelectDrawingsToCopyToProDLG.OpenPB.Click();
            PandIDPlant3DProjectSomeFilesDLG PandIDPlant3DProjectSomeFilesDLG = new PandIDPlant3DProjectSomeFilesDLG();
            if (PandIDPlant3DProjectSomeFilesDLG.Exists)
            {
                PandIDPlant3DProjectSomeFilesDLG.SetActive();
                PandIDPlant3DProjectSomeFilesDLG.M_btnOk.Click();
            }


            pROJECTMANAGERDLG.SetActive();
            wTreeView = pROJECTMANAGERDLG.TreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");
            System.Threading.Thread.Sleep(5000);
            if (!Drawing.Current.ReadyForNextCommand())
            {
                Drawing.Current.TypeKeys("<Tab><Enter>");
            }
            DrawingCheckerDLG DrawingCheckerDLG = new DrawingCheckerDLG();
            if (DrawingCheckerDLG.Exists) {
                DrawingCheckerDLG.TypeKeys("<Tab><Enter>");
            }
                Drawing.Current.TypeE("_select _last ");
            Drawing.Current.TypeE("_erase");
            LoadUnloadApplicationsDLG LoadUnloadApplicationsDLG = new LoadUnloadApplicationsDLG();
            LoadUnloadApplicationsDLG.Reload(); 
         
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.TypeE("_ai_selall");
            Drawing.Current.TypeE("_CONVERTTOCONTROLVALVE");
            System.Threading.Thread.Sleep(2000);
            


        }

		public  void Dismiss()
		{
            this.CancelPB.Click();
            PandIDFunctions.DeleteDrawing();
		}
    }
}
