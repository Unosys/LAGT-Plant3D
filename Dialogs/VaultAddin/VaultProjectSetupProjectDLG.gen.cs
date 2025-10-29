// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Vault Project Setup - Project 1|$frmAddSqliteProjectToVault", Parent = typeof(Plant3D))]
    public partial class VaultProjectSetupProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane CUsersAdministratorDocumentsProject2RelatedFilesPANE;
        public  PushButton StartPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  StaticText CUsersAdministratorDocumentsProject2RelatedFilesST;
        public  StaticText ProjectSupportingFilesFolderST;
        public  StaticText CUsersAdministratorDocumentsProject2SpecSheetsST;
        public  StaticText ProjectSpecsheetsFolderST;
        public  StaticText CUsersAdministratorDocumentsProject2OrthosDWGsST;
        public  StaticText OrthographicOutputFolderST;
        public  StaticText CUsersAdministratorDocumentsProject2Plant3DModelsST;
        public  StaticText Plant3DModelDrawingsST;
        public  StaticText CUsersAdministratorDocumentsProject2PIDDWGST;
        public  StaticText PIDDrawingsFolderST;
        public  GroupBox DatabaseGB;
        public  TextField PasswordTF;
        public  StaticText PasswordST;
        public  TextField UserNameTF;
        public  StaticText UserNameST;
        public  StaticText WindowsCredentialsWillBeST;
        public  ComboBox AuthenticationCB;
        public  StaticText AuthenticationST;
        public  PushButton TestNamePB;
        public  TextField DatabaseNamePrefixTF;
        public  StaticText DatabaseNamePrefixST;
        public  PushButton TestConnectionPB;
        public  ComboBox SQLServerNameCB;
        public  StaticText SQLServerNameST;
        public  GroupBox VaultLocationGB;
        public  PushButton PushButton1PB;
        public  TextField ProjectLocationInVaultTF;
        public  StaticText ProjectLocationInVaultST;
        public  GroupBox WorkspaceLocationGB;
        public  CheckBox DeleteExistingProjectAfterCK;
        public  StaticText LocalWorkingFolderLocationST;
        public  PushButton PushButton2PB;
        public  TextField LocalWorkingFolderLocationTF;
        public  StaticText ExistingProjectFolderST;
        public  TextField ExistingProjectFolderTF;
        public  StaticText VaultProjectsRequireThatST;
        public  StaticText SQLiteProjectConversionToST;
        public  Pane SQLiteProjectConversionToPANE;
        public  TitleBar VaultProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public VaultProjectSetupProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CUsersAdministratorDocumentsProject2RelatedFilesPANE = new Pane()
            {
                Tag = "[Pane]C:*|$panel1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorDocumentsProject2RelatedFilesPANE);

            StartPB = new PushButton()
            {
                Tag = "[Pane]C:*|$panel1|#2/[PushButton]Start|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StartPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]C:*|$panel1|#2/[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]C:*|$panel1|#2/[PushButton]Help|$m_btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CUsersAdministratorDocumentsProject2RelatedFilesST = new StaticText()
            {
                Tag = "[StaticText]C:*|$m_relFilesDir|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorDocumentsProject2RelatedFilesST);

            ProjectSupportingFilesFolderST = new StaticText()
            {
                Tag = "[StaticText]Project supporting files folder:|$relFilesDir|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSupportingFilesFolderST);

            CUsersAdministratorDocumentsProject2SpecSheetsST = new StaticText()
            {
                Tag = "[StaticText]C:*|$m_specsDirLbl|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorDocumentsProject2SpecSheetsST);

            ProjectSpecsheetsFolderST = new StaticText()
            {
                Tag = "[StaticText]Project specsheets folder:|$specsDirLbl|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSpecsheetsFolderST);

            CUsersAdministratorDocumentsProject2OrthosDWGsST = new StaticText()
            {
                Tag = "[StaticText]C:*|$m_orthoDirLbl|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorDocumentsProject2OrthosDWGsST);

            OrthographicOutputFolderST = new StaticText()
            {
                Tag = "[StaticText]Orthographic output folder:|$orthoDirLbl|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicOutputFolderST);

            CUsersAdministratorDocumentsProject2Plant3DModelsST = new StaticText()
            {
                Tag = "[StaticText]C:*|$m_p3dDirLbl|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorDocumentsProject2Plant3DModelsST);

            Plant3DModelDrawingsST = new StaticText()
            {
                Tag = "[StaticText]Plant 3D Model Drawings folder:|$P3DDirLbl|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DModelDrawingsST);

            CUsersAdministratorDocumentsProject2PIDDWGST = new StaticText()
            {
                Tag = "[StaticText]C:*|$m_pidDirLbl|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorDocumentsProject2PIDDWGST);

            PIDDrawingsFolderST = new StaticText()
            {
                Tag = "[StaticText]P*|$pidDirLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDrawingsFolderST);

            DatabaseGB = new GroupBox()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseGB);

            PasswordTF = new TextField()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[TextField]Password:|$m_tbPwd|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTF);

            PasswordST = new StaticText()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[StaticText]Password:|$label10|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordST);

            UserNameTF = new TextField()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[TextField]User name:|$m_tbUsrName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTF);

            UserNameST = new StaticText()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[StaticText]User name:|$label9|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameST);

            WindowsCredentialsWillBeST = new StaticText()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[StaticText]Windows credentials will be used automatically when users open the project|$m_winAuthMsgLbl|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WindowsCredentialsWillBeST);

            AuthenticationCB = new ComboBox()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[ComboBox]Authentication:|$m_comboAuthent|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationCB);

            AuthenticationST = new StaticText()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[StaticText]Authentication:|$label7|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationST);

            TestNamePB = new PushButton()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[PushButton]Test Name|$m_btnDbGenName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TestNamePB);

            DatabaseNamePrefixTF = new TextField()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[TextField]Database name prefix:|$m_tbDbName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseNamePrefixTF);

            DatabaseNamePrefixST = new StaticText()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[StaticText]Database name prefix:|$label6|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseNamePrefixST);

            TestConnectionPB = new PushButton()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[PushButton]Test Connection|$m_btnTestConnection|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TestConnectionPB);

            SQLServerNameCB = new ComboBox()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[ComboBox]SQL Server name:|$m_comboServer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SQLServerNameCB);

            SQLServerNameST = new StaticText()
            {
                Tag = "[GroupBox]Database|$groupBox3|#3/[StaticText]SQL Server name:|$label5|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SQLServerNameST);

            VaultLocationGB = new GroupBox()
            {
                Tag = "[GroupBox]Vault location|$m_vaultLocationGB|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultLocationGB);

            PushButton1PB = new PushButton()
            {
                Tag = "[GroupBox]Vault location|$m_vaultLocationGB|#2/[PushButton]**|$m_vaultDirBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            ProjectLocationInVaultTF = new TextField()
            {
                Tag = "[GroupBox]Vault location|$m_vaultLocationGB|#2/[TextField]Project location in vault:|$m_vaultLocationTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectLocationInVaultTF);

            ProjectLocationInVaultST = new StaticText()
            {
                Tag = "[GroupBox]Vault location|$m_vaultLocationGB|#2/[StaticText]Project location in vault:|$label4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectLocationInVaultST);

            WorkspaceLocationGB = new GroupBox()
            {
                Tag = "[GroupBox]Workspace location|$m_copyProjGB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WorkspaceLocationGB);

            DeleteExistingProjectAfterCK = new CheckBox()
            {
                Tag = "[GroupBox]Workspace location|$m_copyProjGB|#1/[CheckBox]Delete existing project after transfer|$m_deleteProjCB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteExistingProjectAfterCK);

            LocalWorkingFolderLocationST = new StaticText()
            {
                Tag = "[GroupBox]Workspace location|$m_copyProjGB|#1/[StaticText]Local working folder location:|$m_workspaceLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocalWorkingFolderLocationST);

            PushButton2PB = new PushButton()
            {
                Tag = "[GroupBox]Workspace location|$m_copyProjGB|#1/[PushButton]**|$m_workspaceProjBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            LocalWorkingFolderLocationTF = new TextField()
            {
                Tag = "[GroupBox]Workspace location|$m_copyProjGB|#1/[TextField]Local working folder location:|$m_workSpaceProjTB|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocalWorkingFolderLocationTF);

            ExistingProjectFolderST = new StaticText()
            {
                Tag = "[GroupBox]Workspace location|$m_copyProjGB|#1/[StaticText]Existing project folder:|$label3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExistingProjectFolderST);

            ExistingProjectFolderTF = new TextField()
            {
                Tag = "[GroupBox]Workspace location|$m_copyProjGB|#1/[TextField]Existing project folder:|$m_projDirTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExistingProjectFolderTF);

            VaultProjectsRequireThatST = new StaticText()
            {
                Tag = "[StaticText]Vault projects require that a local copy of the project be located in a workspace on your local machine*|$label2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultProjectsRequireThatST);

            SQLiteProjectConversionToST = new StaticText()
            {
                Tag = "[StaticText]SQLite project conversion to Vault|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SQLiteProjectConversionToST);

            SQLiteProjectConversionToPANE = new Pane()
            {
                Tag = "[Pane]SQLite project conversion to Vault|$m_SQLitecollapsiblePanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SQLiteProjectConversionToPANE);

            VaultProjectSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Vault Project Setup - Project 2|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultProjectSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Vault Project Setup - Project 2|$TitleBar|#1/[CustomWin]System Menu Bar|$frmAddSqliteProjectToVault|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Vault Project Setup - Project 2|$TitleBar|#1/[CustomWin]System Menu Bar|$frmAddSqliteProjectToVault|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Vault Project Setup - Project 2|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Vault Project Setup - Project 2|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Vault Project Setup - Project 2|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
