// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$PnPNewExportImportSettingDlg")]
    public partial class Plant3DNewExportImportSettingDLG : Pane
    {
        public  PushButton M_ValueMappingPB;
        public  TextField M_tbName;
        public  PushButton M_btnCancel;
        public  PushButton M_btnOK;
        public  TreeView M_treeView;
        public  ListView M_dataGridView;
        public  ListViewItem ValueMappingLVI;
        public  ScrollBar VerSB;

        partial void OnInitialize();

        public Plant3DNewExportImportSettingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_ValueMappingPB = new PushButton()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_dataGridView|#1/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_ValueMappingPB);

            M_tbName = new TextField()
            {
                Tag = "[TextField]Name:|$m_tbName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbName);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOK);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            M_dataGridView = new ListView()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_dataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);

            ValueMappingLVI = new ListViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_dataGridView|#1/[CustomWin]*/[ListViewItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueMappingLVI);

            VerSB = new ScrollBar()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_dataGridView|#1/[ScrollBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerSB);
        }
    }
}
