// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmProjectMigration1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class AutoCADPlant3DMigrationDLG : Pane
    {
        public  PushButton BtnNext;
        public  PushButton BrowsePB;
        public  TextField SaveFilesToTF;
        public  CheckBox BackupTheDrawingBeforeCK;
        public  Link LinkLabel0;
        public  Link WhatOccursDuringDrawingMigration;
        public  Link WhatIsUpdatedDuringMigration;
        public  Link WhyDidTheMigrationFail;
        public  PushButton MigratePB;
        public  PushButton BtnCancel;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AutoCADPlant3DMigrationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnNext = new PushButton()
            {
                Tag = "[Pane]Please verify that *[2]|$pnlButtons/[PushButton]Next|$btnNext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnNext);

            BrowsePB = new PushButton()
            {
                Tag = "[PushButton]Browse *|$btnBrowse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            SaveFilesToTF = new TextField()
            {
                Tag = "[TextField]Backup the drawing to:|$txtboxDwgPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveFilesToTF);

            BackupTheDrawingBeforeCK = new CheckBox()
            {
                Tag = "[CheckBox]Backup the drawing before migration (recommended)|$chkboxBackup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackupTheDrawingBeforeCK);

            LinkLabel0 = new Link()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process[1]|$pnlInfos/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo/[Link]How do I verify that my drawing is not in use?|$linkLabel0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinkLabel0);

            WhatOccursDuringDrawingMigration = new Link()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process[1]|$pnlInfos/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo/[Link]What occurs during drawing migration?|$linkLabel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatOccursDuringDrawingMigration);

            WhatIsUpdatedDuringMigration = new Link()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process[1]|$pnlInfos/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo/[Link]What is updated during migration?|$linkLabel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatIsUpdatedDuringMigration);

            WhyDidTheMigrationFail = new Link()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process[1]|$pnlInfos/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo/[Link]Why did the migration fail?|$linkLabel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhyDidTheMigrationFail);

            MigratePB = new PushButton()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process[2]|$pnlButtons/[PushButton]Migrate|$btnMigrate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigratePB);

            BtnCancel = new PushButton()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process[2]|$pnlButtons/[PushButton]Cancel|$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D Migration|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
