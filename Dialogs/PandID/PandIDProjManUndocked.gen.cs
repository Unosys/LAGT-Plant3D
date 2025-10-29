// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]PROJECTMANAGER", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class PandIDProjManUndocked : CustomWin
    {
        public  CustomWin PROJECTMANAGER1WIN;
        public  TreeView TreeViewTV;
        public  TreeViewItem DefaultProjectTVI;
        public  TreeViewItem PIDDrawingsTVI;
        public  TreeViewItem Plant3DDrawingsTVI;
        public  TreeViewItem RelatedFilesTVI;
        public  TreeViewItem SampleProjectTVI;
        public  TreeViewItem OrthographicDrawingsTVI;
        public  TreeViewItem Area1PlanTVI;
        public  TreeViewItem TopPlanViewTVI;

        partial void OnInitialize();

        public PandIDProjManUndocked()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PROJECTMANAGER1WIN = new CustomWin()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$59423",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PROJECTMANAGER1WIN);

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$59423/[CustomWin]#1/[CustomWin]#1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            DefaultProjectTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultProjectTVI);

            PIDDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView/[TreeViewItem]#1/[TreeViewItem]P*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDrawingsTVI);

            Plant3DDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView/[TreeViewItem]#1/[TreeViewItem]Plant 3D Drawings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDrawingsTVI);

            RelatedFilesTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView/[TreeViewItem]#1/[TreeViewItem]Related Files|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RelatedFilesTVI);

            SampleProjectTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SampleProjectTVI);

            OrthographicDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicDrawingsTVI);

            Area1PlanTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Area1PlanTVI);

            TopPlanViewTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]#1/[TreeViewItem]#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopPlanViewTVI);
        }
    }
}
