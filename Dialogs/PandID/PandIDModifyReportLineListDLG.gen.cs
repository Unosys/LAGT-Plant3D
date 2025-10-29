// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]ModifyReportLineListDLG")]
    public partial class PandIDModifyReportLineListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnDown;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  PushButton M_btnUp;
        public  CheckBox M_checkBoxDisFullName;
        public  CheckBox M_checkBoxDisGeo;
        public  CheckBox M_chkDisplayAll;
        public  Table M_dataGridView;
        public  GroupBox M_groupBoxPropertyOrder;
        public  GroupBox M_groupBoxReportProperty;
        public  StaticText M_lblInclude;
        public  StaticText M_lblSelectField;
        public  TreeView M_treeView;
        public  ScrollBar PropertyOrder;
        public  CustomWin SplitContainer1;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;

        partial void OnInitialize();

        public PandIDModifyReportLineListDLG()
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

            M_btnDown = new PushButton()
            {
                Tag = "[PushButton]$m_btnDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDown);

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

            M_btnUp = new PushButton()
            {
                Tag = "[PushButton]$m_btnUp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnUp);

            M_checkBoxDisFullName = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkBoxDisFullName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxDisFullName);

            M_checkBoxDisGeo = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkBoxDisGeo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxDisGeo);

            M_chkDisplayAll = new CheckBox()
            {
                Tag = "[CheckBox]$m_chkDisplayAll",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_chkDisplayAll);

            M_dataGridView = new Table()
            {
                Tag = "[Table]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);

            M_groupBoxPropertyOrder = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxPropertyOrder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxPropertyOrder);

            M_groupBoxReportProperty = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxReportProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxReportProperty);

            M_lblInclude = new StaticText()
            {
                Tag = "[StaticText]$m_lblInclude",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblInclude);

            M_lblSelectField = new StaticText()
            {
                Tag = "[StaticText]$m_lblSelectField",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblSelectField);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            PropertyOrder = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyOrder);

            SplitContainer1 = new CustomWin()
            {
                Tag = "[CustomWin]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SplitContainer1);

            SystemWindowsFormsSplitterPanel = new GroupBox()
            {
                Tag = "[GroupBox]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel);

            SystemWindowsFormsSplitterPanel2 = new GroupBox()
            {
                Tag = "[GroupBox]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel2);
        }
    }
}
