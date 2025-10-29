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
using System.Drawing;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class AddComponentGroupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Window]$Window_1";
		}

		public override void Invoke()
		{
            IsometricDWGSettingsAnnotationsTableIDDLG IsometricDWGSettingsAnnotationsTableIDDLG = new IsometricDWGSettingsAnnotationsTableIDDLG();
            IsometricDWGSettingsAnnotationsTableIDDLG.Invoke();
            System.Threading.Thread.Sleep(1000);
            RECT r = IsometricDWGSettingsAnnotationsTableIDDLG.ScrollBarSB.GetRect(true);
            Desktop.Current.PressMouse(MouseButton.Left,r.xPos+2, r.yPos + 20);
            Desktop.Current.ReleaseMouse(MouseButton.Left, r.xPos + 2, 2 + r.yPos + r.ySize / 2);

            //Point pMouseButton = System.Windows.Forms.Control.MousePosition;
            //Desktop.Current.BeginDragAt(MouseButton.Left, pMouseButton.X+5, pMouseButton.Y+30);
            //System.Threading.Thread.Sleep(1500);
            //Desktop.Current.EndDragAt(r.xPos +2, 2+ r.yPos+r.ySize/2);
            //System.Threading.Thread.Sleep(4000);
            //IsometricDWGSettingsAnnotationsTableIDDLG.SetActive();

            IsometricDWGSettingsAnnotationsTableIDDLG.AddComponentGroupPB.Click();
            System.Threading.Thread.Sleep(1000);
            this.Size(700,430);
        }

		public override void Dismiss()
		{
			this.CancelPB.Click();
            IsometricDWGSettingsAnnotationsTableIDDLG IsometricDWGSettingsAnnotationsTableIDDLG = new IsometricDWGSettingsAnnotationsTableIDDLG();
            IsometricDWGSettingsAnnotationsTableIDDLG.Dismiss();
        }
    }
}
