// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Folder Properties", Parent = typeof(Plant3D))]
    public partial class ProjectFolderPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnTemplate;
        public  PushButton BtnLocation;
        public  TextField DWGCreationTemplateForFold1;
        public  StaticText DWGCreationTemplateForFold2;
        public  TextField StoreNewProjectDWGFilesIn1;
        public  StaticText StoreNewProjectDWGFilesIn2;
        public  CheckBox PromptForTemplate;
        public  CheckBox CreateFoldersRelativeToPar;
        public  TextField FolderName;
        public  StaticText FolderNameText;
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;

        partial void OnInitialize();

        public ProjectFolderPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnTemplate = new PushButton()
            {
                Tag = "[PushButton]#2|$btnTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnTemplate);

            BtnLocation = new PushButton()
            {
                Tag = "[PushButton]#1|$btnLocation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnLocation);

            DWGCreationTemplateForFold1 = new TextField()
            {
                Tag = "[TextField]#3|$txtTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGCreationTemplateForFold1);

            DWGCreationTemplateForFold2 = new StaticText()
            {
                Tag = "[StaticText]#3|$lblTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGCreationTemplateForFold2);

            StoreNewProjectDWGFilesIn1 = new TextField()
            {
                Tag = "[TextField]#2|$txtLocation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StoreNewProjectDWGFilesIn1);

            StoreNewProjectDWGFilesIn2 = new StaticText()
            {
                Tag = "[StaticText]#2|$lblLocation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StoreNewProjectDWGFilesIn2);

            PromptForTemplate = new CheckBox()
            {
                Tag = "[CheckBox]#2|$chkPromptTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PromptForTemplate);

            CreateFoldersRelativeToPar = new CheckBox()
            {
                Tag = "[CheckBox]#1|$chkRelative",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateFoldersRelativeToPar);

            FolderName = new TextField()
            {
                Tag = "[TextField]#1|$txtFolderName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderName);

            FolderNameText = new StaticText()
            {
                Tag = "[StaticText]#1|$lblFolderName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderNameText);

            Help = new PushButton()
            {
                Tag = "[PushButton]#5|$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
