// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Rename DWG|$frmRenameDrawing", Parent = typeof(ProjManUndocked), GUIType = GuiType.UIA)]
    public partial class RenameDWG2DLG : Pane
    {
        public  PushButton BtnOK;
        public  PushButton BtnCancel;
        public  GroupBox M_gb_drawing_name;
        public  TextField M_tb_filename;
        public  CheckBox M_cb_override;
        public  TextField M_tb_property_value;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public RenameDWG2DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnOK = new PushButton()
            {
                Tag = "[Pane]Renaming will cause all external references to this drawing to be broken*|$m_panel_buttons/[PushButton]OK|$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            BtnCancel = new PushButton()
            {
                Tag = "[Pane]Renaming will cause all external references to this drawing to be broken*|$m_panel_buttons/[PushButton]Cancel|$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            M_gb_drawing_name = new GroupBox()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_gb_drawing_name);

            M_tb_filename = new TextField()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name/[Pane]Renaming will cause all external references to this drawing to be broken*[1]|$m_panel_filename/[TextField]File name: |$m_tb_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tb_filename);

            M_cb_override = new CheckBox()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name/[Pane]Renaming will cause all external references to this drawing to be broken*[1]|$m_panel_filename/[CheckBox]Override|$m_cb_override",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cb_override);

            M_tb_property_value = new TextField()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name/[Pane]Renaming will cause all external references to this drawing to be broken*[2]|$m_panel_property_names/[Pane]$DrawingNamePropertyItem/[TextField]Test :|$m_tb_property_value",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tb_property_value);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Rename DWG|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
