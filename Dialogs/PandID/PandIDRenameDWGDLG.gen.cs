// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmRenameDrawing", Parent = typeof(CustomWin))]
    public partial class PandIDRenameDWGDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnOK;
        public  StaticText LblFileName;
        public  CheckBox M_cb_override;
        public  GroupBox M_gb_drawing_name;
        public  StaticText M_lb_name;
        public  GroupBox M_panel_buttons;
        public  GroupBox M_panel_filename;
        public  GroupBox M_panel_property_names;
        public  TextField M_tb_property_value;
        public  StaticText M_warnTextLabel;
        public  TextField M_tb_filename;

        partial void OnInitialize();

        public PandIDRenameDWGDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnOK = new PushButton()
            {
                Tag = "[Pane]Renaming will cause all external references to this drawing to be broken*|$m_panel_buttons|#1/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            LblFileName = new StaticText()
            {
                Tag = "[StaticText]$lblFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblFileName);

            M_cb_override = new CheckBox()
            {
                Tag = "[CheckBox]$m_cb_override",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cb_override);

            M_gb_drawing_name = new GroupBox()
            {
                Tag = "[GroupBox]$m_gb_drawing_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_gb_drawing_name);

            M_lb_name = new StaticText()
            {
                Tag = "[StaticText]$m_lb_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lb_name);

            M_panel_buttons = new GroupBox()
            {
                Tag = "[GroupBox]$m_panel_buttons",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_panel_buttons);

            M_panel_filename = new GroupBox()
            {
                Tag = "[GroupBox]$m_panel_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_panel_filename);

            M_panel_property_names = new GroupBox()
            {
                Tag = "[GroupBox]$m_panel_property_names",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_panel_property_names);

            M_tb_property_value = new TextField()
            {
                Tag = "[TextField]$m_tb_property_value",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tb_property_value);

            M_warnTextLabel = new StaticText()
            {
                Tag = "[StaticText]$m_warnTextLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_warnTextLabel);

            M_tb_filename = new TextField()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name|#1/[Pane]Renaming will cause all external references to this drawing to be broken*|$m_panel_filename|#1/[TextField]File name: |$m_tb_filename|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tb_filename);
        }
    }
}
