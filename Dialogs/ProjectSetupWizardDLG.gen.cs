// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup Wizard (Page 1 of 6)|$CreateProjectWizard", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupWizardDLG : Pane
    {
        public  CheckBox M_checkBoxVaultPrj;
        public  PushButton PushButton1PB;
        public  TextField VaultFolderPathTF;
        public  CheckBox CreateThisProjectInCK;
        public  PushButton M_btnProjDir;
        public  TextField M_editProjDir;
        public  TextField M_editDesc;
        public  TextField M_editName;
        public  PushButton M_btnTemplate;
        public  TextField M_editTemplateFile;
        public  CheckBox M_checkBoxCopySettings;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  PushButton M_buttonBack;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_checkBoxVaultPrj = new CheckBox()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[CheckBox]From vault server|$m_browseVaultPrjCB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxVaultPrj);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[PushButton]**[1]|$m_btnVaultDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            VaultFolderPathTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[TextField]Vault folder path:|$m_vaultDirTB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultFolderPathTF);

            CreateThisProjectInCK = new CheckBox()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[CheckBox]Create this project in vault:|$m_checkBoxVaultPrj",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateThisProjectInCK);

            M_btnProjDir = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[PushButton]**[2]|$m_btnProjDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnProjDir);

            M_editProjDir = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[TextField]Specify the directory where program-generated files are stored:|$m_editProjDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editProjDir);

            M_editDesc = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[TextField]Enter an optional description:|$m_editDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editDesc);

            M_editName = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[TextField]Enter a name for this project:|$m_editName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editName);

            M_btnTemplate = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[PushButton]**[3]|$m_btnTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnTemplate);

            M_editTemplateFile = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[TextField]Select project XML file:|$m_editTemplateFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editTemplateFile);

            M_checkBoxCopySettings = new CheckBox()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageWelcome/[CheckBox]Copy settings from existing project|$m_checkBoxCopySettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxCopySettings);

            M_buttonCancel = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]Cancel|$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]Next >>|$m_buttonNext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            M_buttonBack = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]<< Back|$m_buttonBack",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonBack);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 1 of 6)|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
