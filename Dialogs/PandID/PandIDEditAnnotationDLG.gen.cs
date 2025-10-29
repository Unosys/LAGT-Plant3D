// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AnnotationDlg", Parent = typeof(Plant3D))]
    public partial class PandIDEditAnnotationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox AutodeskProcessPowerPnIDGUIUtilGSPreviewCtrlA;
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  CheckBox M_checkPreview;
        public  GroupBox M_EditPanel;
        public  StaticText M_label;
        public  StaticText M_label2;
        public  StaticText M_label3;
        public  StaticText M_labelStyleName;
        public  GroupBox M_panelPreview;
        public  GroupBox M_tableLayoutPanel;
        public  TextField M_textBox;
        public  TextField M_textBox2;
        public  TextField M_textBox3;
        public  GroupBox Panel1;
        public  GroupBox Panel12;
        public  GroupBox Panel13;
        public  GroupBox Panel2;
        public  ComboBox Size;
        public  ComboBox Size2;
        public  TextField SizeTextField;
        public  TextField SizeTextField4;

        partial void OnInitialize();

        public PandIDEditAnnotationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutodeskProcessPowerPnIDGUIUtilGSPreviewCtrlA = new GroupBox()
            {
                Tag = "[Group]$m_panelPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerPnIDGUIUtilGSPreviewCtrlA);

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

            M_checkPreview = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkPreview);

            M_EditPanel = new GroupBox()
            {
                Tag = "[Group]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_EditPanel);

            M_label = new StaticText()
            {
                Tag = "[StaticText]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label);

            M_label2 = new StaticText()
            {
                Tag = "[StaticText]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label2);

            M_label3 = new StaticText()
            {
                Tag = "[StaticText]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label3);

            M_labelStyleName = new StaticText()
            {
                Tag = "[StaticText]$m_labelStyleName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelStyleName);

            M_panelPreview = new GroupBox()
            {
                Tag = "[Group]$m_panelPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_panelPreview);

            M_tableLayoutPanel = new GroupBox()
            {
                Tag = "[Group]$m_tableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tableLayoutPanel);

            M_textBox = new TextField()
            {
                Tag = "[TextField]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBox);

            M_textBox2 = new TextField()
            {
                Tag = "[TextField]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBox2);

            M_textBox3 = new TextField()
            {
                Tag = "[TextField]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBox3);

            Panel1 = new GroupBox()
            {
                Tag = "[Group]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            Panel12 = new GroupBox()
            {
                Tag = "[Group]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel12);

            Panel13 = new GroupBox()
            {
                Tag = "[Group]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel13);

            Panel2 = new GroupBox()
            {
                Tag = "[Group]$panel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel2);

            Size = new ComboBox()
            {
                Tag = "[ComboBox]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size);

            Size2 = new ComboBox()
            {
                Tag = "[ComboBox]$m_EditPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size2);

            SizeTextField = new TextField()
            {
                Tag = "[TextField]$Size:",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeTextField);

            SizeTextField4 = new TextField()
            {
                Tag = "[TextField]$Size:",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeTextField4);
        }
    }
}
