// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$SelectDrawingPropertyDlg")]
    public partial class PandIDSelectDrawingPropertyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  StaticText M_lblCategory;
        public  StaticText M_lblDrawingText;
        public  ListBox M_listBoxCategory;
        public  ListBox M_listBoxDrawingProperty;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;

        partial void OnInitialize();

        public PandIDSelectDrawingPropertyDLG()
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

            M_lblDrawingText = new StaticText()
            {
                Tag = "[StaticText]$m_lblDrawingText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblDrawingText);

            M_listBoxCategory = new ListBox()
            {
                Tag = "[ListBox]$m_listBoxCategory",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBoxCategory);

            M_listBoxDrawingProperty = new ListBox()
            {
                Tag = "[ListBox]$m_listBoxDrawingProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBoxDrawingProperty);

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
