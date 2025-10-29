// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox PageDBSettings;
        public  Pane PanePANE;
        public  Pane ReportNominalDiametersOfPANE;
        public  StaticText UsersWillNotBeST;
        public  StaticText VaultFolderPathST;
        public  TextField VaultFolderPathTF;
        public  Link LearnMoreLINK;
        public  TextField PasswordTF;
        public  StaticText PasswordST;
        public  TextField UserNameTF;
        public  StaticText UserNameST;
        public  PopupList AuthenticationPL;
        public  PushButton DropDownButtonPB;
        public  StaticText AuthenticationST;
        public  PushButton M_btnDbGenName;
        public  TextField DatabaseNamePrefixTF;
        public  StaticText DatabaseNamePrefixST;
        public  StaticText DoYouHaveAnST;
        public  StaticText SQLServerNameST;
        public  PushButton TestConnectionPB;
        public  ComboBox M_comboServer;
        public  StaticText AProjectMasterDatabaseST;
        public  PushButton CancelPB;
        public  PushButton M_buttonNext;
        public  PushButton BackPB;
        public  TitleBar ProjectSetupWizardPageCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton M_buttonCancel;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PageDBSettings = new GroupBox()
            {
                Tag = "[GroupBox]$pageDBSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageDBSettings);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            ReportNominalDiametersOfPANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportNominalDiametersOfPANE);

            UsersWillNotBeST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]Users will not be required to enter any credentials when they*|$m_winAuthMsgLbl|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UsersWillNotBeST);

            VaultFolderPathST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]Vault folder path:|$m_VaultRootLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultFolderPathST);

            VaultFolderPathTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[TextField]Vault folder path:|$m_tbVaultRootFolder|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultFolderPathTF);

            LearnMoreLINK = new Link()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[Link]Learn More|$m_linkHelpLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnMoreLINK);

            PasswordTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[TextField]Password:|$m_tbPwd|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTF);

            PasswordST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]Password:|$m_pwdLbl|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordST);

            UserNameTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[TextField]User name:|$m_tbUsrName|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTF);

            UserNameST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]User name:|$m_usrNameLbl|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameST);

            AuthenticationPL = new PopupList()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[PopupList]Authentication:|$m_comboAuthent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[PopupList]Authentication:|$m_comboAuthent|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            AuthenticationST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]Authentication:|$m_authentLbl|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationST);

            M_btnDbGenName = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[PushButton]Test Name|$m_btnDbGenName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDbGenName);

            DatabaseNamePrefixTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[TextField]Database name prefix:|$m_tbDbName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseNamePrefixTF);

            DatabaseNamePrefixST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]Database name prefix:|$m_dbNameLabel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseNamePrefixST);

            DoYouHaveAnST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]Do you have an existing project that you would like to convert to SQL Server?|$m_helpLbl|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoYouHaveAnST);

            SQLServerNameST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]SQL Server name:|$m_serverNameLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SQLServerNameST);

            TestConnectionPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[PushButton]Test Connection|$m_btnTestConnection|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TestConnectionPB);

            M_comboServer = new ComboBox()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[ComboBox]SQL Server name:|$m_comboServer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboServer);

            AProjectMasterDatabaseST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]A project master database will be created in the specified SQL Server*|$m_dbPageLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AProjectMasterDatabaseST);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Cancel|$m_buttonCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Next >>|$m_buttonNext|#2",
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
                Tag = "[TitleBar]Project Setup Wizard (Page 5 of 6)|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupWizardPageCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 5 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 5 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            M_buttonCancel = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 5 of 6)|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);
        }
    }
}
