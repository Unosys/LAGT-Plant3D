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
    public partial class EquipmentCongruentNozzlePortsTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = AcMainWin.cBabel(23040, 1, "Equipment - Congruent Nozzle Ports*");
		}

		public override void Invoke()
		{
			Drawing.Current.SetSysVar("SDI", 0);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
			PROJECTMANAGERDLG.Invoke();
			PROJECTMANAGERDLG.SetActive();
			//PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
			Plant3DFunctions.CreateDrawing("P3D");
			System.Threading.Thread.Sleep(1000);
			Drawing.Current.TypeE("_PLANTEQUIPMENTCREATE");
			P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
			P3DCreateEquipmentDLG.SetActive();
			P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
			Drawing.Current.TypeE("80,80 ");
			Drawing.Current.TypeE("_zoom _e");
            Drawing.Current.TypeE("_PLANTNOZZLEADD 80,80");
            Desktop.Current.TypeKeys("<Enter>");
            Drawing.Current.TypeE("_PLANTNOZZLEADD 80,80");
			System.Threading.Thread.Sleep(1000);
			EquipmentCongruentNozzlePortsTaskDLG EquipmentCongruentNozzlePortsTaskDLG = new EquipmentCongruentNozzlePortsTaskDLG();
			EquipmentCongruentNozzlePortsTaskDLG.SetActive();
			System.Threading.Thread.Sleep(1000);
		}

		public override void Dismiss()
		{
            EquipmentCongruentNozzlePortsTaskDLG EquipmentCongruentNozzlePortsTaskDLG = new EquipmentCongruentNozzlePortsTaskDLG();
            EquipmentCongruentNozzlePortsTaskDLG.ClosePB.Click(); 
            Desktop.Current.TypeKeys("<ESC 2>");
            Plant3DFunctions.DeleteDrawing("P3D");
        }
    }
}
