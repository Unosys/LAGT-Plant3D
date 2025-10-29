// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupDrawingPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin Control;
        public  PushButton M_btnAdd;
        public  PushButton M_btnAddRow;
        public  PushButton M_btnCancel;
        public  PushButton M_btnDeleteRow;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOk;
        public  PushButton M_btnRemove;
        public  PushButton M_btnSave;
        public  Table M_dataGridView;
        public  CustomWin M_drawingPropertiesUserCtrl;
        public  GroupBox M_groupBox;
        public  GroupBox M_groupBoxCustom;
        public  ListBox M_listBox;
        public  CustomWin M_splitHorz;
        public  CustomWin M_splitVert;
        public  StaticText M_StaticCustomCategories;
        public  StaticText M_StaticProperties;
        public  TreeView M_treeView;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public ProjectSetupDrawingPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Control = new CustomWin()
            {
                Tag = "[CustomWin]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Control);

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

            M_btnRemove = new PushButton()
            {
                Tag = "[PushButton]$m_btnRemove",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRemove);

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

            M_drawingPropertiesUserCtrl = new CustomWin()
            {
                Tag = "[CustomWin]$m_drawingPropertiesUserCtrl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingPropertiesUserCtrl);

            M_groupBox = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBox);

            M_groupBoxCustom = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxCustom",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxCustom);

            M_listBox = new ListBox()
            {
                Tag = "[ListBox]$m_listBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBox);

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

            M_StaticCustomCategories = new StaticText()
            {
                Tag = "[StaticText]$m_StaticCustomCategories",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_StaticCustomCategories);

            M_StaticProperties = new StaticText()
            {
                Tag = "[StaticText]$m_StaticProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_StaticProperties);

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
