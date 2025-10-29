// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupEndConnectionDLG : Pane
    {
        public  TreeViewItem PathsTVI;
        public  TreeView M_treeView;
        public  PushButton M_btnAddBlock;
        public  PushButton CancelPB;
        public  PushButton M_btnOk;

        partial void OnInitialize();

        public ProjectSetupEndConnectionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            M_treeView = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            M_btnAddBlock = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_endConnectorUserCtrl|#1/[GroupBox]End connections|$m_groupbox|#1/[GroupBox]$m_groupBox2|#1/[PushButton]Add Block*|$m_btnAddBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddBlock);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            M_btnOk = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);
        }
    }
}
