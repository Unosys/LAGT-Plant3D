// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Autodesk Vault Professional*|$ExplorerForm", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class VM_ProjectExplorerDLG : Plant3DMainWin
    {
        public  Table FileListPANE;
        public  CustomWin FileListPANE_FilstRow;
        public  CustomWin FileListPANE_SecondRow;
        public  CustomWin FileListPANE_SixRow;
        public  PushButton DropPB;
        public  TextField FileNameTF;
        public  TreeView TreeViewTV;
        public  Pane ExplorerShortcutPANE;
        public  TreeView ShortcutTree;

        partial void OnInitialize();

        public VM_ProjectExplorerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileListPANE = new Table()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#2/[Pane]$m_ViewContainer/[Pane]#1/[Pane]$FolderViewControl/[Table]$m_gridControlFileList",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileListPANE);

            FileListPANE_FilstRow = new CustomWin()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#2/[Pane]$m_ViewContainer/[Pane]#1/[Pane]$FolderViewControl/[Table]$m_gridControlFileList/[CustomWin]#2/[ListBoxItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileListPANE_FilstRow);

            FileListPANE_SecondRow = new CustomWin()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#2/[Pane]$m_ViewContainer/[Pane]#1/[Pane]$FolderViewControl/[Table]$m_gridControlFileList/[CustomWin]#2/[ListBoxItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileListPANE_SecondRow);

            FileListPANE_SixRow = new CustomWin()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#2/[Pane]$m_ViewContainer/[Pane]#1/[Pane]$FolderViewControl/[Table]$m_gridControlFileList/[CustomWin]#2/[ListBoxItem]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileListPANE_SixRow);

            DropPB = new PushButton()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#2/[Pane]$m_ViewContainer/[Pane]#1/[Pane]$FolderViewControl/[Pane]$m_titleBar/[Pane]$m_titlePanel/[Pane]$m_table/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropPB);

            FileNameTF = new TextField()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#2/[Pane]$m_ViewContainer/[Pane]#1/[Pane]$FolderViewControl/[Pane]$ExpandedQuickFindControl/[Pane]$m_table/[Pane]#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTF);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#1/[Pane]$m_navBarControl/[Pane]$m_navBar/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[TreeView]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            ExplorerShortcutPANE = new Pane()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#1/[Pane]$m_navBarControl/[Pane]$m_navBar/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#3/[Pane]$ExplorerShortcutControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExplorerShortcutPANE);

            ShortcutTree = new TreeView()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#1/[Pane]$m_navBarControl/[Pane]$m_navBar/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#3/[Pane]$ExplorerShortcutControl/[TreeView]$m_shortcutTree",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShortcutTree);
        }
    }
}
