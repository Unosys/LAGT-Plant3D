// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]$59420", Parent = typeof(MainWin))]
    public partial class PROJECTMANAGERDLG : CustomWin
    {
        public  TreeView TreeViewTV;
        public  TreeViewItem DefaultProjectTVI;
        public  TreeViewItem PIDDrawingsTVI;
        public  TreeViewItem Plant3DDrawingsTVI;
        public  TreeViewItem PipeSpecsTVI;
        public  TreeViewItem RelatedFilesTVI;
        public  PushButton OpenPB;
        public  PushButton PushButton2PB;
        public  PopupList CurrentProjectPL;

        partial void OnInitialize();

        public PROJECTMANAGERDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            DefaultProjectTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultProjectTVI);

            PIDDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]P*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDrawingsTVI);

            Plant3DDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]Plant 3D Drawings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDrawingsTVI);

            PipeSpecsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]Pipe Specs|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecsTVI);

            RelatedFilesTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]Related Files|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RelatedFilesTVI);

            OpenPB = new PushButton()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[PopupList]Current Project:|$m_comboPrjFiles|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            PushButton2PB = new PushButton()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]toolStrip1|$m_ButtonCollection|#1/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            CurrentProjectPL = new PopupList()
            {
                Tag = "[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[PopupList]Current Project:|$m_comboPrjFiles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectPL);
        }
    }
}
