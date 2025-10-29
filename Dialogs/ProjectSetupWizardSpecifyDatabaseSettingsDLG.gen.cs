// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup Wizard (Page 5 of 6)|$CreateProjectWizard", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupWizardSpecifyDatabaseSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Link M_linkHelpLbl;
        public  TextField M_tbPwd;
        public  TextField M_tbUsrName;
        public  PopupList M_comboAuthent;
        public  PushButton DropDownButtonPB;
        public  PushButton M_btnDbGenName;
        public  TextField M_tbDbName;
        public  PushButton M_btnTestConnection;
        public  ComboBox M_comboServer;
        public  RadioButton M_radioSQLServer;
        public  RadioButton M_radioSQLite;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  PushButton M_buttonBack;
        public  PushButton ClosePB;
        public  TextField M_comboServerTextField;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyDatabaseSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_linkHelpLbl = new Link()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[Link]Learn More|$m_linkHelpLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_linkHelpLbl);

            M_tbPwd = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[TextField]Password:|$m_tbPwd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbPwd);

            M_tbUsrName = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[TextField]User name:|$m_tbUsrName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbUsrName);

            M_comboAuthent = new PopupList()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[PopupList]Authentication:|$m_comboAuthent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboAuthent);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[PopupList]Authentication:|$m_comboAuthent/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            M_btnDbGenName = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[PushButton]Test Name|$m_btnDbGenName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDbGenName);

            M_tbDbName = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[TextField]Database name prefix:|$m_tbDbName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbDbName);

            M_btnTestConnection = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[PushButton]Test Connection|$m_btnTestConnection",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnTestConnection);

            M_comboServer = new ComboBox()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[ComboBox]SQL Server name:|$m_comboServer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboServer);

            M_radioSQLServer = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[RadioButton]AutoCAD Plant 3D and AutoCAD PID both include a file-based local database (SQLite) that requires no configuration*[1]|$m_radioSQLServer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioSQLServer);

            M_radioSQLite = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Report nominal diameters of imperial content in:|$pageDBSettings/[RadioButton]AutoCAD Plant 3D and AutoCAD PID both include a file-based local database (SQLite) that requires no configuration*[2]|$m_radioSQLite",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioSQLite);

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
                Tag = "[TitleBar]Project Setup Wizard (Page 5 of 6)|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            M_comboServerTextField = new TextField()
            {
                Tag = "[TextField]$m_comboServer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboServerTextField);
        }
    }
}
