// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Folder Already Exists", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class FolderAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton MergeTheExistingFolderPB;
        public  PushButton CreateAFolderWithPB;
        public  PushButton DoNotCreateThisPB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public FolderAlreadyExistsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            MergeTheExistingFolderPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MergeTheExistingFolderPB);

            CreateAFolderWithPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateAFolderWithPB);

            DoNotCreateThisPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1003|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotCreateThisPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Cancel|$CommandButton_2|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
