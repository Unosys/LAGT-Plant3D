// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class ProjectSetupWizardSpecifyDatabaseSettingsVault5DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText M_authentLbl;
        public  PushButton M_btnDbGenName;
        public  PushButton M_btnTestConnection;
        public  PushButton M_buttonBack;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  ComboBox M_comboAuthent;
        public  ComboBox M_comboServer;
        public  TextField M_comboServerTextField;
        public  StaticText M_dbNameLabel;
        public  StaticText M_dbPageLbl;
        public  StaticText M_helpLbl;
        public  Link M_linkHelpLbl;
        public  StaticText M_pwdLbl;
        public  StaticText M_serverNameLbl;
        public  TextField M_tbDbName;
        public  TextField M_tbPwd;
        public  TextField M_tbUsrName;
        public  TextField M_tbVaultRootFolder;
        public  StaticText M_usrNameLbl;
        public  StaticText M_VaultRootLbl;
        public  StaticText M_winAuthMsgLbl;
        public  GroupBox PageDBSettings;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyDatabaseSettingsVault5DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_authentLbl = new StaticText()
            {
                Tag = "[StaticText]$m_authentLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_authentLbl);

            M_btnDbGenName = new PushButton()
            {
                Tag = "[PushButton]$m_btnDbGenName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDbGenName);

            M_btnTestConnection = new PushButton()
            {
                Tag = "[PushButton]$m_btnTestConnection",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnTestConnection);

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
                Tag = "[PushButton]$m_buttonNext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            M_comboAuthent = new ComboBox()
            {
                Tag = "[ComboBox]$m_comboAuthent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboAuthent);

            M_comboServer = new ComboBox()
            {
                Tag = "[ComboBox]$m_comboServer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboServer);

            M_comboServerTextField = new TextField()
            {
                Tag = "[TextField]$m_comboServer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboServerTextField);

            M_dbNameLabel = new StaticText()
            {
                Tag = "[StaticText]$m_dbNameLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dbNameLabel);

            M_dbPageLbl = new StaticText()
            {
                Tag = "[StaticText]$m_dbPageLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dbPageLbl);

            M_helpLbl = new StaticText()
            {
                Tag = "[StaticText]$m_helpLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_helpLbl);

            M_linkHelpLbl = new Link()
            {
                Tag = "[Link]$m_linkHelpLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_linkHelpLbl);

            M_pwdLbl = new StaticText()
            {
                Tag = "[StaticText]$m_pwdLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pwdLbl);

            M_serverNameLbl = new StaticText()
            {
                Tag = "[StaticText]$m_serverNameLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_serverNameLbl);

            M_tbDbName = new TextField()
            {
                Tag = "[TextField]$m_tbDbName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbDbName);

            M_tbPwd = new TextField()
            {
                Tag = "[TextField]$m_tbPwd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbPwd);

            M_tbUsrName = new TextField()
            {
                Tag = "[TextField]$m_tbUsrName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbUsrName);

            M_tbVaultRootFolder = new TextField()
            {
                Tag = "[TextField]$m_tbVaultRootFolder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbVaultRootFolder);

            M_usrNameLbl = new StaticText()
            {
                Tag = "[StaticText]$m_usrNameLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_usrNameLbl);

            M_VaultRootLbl = new StaticText()
            {
                Tag = "[StaticText]$m_VaultRootLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_VaultRootLbl);

            M_winAuthMsgLbl = new StaticText()
            {
                Tag = "[StaticText]$m_winAuthMsgLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_winAuthMsgLbl);

            PageDBSettings = new GroupBox()
            {
                Tag = "[GroupBox]$pageDBSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageDBSettings);
        }
    }
}
