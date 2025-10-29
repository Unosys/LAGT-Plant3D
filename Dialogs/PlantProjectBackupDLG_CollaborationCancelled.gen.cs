// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Project Backup|$PrjBackUpDlog")]
    public partial class PlantProjectBackupDLG_CollaborationCancelled : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  Link LogFileLINK;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public PlantProjectBackupDLG_CollaborationCancelled()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant 3D - Project Backup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            LogFileLINK = new Link()
            {
                Tag = "[CustomWin]$CancelPage|#1/[StaticText]$ReviewText|#2/[Link]$LogHyperlink|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogFileLINK);

            Close2PB = new PushButton()
            {
                Tag = "[CustomWin]$CancelPage|#1/[PushButton]Close|$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
