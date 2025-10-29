// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDDataManagerConfigurationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOk;
        public  PushButton M_btnSave;
        public  PushButton M_buttonNewView;
        public  PushButton M_buttonNewLevel;
        public  PushButton M_buttonRemoveView;
        public  TreeView M_treeView;
        public  ListBox M_viewListBox;
        public  GroupBox M_viewsGroupBox;
        public  GroupBox M_viewsPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;
        public  GroupBox SystemWindowsFormsSplitterPanel5;
        public  GroupBox SystemWindowsFormsSplitterPanel6;

        partial void OnInitialize();

        public PandIDDataManagerConfigurationDLG()
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

            M_buttonNewView = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4263644|#1/[Pane]$m_splitVert|#1/[Pane]$20974542|#2/[Pane]$m_dmConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[PushButton]Create View|$m_buttonNewView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNewView);

            M_buttonNewLevel = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4263644|#1/[Pane]$m_splitVert|#1/[Pane]$20974542|#2/[Pane]$m_dmConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4719710|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[PushButton]New Level*|$m_btnNewLevel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNewLevel);

            M_buttonRemoveView = new PushButton()
            {
                Tag = "[PushButton]$m_buttonRemoveView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonRemoveView);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            M_viewListBox = new ListBox()
            {
                Tag = "[ListBox]$m_viewListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_viewListBox);

            M_viewsGroupBox = new GroupBox()
            {
                Tag = "[Group]$m_viewsGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_viewsGroupBox);

            M_viewsPanel = new GroupBox()
            {
                Tag = "[Group]$m_viewsPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_viewsPanel);

            SystemWindowsFormsSplitterPanel = new GroupBox()
            {
                Tag = "[Group]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel);

            SystemWindowsFormsSplitterPanel2 = new GroupBox()
            {
                Tag = "[Group]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel2);

            SystemWindowsFormsSplitterPanel3 = new GroupBox()
            {
                Tag = "[Group]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel3);

            SystemWindowsFormsSplitterPanel4 = new GroupBox()
            {
                Tag = "[Group]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel4);

            SystemWindowsFormsSplitterPanel5 = new GroupBox()
            {
                Tag = "[Group]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel5);

            SystemWindowsFormsSplitterPanel6 = new GroupBox()
            {
                Tag = "[Group]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel6);
        }
    }
}
