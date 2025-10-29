// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DwgOffLineEditsNotification", Parent = typeof(CustomWin))]
    public partial class PandIDProjectDataMergedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText PleaseNoteThatBackwardST;
        public  PushButton BrowsePB;
        public  TextField BackupTheDrawingToTF;
        public  StaticText BackupTheDrawingToST;
        public  CheckBox BackupTheDrawingBeforeCK;
        public  StaticText PleaseVerifyThatThisST;
        public  Pane PleaseVerifyThatThis1PANE;
        public  Pane PleaseVerifyThatThis2PANE;
        public  Link HowDoIVerifyLINK;
        public  StaticText InformationST;
        public  Link WhatOccursDuringDrawingLINK;
        public  Link WhatIsUpdatedDuringLINK;
        public  Link WhyDidTheMigrationLINK;
        public  Pane PleaseVerifyThatThis3PANE;
        public  PushButton MigratePB;
        public  PushButton CancelPB;
        public  Pane PleaseVerifyThatThis4PANE;
        public  StaticText ThisDrawingWasCreatedST;
        public  TitleBar AutoCADPlant3DMigrationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDProjectDataMergedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PleaseNoteThatBackwardST = new StaticText()
            {
                Tag = "[StaticText]Please note that backward migration is not supported*|$lblMsg03|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseNoteThatBackwardST);

            BrowsePB = new PushButton()
            {
                Tag = "[PushButton]Browse *|$btnBrowse|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            BackupTheDrawingToTF = new TextField()
            {
                Tag = "[TextField]Backup the drawing to:|$txtboxDwgPath|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackupTheDrawingToTF);

            BackupTheDrawingToST = new StaticText()
            {
                Tag = "[StaticText]Backup the drawing to:|$lblMsg02|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackupTheDrawingToST);

            BackupTheDrawingBeforeCK = new CheckBox()
            {
                Tag = "[CheckBox]Backup the drawing before migration (recommended)|$chkboxBackup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackupTheDrawingBeforeCK);

            PleaseVerifyThatThisST = new StaticText()
            {
                Tag = "[StaticText]Please verify that this drawing is not in use before proceeding with migration process|$lblMsg01|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatThisST);

            PleaseVerifyThatThis1PANE = new Pane()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlInfos|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatThis1PANE);

            PleaseVerifyThatThis2PANE = new Pane()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlInfos|#2/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatThis2PANE);

            HowDoIVerifyLINK = new Link()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlInfos|#2/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo|#1/[Link]How do I verify that my drawing is not in use?|$linkLabel0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HowDoIVerifyLINK);

            InformationST = new StaticText()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlInfos|#2/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo|#1/[StaticText]Information|$lblHeader|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InformationST);

            WhatOccursDuringDrawingLINK = new Link()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlInfos|#2/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo|#1/[Link]What occurs during drawing migration?|$linkLabel1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatOccursDuringDrawingLINK);

            WhatIsUpdatedDuringLINK = new Link()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlInfos|#2/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo|#1/[Link]What is updated during migration?|$linkLabel1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatIsUpdatedDuringLINK);

            WhyDidTheMigrationLINK = new Link()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlInfos|#2/[Pane]Please verify that this drawing is not in use before proceeding with migration process|$frmMigrationInfo|#1/[Link]Why did the migration fail?|$linkLabel1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhyDidTheMigrationLINK);

            PleaseVerifyThatThis3PANE = new Pane()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlButtons|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatThis3PANE);

            MigratePB = new PushButton()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlButtons|#3/[PushButton]Migrate|$btnMigrate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigratePB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlButtons|#3/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PleaseVerifyThatThis4PANE = new Pane()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlHeader|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatThis4PANE);

            ThisDrawingWasCreatedST = new StaticText()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process|$pnlHeader|#1/[StaticText]This drawing was created in AutoCAD P*|$lblHeader|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisDrawingWasCreatedST);

            AutoCADPlant3DMigrationCTL = new TitleBar()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D Migration|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCADPlant3DMigrationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D Migration|$TitleBar|#1/[CustomWin]System Menu Bar|$frmDrawingMigration1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D Migration|$TitleBar|#1/[CustomWin]System Menu Bar|$frmDrawingMigration1|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D Migration|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
