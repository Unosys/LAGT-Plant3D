// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmSelectOrthoDwg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class SelectOrthographicDrawingDLG : Pane
    {
        public  TreeView M_treeView;
        public  TreeViewItem DefaultprojectTVI;
        public  TreeViewItem OrthographicDrawingsTVI;
        public  TreeViewItem oneTVI;
        public  TreeViewItem one23TVI;
        public  TreeViewItem OrthoViewPortTVI;
        public  PushButton M_btnNewDwg;
        public  PushButton M_btnCancel;
        public  PushButton M_btnOK;
        public  StaticText OrthographicDrawingsInTheST;
        public  TitleBar SelectOrthographicDrawingCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectOrthographicDrawingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            DefaultprojectTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$m_treeView|#1/[TreeViewItem]defaultproject|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultprojectTVI);

            OrthographicDrawingsTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$m_treeView|#1/[TreeViewItem]defaultproject|#1/[TreeViewItem]Orthographic Drawings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicDrawingsTVI);

            oneTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$m_treeView|#1/[TreeViewItem]defaultproject|#1/[TreeViewItem]Orthographic Drawings|#1/[TreeViewItem]1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneTVI);

            one23TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$m_treeView|#1/[TreeViewItem]defaultproject|#1/[TreeViewItem]Orthographic Drawings|#1/[TreeViewItem]123|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one23TVI);

            OrthoViewPortTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$m_treeView|#1/[TreeViewItem]defaultproject|#1/[TreeViewItem]Orthographic Drawings|#1/[TreeViewItem]OrthoViewPort|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoViewPortTVI);

            M_btnNewDwg = new PushButton()
            {
                Tag = "[PushButton]Create New*|$m_btnNewDwg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnNewDwg);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOK);

            OrthographicDrawingsInTheST = new StaticText()
            {
                Tag = "[StaticText]Orthographic drawings in the project:|$m_headingLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicDrawingsInTheST);

            SelectOrthographicDrawingCTL = new TitleBar()
            {
                Tag = "[TitleBar]Select Orthographic Drawing|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectOrthographicDrawingCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Select Orthographic Drawing|$TitleBar|#1/[CustomWin]System Menu Bar|$frmSelectOrthoDwg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Select Orthographic Drawing|$TitleBar|#1/[CustomWin]System Menu Bar|$frmSelectOrthoDwg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Orthographic Drawing|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
