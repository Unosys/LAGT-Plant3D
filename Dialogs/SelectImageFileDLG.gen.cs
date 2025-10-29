// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Select Image File|$DXImageEditorForm")]
    public partial class SelectImageFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton SelectFilePB;
        public  PushButton ApplyPB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectImageFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SelectFilePB = new PushButton()
            {
                Tag = "[Pane]$pnlMainForm|#1/[Pane]$pnlFrame|#2/[Pane]$buttonsPanel|#1/[PushButton]Select File*|$selectFileButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFilePB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$pnlMainForm|#1/[Pane]$pnlFrame|#2/[Pane]$buttonsPanel|#1/[PushButton]Apply|$applyButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$pnlMainForm|#1/[Pane]$pnlFrame|#2/[Pane]$buttonsPanel|#1/[PushButton]Cancel|$39323804|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Image File|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
