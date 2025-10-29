// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Modify Shared Content Folder|$ModifySharedContentFolder|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ModifySharedContentFolderDLG : Window
    {
        public  PushButton ClosePB;
        public  TextField EdSharedContentFolder;
        public  PushButton BtSharedContentFolder;
        public  CheckBox CbCopyAllContent;
        public  PushButton BtOk;
        public  PushButton BtCancel;
        public  PushButton BtHelp;

        partial void OnInitialize();

        public ModifySharedContentFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Modify Shared Content Folder|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            EdSharedContentFolder = new TextField()
            {
                Tag = "[TextField]Shared Content Folder:|$edSharedContentFolder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EdSharedContentFolder);

            BtSharedContentFolder = new PushButton()
            {
                Tag = "[PushButton]**|$btSharedContentFolder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtSharedContentFolder);

            CbCopyAllContent = new CheckBox()
            {
                Tag = "[CheckBox]$cbCopyAllContent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CbCopyAllContent);

            BtOk = new PushButton()
            {
                Tag = "[PushButton]OK|$btOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtOk);

            BtCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtCancel);

            BtHelp = new PushButton()
            {
                Tag = "[PushButton]Help|$btHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtHelp);
        }
    }
}
