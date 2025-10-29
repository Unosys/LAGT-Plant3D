// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]File Exists", Parent = typeof(NewDWGDLG), GUIType = GuiType.UIA)]
    public partial class FileExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OverwritePB;
        public  PushButton RenamePB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public FileExistsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OverwritePB = new PushButton()
            {
                Tag = "[Pane]File Exists|$Window/[PushButton]Overwrite the existing drawing with this one|$CommandLink_1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverwritePB);

            RenamePB = new PushButton()
            {
                Tag = "[Pane]File Exists|$Window/[PushButton]Change the name of this drawing|$CommandLink_1002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenamePB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]File Exists|$Window/[PushButton]Cancel|$CommandButton_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]File Exists|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
