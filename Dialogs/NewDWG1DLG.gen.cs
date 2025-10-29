// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmNewDWG_Revised", Parent = typeof(Plant3D))]
    public partial class NewDWG1DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnHelp;
        public  PushButton BtnOK;
        public  StaticText LblDWGTemplate;
        public  StaticText LblFileName;
        public  StaticText LblFolderPath;
        public  PushButton M_dwtBrowseButton;
        public  GroupBox M_gb_drawing_name;
        public  GroupBox M_gb_drawing_properties;
        public  GroupBox M_gb_project_properties;
        public  GroupBox M_panel_buttons;
        public  GroupBox M_panel_filename;
        public  StaticText M_StaticAuthor;
        public  TextField M_tb_filename;
        public  TextField M_textBoxAuthor;
        public  TextField TbDWGTemplate;
        public  TextField TbFolderPath;

        partial void OnInitialize();

        public NewDWG1DLG()
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

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            LblDWGTemplate = new StaticText()
            {
                Tag = "[StaticText]$lblDWGTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblDWGTemplate);

            LblFileName = new StaticText()
            {
                Tag = "[StaticText]$lblFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblFileName);

            LblFolderPath = new StaticText()
            {
                Tag = "[StaticText]$lblFolderPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblFolderPath);

            M_dwtBrowseButton = new PushButton()
            {
                Tag = "[PushButton]$m_dwtBrowseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dwtBrowseButton);

            M_gb_drawing_name = new GroupBox()
            {
                Tag = "[GroupBox]$m_gb_drawing_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_gb_drawing_name);

            M_gb_drawing_properties = new GroupBox()
            {
                Tag = "[GroupBox]$m_gb_drawing_properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_gb_drawing_properties);

            M_gb_project_properties = new GroupBox()
            {
                Tag = "[GroupBox]$m_gb_project_properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_gb_project_properties);

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

            M_StaticAuthor = new StaticText()
            {
                Tag = "[StaticText]$m_StaticAuthor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_StaticAuthor);

            M_tb_filename = new TextField()
            {
                Tag = "[TextField]$m_tb_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tb_filename);

            M_textBoxAuthor = new TextField()
            {
                Tag = "[TextField]$m_textBoxAuthor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxAuthor);

            TbDWGTemplate = new TextField()
            {
                Tag = "[TextField]$tbDWGTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TbDWGTemplate);

            TbFolderPath = new TextField()
            {
                Tag = "[TextField]$tbFolderPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TbFolderPath);
        }
    }
}
