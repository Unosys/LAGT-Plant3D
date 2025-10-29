// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Autodesk Data Management Server Console *|$ExplorerForm", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class VaultProServer : MainWin
    {
        public  TreeView TreeViewTV;
        public  ScrollBar HorizontalScrollBarSB;

        partial void OnInitialize();

        public VaultProServer()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#1/[Pane]$m_navBarControl/[Pane]$m_navBar/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[TreeView]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[Pane]$m_mainPanelContainer/[Pane]$m_navPanel/[Pane]$m_navBarControl/[Pane]$m_navBar/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[TreeView]#1/[ScrollBar]$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);
        }
    }
}
