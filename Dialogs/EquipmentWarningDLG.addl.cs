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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class EquipmentWarningDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = AcMainWin.cBabel(15, 8, "Warning");
        }

        public override void Invoke()
        {
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            P3DCreateEquipmentDLG.Invoke();
            P3DCreateEquipmentDLG.EquipmentPANE.Click();
            P3DCreateEquipmentDLG.AddShapePB.Click();
            P3DCreateEquipmentDLG.TypeKeys("<Down 8><Enter>");
            P3DCreateEquipmentDLG.AddTrimPB.Click();
            P3DCreateEquipmentDLG.TypeKeys("<Down><Enter>");
            P3DCreateEquipmentDLG.TypeKeys("<Up 3>");//Select added shape
            P3DCreateEquipmentDLG.RemovePB.Click();
            EquipmentWarningDLG EquipmentWarningDLG = new EquipmentWarningDLG();
            EquipmentWarningDLG.SetActive();

        }

        public override void Dismiss()
        {
            EquipmentWarningDLG EquipmentWarningDLG = Current<EquipmentWarningDLG>();
            EquipmentWarningDLG.TypeKeys("<Esc>");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            P3DCreateEquipmentDLG.Dismiss();
            Plant3DFunctions.DeleteDrawing("P3D");
        }
    }
}
