// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText M_authentLbl;
        public  PushButton M_btnDbGenName;
        public  PushButton M_btnTestConnection;
        public  PushButton M_buttonBack;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  ComboBox M_comboServer;
        public  TextField M_comboServerTextField;
        public  StaticText M_dbNameLabel;
        public  StaticText M_dbPageLbl;
        public  StaticText M_helpLbl;
        public  Link M_linkHelpLbl;
        public  StaticText M_pwdLbl;
        public  RadioButton M_radioSQLServer;
        public  RadioButton M_radioSQLite;
        public  StaticText M_serverNameLbl;
        public  TextField M_tbDbName;
        public  TextField M_tbPwd;
        public  StaticText PasswordST;
        public  TextField M_tbUsrName;
        public  StaticText M_usrNameLbl;
        public  CustomWin M_wizardSetup;
        public  GroupBox PageDBSettings;
        public  PopupList M_comboAuthent;

        partial void OnInitialize();

        public PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG()
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
                Tag = "[Pane]$m_wizardSetup/[Pane]$pageDBSettings/[PushButton]$m_btnTestConnection",
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
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Cancel|$m_buttonCancel|#3",
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

            M_comboServer = new ComboBox()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[ComboBox]SQL Server name:|$m_comboServer|#1",
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

            M_radioSQLServer = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[RadioButton]AutoCAD Plant 3D and AutoCAD PID both include a file-based local database (SQLite) that requires no configuration*[1]|$m_radioSQLServer|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioSQLServer);

            M_radioSQLite = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[RadioButton]AutoCAD Plant 3D and AutoCAD PID both include a file-based local database (SQLite) that requires no configuration*[2]|$m_radioSQLite|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioSQLite);

            M_serverNameLbl = new StaticText()
            {
                Tag = "[StaticText]$m_serverNameLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_serverNameLbl);

            M_tbDbName = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[TextField]Database name prefix:|$m_tbDbName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbDbName);

            M_tbPwd = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[TextField]Password:|$m_tbPwd|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbPwd);

            PasswordST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[StaticText]Password:|$m_pwdLbl|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordST);

            M_tbUsrName = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[TextField]User name:|$m_tbUsrName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbUsrName);

            M_usrNameLbl = new StaticText()
            {
                Tag = "[StaticText]$m_usrNameLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_usrNameLbl);

            M_wizardSetup = new CustomWin()
            {
                Tag = "[CustomWin]$m_wizardSetup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_wizardSetup);

            PageDBSettings = new GroupBox()
            {
                Tag = "[GroupBox]$pageDBSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageDBSettings);

            M_comboAuthent = new PopupList()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings|#1/[PopupList]Authentication:|$m_comboAuthent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboAuthent);
        }
    }
}
