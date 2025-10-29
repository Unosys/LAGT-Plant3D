// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class ProjectSetupWizardVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText M_ProjNameLbl;
        public  CustomWin M_wizardSetup;
        public  GroupBox PageWelcome;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  CheckBox FromVaultServerCK;
        public  PushButton PushButton1PB;
        public  TextField VaultFolderPathTF;
        public  StaticText VaultFolderPathST;
        public  CheckBox M_checkBoxVaultPrj;
        public  PushButton PushButton2PB;
        public  TextField SpecifyTheDirectoryTF;
        public  StaticText SpecifyTheDirectoryWhereST;
        public  TextField EnterAnOptionalDescriptionTF;
        public  StaticText EnterAnOptionalDescriptionST;
        public  TextField M_editName;
        public  StaticText EnterANameForST;
        public  PushButton PushButton3PB;
        public  StaticText SelectProjectXMLFileST;
        public  TextField SelectProjectXMLFileTF;
        public  CheckBox M_checkBoxCopySettings;
        public  PushButton Cancel;
        public  PushButton M_buttonNext;
        public  PushButton BackPB;
        public  TitleBar ProjectSetupWizardPageCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  RadioButton ImperialRB;
        public  RadioButton MetricRB;

        partial void OnInitialize();

        public ProjectSetupWizardVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

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

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            FromVaultServerCK = new CheckBox()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[CheckBox]From vault server|$m_browseVaultPrjCB|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FromVaultServerCK);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[PushButton]**[1]|$m_btnVaultDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            VaultFolderPathTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[TextField]Vault folder path:|$m_vaultDirTB|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultFolderPathTF);

            VaultFolderPathST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[StaticText]Vault folder path:|$m_vaultLocLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultFolderPathST);

            M_checkBoxVaultPrj = new CheckBox()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[CheckBox]Create this project in vault:|$m_checkBoxVaultPrj|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxVaultPrj);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[PushButton]**[2]|$m_btnProjDir|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            SpecifyTheDirectoryTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[TextField]Specify the directory where program-generated files are stored:|$m_editProjDir|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryTF);

            SpecifyTheDirectoryWhereST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[StaticText]Specify the directory where program-generated files are stored:|$m_projDirLbl|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryWhereST);

            EnterAnOptionalDescriptionTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[TextField]Enter an optional description:|$m_editDesc|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterAnOptionalDescriptionTF);

            EnterAnOptionalDescriptionST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[StaticText]Enter an optional description:|$m_projDescLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterAnOptionalDescriptionST);

            M_editName = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[TextField]Enter a name for this project:|$m_editName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editName);

            EnterANameForST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[StaticText]Enter a name for this project:|$m_ProjNameLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterANameForST);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[PushButton]**[3]|$m_btnTemplate|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            SelectProjectXMLFileST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[StaticText]Select project XML file:|$m_ProjectXMLLbl|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectProjectXMLFileST);

            SelectProjectXMLFileTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[TextField]Select project XML file:|$m_editTemplateFile|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectProjectXMLFileTF);

            M_checkBoxCopySettings = new CheckBox()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageWelcome|#1/[CheckBox]Copy settings from existing project|$m_checkBoxCopySettings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxCopySettings);

            Cancel = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Cancel|$m_buttonCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Next;|$m_buttonNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            BackPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]<< Back|$m_buttonBack|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPB);

            ProjectSetupWizardPageCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 1 of 6)|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupWizardPageCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 1 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 1 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 1 of 6)|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ImperialRB = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageUnitSettings|#1/[RadioButton]$m_imperialRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialRB);

            MetricRB = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pageUnitSettings|#1/[RadioButton]$m_metricRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MetricRB);
        }
    }
}
