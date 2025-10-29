// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupProjectReportsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Apply;
        public  CustomWin Control;
        public  GroupBox GroupBox1;
        public  StaticText Label1;
        public  PushButton M_btnCancel;
        public  PushButton M_btnDelete;
        public  PushButton M_btnHelp;
        public  PushButton M_btnModify;
        public  PushButton M_btnNew;
        public  PushButton M_btnOk;
        public  PushButton M_btnReset;
        public  PushButton M_btnSave;
        public  GroupBox M_dataGridPanel;
        public  CustomWin M_datagridRowSpinner;
        public  ScrollBar M_dataGridViewHScroll;
        public  PushButton M_firstRowBtn;
        public  CustomWin M_gridView;
        public  GroupBox M_hScrollPanel;
        public  PushButton M_lastRowBtn;
        public  StaticText M_lblDefinedReports;
        public  StaticText M_lblInformation;
        public  StaticText M_lblReportPreview;
        public  ListBox M_listBox;
        public  PushButton M_nextRowBtn;
        public  Table M_pnIDDataGridView;
        public  PushButton M_previousRowBtn;
        public  TextField M_recordIndexTextBox;
        public  CustomWin M_reportsUserControl;
        public  StaticText M_rowCountLabel;
        public  CustomWin M_splitHorz;
        public  CustomWin M_splitVert;
        public  TreeView M_treeView;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public ProjectSetupProjectReportsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Apply = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Apply);

            Control = new CustomWin()
            {
                Tag = "[CustomWin]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Control);

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

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnDelete = new PushButton()
            {
                Tag = "[PushButton]$m_btnDelete",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDelete);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnModify = new PushButton()
            {
                Tag = "[PushButton]$m_btnModify",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModify);

            M_btnNew = new PushButton()
            {
                Tag = "[PushButton]$m_btnNew",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnNew);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_btnReset = new PushButton()
            {
                Tag = "[PushButton]$m_btnReset",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnReset);

            M_btnSave = new PushButton()
            {
                Tag = "[PushButton]$groupBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            M_dataGridPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_dataGridPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridPanel);

            M_datagridRowSpinner = new CustomWin()
            {
                Tag = "[CustomWin]$m_datagridRowSpinner",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_datagridRowSpinner);

            M_dataGridViewHScroll = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_dataGridViewHScroll",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridViewHScroll);

            M_firstRowBtn = new PushButton()
            {
                Tag = "[PushButton]$m_firstRowBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_firstRowBtn);

            M_gridView = new CustomWin()
            {
                Tag = "[CustomWin]$m_gridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_gridView);

            M_hScrollPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_hScrollPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_hScrollPanel);

            M_lastRowBtn = new PushButton()
            {
                Tag = "[PushButton]$m_lastRowBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lastRowBtn);

            M_lblDefinedReports = new StaticText()
            {
                Tag = "[StaticText]$m_lblDefinedReports",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblDefinedReports);

            M_lblInformation = new StaticText()
            {
                Tag = "[StaticText]$m_lblInformation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblInformation);

            M_lblReportPreview = new StaticText()
            {
                Tag = "[StaticText]$m_lblReportPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblReportPreview);

            M_listBox = new ListBox()
            {
                Tag = "[ListBox]$m_listBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBox);

            M_nextRowBtn = new PushButton()
            {
                Tag = "[PushButton]$m_nextRowBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_nextRowBtn);

            M_pnIDDataGridView = new Table()
            {
                Tag = "[Table]$m_pnIDDataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pnIDDataGridView);

            M_previousRowBtn = new PushButton()
            {
                Tag = "[PushButton]$m_previousRowBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_previousRowBtn);

            M_recordIndexTextBox = new TextField()
            {
                Tag = "[TextField]$m_recordIndexTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_recordIndexTextBox);

            M_reportsUserControl = new CustomWin()
            {
                Tag = "[CustomWin]$m_reportsUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_reportsUserControl);

            M_rowCountLabel = new StaticText()
            {
                Tag = "[StaticText]$m_rowCountLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_rowCountLabel);

            M_splitHorz = new CustomWin()
            {
                Tag = "[CustomWin]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_splitHorz);

            M_splitVert = new CustomWin()
            {
                Tag = "[CustomWin]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_splitVert);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            SystemWindowsFormsSplitterPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel);

            SystemWindowsFormsSplitterPanel2 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel2);

            SystemWindowsFormsSplitterPanel3 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel3);

            SystemWindowsFormsSplitterPanel4 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel4);
        }
    }
}
