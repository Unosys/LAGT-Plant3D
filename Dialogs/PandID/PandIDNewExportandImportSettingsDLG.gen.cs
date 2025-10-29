// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$PnPNewExportImportSettingDlg", Parent = typeof(Pane))]
    public partial class PandIDNewExportandImportSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox GroupBox1;
        public  StaticText Label1;
        public  StaticText Label2;
        public  StaticText Label3;
        public  StaticText Label4;
        public  StaticText Label5;
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  Table M_dataGridView;
        public  TextField M_tbDesc;
        public  TextField M_tbExternalObjName;
        public  TextField M_tbName;
        public  TreeView M_treeView;
        public  ScrollBar VerticalScrollBar;
        public  PushButton PushButton;
        public  Header HeaderCTL;
        public  Header PIDPropertyCTL;
        public  Header ExternalPropertyCTL;
        public  Header UIDCTL;
        public  Header ValueMappingCTL;
        public  PushButton PushButtonPB;
        public  TreeView PIDClassesTV;
        public  TreeViewItem EngineeringItemsTVI;

        partial void OnInitialize();

        public PandIDNewExportandImportSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            GroupBox1 = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox1);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            Label2 = new StaticText()
            {
                Tag = "[StaticText]$label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label2);

            Label3 = new StaticText()
            {
                Tag = "[StaticText]$label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label3);

            Label4 = new StaticText()
            {
                Tag = "[StaticText]$label4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label4);

            Label5 = new StaticText()
            {
                Tag = "[StaticText]$label5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label5);

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

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_tbDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);

            PushButton = new PushButton()
            {
                Tag = "[PushButton]$m_dataGridView(4:0)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton);

            HeaderCTL = new Header()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            PIDPropertyCTL = new Header()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDPropertyCTL);

            ExternalPropertyCTL = new Header()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]External Property|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExternalPropertyCTL);

            UIDCTL = new Header()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]UID|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UIDCTL);

            ValueMappingCTL = new Header()
            {
                Tag = "[GroupBox]$groupBox1|#1/[Table]$m_dataGridView|#1/[CustomWin]#1/[Header]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueMappingCTL);

            PushButtonPB = new PushButton()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            PIDClassesTV = new TreeView()
            {
                Tag = "[TreeView]P*|$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassesTV);

            EngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Engineering Items|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItemsTVI);
        }
    }
}
