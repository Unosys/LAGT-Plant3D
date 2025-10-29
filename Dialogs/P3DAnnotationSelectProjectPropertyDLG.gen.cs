// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectProjectPropertyDlg")]
    public partial class P3DAnnotationSelectProjectPropertyDLG : Pane
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  StaticText M_lblCategory;
        public  StaticText M_lblProjectText;
        public  ListBox M_listBoxCategory;
        public  ListBox M_listBoxProperty;
        public  CustomWin SplitContainer1;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;

        partial void OnInitialize();

        public P3DAnnotationSelectProjectPropertyDLG()
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

            M_lblCategory = new StaticText()
            {
                Tag = "[StaticText]$m_lblCategory",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblCategory);

            M_lblProjectText = new StaticText()
            {
                Tag = "[StaticText]$m_lblProjectText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblProjectText);

            M_listBoxCategory = new ListBox()
            {
                Tag = "[ListBox]$m_listBoxCategory",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBoxCategory);

            M_listBoxProperty = new ListBox()
            {
                Tag = "[ListBox]$m_listBoxProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBoxProperty);

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
