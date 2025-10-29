// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]New DWG|$frmNewDWG_Revised", Parent = typeof(Plant3D))]
    public partial class PandIDNewDWG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  PushButton Help;
        public  PushButton Cancel;
        public  GroupBox DrawingProperties;
        public  TextField AuthorText;
        public  StaticText Author;
        public  GroupBox DrawingName;
        public  Pane M_panel_filenamePane2PANE;
        public  TextField FileName;
        public  StaticText FileNameText;
        public  GroupBox ProjectProperties2;
        public  PushButton M_dwt_BrowseButtonPushButtonPB;
        public  StaticText FolderPathText;
        public  TextField DWGTemplateText;
        public  TextField FolderPath;
        public  StaticText DWGTemplate;

        partial void OnInitialize();

        public PandIDNewDWG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[Pane]$m_panel_buttons/[PushButton]OK|$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Help = new PushButton()
            {
                Tag = "[Pane]$m_panel_buttons/[PushButton]Help|$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[Pane]$m_panel_buttons/[PushButton]Cancel|$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            DrawingProperties = new GroupBox()
            {
                Tag = "[GroupBox]Drawing properties|$m_gb_drawing_properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingProperties);

            AuthorText = new TextField()
            {
                Tag = "[GroupBox]Drawing properties|$m_gb_drawing_properties/[TextField]Author:|$m_textBoxAuthor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthorText);

            Author = new StaticText()
            {
                Tag = "[GroupBox]Drawing properties|$m_gb_drawing_properties/[StaticText]Author:|$m_StaticAuthor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Author);

            DrawingName = new GroupBox()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingName);

            M_panel_filenamePane2PANE = new Pane()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name/[Pane]$m_panel_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_panel_filenamePane2PANE);

            FileName = new TextField()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name/[Pane]$m_panel_filename/[TextField]File name: |$m_tb_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FileNameText = new StaticText()
            {
                Tag = "[GroupBox]Drawing name|$m_gb_drawing_name/[Pane]$m_panel_filename/[StaticText]File name: |$lblFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);

            ProjectProperties2 = new GroupBox()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectProperties2);

            M_dwt_BrowseButtonPushButtonPB = new PushButton()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties/[PushButton]...|$m_dwtBrowseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dwt_BrowseButtonPushButtonPB);

            FolderPathText = new StaticText()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties/[StaticText]Folder path: |$lblFolderPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderPathText);

            DWGTemplateText = new TextField()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties/[TextField]DWG template:|$tbDWGTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGTemplateText);

            FolderPath = new TextField()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties/[TextField]Folder path: |$tbFolderPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderPath);

            DWGTemplate = new StaticText()
            {
                Tag = "[GroupBox]Project properties|$m_gb_project_properties/[StaticText]DWG template:|$lblDWGTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGTemplate);
        }
    }
}
