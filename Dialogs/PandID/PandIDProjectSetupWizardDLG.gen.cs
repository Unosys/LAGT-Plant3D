// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateProjectWizard")]
    public partial class PandIDProjectSetupWizardDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnProjDir;
        public  PushButton M_btnTemplate;
        public  PushButton M_buttonBack;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  CheckBox M_checkBoxCopySettings;
        public  CheckBox M_checkBoxVaultPrj;
        public  TextField M_editDesc;
        public  TextField M_editName;
        public  TextField M_editProjDir;
        public  TextField M_editTemplateFile;
        public  StaticText M_projDescLbl;
        public  StaticText M_projDirLbl;
        public  StaticText M_ProjectXMLLbl;
        public  StaticText M_ProjNameLbl;
        public  CustomWin M_wizardSetup;
        public  GroupBox PageWelcome;
        public  PushButton ClosePB;
        public  PushButton YesPB;
        public  PushButton NoPB;

        partial void OnInitialize();

        public PandIDProjectSetupWizardDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnProjDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnProjDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnProjDir);

            M_btnTemplate = new PushButton()
            {
                Tag = "[PushButton]$m_btnTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnTemplate);

            M_buttonBack = new PushButton()
            {
                Tag = "[PushButton]$m_buttonBack",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonBack);

            M_buttonCancel = new PushButton()
            {
                Tag = "[PushButton]$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]$m_buttonNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            M_checkBoxCopySettings = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkBoxCopySettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxCopySettings);

            M_checkBoxVaultPrj = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkBoxVaultPrj",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxVaultPrj);

            M_editDesc = new TextField()
            {
                Tag = "[TextField]$m_editDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editDesc);

            M_editName = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[TextField]$m_editName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editName);

            M_editProjDir = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[TextField]$m_editProjDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editProjDir);

            M_editTemplateFile = new TextField()
            {
                Tag = "[TextField]$m_editTemplateFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editTemplateFile);

            M_projDescLbl = new StaticText()
            {
                Tag = "[StaticText]$m_projDescLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projDescLbl);

            M_projDirLbl = new StaticText()
            {
                Tag = "[StaticText]$m_projDirLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projDirLbl);

            M_ProjectXMLLbl = new StaticText()
            {
                Tag = "[StaticText]$m_ProjectXMLLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_ProjectXMLLbl);

            M_ProjNameLbl = new StaticText()
            {
                Tag = "[StaticText]$m_ProjNameLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_ProjNameLbl);

            M_wizardSetup = new CustomWin()
            {
                Tag = "[CustomWin]$m_wizardSetup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_wizardSetup);

            PageWelcome = new GroupBox()
            {
                Tag = "[GroupBox]$pageWelcome",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageWelcome);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard*|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            YesPB = new PushButton()
            {
                Tag = "[DialogBox]Project Setup Wizard (Page 5 of 6)|#1/[PushButton]Yes|$6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[DialogBox]Project Setup Wizard (Page 5 of 6)|#1/[PushButton]No|$7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);
        }
    }
}
