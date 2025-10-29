// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Project Backup|$PrjBackUpDlog")]
    public partial class PlantProjectBackupDLG_Collaboration : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton BackupProjectPB;
        public  PushButton PushButtonPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PlantProjectBackupDLG_Collaboration()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[CustomWin]$StartPage|#1/[PushButton]Cancel|$CancelButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            BackupProjectPB = new PushButton()
            {
                Tag = "[CustomWin]$StartPage|#1/[PushButton]Backup Project|$BackupButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackupProjectPB);

            PushButtonPB = new PushButton()
            {
                Tag = "[CustomWin]$StartPage|#1/[PushButton]$BtnChange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant 3D - Project Backup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
