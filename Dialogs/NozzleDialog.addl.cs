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
    public partial class NozzleDialog : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$NozzleDialog_1";
        }

		public override void Invoke()
		{
            var P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            P3DCreateEquipmentDLG.Invoke();
            P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            Drawing.Current.TypeE("200,200");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_ZOOM");
            Drawing.Current.TypeE("_E");
            Drawing.Current.TypeE("_PLANTNOZZLEADD");
            Drawing.Current.TypeE("_last");
            System.Threading.Thread.Sleep(3000);
            var EquipmentCongruentNozzlePortsTaskDLG = new EquipmentCongruentNozzlePortsTaskDLG();
            if (EquipmentCongruentNozzlePortsTaskDLG.Exists) 
            {
                EquipmentCongruentNozzlePortsTaskDLG.ClosePB.Click();
            }
            this.SetActive();

        }

		public override void Dismiss()
        {
            this.ClosePB.Click();
            Plant3DFunctions.DeleteDrawing("P3D");
        }
    }
}
