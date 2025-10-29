// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$PnPNewExportImportSettingDlg")]
    public partial class P3DModifyExportAndImportSettingDLG : Pane
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  Table M_dataGridView;
        public  TextField M_tbDesc;
        public  TextField M_tbExternalObjName;
        public  TextField M_tbName;
        public  TreeView M_treeView;

        partial void OnInitialize();

        public P3DModifyExportAndImportSettingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnOK = new PushButton()
            {
                Tag = "[PushButton]$m_btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOK);

            M_dataGridView = new Table()
            {
                Tag = "[Table]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);

            M_tbDesc = new TextField()
            {
                Tag = "[TextField]$m_tbDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbDesc);

            M_tbExternalObjName = new TextField()
            {
                Tag = "[TextField]$m_tbExternalObjName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbExternalObjName);

            M_tbName = new TextField()
            {
                Tag = "[TextField]$m_tbName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbName);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);
        }
    }
}
