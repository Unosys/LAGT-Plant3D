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
    public partial class PandIDSegmentDataDiffersTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(21040,1, "Segment Data Differs")+ "|#1|Données de segment différentes";
		}

        public override void Invoke()
        {
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDPROJECTMANAGERDLG.SetActive();
            Window wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1");
            PandIDSelectDrawingsToCopyToProDLG PandIDSelectDrawingsToCopyToProDLG = new PandIDSelectDrawingsToCopyToProDLG();
            PandIDSelectDrawingsToCopyToProDLG.SetActive();
            PandIDSelectDrawingsToCopyToProDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\TagEquipment.dwg");
            PandIDSelectDrawingsToCopyToProDLG.OpenPB.Click();
            PandIDPlant3DProjectSomeFilesDLG PandIDPlant3DProjectSomeFilesDLG = new PandIDPlant3DProjectSomeFilesDLG();
            if (PandIDPlant3DProjectSomeFilesDLG.Exists)
            {
                PandIDPlant3DProjectSomeFilesDLG.SetActive();
                PandIDPlant3DProjectSomeFilesDLG.M_btnOk.Click();
            }
            PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1,1");
            Drawing.Current.TypeE("_ASSIGNTAG");
            Drawing.Current.TypeE("11.5,12.8");
            Drawing.Current.TypeE("");
            System.Threading.Thread.Sleep(1000);
            PandIDAssignTagDLG PandIDAssignTagDLG = new PandIDAssignTagDLG();
            PandIDAssignTagDLG.TypeKeys("<Tab 7><Down>");
            PandIDAssignTagDLG.TypeKeys("1");
            PandIDAssignTagDLG.AssignPB.Click();
            Drawing.Current.TypeE("_ASSIGNTAG");
            Drawing.Current.TypeE("12,14.5");
            Drawing.Current.TypeE("");
            PandIDAssignTagDLG.TypeKeys("<Tab 7><Down><Tab><Down><Tab><Down><Tab>");
            PandIDAssignTagDLG.TypeKeys("2");//5
            PandIDAssignTagDLG.AssignPB.Click();
            Drawing.Current.TypeE("_ERASE");
            Drawing.Current.TypeE("11.5,12.8");
            Drawing.Current.TypeE("");
        }

		public override void Dismiss()
		{
            this.Close();
            PandIDFunctions.DeleteDrawing();
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.Dismiss();
		}
    }
}
