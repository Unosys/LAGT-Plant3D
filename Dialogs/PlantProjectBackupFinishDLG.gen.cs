// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Project Backup|$PrjBackUpDlog")]
    public partial class PlantProjectBackupFinishDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Close2PB;
        public  PushButton OpenBackupLocationPB;

        partial void OnInitialize();

        public PlantProjectBackupFinishDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close2PB = new PushButton()
            {
                Tag = "[CustomWin]$SuccessPage|#1/[PushButton]Close|$CloseButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);

            OpenBackupLocationPB = new PushButton()
            {
                Tag = "[CustomWin]$SuccessPage|#1/[PushButton]Open Backup Location|$OpenButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenBackupLocationPB);
        }
    }
}
