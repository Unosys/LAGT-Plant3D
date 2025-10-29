// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]New DWG|$frmNewDWG_Revised", Parent = typeof(ProjManUndocked), GUIType = GuiType.UIA)]
    public partial class NewDWGDLG : Pane
    {
        public  PushButton BtnOK;
        public  PushButton BtnHelp;
        public  PushButton BtnCancel;
        public  TextField M_textBoxAuthor;
        public  TextField M_tb_filename;
        public  PushButton M_dwtBrowseButton;
        public  TextField TbDWGTemplate;
        public  TextField TbFolderPath;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public NewDWGDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnOK = new PushButton()
            {
                Tag = "[Pane]$m_panel_buttons/[PushButton]OK|$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            BtnHelp = new PushButton()
            {
                Tag = "[Pane]$m_panel_buttons/[PushButton]Help|$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            BtnCancel = new PushButton()
            {
                Tag = "[Pane]$m_panel_buttons/[PushButton]Cancel|$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            M_textBoxAuthor = new TextField()
            {
                Tag = "[GroupBox]Drawing properties|$m_gb_drawing_properties/[TextField]Author:|$m_textBoxAuthor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxAuthor);

            M_tb_filename = new TextField()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name/[Pane]$m_panel_filename/[TextField]File name: |$m_tb_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tb_filename);

            M_dwtBrowseButton = new PushButton()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties/[PushButton]**|$m_dwtBrowseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dwtBrowseButton);

            TbDWGTemplate = new TextField()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties/[TextField]DWG template:|$tbDWGTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TbDWGTemplate);

            TbFolderPath = new TextField()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties/[TextField]Folder path: |$tbFolderPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TbFolderPath);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]New DWG|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
