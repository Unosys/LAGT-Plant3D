// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupExportandImportSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox GroupBox1;
        public  PushButton M_btnCancel;
        public  PushButton M_btnDelete;
        public  PushButton M_btnHelp;
        public  PushButton M_btnModify;
        public  PushButton M_btnNew;
        public  PushButton M_btnOk;
        public  PushButton M_btnSave;
        public  ListBox M_listBox;
        public  TreeView M_treeView;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public PandIDProjectSetupExportandImportSettingsDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$28708114|#1/[Pane]$m_splitVert|#1/[Pane]$3147056|#2/[Pane]$m_exportImportSettingsUserControl|#1/[GroupBox]Export and import settings|$groupBox1|#1/[PushButton]$m_btnNew|#1",
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

            M_btnSave = new PushButton()
            {
                Tag = "[PushButton]$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            M_listBox = new ListBox()
            {
                Tag = "[ListBox]$m_listBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBox);

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
