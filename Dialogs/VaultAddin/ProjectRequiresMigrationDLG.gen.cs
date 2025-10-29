// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]ProjectRequiresMigrationDLG", Parent = typeof(PROJECTMANAGERDLG))]
    public partial class ProjectRequiresMigrationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  M_ServerMigrationWizardClass M_ServerMigrationWizard;

        partial void OnInitialize();

        public ProjectRequiresMigrationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_ServerMigrationWizard = new M_ServerMigrationWizardClass()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnPProjectSetup.GenericWizard]$m_ServerMigrationWizard|[Autodesk.ProcessPower.PnPProjectSetup.GenericWizard]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_ServerMigrationWizard);
        }

        public partial class M_ServerMigrationWizardClass : CustomWin
        {
            public M_ServerMigrationWizardPage1Class M_ServerMigrationWizardPage1;
            public M_ServerMigrationWizardPage2Class M_ServerMigrationWizardPage2;
            public PushButton Cancel;
            public PushButton Next;
            public PushButton Back;

            partial void OnInitialize();

            public M_ServerMigrationWizardClass()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnPProjectSetup.GenericWizard]$m_ServerMigrationWizard|[Autodesk.ProcessPower.PnPProjectSetup.GenericWizard]#1";
                ParentType = this.GetType();

                M_ServerMigrationWizardPage1 = new M_ServerMigrationWizardPage1Class()
                {
                    Tag = "[CustomWin][Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]$m_ServerMigrationWizardPage1|[Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(M_ServerMigrationWizardPage1);

                M_ServerMigrationWizardPage2 = new M_ServerMigrationWizardPage2Class()
                {
                    Tag = "[CustomWin][Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]$m_ServerMigrationWizardPage2|[Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(M_ServerMigrationWizardPage2);

                Cancel = new PushButton()
                {
                    Tag = "[PushButton]$m_buttonCancel|Cancel|#3",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Cancel);

                Next = new PushButton()
                {
                    Tag = "[PushButton]$m_buttonNext|Next >>|#2",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Next);

                Back = new PushButton()
                {
                    Tag = "[PushButton]$m_buttonBack|<< Back|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Back);
            }
        }

        public partial class M_ServerMigrationWizardPage1Class : CustomWin
        {
            public StaticText ClickTheNextButtonToLearn1;
            public StaticText TheProjectProject2013_2Was;
            public CustomWin ClickTheNextButtonToLearn2;

            partial void OnInitialize();

            public M_ServerMigrationWizardPage1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]$m_ServerMigrationWizardPage1|[Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]#1";
                ParentType = this.GetType();

                ClickTheNextButtonToLearn1 = new StaticText()
                {
                    Tag = "[StaticText]$m_Page1ContentText|Click the Next button to learn more about migrating the project and begin the migration process, or cancel if you do not want *|#2",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(ClickTheNextButtonToLearn1);

                TheProjectProject2013_2Was = new StaticText()
                {
                    Tag = "[StaticText]$m_Page1MainInstruction|The project Project2013_2 was created in AutoCAD Plant 3D 2013, and must be migrated to work in AutoCAD Plant 3D 2014.|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(TheProjectProject2013_2Was);

                ClickTheNextButtonToLearn2 = new CustomWin()
                {
                    Tag = "[CustomWin][System.Windows.Forms.PictureBox]$pictureBox1|[System.Windows.Forms.PictureBox]Click the Next button to learn more about migrating the project and begin the migration process, or cancel if you do not want *|[System.Windows.Forms.PictureBox]#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(ClickTheNextButtonToLearn2);
            }
        }

        public partial class M_ServerMigrationWizardPage2Class : CustomWin
        {
            public PushButton BeginProjectMigration;
            public StaticText AfterWeMigrateTheProjectW;
            public StaticText MigrateAndUpdateText;
            public StaticText N3Text;
            public StaticText BeforeWeMigrateTheProject;
            public StaticText ThatSyncingFeelingText;
            public StaticText N2Text;
            public StaticText AllDrawingsNeedToBeChecke;
            public StaticText CheckCheckText;
            public StaticText N1Text;
            public StaticText BecauseThisIsAVaultBased;

            partial void OnInitialize();

            public M_ServerMigrationWizardPage2Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]$m_ServerMigrationWizardPage2|[Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]#1";
                ParentType = this.GetType();

                BeginProjectMigration = new PushButton()
                {
                    Tag = "[PushButton]$m_BeginMigrationBtn|Begin Project Migration|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(BeginProjectMigration);

                AfterWeMigrateTheProjectW = new StaticText()
                {
                    Tag = "[StaticText]$label10|After we migrate the project we do a final synchronization and the migration is complete!|#10",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(AfterWeMigrateTheProjectW);

                MigrateAndUpdateText = new StaticText()
                {
                    Tag = "[StaticText]$label9|Migrate and update|#8",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(MigrateAndUpdateText);

                N3Text = new StaticText()
                {
                    Tag = "[StaticText]$label8|3.|#9",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(N3Text);

                BeforeWeMigrateTheProject = new StaticText()
                {
                    Tag = "[StaticText]$label7|Before we migrate the project we will ensure the project is up to date and will start off with a project synchronization.|#7",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(BeforeWeMigrateTheProject);

                ThatSyncingFeelingText = new StaticText()
                {
                    Tag = "[StaticText]$label6|That syncing feeling|#5",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(ThatSyncingFeelingText);

                N2Text = new StaticText()
                {
                    Tag = "[StaticText]$label5|2.|#6",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(N2Text);

                AllDrawingsNeedToBeChecke = new StaticText()
                {
                    Tag = "[StaticText]$label4|All drawings need to be checked in, and you will need exclusive project access in order to have a smooth migration.|#4",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(AllDrawingsNeedToBeChecke);

                CheckCheckText = new StaticText()
                {
                    Tag = "[StaticText]$label3|Check? Check|#2",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CheckCheckText);

                N1Text = new StaticText()
                {
                    Tag = "[StaticText]$label2|1.|#3",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(N1Text);

                BecauseThisIsAVaultBased = new StaticText()
                {
                    Tag = "[StaticText]$label1|Because this is a Vault based Plant 3D Project, there are a few additional things you should know about the migration|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(BecauseThisIsAVaultBased);
            }
        }
    }
}
