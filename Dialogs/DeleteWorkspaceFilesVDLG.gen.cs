// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Delete Workspace Files")]
    public partial class DeleteWorkspaceFilesVDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox CheckboxCK;
        public  PushButton DeleteFilesPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public DeleteWorkspaceFilesVDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CheckboxCK = new CheckBox()
            {
                Tag = "[Pane]Delete Workspace Files|$Window/[CheckBox]Always delete local workspace files*|$VerificationCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckboxCK);

            DeleteFilesPB = new PushButton()
            {
                Tag = "[Pane]Delete Workspace Files|$Window/[PushButton]Delete Files|$CommandButton_1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteFilesPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Delete Workspace Files|$Window/[PushButton]Cancel|$CommandButton_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
