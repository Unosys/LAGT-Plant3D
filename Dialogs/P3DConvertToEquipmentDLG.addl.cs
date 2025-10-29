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
    public partial class P3DConvertToEquipmentDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$SelectEquipmentTypeDlg";
		}

		public  void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
            Plant3DFunctions.CreateDrawing("P3D", null, null, null);
			Drawing.Current.TypeE("_line");
			Drawing.Current.TypeE("7,7");
			Drawing.Current.TypeE("7,4");
			Drawing.Current.TypeKeys("<Enter>");
			Drawing.Current.TypeE("_PlantEquipmentConvert");
			Drawing.Current.TypeE("7,5");
			Drawing.Current.TypeKeys("<Enter>");
		}

		public  void Dismiss()
		{
			P3DConvertToEquipmentDLG P3DConvertToEquipmentDLG = new P3DConvertToEquipmentDLG();
			P3DConvertToEquipmentDLG.M_Cancel.Click();
			Drawing.Current.TypeE("_ProjectManager");
//   Plant3DFunctions.DeleteDrawing("P3D") Plant3DFunctions.DeleteDrawing("P3D") = new Plant3DFunctions.DeleteDrawing("P3D")();
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
