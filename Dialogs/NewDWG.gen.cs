// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]NewDWG", Parent = typeof(Plant3D))]
    public partial class NewDWG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin ProjectProperties1;
        public  PushButton OK;
        public  PushButton Help;
        public  PushButton Cancel;
        public  StaticText DrawingProperties;
        public  StaticText AuthorText;
        public  TextField Author;
        public  StaticText DrawingName;
        public  CustomWin M_panel_filename;
        public  TextField FileName;
        public  StaticText FileNameText;
        public  StaticText ProjectProperties2;
        public  StaticText FolderPathText;
        public  TextField FolderPath;
        public  StaticText DWGTemplateText;
        public  PushButton M_dwtBrowseButton;
        public  TextField DWGTemplate;

        partial void OnInitialize();

        public NewDWG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ProjectProperties1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]#1|[System.Windows.Forms.Panel]$m_panel_buttons",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectProperties1);

            OK = new PushButton()
            {
                Tag = "[PushButton]#1|$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Help = new PushButton()
            {
                Tag = "[PushButton]#3|$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]#2|$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            DrawingProperties = new StaticText()
            {
                Tag = "[StaticText]#2|$m_gb_drawing_properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingProperties);

            AuthorText = new StaticText()
            {
                Tag = "[StaticText]#1|$m_StaticAuthor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthorText);

            Author = new TextField()
            {
                Tag = "[TextField]#1|$m_textBoxAuthor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Author);

            DrawingName = new StaticText()
            {
                Tag = "[StaticText]#1|$m_gb_drawing_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingName);

            M_panel_filename = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]#1|[System.Windows.Forms.Panel]$m_panel_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_panel_filename);

            FileName = new TextField()
            {
                Tag = "[TextField]#1|$m_tb_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FileNameText = new StaticText()
            {
                Tag = "[StaticText]#1|$lblFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);

            ProjectProperties2 = new StaticText()
            {
                Tag = "[StaticText]#3|$m_gb_project_properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectProperties2);

            FolderPathText = new StaticText()
            {
                Tag = "[StaticText]#1|$lblFolderPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderPathText);

            FolderPath = new TextField()
            {
                Tag = "[TextField]#1|$tbFolderPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderPath);

            DWGTemplateText = new StaticText()
            {
                Tag = "[StaticText]#2|$lblDWGTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGTemplateText);

            M_dwtBrowseButton = new PushButton()
            {
                Tag = "[PushButton]#1|$m_dwtBrowseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dwtBrowseButton);

            DWGTemplate = new TextField()
            {
                Tag = "[TextField]#2|$tbDWGTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGTemplate);
        }
    }
}
