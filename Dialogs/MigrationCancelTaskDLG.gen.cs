// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Cancel")]
    public partial class MigrationCancelTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ExitPB;
        public  PushButton ResumePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public MigrationCancelTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ExitPB = new PushButton()
            {
                Tag = "[Pane]Cancel|$Window/[PushButton]Exit|$CommandLink_1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExitPB);

            ResumePB = new PushButton()
            {
                Tag = "[Pane]Cancel|$Window/[PushButton]Resume|$CommandLink_1002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ResumePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Cancel|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
