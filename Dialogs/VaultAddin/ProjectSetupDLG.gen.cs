// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox CmbboxTPGforPiping;
        public  ComboBox CmbboxTPGforPnid;
        public  StaticText Label1;
        public  StaticText LblTPGforP3D;
        public  StaticText LblTPGforPNID;
        public  PushButton M_btnAdd;
        public  PushButton M_btnAddRow;
        public  PushButton M_btnCancel;
        public  PushButton M_btnCheckOut;
        public  PushButton M_btnDeleteRow;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOk;
        public  PushButton M_btnRelatedFilesDir;
        public  PushButton M_btnRemove;
        public  PushButton M_btnReportDir;
        public  PushButton M_btnSave;
        public  Table M_dataGridView;
        public  GroupBox M_groupBoxCustom;
        public  GroupBox M_groupBoxGapSymbol;
        public  GroupBox M_groupBoxGeneral;
        public  GroupBox M_groupBoxOther;
        public  GroupBox M_groupBoxProject;
        public  GroupBox M_groupBoxPrompts;
        public  GroupBox M_groupBoxReportDir;
        public  StaticText M_labelCheckOutStatus;
        public  StaticText M_labelRelatedFilesDir;
        public  StaticText M_labelReportsDir;
        public  StaticText M_lblCustomCategories;
        public  StaticText M_lblProjectDesc;
        public  StaticText M_lblProjectName;
        public  StaticText M_lblProjectNumber;
        public  StaticText M_lblprompt;
        public  StaticText M_lblProperties;
        public  StaticText M_lblZoomFactor;
        public  ListBox M_listBox;
        public  RadioButton M_radioClose;
        public  RadioButton M_radioNoAutoPrompt;
        public  RadioButton M_radioOpen;
        public  TextField M_textBoxProjectDesc;
        public  TextField M_textBoxProjectName;
        public  TextField M_textBoxProjectNumber;
        public  TextField M_textBoxRelatedFilesDir;
        public  TextField M_textBoxReportDir;
        public  TextField M_textBoxZoomFactor;
        public  TreeView M_treeView;
        public  ScrollBar ProjectDetails;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public ProjectSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CmbboxTPGforPiping = new ComboBox()
            {
                Tag = "[ComboBox]$cmbboxTPGforPiping",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CmbboxTPGforPiping);

            CmbboxTPGforPnid = new ComboBox()
            {
                Tag = "[ComboBox]$cmbboxTPGforPnid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CmbboxTPGforPnid);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            LblTPGforP3D = new StaticText()
            {
                Tag = "[StaticText]$lblTPGforP3D",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblTPGforP3D);

            LblTPGforPNID = new StaticText()
            {
                Tag = "[StaticText]$lblTPGforPNID",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblTPGforPNID);

            M_btnAdd = new PushButton()
            {
                Tag = "[PushButton]$m_btnAdd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAdd);

            M_btnAddRow = new PushButton()
            {
                Tag = "[PushButton]$m_btnAddRow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddRow);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnCheckOut = new PushButton()
            {
                Tag = "[PushButton]$m_btnCheckOut",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCheckOut);

            M_btnDeleteRow = new PushButton()
            {
                Tag = "[PushButton]$m_btnDeleteRow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDeleteRow);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_btnRelatedFilesDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnRelatedFilesDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRelatedFilesDir);

            M_btnRemove = new PushButton()
            {
                Tag = "[PushButton]$m_btnRemove",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRemove);

            M_btnReportDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnReportDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnReportDir);

            M_btnSave = new PushButton()
            {
                Tag = "[PushButton]$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            M_dataGridView = new Table()
            {
                Tag = "[Table]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);

            M_groupBoxCustom = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxCustom",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxCustom);

            M_groupBoxGapSymbol = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxGapSymbol",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxGapSymbol);

            M_groupBoxGeneral = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxGeneral",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxGeneral);

            M_groupBoxOther = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxOther",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxOther);

            M_groupBoxProject = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxProject",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxProject);

            M_groupBoxPrompts = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxPrompts",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxPrompts);

            M_groupBoxReportDir = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxReportDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxReportDir);

            M_labelCheckOutStatus = new StaticText()
            {
                Tag = "[StaticText]$m_labelCheckOutStatus",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelCheckOutStatus);

            M_labelRelatedFilesDir = new StaticText()
            {
                Tag = "[StaticText]$m_labelRelatedFilesDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelRelatedFilesDir);

            M_labelReportsDir = new StaticText()
            {
                Tag = "[StaticText]$m_labelReportsDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelReportsDir);

            M_lblCustomCategories = new StaticText()
            {
                Tag = "[StaticText]$m_lblCustomCategories",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblCustomCategories);

            M_lblProjectDesc = new StaticText()
            {
                Tag = "[StaticText]$m_lblProjectDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblProjectDesc);

            M_lblProjectName = new StaticText()
            {
                Tag = "[StaticText]$m_lblProjectName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblProjectName);

            M_lblProjectNumber = new StaticText()
            {
                Tag = "[StaticText]$m_lblProjectNumber",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblProjectNumber);

            M_lblprompt = new StaticText()
            {
                Tag = "[StaticText]$m_lblprompt",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblprompt);

            M_lblProperties = new StaticText()
            {
                Tag = "[StaticText]$m_lblProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblProperties);

            M_lblZoomFactor = new StaticText()
            {
                Tag = "[StaticText]$m_lblZoomFactor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblZoomFactor);

            M_listBox = new ListBox()
            {
                Tag = "[ListBox]$m_listBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBox);

            M_radioClose = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioClose);

            M_radioNoAutoPrompt = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioNoAutoPrompt",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioNoAutoPrompt);

            M_radioOpen = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioOpen",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioOpen);

            M_textBoxProjectDesc = new TextField()
            {
                Tag = "[TextField]$m_textBoxProjectDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxProjectDesc);

            M_textBoxProjectName = new TextField()
            {
                Tag = "[TextField]$m_textBoxProjectName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxProjectName);

            M_textBoxProjectNumber = new TextField()
            {
                Tag = "[TextField]$m_textBoxProjectNumber",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxProjectNumber);

            M_textBoxRelatedFilesDir = new TextField()
            {
                Tag = "[TextField]$m_textBoxRelatedFilesDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxRelatedFilesDir);

            M_textBoxReportDir = new TextField()
            {
                Tag = "[TextField]$m_textBoxReportDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxReportDir);

            M_textBoxZoomFactor = new TextField()
            {
                Tag = "[TextField]$m_textBoxZoomFactor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxZoomFactor);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            ProjectDetails = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetails);

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
