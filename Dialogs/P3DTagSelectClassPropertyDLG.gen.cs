// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectClassPropertyDlg")]
    public partial class P3DTagSelectClassPropertyDLG : Pane
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  CheckBox M_checkBox;
        public  StaticText M_lblClassText;
        public  StaticText M_lblPropertyText;
        public  ListBox M_listBoxProperty;
        public  TreeView M_treeViewClass;
        public  CustomWin SplitContainer1;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  ScrollBar VerticalScrollBar;

        partial void OnInitialize();

        public P3DTagSelectClassPropertyDLG()
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

            M_checkBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBox);

            M_lblClassText = new StaticText()
            {
                Tag = "[StaticText]$m_lblClassText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblClassText);

            M_lblPropertyText = new StaticText()
            {
                Tag = "[StaticText]$m_lblPropertyText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblPropertyText);

            M_listBoxProperty = new ListBox()
            {
                Tag = "[ListBox]$m_listBoxProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBoxProperty);

            M_treeViewClass = new TreeView()
            {
                Tag = "[TreeView]$m_treeViewClass",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeViewClass);

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

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_listBoxProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);
        }
    }
}
