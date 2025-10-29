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
    public partial class ConfirmDeleteMappingMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
        {
            Tag = "[DialogBox]" + AcMainWin.cBabel(426, 34, "Confirm Delete") + "|*" + AcMainWin.cBabel(23062, 7, "Confirm ") + "*";
        }

		public override void Invoke()
		{
            var SelectPlant3DClassMappingDLG = new SelectPlant3DClassMappingDLG();
            SelectPlant3DClassMappingDLG.Invoke();
            System.Threading.Thread.Sleep(1000);
            SelectPlant3DClassMappingDLG.Plant3DClassTV.Select(AcMainWin.cBabel(23073, 16, "Piping and Equipment") + "/" + AcMainWin.cBabel(21100, 21, "Equipment"));
            //    SelectPlant3DClassMappingDLG.EquipmentTVI.Select();

            SelectPlant3DClassMappingDLG.MapToAllSubtypesCK.Check();
            SelectPlant3DClassMappingDLG.OKPB.Click();
            PIDObjectMappingDLG PIDObjectMappingDLG = new PIDObjectMappingDLG();
            //PIDObjectMappingDLG.NoImageLB.Select(AcMainWin.cBabel(21051, 3, "Equipment"));
            PIDObjectMappingDLG.EquipmentLBI.Click();
            PIDObjectMappingDLG.DeletePB.Click();
            this.SetActive();
        }

		public override void Dismiss()
		{
            this.YesPB.Click();
            ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
            ProjectSetupPlant3DDWG.Dismiss();

        }
    }
}
