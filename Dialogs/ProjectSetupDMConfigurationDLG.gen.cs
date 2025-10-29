// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupDMConfigurationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin Control;
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOk;
        public  PushButton M_btnSave;
        public  PushButton M_buttonNewView;
        public  PushButton M_buttonRemoveView;
        public  CustomWin M_dmConfigUserControl;
        public  CustomWin M_splitHorz;
        public  CustomWin M_splitVert;
        public  TreeView M_treeView;
        public  ListBox M_viewListBox;
        public  GroupBox M_viewsGroupBox;
        public  GroupBox M_viewsPanel;
        public  CustomWin SplitContainer1;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;
        public  GroupBox SystemWindowsFormsSplitterPanel5;
        public  GroupBox SystemWindowsFormsSplitterPanel6;

        partial void OnInitialize();

        public ProjectSetupDMConfigurationDLG()
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
                Tag = "[PushButton]$m_buttonNewView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNewView);

            M_buttonRemoveView = new PushButton()
            {
                Tag = "[PushButton]$m_buttonRemoveView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonRemoveView);

            M_dmConfigUserControl = new CustomWin()
            {
                Tag = "[CustomWin]$m_dmConfigUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dmConfigUserControl);

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

            M_viewListBox = new ListBox()
            {
                Tag = "[ListBox]$m_viewListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_viewListBox);

            M_viewsGroupBox = new GroupBox()
            {
                Tag = "[GroupBox]$m_viewsGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_viewsGroupBox);

            M_viewsPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_viewsPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_viewsPanel);

            SplitContainer1 = new CustomWin()
            {
                Tag = "[CustomWin]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SplitContainer1);

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
                Tag = "[GroupBox]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel4);

            SystemWindowsFormsSplitterPanel5 = new GroupBox()
            {
                Tag = "[GroupBox]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel5);

            SystemWindowsFormsSplitterPanel6 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel6);
        }
    }
}
