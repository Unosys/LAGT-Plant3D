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
    public partial class P3DCreateEquipmentDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			//Tag = "$EquBaseDlg";
            Tag = "[Pane]Create Equipment|$EquBaseDlg";
		}

		public override void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
            Plant3DFunctions.CreateDrawing("P3D", null, null, null);
			Drawing.Current.TypeE("_Erase");
			Drawing.Current.TypeE("_All");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("_PLANTEQUIPMENTCREATE");
            System.Threading.Thread.Sleep(1000);
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
			P3DCreateEquipmentDLG.SetActive ();
			System.Threading.Thread.Sleep(3000);
			this.Size(800, 900);
			try { 
				this.Move(50, 50);
			}
			catch {
			
			}
           

        }

		public override void Dismiss()
		{
			P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
			P3DCreateEquipmentDLG.PropertiesPANE.DoubleClick(MouseButton.Left,10,-2);
            P3DCreateEquipmentDLG.CancelPB.Click();
			Drawing.Current.TypeE("_ProjectManager");
			Plant3DFunctions.DeleteDrawing("P3D");
		}
        public void SelectTab(int i = 1)
        {
            
            RECT r = this.EquipmentPANE.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r.xPos + 10, r.yPos - 2);
            if (i != 1)
            {
                Desktop.Current.TypeKeys("<Right " + (i - 1).ToString() + ">");
            }
			
        }
    }
}
