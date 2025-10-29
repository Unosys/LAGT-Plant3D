// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Browse For Folder|Select Folder", Parent = typeof(ModifySharedContentFolderDLG), GUIType = GuiType.UIA)]
    public partial class BrowseForSharedContentFolderDLG : DialogBox
    {
        public  PushButton OK;
        public  PushButton Cancel;
        public  PushButton ClosePB;
        public  TextField FolderTF;
        public  PushButton SelectFolderPB;

        partial void OnInitialize();

        public BrowseForSharedContentFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Browse For Folder|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            FolderTF = new TextField()
            {
                Tag = "[TextField]Folder:|$1152|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderTF);

            SelectFolderPB = new PushButton()
            {
                Tag = "[PushButton]Select Folder|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFolderPB);
        }
    }
}
